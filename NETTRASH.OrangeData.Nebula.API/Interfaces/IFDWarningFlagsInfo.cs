namespace NETTRASH.OrangeData.Nebula.API.Interfaces
{
    public interface IFDWarningFlagsInfo
    {
        #region Public properties



        /// <summary>
        /// Значение
        /// </summary>
        /// <value>Число, необязательное поле</value>
        int? Value { get; set; }

        /// <summary>
        /// Описание
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        string Description { get; set; }



        #endregion
    }
}
