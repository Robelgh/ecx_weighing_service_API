using Application.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validation.Model.Validation
{
    public class AgriculturalDTOValidation : AbstractValidator<AgriculturalDTO>
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
        public DateTime DateReceived { get; set; }


        public AgriculturalDTOValidation()
        {
            RuleFor(p => p.Consignment)
                .NotEmpty().WithMessage("{PropertyName} is requiered.")
                .NotNull();
            RuleFor(p => p.Warehouse)
               .NotEmpty().WithMessage("{PropertyName} is requiered.")
               .NotNull();
            RuleFor(p => p.ClientId)
             .NotEmpty().WithMessage("{PropertyName} is requiered.")
             .NotNull();
            RuleFor(p => p.Commodity)
               .NotEmpty().WithMessage("{PropertyName} is requiered.")
               .NotNull();
            RuleFor(p => p.DriverName)
             .NotEmpty().WithMessage("{PropertyName} is requiered.")
             .NotNull();
            RuleFor(p => p.License)
               .NotEmpty().WithMessage("{PropertyName} is requiered.")
               .NotNull();
            RuleFor(p => p.PlaceIssued)
             .NotEmpty().WithMessage("{PropertyName} is requiered.")
             .NotNull();
            RuleFor(p => p.TruckPlate)
               .NotEmpty().WithMessage("{PropertyName} is requiered.")
               .NotNull();
            RuleFor(p => p.VoucherNumber)
             .NotEmpty().WithMessage("{PropertyName} is requiered.")
             .NotNull();
            RuleFor(p => p.TruckNumberPlomps)
               .NotEmpty().WithMessage("{PropertyName} is requiered.")
               .NotNull();
            RuleFor(p => p.TrailerNumberPlomps)
               .NotEmpty().WithMessage("{PropertyName} is requiered.")
               .NotNull();
            RuleFor(p => p.Region)
               .NotEmpty().WithMessage("{PropertyName} is requiered.")
               .NotNull();
            RuleFor(p => p.Zone)
               .NotEmpty().WithMessage("{PropertyName} is requiered.")
               .NotNull();
            RuleFor(p => p.SpecficArea)
               .NotEmpty().WithMessage("{PropertyName} is requiered.")
               .NotNull();
            RuleFor(p => p.ProductionYear)
              .NotNull().WithMessage("{PropertyName} is requiered.");

            RuleFor(p => p.NumberOfBags)
              .NotNull().WithMessage("{PropertyName} is requiered.");

            RuleFor(p => p.VehicleSize)
              .NotNull().WithMessage("{PropertyName} is requiered.");

            RuleFor(p => p.EstimatedWeight)
              .NotNull().WithMessage("{PropertyName} is requiered.");

            RuleFor(p => p.GrossWeight)
              .NotNull().WithMessage("{PropertyName} is requiered.");

            RuleFor(p => p.TicketNumber)
              .NotEmpty().WithMessage("{PropertyName} is requiered.")
              .NotNull();
            RuleFor(p => p.DateReceived)
             .NotEmpty().WithMessage("{PropertyName} is requiered.")
             .NotNull();
        }


    }
}
