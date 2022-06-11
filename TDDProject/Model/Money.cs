using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TDDProject.Model
{
    public abstract class Money 
    {
        protected int amount;
        protected string currency;

        public override bool Equals(object? obj)
        {
            Money money = (Money)obj;

            return amount == money.amount;
        }


        public static Money Dollar(int amount, string currency)
        {
            return new Dollar(amount, currency);
        }

        public static Money Franc(int amount, string currency)
        {
            return new Franc(amount, currency);
        }

        public abstract string Currency();
    }
}


