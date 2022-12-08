using Neptun.data;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Neptun.model
{
    public  class DBControl
    {
        private SQLiteAsyncConnection _connection;
        public async Task Initialize()
        {
            if (_connection != null) return;
            _connection = new SQLiteAsyncConnection("Neptun.db3");
            try
            {
                //kitalalni vmi prefset
                bool init = true;
                await _connection.CreateTableAsync<Subjects>();
                await _connection.CreateTableAsync<Users>();
                if (init == false)
                {

                    //Properties.Settings.Default["DB_Init"] = true;
                    //Properties.Settings.Default.Save();
                    var user1 = new Users()
                    {
                        Name = "user",
                        Password = "1234",
                        Id= 1,
                        live = false,
                    };
                    var user2 = new Users()
                    {
                        Name = "admin",
                        Password = "admin",
                        Id = 2,
                        live = false,
                    };
                    var user3 = new Users()
                    {
                        Name = "root",
                        Password = "toor",
                        Id = 3,
                        live = false,
                    };

                    var sub1 = new Subjects()
                    {
                        Name = "Prog1",
                        Description = "Programozás gyakorlatban.",
                        Stock = 20,
                        TargyId = 1,
                    };
                    var sub2 = new Subjects()
                    {
                        Name = "Matek I.",
                        Description = "Matematika, algebra gyakorlatban.",
                        Stock = 50,
                        TargyId = 2,
                    };
                    var sub3 = new Subjects()
                    {
                        Name = "IT biztonság",
                        Description = "IoT Security",
                        Stock = 30,
                        TargyId = 3,
                    };
                    var sub4 = new Subjects()
                    {
                        Name = "Mesterséges inteligencia",
                        Description = "Keresések, gráfok és neurális hálózatok",
                        Stock = 20,
                        TargyId = 4,
                    };
                    await _connection.InsertOrReplaceAsync(user1);
                    await _connection.InsertOrReplaceAsync(user2);
                    await _connection.InsertOrReplaceAsync(user3);
                    //await _connection.InsertOrReplaceAsync(sub1);
                    //await _connection.InsertOrReplaceAsync(sub2);
                    //await _connection.InsertOrReplaceAsync(sub3);
                    //await _connection.InsertOrReplaceAsync(sub4);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
        public async Task DeleteAll()
        {
            _ = await _connection.DeleteAllAsync<Subjects>();
            _ = await _connection.DeleteAllAsync<Users>();
        }

        public async Task InsertClasses(Users input = null,Subjects insert = null,bool live = false)
        {
            if(input != null)
                await _connection.UpdateAsync(input);
            else
                await _connection.UpdateAsync(insert);
            if (input != null && live == true)
                await _connection.InsertOrReplaceAsync(input);
            await Initialize();
        }

        public async void ResetLive(List<Users> users)
        {
            for (int i = 0; i < users.Count; i++)
            {
                var log = new Users()
                {
                    Name = users[i].Name,
                    Password = users[i].Password,
                    Id = users[i].Id,
                    live = false,
                    classes = users[i].classes,
                };
                await _connection.InsertOrReplaceAsync(log);
            }
        }

        public Task<List<Users>> GetUser() =>
           _connection.Table<Users>().ToListAsync();
        public Task<List<Subjects>> GetSub() =>
          _connection.Table<Subjects>().ToListAsync();
    }
}
