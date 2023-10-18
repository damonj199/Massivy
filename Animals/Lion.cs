using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Lion
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string View { get; set; }
        public string Habitat { get; set; }
        public double Area { get; set; }
        public string Food { get; set; }
        public string Sound { get; set; }

        public void DoVoice()
        {
            Console.WriteLine($"{Name} Pppp-Ppp");
        }

    }
}
