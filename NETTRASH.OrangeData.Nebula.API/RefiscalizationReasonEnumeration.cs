namespace NETTRASH.OrangeData.Nebula.API
{
    public enum RefiscalizationReasonEnumeration : int
    {
        /// <summary>
        /// Замена ФН
        /// </summary>
        FiscalDriveChange = 1,

        /// <summary>
        /// Замена ОФД
        /// </summary>
        OFDChange = 2,

        /// <summary>
        /// Изменение реквизитов
        /// </summary>
        RequisitesChange = 3,

        /// <summary>
        /// Изменение настроек ККТ
        /// </summary>
        SettingsChange = 4
    }
}
