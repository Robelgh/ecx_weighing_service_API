using Application.Agricultural.Request;
using Application.IRepository;
using Application.Model;
using Application.NonAgricultural.Request;
using Application.Validation.Exception.Validation;
using Application.Validation.Model.Validation;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.NonAgricultural.Handler
{
    public class UpdateNonAgriculturalHandler : IRequestHandler<UpdateNonAgriculturalRequest>
    {
        private INonAgriculturalRepository _nonagriculturalRepository;
        private IMapper _mapper;
        BaseResponse response;
        public UpdateNonAgriculturalHandler(INonAgriculturalRepository nonagriculturalRepository, IMapper mapper)
        {
            _nonagriculturalRepository = nonagriculturalRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateNonAgriculturalRequest request, CancellationToken cancellationToken)
        {
            var validator = new NonAgriculturalDTOValidation();
            var validationResult = await validator.ValidateAsync(request.NonAgriculturalDTO);
            if (validationResult.IsValid == false)
                throw new ValidationException(validationResult);
            var nonagricultural = await _nonagriculturalRepository.GetById(request.NonAgriculturalDTO.Id);
            _mapper.Map(request.NonAgriculturalDTO, nonagricultural);
            await _nonagriculturalRepository.Update(nonagricultural);
            return Unit.Value;
        }
    }
}
