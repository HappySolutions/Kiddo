using Kiddo1.Models;
using Kiddo1.Persistance;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kiddo1.Services
{
    public interface ITodoItemService
    {
        IEnumerable<BList> GetAll();
        BList GetById(int id);
        void Update(BList todoItem);
        void Insert(BList todoItem);
        void Delete(int id);
    }

    public class TodoItemService : ITodoItemService
    {
        private ISQLiteDb ConnectionProvider { get; }
        private SQLiteConnection Connection { get; }

        public TodoItemService(ISQLiteDb connectionProvider)
        {
            this.ConnectionProvider = connectionProvider;
            this.Connection = this.ConnectionProvider.GetConnection();
            this.Connection.CreateTable<BList>();
        }

        public void Delete(int id)
        {
            this.Connection.Delete<BList>(id);
        }

        public IEnumerable<BList> GetAll()
        {
            return this.Connection.Table<BList>().ToList();
        }

        public BList GetById(int id)
        {
            return this.Connection.Table<BList>().FirstOrDefault(x => x.ListId == id);
        }

        public void Insert(BList todoItem)
        {
            this.Connection.Insert(todoItem);
        }

        public void Update(BList todoItem)
        {
            this.Connection.Update(todoItem);
        }
    }

}
