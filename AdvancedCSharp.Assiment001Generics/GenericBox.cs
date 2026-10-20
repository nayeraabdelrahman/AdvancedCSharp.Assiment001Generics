using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AdvancedCSharp.Assiment001Generics
{
    #region Q2 - Generic Container<T>
    internal class GenericBox<T>
    {
        // Write a generic class Container<T>
        // with Add and Get methods.

        #region Fields

        T boxValue;
        #endregion

        #region Constructors
     public GenericBox ( T boxValue)
        {
            this.boxValue = boxValue;
        }
        #endregion

        #region Methods

        #region Add and Get Method
        public void Add(T value)
        {
            BoxValue = value;
        }
        public T BoxValue
        {
            set{
                boxValue = value;
            }
            get{
                return boxValue;
            }
        }
        #endregion

        #endregion


    }
  
    #endregion
}
