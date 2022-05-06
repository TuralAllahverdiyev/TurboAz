using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboAz.Interfaces;

namespace TurboAz.Classes
{
    public class User : Iremovable
    {
        public string Email { get; set; }
        public int PhoneNum { get; set; }
        public int Login { get; set; }
        public string Password { get; set; }

        public void Remove()
        {
            Console.WriteLine("Elan silindi");
        }

        public void Add()
        {
            Console.WriteLine("Elan elave edilid");
        }


    }
}