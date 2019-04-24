namespace NETTRASH.OrangeData.Nebula.API.Request
{
    public class Base
    {
        #region Public constructors



        public Base()
        {
        }



        #endregion
        #region Public methods



        /// <summary>
        /// Возвращает часть URL для выполнения запроса.
        /// </summary>
        /// <returns>Строка (часть URL запроса)</returns>
        public virtual string GetURLPart()
        {
            return "/api/v1";
        }

        /// <summary>
        /// Получение данных для запроса
        /// </summary>
        /// <returns>Возвращает данные для запроса</returns>
        public virtual System.Net.Http.HttpContent GetContent()
        {
            return null;
        }

        /// <summary>
        /// Получение метода запроса
        /// </summary>
        /// <returns>Возвращает метод запроса</returns>
        public virtual System.Net.Http.HttpMethod GetMethod()
        {
            return System.Net.Http.HttpMethod.Get;
        }



        #endregion
    }
}
