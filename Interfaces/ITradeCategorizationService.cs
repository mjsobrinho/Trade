using TradeCategoryUbsAPI.Models;

namespace TradeCategoryUbsAPI.Interfaces
{
    public interface ITradeCategorizationService {
        public List<string> CategorizeTrades(List<Trade> trades);
    }
    
}
