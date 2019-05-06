namespace NETTRASH.OrangeData.Nebula.API
{
    public class Result<T>
    {
        #region Public properties



        public System.Net.HttpStatusCode StatusCode { get; set; }

        public T Response { get; set; }



        #endregion
        #region Public constructors



        public Result(System.Net.HttpStatusCode StatusCode, T ResponseData)
        {
            this.StatusCode = StatusCode;
            this.Response = ResponseData;
        }



        #endregion
    }
}
