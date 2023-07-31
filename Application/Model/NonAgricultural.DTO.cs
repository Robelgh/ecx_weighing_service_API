using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Agricultural.Model
{
    public class NonAgriculturalDTO : baseDTO
    {
        public string DriverName { get; set; }
        public string License { get; set; }
        public string TruckPlate { get; set; }
        public string Trailer { get; set; }
        public string TruckType { get; set; }
        public string WeighingItem { get; set; }
        public double GrossWeight { get; set; }
        public string Warehouse { get; set; }
        public string BankSlip { get; set; }
        public double WeighbridgeServiceFee { get; set; }
    }
}
