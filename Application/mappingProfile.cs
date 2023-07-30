using Application.DTO;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class mappingProfile
    {
        public MappingProfile()
        {
            CreateMap<Agricultural, AgriculturalDTO>().ReverseMap();
            CreateMap<nonAgricultural, NonAgriculturalDTO>().ReverseMap();
            CreateMap<Truck, TruckDTO>().ReverseMap();
        }
    }
}
