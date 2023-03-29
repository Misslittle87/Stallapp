using System.Security.Cryptography;

namespace Stallapp.Services
{
    public class LoginService
    {
        static SQLiteAsyncConnection db;
        static async Task Init()
        {
            if (db != null)
            {
                return;
            }
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "Stallapp.db");
            db = new SQLiteAsyncConnection(databasePath);
            await db.CreateTableAsync<UserInfoModel>();
        }
        public static async Task AddUser(string userName, string password)
        {
            Random rand = new Random();
            int salt = rand.Next();
            string saltedPW = $"{password}{salt}";
            await Init();
            var users = await db.Table<UserInfoModel>().Where(u => u.UserName == userName).FirstOrDefaultAsync();
            var hachedPW = HashPassword(saltedPW);
            if (users == null)
            {
                var user = new UserInfoModel
                {
                    UserName = userName,
                    Password = hachedPW
                };
                var id = await db.InsertAsync(user);
                await Shell.Current.DisplayAlert("Lycka", "Du är registrerad", "OK");
            }
            else
            {
                await Shell.Current.DisplayAlert("Fel!","Användaren finns redan","OK");
            }            
        }
        public static async Task RemoveUser(int id)
        {
            await Init();
            var users = await db.DeleteAsync<UserInfoModel>(id);
        }
        public static async Task<UserInfoModel> GetUser(string userName, string password)
        {
            await Init();
            var hachedPW = HashPassword(password);
            var user = await db.Table<UserInfoModel>().Where(u => u.UserName == userName && u.Password == hachedPW).FirstOrDefaultAsync();
            if (user == null)
            {
                await Shell.Current.DisplayAlert("Fel", "Finns inte", "OK");
            }
            else
            {
                await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
            }            
            return user;
        }
        static string HashPassword(string password)
        {
            using var sha = SHA256.Create();
            var pwBytes = Encoding.Default.GetBytes(password);
            var hached = sha.ComputeHash(pwBytes);
            return Convert.ToBase64String(hached);
        }
    }
}
