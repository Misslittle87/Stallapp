using System.ComponentModel.DataAnnotations;

namespace Stallapp.Model
{
    public class UserInfoModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public int Salt { get; set; }
    }
}
