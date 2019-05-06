namespace NETTRASH.OrangeData.Nebula.API.Interfaces
{
    public interface IDeviceGroupData
    {
        #region Public properties



        /// <summary>
        /// Идентификатор документа
        /// </summary>
        /// <value>Строка от 1 до 32 символов</value>
        string Id { get; set; }

        /// <summary>
        /// Идентификатор организации
        /// </summary>
        /// <value>Строка до 32 символов</value>
        string OrganizationId { get; set; }

        /// <summary>
        /// Уникальное в пределах организации имя группы устройств
        /// </summary>
        /// <value>Строка до 32 символов, необязательное поле</value>
        string Name { get; set; }

        /// <summary>
        /// Код налоговой системы. При наличии переопределяет систему налогообложения
        /// </summary>
        /// <value>Число, необязательное поле</value>
        TaxSystemEnumeration TaxSystem { get; set; }

        /// <summary>
        /// Произвольный комментарий
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        string Comment { get; set; }

        /// <summary>
        /// Тип ключа используемого для подписи:
        ///   0 – используется подпись SHA256-RSA;
        ///   1 – подпись не используется
        /// </summary>
        /// <value>Число, необязательное поле</value>
        SignatureTypeEnumeration SignatureType { get; set; }

        /// <summary>
        /// Временная зона, в которой находятся все устройства этой группы. Смещение относительно UTC, на текущий момент в РФ это от 2 до 12
        /// </summary>
        /// <value>Число</value>
        short TimeZone { get; set; }



        #endregion
    }
}
