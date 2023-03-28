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
            await Init();

            var users = await db.Table<UserInfoModel>().Where(u => u.UserName == userName).FirstOrDefaultAsync();
            if (users == null)
            {
                var user = new UserInfoModel
                {
                    UserName = userName,
                    Password = password
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
            var user = await db.Table<UserInfoModel>().Where(u => u.UserName == userName && u.Password == password).FirstOrDefaultAsync();
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
    }
}
