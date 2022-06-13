using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    internal class SamsungRemocon : IRemoteControl
    {
        public void ChDown()
        {
            Console.WriteLine("SamsungRemocon ChDown...");
        }

        public void ChUp()
        {
            Console.WriteLine("SamsungRemocon ChUp...");
        }

        public void PowerOff()
        {
            Console.WriteLine("SamsungRemocon PowerOff...");
        }

        public void PowerOn()
        {
            Console.WriteLine("SamsungRemocon PowerOn...");
        }

        public void SoundDown()
        {
            Console.WriteLine("SamsungRemocon SoundDown...");
        }

        public void SoundUp()
        {
            Console.WriteLine("SamsungRemocon SoundUp...");
        }

    }
}
