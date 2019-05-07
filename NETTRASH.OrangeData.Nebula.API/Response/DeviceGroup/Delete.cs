namespace NETTRASH.OrangeData.Nebula.API.Response.DeviceGroup
{
    public class Delete : Base
    {
        #region Public properties



        public bool SuccessfullyDeleted { get; set; }



        #endregion
        #region Public constructors



        public Delete()
            : base()
        {
        }

        public Delete(bool bDeleted)
            : base()
        {
            SuccessfullyDeleted = bDeleted;
        }



        #endregion
        #region Public methods



        public static Delete Load(System.Net.HttpStatusCode statusCode)
        {
            return new Delete(statusCode == System.Net.HttpStatusCode.NoContent);
        }



        #endregion
    }
}
