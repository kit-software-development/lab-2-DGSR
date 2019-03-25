using Practice.Common;
using Practice.HR.Events;
using System;

namespace Practice.HR
{
    /// <summary>
    ///     Скрытая реализация представления о клиенте.
    /// </summary>
    internal class Client : AbstractPerson, IClient
    {
        /*
         * TODO #4: Реализуйте интерфейс IClient для класса Client
         */
        private float _discount;
        public float Discount{
            get
            { return _discount; }
            set {
                var args = new ValueChangeEventArgs<float>(_discount);
                _discount = value;
                DiscountChange?.Invoke(this, args);
            }
        }

        public Client(IName name,float discount): base(name){
           Discount=discount;
    }
        public event EventHandler<ValueChangeEventArgs<float>> DiscountChange;
    }
    }
