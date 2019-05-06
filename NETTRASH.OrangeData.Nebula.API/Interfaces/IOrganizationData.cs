using System;
namespace NETTRASH.OrangeData.Nebula.API.Interfaces
{
    public interface IOrganizationData
    {
        #region Public properties



        /// <summary>
        /// Идентификатор документа
        /// </summary>
        /// <value>Строка от 1 до 32 символов</value>
        string Id { get; set; }

        /// <summary>
        /// Уникальное имя организации
        /// </summary>
        /// <value>Строка от 0 до 256 символов</value>
        string Name { get; set; }

        /// <summary>
        /// ИНН организации
        /// </summary>
        /// <value>Строка 10 или 12 символов</value>
        string INN { get; set; }

        /// <summary>
        /// Юридический адрес
        /// </summary>
        /// <value>Строка длиной до 256 символов</value>
        string Address { get; set; }

        /// <summary>
        /// Код налоговой системы: 1: ОСН,2: УСН доход, 4: УСН доход минус расход,8: ЕНВД, 16: ЕСН, 32: ПСН
        /// </summary>
        /// <value>Число</value>
        TaxSystemEnumeration TaxSystem { get; set; }

        /// <summary>
        /// Публичная часть ключа, используемого для подписи
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        string PublicKey { get; set; }

        /// <summary>
        /// Флаг блокировки:
        ///   «false» - организация не заблокирована
        ///   «true» - организация заблокирована
        /// </summary>
        /// <value>Логическое</value>
        bool IsBlocked { get; set; }

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



        #endregion
    }
}
