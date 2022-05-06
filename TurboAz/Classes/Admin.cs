using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurboAz.Interfaces;

namespace TurboAz.Classes
{
    public class Admin : Iremovable
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public void Remove()
        {
            Console.WriteLine("Elan silindi");
        }
    }
}