using System.Text;

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



        #endregion
        #region Public Constructors



        public Arguments(string[] args)
        {
            _Valid = false;
            _Init(args);
        }



        #endregion
        #region Private methods



        private void _Init(string[] args)
        {
            if ((args?.Length ?? 0) != 8) return;
            for (int i=0; i<args.Length/2; i+=2)
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
                    default:
                        _Valid = false;
                        _Message = $"Invalid argument: {args[i]}";
                        return;
                }
            }
            _Valid = !string.IsNullOrEmpty(Host) && !string.IsNullOrEmpty(User) && !string.IsNullOrEmpty(Password) && Port > 0;
            _Message = !_Valid ? "Argument not found" : string.Empty;
        }



        #endregion
        #region Public methods



        public string GetUseString()
        {
            return "Use: NETTRASH.OrangeData.Nebula {args}\nArguments:\n\t-h [host] - Nebula Host (localhost|192.168.0.1|nebula.local)\n\t-p [port] - Nebula Port\n\t-u [user] - Nebula User\n\t-s [secret] - Password\n";
        }

        public string Execute()
        {
            StringBuilder retVal = new StringBuilder();
            retVal.AppendLine($"Host: {Host}\nPort: {Port}\n");
            return retVal.ToString();
        }



        #endregion
    }
}
