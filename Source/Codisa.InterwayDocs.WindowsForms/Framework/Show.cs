using MvvmFx.CaliburnMicro;

namespace Codisa.InterwayDocs.Framework
{
    public static class Show
    {
        public static IResult Busy(string message)
        {
            return new BusyResult(false, message);
        }

        public static IResult NotBusy()
        {
            return new BusyResult(true);
        }
    }
}