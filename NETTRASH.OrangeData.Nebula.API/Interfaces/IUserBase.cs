namespace NETTRASH.OrangeData.Nebula.API.Interfaces
{
    public interface IUserBase
    {
        #region Public properties



        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        /// <value>Строка от 1 до 32 символов</value>
        string Id { get; set; }

        /// <summary>
        /// Идентификатор организации
        /// </summary>
        /// <value>Строка от 1 до 32 символов</value>
        string OrganizationId { get; set; }

        /// <summary>
        /// Уникальное имя пользователя (логин)
        /// </summary>
        /// <value>Строка до 66 символов</value>
        string Name { get; set; }

        /// <summary>
        /// Полное имя пользователя
        /// </summary>
        /// <value>Строка до 128 сим-волов</value>
        string FullName { get; set; }

        /// <summary>
        /// Электронная почта
        /// </summary>
        /// <value>Строка до 256 символов, необязательное поле</value>
        string EMail { get; set; }

        /// <summary>
        /// Разрешение фискализировать:
        ///   «false» - фискализировать ФН запрещено;
        ///   «true» - фискализировать ФН разрешено
        /// </summary>
        /// <value>Логическое</value>
        bool Fiscalize { get; set; }

        /// <summary>
        /// Разрешение мониторить:
        ///   «false» - мониторить систему запрещено;
        ///   «true» - мониторить систему разрешено
        /// </summary>
        /// <value>Логическое</value>
        bool Monitor { get; set; }

        /// <summary>
        /// Флаг блокировки:
        ///   «false» - пользователь не заблокирован;
        ///   «true» - пользователь заблокирован
        /// </summary>
        /// <value>Логическое</value>
        bool IsBlocked { get; set; }

        /// <summary>
        /// Произвольный комментарий
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        string Comment { get; set; }



        #endregion
    }
}
