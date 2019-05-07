namespace NETTRASH.OrangeData.Nebula.API.Interfaces
{
    public interface IOrganizationKeyData
    {
        #region Public properties



        /// <summary>
        /// Идентификатор организации
        /// </summary>
        /// <value>Строка от 1 до 32 символов, необязательное поле</value>
        string OrganizationId { get; set; }

        /// <summary>
        /// Идентификатор группы, к которой привязан ключ
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        string GroupId { get; set; }

        /// <summary>
        /// Название ключа
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        string Name { get; set; }

        /// <summary>
        /// Ключ
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        string Key { get; set; }

        /// <summary>
        /// Тип ключа:
        ///   0 - SHA256-RSA;
        ///   1 - принимать документы без подпи-си
        /// </summary>
        /// <value>Число, необязательное поле</value>
        SignatureTypeEnumeration SignatureType { get; set; }



        #endregion
    }
}
