using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameClassLibrary
{
    public class RandomNumber
    {
        public static int GetRandom(int maxValue)
        {
            Random random = new Random();
            return random.Next(0, maxValue)+1;
        }
    }
}
