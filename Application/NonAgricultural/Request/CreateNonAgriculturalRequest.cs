﻿using Application.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.NonAgricultural.Request
{
    public class CreateNonAgriculturalRequest : IRequest<BaseResponse>
    {
        public NonAgriculturalDTO NonAgriculturalDTO { get; set; }
    }
}
