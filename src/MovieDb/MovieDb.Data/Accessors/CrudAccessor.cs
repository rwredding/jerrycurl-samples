using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Jerrycurl.Mvc;

namespace MovieDb.Data.Accessors
{
    public class CrudAccessor : Accessor
    {
        public IList<T> Get<T>() => this.Query<T>();
        public Task<IList<T>> GetAsync<T>() => this.QueryAsync<T>();

        public T Get<T>(object keyValues) => this.One<T>(keyValues);
        public Task<T> GetAsync<T>(object keyValues) => this.OneAsync<T>(keyValues);

        public void Create<T>(T model) => this.Execute(model);
        public Task CreateAsync<T>(T model) => this.ExecuteAsync(model);

        public void Update<T>(T model) => this.Execute(model);
        public Task UpdateAsync<T>(T model) => this.ExecuteAsync(model);

        public void Delete<T>(T model) => this.Execute(model);
        public Task DeleteAsync<T>(T model) => this.ExecuteAsync(model);
    }
}