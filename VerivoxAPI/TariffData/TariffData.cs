using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VerivoxAPI.Models;
using VerivoxAPI.TariffData;

namespace VerivoxAPI.TariffData
{
    public class TariffData : ITariffData
    {
       

        private List<Tariff> ObjTarrifs = new List<Tariff>()
        {
            new Tariff(){
                    Id = Guid.NewGuid(),
                    TarrifName = "Product A",
                    

                },

            new Tariff(){
                    Id = Guid.NewGuid(),
                    TarrifName = "Product B",
                    

                }
        };


        List<Tariff> ITariffData.GetTariff(Double consumption)
        {
            foreach(Tariff trf in ObjTarrifs)
            {
                trf.consumption = consumption;
            }
            return ObjTarrifs.OrderBy(o => o.AnnualCost).ToList();
        }

        

        //List<Tariff> ITariffData.GetTarrifs()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
