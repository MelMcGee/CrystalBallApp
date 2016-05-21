using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrystalBallApp.Models
{
   public class RandomStrings
    {
        private string[] availableStrings = { "Code is poetry","Ladies prefer coding", "We Can Code IT", "Puppies are cute"};
        private Random rnd = new Random(); //just grabbing a random object so we can use it later

        //get string
        internal string grabRandomString()
        {
            return availableStrings[rnd.Next(0,availableStrings.Length)];
        }
    }
}
