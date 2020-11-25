using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单元测试demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var powerSupply = new PowerSupply();
            DeskFan deskFan = new DeskFan(powerSupply);
            Console.WriteLine(deskFan.word());
        }
    }
    class PowerSupply
    {
        public int GoPower()
        {
            return 100;
        }
    }

    class DeskFan
    {
        public PowerSupply _powerSupply;

        public DeskFan(PowerSupply powerSupply)
        {
            _powerSupply = powerSupply;
        }

        public string word()
        {
            int power = _powerSupply.GoPower();
            if (power<=0)
            {
                return "没电";
            }
            else if (power <=100)
            {
                return "慢转";
            }
            else if(power <=200)
            {
                return "快转";
            }
            else
            {
                return "危险";
            }
        }
    }
}
