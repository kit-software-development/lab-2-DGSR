using Practice.Common;
using Practice.HR.Events;
using System;

namespace Practice.HR
{
    /// <summary>
    ///     Абстрактная база для описания конкретных реализаций типа "Человек".
    ///     Используется для дальнейшего наследования.
    /// </summary>
    internal abstract class AbstractPerson
    {
        private IName _name;
       // internal Organization.Department Department
        //{           get            {              throw new System.NotImplementedException();           }

         //   set           {               throw new System.NotImplementedException();          }      }
        public IName Name
        {
            get
            {
                return _name;
            }

            set
            {
                ValueChangeEventArgs<IName> args = new ValueChangeEventArgs<IName>(_name);
                _name = value;
                NameChange?.Invoke(this, args);
            }
        }

        //internal Common.Name Name
        //{
         //   get
      //      {
     //           throw new System.NotImplementedException();
    //        }
    
            //set
           // {
           //     throw new System.NotImplementedException();
         //   }
       // }
   
        public event EventHandler<ValueChangeEventArgs<IName>> NameChange;

        public AbstractPerson(IName name)
        {
            Name = name;
        }
        /*
         * TODO #3: Реализуйте интерфейс IPerson для класса AbstractPerson
         */
    }
}
