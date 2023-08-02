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
    public class GetAllNonAgriculturalHandler : IRequestHandler<GetAllNonAgriculturalRequest, List<NonAgriculturalDTO>>
    {
        private INonAgriculturalRepository _nonagriculturalRepository;
        private IMapper _mapper;
        
        public GetAllNonAgriculturalHandler(INonAgriculturalRepository nonagriculturalRepository, IMapper mapper)
        {
            _nonagriculturalRepository = nonagriculturalRepository;
            _mapper = mapper;
        }
        public async Task<List<NonAgriculturalDTO>> Handle(GetAllNonAgriculturalRequest request, CancellationToken cancellationToken)
        {
            var nonAgriculture = await _nonagriculturalRepository.GetAll();
            return _mapper.Map<List<NonAgriculturalDTO>>(nonAgriculture);
        }
    }
}
