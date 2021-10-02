using CaseMediaMVC.Data.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CaseMediaMVC.Entities.BusinessEntities;

namespace CaseMediaMVC.Data
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly ICaseMediaDBContext _caseMediaContext;
        protected IMongoCollection<T> _dbCollection;

        protected BaseRepository(ICaseMediaDBContext context)
        {
            _caseMediaContext = context;
            _dbCollection = _caseMediaContext.GetCollection<T>(typeof(T).Name);
        }

        public virtual T Add(T entity)
        {
            _dbCollection.InsertOne(entity);
            return entity;
        }

        public virtual T GetById(Guid id)
        {
            return _dbCollection.Find<T>(m => m.Id == id).FirstOrDefault();
        }

        public virtual void Remove(Guid id)
        {
            _dbCollection.DeleteOne(m => m.Id == id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbCollection.Find<T>(T => true).ToList();
        }

        public void Update(T entity)
        {
            _dbCollection.ReplaceOne(Builders<T>.Filter.Eq("_id", entity.Id), entity);
        }
    }
}
