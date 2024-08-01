namespace TradeCategoryUbsAPI.Services
{
    public class InvalidTradeException : Exception
    {
        public InvalidTradeException(string message) : base(message)
        {
        }
    }
}
