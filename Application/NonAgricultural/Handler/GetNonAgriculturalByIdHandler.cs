using Application.IRepository;
using Application.Model;
using Application.NonAgricultural.Request;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.NonAgricultural.Handler
{
    public class GetNonAgriculturalByIdHandler : IRequestHandler<GetNonAgriculturalByIdRequest, NonAgriculturalDTO>
    {
        private INonAgriculturalRepository _nonagriculturalRepository;
        private IMapper _mapper;
        public GetNonAgriculturalByIdHandler(INonAgriculturalRepository nonagriculturalRepository, IMapper mapper)
        {
            _nonagriculturalRepository = nonagriculturalRepository;
            _mapper = mapper;
        }

        public async Task<NonAgriculturalDTO> Handle(GetNonAgriculturalByIdRequest request, CancellationToken cancellationToken)
        {
            var nonAgriculture = await _nonagriculturalRepository.GetById(request.Id);
            return _mapper.Map<NonAgriculturalDTO>(nonAgriculture);
        }
    }
}
