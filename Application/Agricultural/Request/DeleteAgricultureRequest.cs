using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Agricultural.Request
{
    public class DeleteAgricultureRequest : IRequest<Unit>
    {
        public Guid Id { get; set; }
    }
}


