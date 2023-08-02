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
    public class GetAgricultureByIdHandler : IRequestHandler<GetAgricultureByIdRequest, AgriculturalDTO>
    {
        private IAgriculturalRepository _agriculturalRepository;
        private IMapper _mapper;
        public GetAgricultureByIdHandler(IAgriculturalRepository agriculturalRepository, IMapper mapper)
        {
            _agriculturalRepository = agriculturalRepository;
            _mapper = mapper;
        }

        public async Task<AgriculturalDTO> Handle(GetAgricultureByIdRequest request, CancellationToken cancellationToken)
        {
            var agriculture = await _agriculturalRepository.GetById(request.Id);
            return _mapper.Map<AgriculturalDTO>(agriculture);
        }
    }
}
