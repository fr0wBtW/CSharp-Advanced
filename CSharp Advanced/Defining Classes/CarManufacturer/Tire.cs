using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
   public class Tire
    {
        public Tire(int year, double pressuse)
        {
            this.Year = year;
            this.Pressure = pressuse;
        }
        public int Year { get; set; }
        public double Pressure { get; set; }
    }
}
