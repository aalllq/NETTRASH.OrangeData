using NETTRASH.OrangeData.Nebula.Interfaces;

namespace NETTRASH.OrangeData.Nebula
{
    public class CommandResult : ICommandResult
    {
        #region Public properties



        public bool Success { get; private set; }

        public string Message { get; private set; }



        #endregion
        #region Public constructors



        public CommandResult(bool bSuccess, string sMessage)
        {
            Success = bSuccess;
            Message = sMessage;
        }



        #endregion
    }
}
