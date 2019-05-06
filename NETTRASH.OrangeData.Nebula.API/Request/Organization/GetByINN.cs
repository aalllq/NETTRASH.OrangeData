namespace NETTRASH.OrangeData.Nebula.API.Request.Organization
{
    public class GetByINN : Get
    {
        #region Public constructors



        public GetByINN()
            : base()
        {
        }

        public GetByINN(string sINN)
            : base(sINN)
        {
        }



        #endregion
        #region Public methods



        public override string GetURLPart()
        {
            return $"{base.GetURLPart()}/organizations/getByInn/{Id}";
        }



        #endregion
    }
}
