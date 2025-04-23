using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class locations
    {
        public int itemsValue(int result)
        {
            int valueItems = 0;

            if (result>= 1 && result<50)
            {
                valueItems = 1;
            }
            else if (result >= 50 && result<80)
            {
                valueItems = 2;
            }
            else if (result>= 80 && result<=99)
            {
                valueItems = 3;
            }
            else if (result == 100)
            {
                valueItems = 4;
            }

            return valueItems;
        }



    }
}
