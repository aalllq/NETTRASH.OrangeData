namespace NETTRASH.OrangeData.Nebula.API
{
    public class Result<T>
    {
        #region Public properties



        public uint Code { get; set; }

        public T Response { get; set; }



        #endregion
        #region Public constructors



        public Result(uint nCode, T ResponseData)
        {
            Code = nCode;
            Response = ResponseData;
        }



        #endregion
    }
}
