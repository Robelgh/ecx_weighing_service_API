﻿using Application.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Truck.Request
{
    public class CreateTruckRequest : IRequest<BaseResponse>
    {
        public TruckDTO TruckDTO { get; set; }
    }
}
