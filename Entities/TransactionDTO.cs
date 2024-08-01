namespace TradeCategoryUbsAPI.Entities
{
    public class transactionDTO: BaseDTO
    {
        public DateTime Dt_transaction { get; set; }
        public string Json_transaction { get; set; }
        public string Json_saida { get; set; }
    }
}
