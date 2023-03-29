namespace Stallapp.Model
{
    public class UserInfoModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(250)]
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Salt { get; set; }
    }
}
