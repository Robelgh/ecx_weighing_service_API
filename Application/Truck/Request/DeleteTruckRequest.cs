using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Truck.Request
{
    public class DeleteTruckRequest : IRequest
    {
        public Guid Id { get; set; }
}
}
