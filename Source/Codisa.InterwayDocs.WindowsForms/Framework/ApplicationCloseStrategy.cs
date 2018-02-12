using System;
using System.Collections.Generic;
using System.Linq;
using MvvmFx.CaliburnMicro;

namespace Codisa.InterwayDocs.Framework
{
    public class ApplicationCloseStrategy : ICloseStrategy<IBookViewModel>
    {
        private IEnumerator<IBookViewModel> _enumerator;
        private bool _finalResult;
        private Action<bool, IEnumerable<IBookViewModel>> _callback;

        public void Execute(IEnumerable<IBookViewModel> toClose, Action<bool, IEnumerable<IBookViewModel>> callback)
        {
            _enumerator = toClose.GetEnumerator();
            _callback = callback;
            _finalResult = true;

            Evaluate(_finalResult);
        }

        private void Evaluate(bool result)
        {
            _finalResult = _finalResult && result;

            if (!_enumerator.MoveNext() || !result)
                _callback(_finalResult, new List<IBookViewModel>());
            else
            {
                var current = _enumerator.Current;
                var conductor = current as IConductor;
                if (conductor != null)
                {
                    var tasks = conductor.GetChildren()
                        .OfType<IHaveShutdownTask>()
                        .Select(x => x.GetShutdownTask())
                        .Where(x => x != null);

                    var sequential = new SequentialResult(tasks.GetEnumerator());
                    sequential.Completed += (s, e) =>
                    {
                        if (!e.WasCancelled)
                            Evaluate(!e.WasCancelled);
                    };
                    sequential.Execute(new ActionExecutionContext());
                }
                else
                {
                    Evaluate(true);
                }
            }
        }
    }
}