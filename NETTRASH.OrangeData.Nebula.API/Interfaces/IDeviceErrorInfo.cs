namespace NETTRASH.OrangeData.Nebula.API.Interfaces
{
    public interface IDeviceErrorInfo
    {
        #region Public properties



        /// <summary>
        /// Код ошибки, выданный устройством
        /// </summary>
        /// <value>Число, необязательное поле</value>
        int? Code { get; set; }

        /// <summary>
        /// Текстовое описание ошибки
        /// </summary>
        /// <value>Строка</value>
        string Message { get; set; }



        #endregion
    }
}
