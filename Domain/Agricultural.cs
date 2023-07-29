using Domain.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Agricultural : BaseDomainEntity
    {

        public string Consignment { get; set; }
        public string Warehouse { get; set; }
        public Guid ClientId { get; set; }
        public string Commodity { get; set; }
        public string DriverName { get; set; }
        public string License { get; set; }
        public string PlaceIssued { get; set; }
        public string TruckPlate { get; set; }
        public string TrailerPlate { get; set; }
        public string VoucherNumber { get; set; }
        public string TruckNumberPlomps { get; set; }
        public string TrailerNumberPlomps { get; set; }
        public string Region { get; set; }
        public string Zone { get; set; }
        public string Woreda { get; set; }
        public string SpecficArea { get; set; }
        public int ProductionYear { get; set; }
        public int NumberOfBags { get; set; }
        public double VehicleSize { get; set; }
        public double EstimatedWeight { get; set; }
        public double GrossWeight { get; set; }
        public string TicketNumber { get; set; }
        public  DateTime DateReceived { get; set; }


    }
}
