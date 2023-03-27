namespace Stallapp.Model
{
    [Table("User")]
    public class UserInfoModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(250)]
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
