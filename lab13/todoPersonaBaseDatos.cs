using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace lab13
{
    public class todoPersonaBaseDatos
    {
        readonly SQLiteAsyncConnection database;

        public todoPersonaBaseDatos(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<TodoPersona>().Wait();
        }

        public Task<List<TodoPersona>> GetItemsAsync()
        {
            return database.Table<TodoPersona>().ToListAsync();
        }

        public Task<List<TodoPersona>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<TodoPersona>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
        }

        public Task<TodoPersona> GetItemAsync(int id)
        {
            return database.Table<TodoPersona>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(TodoPersona item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(TodoPersona item)
        {
            return database.DeleteAsync(item);
        }
    }
}


