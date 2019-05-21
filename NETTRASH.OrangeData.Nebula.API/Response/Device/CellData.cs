using Newtonsoft.Json;

namespace NETTRASH.OrangeData.Nebula.API.Response.Device
{
    [JsonObject]
    public class CellData : Interfaces.IDeviceCellData
    {
        #region Public properties



        /// <summary>
        /// Серийный номер устройства
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        [JsonProperty(PropertyName = "serialNumber")]
        public string SerialNumber { get; set; }

        /// <summary>
        /// Наименование таблицы
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        [JsonProperty(PropertyName = "name")]
        public string TableName { get; set; }

        /// <summary>
        /// Номер таблицы
        /// </summary>
        /// <value>Число, необязательное поле</value>
        [JsonProperty(PropertyName = "number")]
        public int? Table { get; set; }

        /// <summary>
        /// Название поля
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        [JsonProperty(PropertyName = "columnName")]
        public string ColumnName { get; set; }

        /// <summary>
        /// Номер поля
        /// </summary>
        /// <value>Число, необязательное поле</value>
        [JsonProperty(PropertyName = "column")]
        public int? Column { get; set; }

        /// <summary>
        /// Номер ряда
        /// </summary>
        /// <value>Число, необязательное поле</value>
        [JsonProperty(PropertyName = "row")]
        public int? Row { get; set; }

        /// <summary>
        /// Значение
        /// </summary>
        /// <value>Строка, необязательное поле</value>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Тип поля (1 байт):
        ///   «0» – «BIN» бинарный;
        ///   «1» – «CHAR» текстовый
        /// </summary>
        /// <value>Число, необязательное поле</value>
        [JsonProperty(PropertyName = "columnType")]
        public ColumnTypeEnumeration ColumnType { get; set; }

        /// <summary>
        /// Минимальное значение поля – для полей типа BIN (X байт)
        /// </summary>
        /// <value>Число, необязательное поле</value>
        [JsonProperty(PropertyName = "minValue")]
        public int? MinValue { get; set; }

        /// <summary>
        /// Количество байт – X (1 байт)
        /// </summary>
        /// <value>Число, необязательное поле</value>
        [JsonProperty(PropertyName = "lengthInBytes")]
        public int? Length { get; set; }



        #endregion
        #region Public constructors



        public CellData()
        {
        }



        #endregion
    }
}
