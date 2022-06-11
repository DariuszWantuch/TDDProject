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

        public override bool Equals(object? obj)
        {
            Money money = (Money)obj;

            return amount == money.amount;
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public abstract string Currency();
    }
}


