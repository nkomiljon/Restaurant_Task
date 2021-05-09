using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Restaurant
{
    class EggOrder
    {

        public int GetQuantity(int quantity)
        {
            return quantity;
        }
       
        public int Crack()
        {
            Random rnd = new Random();
            return rnd.Next(101);
        }
        public string GetQuality()
        {
            if (Crack() < 25)
            {
                return "Egg is Bad!!!";
            }
            else
            {
                return $"{Crack()}";
            }
        }
        public string DiscardShell()
        {
           if(Crack() > 25)
            {
                return "Egg is Good DiscardShell";
            }
           else
            {
                return "Egg is Bad no DiscardShell";
            }
        }
        public string Cook()
        {
               return "Egg is Cook";
            
        }
    }
}
