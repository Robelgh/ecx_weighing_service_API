using Application.Agricultural.Handler;
using Application.Agricultural.Request;
using Application.IRepository;
using Application.Model;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Agricultural.Handler
{
    public class GetAllAgricultureHandler : IRequestHandler<GetAllAgricultureRequest,List< AgriculturalDTO>>
    {
        private IAgriculturalRepository _agriculturalRepository;
        private IMapper _mapper;
        public GetAllAgricultureHandler(IAgriculturalRepository agriculturalRepository, IMapper mapper)
        {
            _agriculturalRepository = agriculturalRepository;
            _mapper = mapper;

        }

        public async Task<List<AgriculturalDTO>> Handle(GetAllAgricultureRequest request, CancellationToken cancellationToken)
        {
            var agriculture = await _agriculturalRepository.GetAll();
            return _mapper.Map<List<AgriculturalDTO>>(agriculture);
        }
    }
}



