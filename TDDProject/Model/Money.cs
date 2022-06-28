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

        public static Money Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public abstract int Plus(int amountAdd);

        public abstract void Reduce(int reduceAmount);

        public abstract string Currency();
    }
}


