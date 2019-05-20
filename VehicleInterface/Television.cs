using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInterface
{
    class Television : IElectronicDevice
    {

        public int Volume { get; set; }

        public void Off()
        {
            Console.WriteLine("The TV is Off");
        }

        public void On()
        {
            Console.WriteLine("The TV is On");
        }

        public void VolumeDown()
        {
            if (Volume > 0)
            {
                Volume--;
                Console.WriteLine($"The TV Volume is at {Volume}");

            }
        }

        public void VolumeUp()
        {
            if (Volume < 99)
            {
                Volume++;
                Console.WriteLine($"The TV Volume is at {Volume}");
            }
        }
    }
}
