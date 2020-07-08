using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoCar.Data
{
    public class EntityData<T> where T: class
    {
        public SocarEntities CreateContext()
        {
            SocarEntities context = new SocarEntities();
            context.Configuration.ProxyCreationEnabled = false;
            context.Database.Log = x => Console.WriteLine(x);

            return context;
        }
        public List<T> GetAll()
        {
            SocarEntities context = CreateContext();
            return context.Set<T>().ToList();
        }
        public int GetCount()
        {
            SocarEntities context = CreateContext();
            return context.Set<T>().Count();
        }
        public void Insert(T entity)
        {
            SocarEntities context = CreateContext();
            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();
        }
        public virtual void Update(T entity)
        {
            SocarEntities context = CreateContext();
            
            context.Entry(entity).State = EntityState.Modified;
  
            context.SaveChanges();            
        }
        public void Delete(T entity)
        {
            SocarEntities context = CreateContext();
            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();
        }




    }
}
