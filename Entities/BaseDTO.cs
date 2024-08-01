
namespace TradeCategoryUbsAPI.Entities
{
    public class BaseDTO : ResponseBase
    {
        public BaseDTO()
        {
            dt_manut = DateTime.Now;
        }

        public DateTime? dt_manut { get; set; }

        public string cd_user { get; set; }
    }
}
