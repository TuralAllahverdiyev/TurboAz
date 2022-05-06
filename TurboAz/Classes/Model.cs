using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAz.Classes
{
    public enum Ban
    {
        sedan,
        hatchback,
        bus,
        cabrio,
        coupe
    }
    public enum Fuel
    {
        gasoline,
        diesel,
        gas,
        hybrid
    }
    public enum Gearbox
    {
        mechanical,
        automatic,
        robot
    }
    public enum Colors
    {
        white,
        black,
        green,
        gray
    }
    public class Model<Tname> : Marka
    {
        public int ModelId { get; set; }
        public Tname ModelName { get; set; }
        public double KM { get; set; }
        public Ban BanType { get; set; }
        public Fuel FuelType { get; set; }
        public Gearbox GearType { get; set; }
        public Colors Color { get; set; }

    }
}