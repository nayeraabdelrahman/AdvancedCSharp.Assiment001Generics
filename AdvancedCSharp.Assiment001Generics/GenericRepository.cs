using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharp.Assiment001Generics
{
    internal class GenericRepository<T>:IGenericRepository<T>
    {
       private readonly List<T> _items = [];
        public void additem(T item)
        {
            _items.Add(item);
        }
        //void deletebox(int id) {
        //    foreach(var item in _items)
        //    {
        //        if (item.id==id)
        //    }
        //}
        public List<T> GetAll()
        {
            return _items;
        }
        //T GetById(int id);
    }
}
