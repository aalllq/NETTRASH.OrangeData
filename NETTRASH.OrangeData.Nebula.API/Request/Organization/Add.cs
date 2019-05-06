﻿using System.Net.Http;

namespace NETTRASH.OrangeData.Nebula.API.Request.Organization
{
    public class Add : Base
    {
        #region Public properties



        public Classes.Organization.OrganizationData Organization { get; set; }



        #endregion
        #region Public constructors



        public Add()
        {
            Organization = null;
        }

        public Add(Classes.Organization.OrganizationData organization)
        {
            Organization = organization;
        }



        #endregion
        #region Public methods



        public override HttpContent GetContent()
        {
            return new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(Organization), System.Text.Encoding.UTF8, "application/json");
        }

        public override HttpMethod GetMethod()
        {
            return HttpMethod.Post;
        }



        #endregion
    }
}
