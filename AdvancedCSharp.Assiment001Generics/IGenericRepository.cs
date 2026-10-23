using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharp.Assiment001Generics
{
    internal interface IGenericRepository<T>
    {
        void additem(T item);
        //void deletebox(T box);
        List<T> GetAll();
        //T GetById(int id);
    }
}
