using Application.Agricultural.Request;
using Application.IRepository;
using Application.Validation.Exception.Validation;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Agricultural.Handler
{
    public class DeleteAgricultureHandler : IRequestHandler<DeleteAgricultureRequest,Unit>
    {
        private IAgriculturalRepository _agriculturalRepository;
        private IMapper _mapper;

        public DeleteAgricultureHandler(IAgriculturalRepository agriculturalRepository, IMapper mapper)
        {
            _agriculturalRepository = agriculturalRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteAgricultureRequest request, CancellationToken cancellationToken)
        {
            var agriculture = await _agriculturalRepository.GetById(request.Id);
            await _agriculturalRepository.Delete(agriculture);
            return Unit.Value;
        }
    }

     
}
