using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Response.Organization
{
    public class List : BaseList<Classes.Organization.OrganizationInfo>
    {
        #region Public constructors



        public List()
            : base()
        {
        }



        #endregion
        #region Public methods



        public static List Load(string sSourceJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<List>(sSourceJson);
            }
            catch
            {
                return null;
            }
        }



        #endregion
    }
}
