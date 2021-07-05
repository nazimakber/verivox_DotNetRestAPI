using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

namespace VerivoxAPI.Models
{
    public class Tariff
    {
        private double baseCost = 60;
        public Guid Id { get; set; }
        public String TarrifName { get; set; }
        public Double consumption { get; set; }
        public double AnnualCost => TarrifName == "Product A" ? (consumption * 0.22) + baseCost : (consumption <= 4000) ? 800 : 800 + (consumption - 4000) * 0.30;  

        //public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);


    }
}
