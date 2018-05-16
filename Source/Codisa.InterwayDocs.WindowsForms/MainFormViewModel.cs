using System;
using System.Collections.Generic;
using System.Configuration;
#if WISEJ
using Wisej.Web;
#else
using System.Windows.Forms;
#endif
using Codisa.InterwayDocs.Delivery;
using Codisa.InterwayDocs.Framework;
using Codisa.InterwayDocs.Incoming;
using Codisa.InterwayDocs.Outgoing;
using Codisa.InterwayDocs.Tools;
using Codisa.InterwayDocs.Update;
using MvvmFx.CaliburnMicro;

namespace Codisa.InterwayDocs
{
    public class MainFormViewModel : Conductor<IBookViewModel>, IMainFormViewModel
    {
        #region Fields and properties

        /// <summary>
        /// Gets a value indicating whether to use long names on entities.
        /// </summary>
        /// <value>
        ///   <c>true</c> if use long names on entities; otherwise, <c>false</c>.
        /// </value>
        public bool UseLongNameEntities { get; private set; }

        /// <summary>
        /// Gets or sets the control objects of the view.
        /// </summary>
        /// <value>
        /// The control objects of the view.
        /// </value>
        public List<Control> ViewNamedElements { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the search panel is expected to be open.
        /// </summary>
        /// <value>
        /// <c>true</c> if the search panel is supposed to be open; otherwise, <c>false</c>.
        /// </value>
        public bool IsSearchPanelOpen { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the detail panel is expected to be open.
        /// </summary>
        /// <value>
        /// <c>true</c> if the detail panel is supposed to be open; otherwise, <c>false</c>.
        /// </value>
        public bool IsDetailPanelOpen { get; set; } = true;

        #endregion

        #region Initializers

        public MainFormViewModel()
        {
            CloseStrategy = new ApplicationCloseStrategy();
            try
            {
                UseLongNameEntities = Convert.ToBoolean(ConfigurationManager.AppSettings["UseLongNameEntities"]);
            }
            catch (Exception)
            {
                UseLongNameEntities = false;
            }

            new UpdateViewModel();
        }

        protected override void OnInitialize()
        {
            DisplayName = "MainFormTitle".GetUiTranslation();
        }

        protected override void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);

            BindMenuItems();
            OpenIncomingBook();
        }

        private IMainForm GetView()
        {
            return base.GetView() as IMainForm;
        }

        private void BindMenuItems()
        {
            var mainForm = GetView();
            if (mainForm != null)
                mainForm.BindMenuItems(ViewNamedElements);
        }

        public void RefreshTranslation()
        {
            DisplayName = "MainFormTitle".GetUiTranslation();

            var mainForm = GetView();
            if (mainForm != null)
                mainForm.RefreshTranslation();

            ActiveItem.RefreshTranslation();
        }

        #endregion

        #region Action methods

        /*public IEnumerable<IResult> GetId()
        {
            //IsCustomerNameReadOnly = true;
            var result = new CustomerIdResult();

            //CanDataEntry = false;
            yield return Show.Busy("Generating Customer Id");
            yield return result;

            //CustomerId = result.Response.ToString();
            yield return Show.NotBusy();
            //CanDataEntry = true;
        }*/

        public IEnumerable<IResult> OpenIncomingBookAsync()
        {
            var result = new IncomingBookViewModelResult();
            yield return Show.Busy("A ler o livro de entradas");
            yield return result;

            ActivateItem(result.Response);
            yield return Show.NotBusy();

            if (ActiveItem == result.Response)
                MarkActiveMenuItem("IncomingBook");
        }

        public void OpenIncomingBook()
        {
            try
            {
                var book = new IncomingBookViewModel();
                ActivateItem(book);

                if (ActiveItem == book)
                    MarkActiveMenuItem("IncomingBook");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OperationError".GetUiTranslation(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OpenOutgoingBook()
        {
            try
            {
                var book = new OutgoingBookViewModel();
                ActivateItem(book);

                if (ActiveItem == book)
                    MarkActiveMenuItem("OutgoingBook");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OperationError".GetUiTranslation(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void OpenDeliveryBook()
        {
            try
            {
                var book = new DeliveryBookViewModel();
                ActivateItem(book);

                if (ActiveItem == book)
                    MarkActiveMenuItem("DeliveryBook");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OperationError".GetUiTranslation(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MarkActiveMenuItem(string menuItem)
        {
            var mainForm = GetView() as IMainForm;
            if (mainForm != null)
                mainForm.MarkActiveMenuItem(menuItem);
        }

        public void About()
        {
            try
            {
                using (var modal = new AboutForm())
                {
                    modal.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OperationError".GetUiTranslation(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void PdfManual()
        {
            try
            {
                System.Diagnostics.Process.Start(@".\Manual.pdf");
            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Backup()
        {
            try
            {
                using (var modal = new BackupForm())
                {
                    modal.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OperationError".GetUiTranslation(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Restore()
        {
            try
            {
                using (var modal = new RestoreForm())
                {
                    modal.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OperationError".GetUiTranslation(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Export()
        {
            try
            {
                using (var modal = new ExportForm())
                {
                    modal.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OperationError".GetUiTranslation(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Import()
        {
            try
            {
                using (var modal = new ImportForm())
                {
                    modal.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "OperationError".GetUiTranslation(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Exit

        public void Exit()
        {
            TryClose();
        }

        #endregion
    }

    public class IncomingBookViewModelResult : IResult
    {
        public IncomingBookViewModel Response { get; set; }

        public void Execute(ActionExecutionContext context)
        {
            System.Threading.ThreadPool.QueueUserWorkItem(state =>
            {
                //System.Threading.Thread.Sleep(200);
                Response = new IncomingBookViewModel();
                Completed(this, new ResultCompletionEventArgs());
            });
        }

        public event EventHandler<ResultCompletionEventArgs> Completed = delegate { };
    }

    /*public class CustomerIdResult : IResult
    {
        public Guid Response { get; set; }

        public void Execute(ActionExecutionContext context)
        {
            System.Threading.ThreadPool.QueueUserWorkItem(state =>
            {
                System.Threading.Thread.Sleep(2000);

                Response = Guid.NewGuid();
                Completed(this, new ResultCompletionEventArgs());
            });
        }

        public event EventHandler<ResultCompletionEventArgs> Completed = delegate { };
    }*/
}