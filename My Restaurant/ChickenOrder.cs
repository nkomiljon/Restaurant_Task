using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Restaurant
{
    class ChickenOrder
    {
        //CR: You should create constructor to this class, that argument is quantity  (see requirements)
        //Class should has public variable

        public int GetQuantity(int quantity)
        {
            //CR: this method has no argument
            return quantity;
        }
        public string CutUp()
        {
            //CR: Method CutUp - no argument and return value
            return "You request is Chicken";
        }
        public string Cook()
        {
            //CR: Method Cook - no argument and return value
            return "Chicken is Cook";
        }
    }
}
