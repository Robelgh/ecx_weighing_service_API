using Application.Agricultural.Request;
using Application.IRepository;
using Application.Validation.Exception.Validation;
using Application.Validation.Model.Validation;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Agricultural.Handler
{
    public class UpdateAgricultureHandler : IRequestHandler<UpdateAgricultureRequest, Unit>
    {
        private IAgriculturalRepository _agriculturalRepository;
        private IMapper _mapper;
        public UpdateAgricultureHandler(IAgriculturalRepository agriculturalRepository, IMapper mapper)
        {
            _agriculturalRepository = agriculturalRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateAgricultureRequest request, CancellationToken cancellationToken)
        {
            var validator = new AgriculturalDTOValidation();
            var validationResult = await validator.ValidateAsync(request.agriculturalDTO);
            if (validationResult.IsValid == false)
                throw new ValidationException(validationResult);
            var agriculture = await _agriculturalRepository.GetById(request.agriculturalDTO.Id);
            _mapper.Map(request.agriculturalDTO, agriculture);
            await _agriculturalRepository.Update(agriculture);
            return Unit.Value;
        }

    
    }
}
