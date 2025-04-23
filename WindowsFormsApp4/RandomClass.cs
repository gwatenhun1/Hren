using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class RandomClass
    {
        public int randomizer ()
        {
            Random rand = new Random ();
            int result = rand.Next (0, 100);
            return result;
        }



    }
}
