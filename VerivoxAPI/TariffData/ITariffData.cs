using System;
using System.Collections.Generic;
using VerivoxAPI.Models;
using System.Linq;
using System.Threading.Tasks;

namespace VerivoxAPI.TariffData
{
    public interface ITariffData
    {
        //List<Tariff>GetTarrifs();

        public List<Tariff> GetTariff(Double consumption);
    }
}
