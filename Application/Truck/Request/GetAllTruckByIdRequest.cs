using Application.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Truck.Request
{
    public class GetAllTruckByIdRequest : IRequest<TruckDTO>
    {
        public Guid Id { get; set; }
    }
}
