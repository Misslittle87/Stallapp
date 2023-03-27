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
        public static async Task AddUser( string userName, string password)
        {
            await Init();
            var user = new UserInfoModel
            {                   
                UserName = userName,
                Password = password
            };
            var id = await db.InsertAsync(user);
        }
        public static async Task RemoveUser(int id)
        {
            await Init();
            await db.DeleteAsync<UserInfoModel>(id);
        }
        public static async Task<List<UserInfoModel>> GetUser()
        {
            await Init();
            var user = await db.Table<UserInfoModel>().ToListAsync();
            return user;
        }
    }
}
