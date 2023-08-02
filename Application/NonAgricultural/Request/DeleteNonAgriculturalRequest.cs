using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.NonAgricultural.Request
{
    public class DeleteNonAgriculturalRequest : IRequest
    {
        public Guid Id { get; set; }
    }
}
