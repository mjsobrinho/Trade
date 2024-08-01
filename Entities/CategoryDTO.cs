namespace TradeCategoryUbsAPI.Entities
{
    public class categoryDTO : BaseDTO

    {
        public string Sector { get; set; }
        public string Category { get; set; }
        public decimal Fx_inicial { get; set; }
        public decimal Fx_final { get; set; }
        public DateTime Dt_inicial { get; set; }
        public DateTime Dt_final { get; set; }

    }
}
