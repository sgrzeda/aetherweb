namespace AetherWeb.Database.Models
{
    public class AccountBase
    {
        public string Account { get; set; }
        public string Password { get; set; }
        public string IsUse { get; set; }

        public virtual AccountDetail Details { get; set; }
    }
}