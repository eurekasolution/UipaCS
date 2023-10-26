using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IRemoteController
    {
        public void powerOn();
        public void powerOff();
        public void volumeUp();
        public void volumeDown();
    }

    public class Tv : IRemoteController
    {
        public void powerOn()
        {
            Console.WriteLine("power on");
        }
        public void powerOff()
        {
            Console.WriteLine("power off");
        }
        public void volumeUp()
        {
            Console.WriteLine("volume up");
        }
        public void volumeDown()
        {
            Console.WriteLine("volume down");
        }
    }

    public class Test08
    {
        public static void Main08(string[] args)
        {
            Tv tv = new Tv();
            tv.powerOn();
            tv.volumeUp();
            tv.volumeDown();
            tv.powerOff();
        }
    }
}
