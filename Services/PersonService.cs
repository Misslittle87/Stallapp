using SQLite;
using Stallapp.Model;

namespace Stallapp.Services
{
    public static class PersonService
    {
        static SQLiteAsyncConnection db;
        static async Task Init()
        {
            if (db == null)
            {
                return;
            }
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "StallappDatabas.db");
            db = new SQLiteAsyncConnection(databasePath);
            await db.CreateTableAsync<PersonModel>();
        }
        public static async Task AddPerson(string firstName, string lastName, string email)
        {
            await Init();
            var person = new PersonModel
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email                
            };
            var id = await db.InsertAsync(person);
        }
        public static async Task RemovePerson(int id)
        {
            await Init();
            await db.DeleteAsync<PersonModel>(id);
        }
        public static async Task<IEnumerable<PersonModel>> GetPerson()
        {
            await Init();
            var person = await db.Table<PersonModel>().ToListAsync();
            return person;
        }
    }
}
