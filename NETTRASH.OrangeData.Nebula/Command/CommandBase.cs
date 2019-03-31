using System.Text;
using NETTRASH.OrangeData.Nebula.Enums;
using NETTRASH.OrangeData.Nebula.Interfaces;

namespace NETTRASH.OrangeData.Nebula
{
    public class CommandBase : ICommand
    {
        #region Private properties



        private StringBuilder _commandLog;



        #endregion
        #region Public properties



        public string Log
        {
            get
            {
                return _commandLog?.ToString() ?? string.Empty;
            }
        }

        public RealmType Realm { get; private set; }

        public CommandType Command { get; private set; }



        #endregion
        #region Public constructors



        public CommandBase()
        {
            Realm = RealmType.Unknown;
            Command = CommandType.Unknown;
        }



        #endregion
        #region Protected methods



        protected virtual void logLine(string sMessage)
        {
            if (_commandLog == null) _commandLog = new StringBuilder();
            _commandLog.AppendLine(sMessage);
        }



        #endregion
        #region Public methods



        public virtual ICommandResult Execute()
        {
            return new CommandResult(true, string.Empty);
        }



        #endregion
    }
}
