namespace NETTRASH.OrangeData.Nebula.API
{
    public enum KKTOperationModeEnumeration : int
    {
        /// <summary>
        /// Шифрование
        /// </summary>
        Encryption = 1,

        /// <summary>
        /// Автономный режим
        /// </summary>
        Offline = 2,

        /// <summary>
        /// Автоматический режим
        /// </summary>
        Automatic = 4,

        /// <summary>
        /// Применение в сфере услуг
        /// </summary>
        ApplicationInTheServiceSector = 8,

        /// <summary>
        /// Режим БСО
        /// </summary>
        BSO = 16,

        /// <summary>
        /// Применение в сети Интернет
        /// </summary>
        ApplicationInTheInternet = 32
    }
}
