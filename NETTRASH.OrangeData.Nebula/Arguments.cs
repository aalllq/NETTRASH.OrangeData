using System.Text;
using NETTRASH.OrangeData.Nebula.Interfaces;

namespace NETTRASH.OrangeData.Nebula
{
    public class Arguments
    {
        #region Private properties



        private bool _Valid { get; set; }

        private string _Message { get; set; }



        #endregion
        #region Public properties



        public bool Valid { get { return _Valid; } }

        public string Message { get { return _Message; } }

        public string Host { get; set; }

        public int Port { get; set; }

        public string User { get; set; }

        public string Password { get; set; }

        public string Realm { get; set; }

        public string Command { get; set; }



        #endregion
        #region Public Constructors



        public Arguments(string[] args)
        {
            _Valid = false;
            _Init(args);
            if (_Valid)
            {
                _additionalValidate();
            }
        }



        #endregion
        #region Private methods



        private void _Init(string[] args)
        {
            _Valid = false;
            if ((args?.Length ?? 0) < 12) return;
            for (int i = 0; i < args.Length / 2; i += 2)
            {
                switch (args[i])
                {
                    case "-h":
                        Host = args[i + 1];
                        break;
                    case "-p":
                        Port = int.Parse(args[i + 1]);
                        break;
                    case "-u":
                        User = args[i + 1];
                        break;
                    case "-s":
                        Password = args[i + 1];
                        break;
                    case "-obj":
                        Realm = args[i + 1];
                        break;
                    case "-cmd":
                        Command = args[i + 1];
                        break;
                    default:
                        _Valid = false;
                        _Message = $"Invalid argument: {args[i]}";
                        return;
                }
            }
            _Valid = !string.IsNullOrEmpty(Host) && !string.IsNullOrEmpty(User) && !string.IsNullOrEmpty(Password) && Port > 0;
            _Message = !_Valid ? "Argument not found" : string.Empty;
        }

        private void _additionalValidate()
        {

        }



        #endregion
        #region Public methods



        public string GetUseString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Use: NETTRASH.OrangeData.Nebula {args}");
            sb.AppendLine("Arguments:");
            sb.AppendLine("\t-h [host] - Nebula Host (localhost|192.168.0.1|nebula.local)");
            sb.AppendLine("\t-p [port] - Nebula Port");
            sb.AppendLine("\t-u [user] - Nebula User");
            sb.AppendLine("\t-s [secret] - Nebula User Password");
            sb.AppendLine("\t-obj [object] - Nebula object (Realm)");
            sb.AppendLine("\t-cmd [command] - Nebula command (Command)");
            sb.AppendLine("\t{prms} - (optional) command parameters");
            sb.AppendLine("");
            sb.AppendLine("Realms:");
            sb.AppendLine($"\t - {string.Join("\n\t - ", System.Enum.GetNames(typeof(Enums.RealmType)))}");
            sb.AppendLine("");
            sb.AppendLine("Realm commands:");
            sb.AppendLine("");
            sb.AppendLine("  Farm");
            sb.AppendLine("");
            return sb.ToString();
        }

        public ICommand GetCommand()
        {

            return null;
        }



        #endregion
    }
}
