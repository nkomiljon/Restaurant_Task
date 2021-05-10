using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Restaurant
{
    class EggOrder
    {
        //CR: Class should has some public variables. Check the presentation
        //CR: You should create constructor to this class, that argument is quantity (see requirements)

        public int GetQuantity(int quantity)
        {
            //CR: This method has no arguments
            return quantity;
        }
        public int Crack()
        {
            //CR: Method doesn't return any value

            //CR: Egg quality should be implement only once, when an instance of EggOrder is created
            Random rnd = new Random();
            return rnd.Next(101);
            
            //CR: Method should throw an exception
        }
        public string GetQuality()
        {
            //CR: This method returns just quality of egg
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
            //CR: Method doesn't return value and doesn't do anything
            if (Crack() > 25)
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
            //CR: Method doesn't return value and doesn't do anything
            return "Egg is Cook";
        }
    }
}
