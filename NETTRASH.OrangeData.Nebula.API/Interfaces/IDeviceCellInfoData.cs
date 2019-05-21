namespace NETTRASH.OrangeData.Nebula.API.Interfaces
{
    public interface IDeviceCellInfoData
    {
        #region Public properties



        /// <summary>
        /// Название поля
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        string ColumnName { get; set; }

        /// <summary>
        /// Номер поля
        /// </summary>
        /// <value>Число, необязательное поле</value>
        int? Column { get; set; }

        /// <summary>
        /// Номер ряда
        /// </summary>
        /// <value>Число, необязательное поле</value>
        int? Row { get; set; }

        /// <summary>
        /// Значение
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        string Value { get; set; }

        /// <summary>
        /// Тип поля (1 байт):
        ///   «0» – «BIN» бинарный;
        ///   «1» – «CHAR» текстовый
        /// </summary>
        /// <value>Число, необязательное поле</value>
        ColumnTypeEnumeration ColumnType { get; set; }

        /// <summary>
        /// Минимальное значение поля – для полей типа BIN (X байт)
        /// </summary>
        /// <value>Число, необязательное поле</value>
        int? MinValue { get; set; }

        /// <summary>
        /// Количество байт – X (1 байт)
        /// </summary>
        /// <value>Число, необязательное поле</value>
        int? Length { get; set; }



        #endregion
    }
}
