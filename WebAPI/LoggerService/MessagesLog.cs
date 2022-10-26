/// <summary>
/// Message logs declare here
/// </summary>

namespace LoggerService
{
    public static class MessagesLog
    {
        //Common
        public const string IntSvrError = "Internal server error";
        public const string ControllerError = "There is an Error in action : ";


        /// <summary>
        /// Data GET, SET, 
        /// </summary>

        //Location Message
        public const string GetCountryAll = "Return All Countries";
        public const string GetCitiesByID = "Return Cities By ID";

        //Weather Logs
        public const string GetWeatherLogByCityID = "Return Weather Logs by City ID";
    }
}
