namespace NETTRASH.OrangeData.Nebula.API
{
    public enum FiscalizationModeEnumeration : int
    {
        /// <summary>
        /// Первичная фискализация
        /// </summary>
        First = 0,

        /// <summary>
        /// Фискализация в связи с заменой ФН
        /// </summary>
        FiscalDriveChange = 1,

        /// <summary>
        /// Фискализация в связи с изменением параметров без замены ФН
        /// </summary>
        PropertyChangeWithoutChangeFiscalDrive = 2
    }
}
