using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAz.Classes.folderByHuseyn
{
    internal class ListProd
    { 
            Dictionary<int, int> product = new Dictionary<int, int>();
    }
    internal class vehicleClass<T>
    {
        public T getVehicle(T t)
        {
            Console.WriteLine("Created");
            return t;
        }
    }
    internal class motoClass
    {
        public int Engine { get; set; }
        public int FIN { get; set; }
    }
}

