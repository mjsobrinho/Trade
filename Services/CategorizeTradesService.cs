using TradeCategoryUbsAPI.Interfaces;
using TradeCategoryUbsAPI.Models;

namespace TradeCategoryUbsAPI.Services
{
    public class CategorizeTradesService: ITradeCategorizationService
    {
        public List<string> CategorizeTrades(List<Trade> trades)
        {
            var categories = new List<string>();

            //Aqui realiza a operação da regra negocio
           //vai chamar um serviço (repositorio) pra retornar os parâmetros e categorizar as tranzações ou chmar uma procedure no repositorio
            

            foreach (var trade in trades)
            {
                if (trade.Value > 0 && trade.Value < 1000000 && trade.ClientSector == "Public")
                {
                    categories.Add("LOWRISK");
                }
                else if (trade.Value > 0 && trade.Value >= 1000000 && trade.ClientSector == "Public")
                {
                    categories.Add("MEDIUMRISK");
                }
                else if (trade.Value > 0 && trade.Value >= 1000000 && trade.ClientSector == "Private")
                {
                    categories.Add("HIGHRISK");
                }
                else
                    categories.Add("Não encontrada");
            }

            return categories;
        }
    }

}
