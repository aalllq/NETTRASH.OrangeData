namespace NETTRASH.OrangeData.Nebula.API
{
    public enum AgentTypeEnumeration : int
    {
        /// <summary>
        /// Банковский платёжный агент
        /// </summary>
        BankPaymentAgent = 1,

        /// <summary>
        /// Банковский платёжный субагент
        /// </summary>
        BankPaymentSubagent = 2,

        /// <summary>
        /// Платёжный агент
        /// </summary>
        PaymentAgent = 4,

        /// <summary>
        /// Платёжный субагент
        /// </summary>
        PaymentSubagent = 8,

        /// <summary>
        /// Поверенный
        /// </summary>
        Attorney = 16,

        /// <summary>
        /// Комиссионер
        /// </summary>
        Commissioner = 32,

        /// <summary>
        /// Иной агент
        /// </summary>
        Other = 64
    }
}
