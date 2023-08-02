using Application.Agricultural.Request;
using Application.IRepository;
using Application.Model;
using Application.NonAgricultural.Request;
using Application.Validation.Model.Validation;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.NonAgricultural.Handler
{
    public class CreateNonAgriculturalHandler : IRequestHandler<CreateNonAgriculturalRequest, BaseResponse>
    {
        private INonAgriculturalRepository _nonagriculturalRepository;
        private IMapper _mapper;
        BaseResponse response;
        public CreateNonAgriculturalHandler(INonAgriculturalRepository nonagriculturalRepository, IMapper mapper)
        {
            _nonagriculturalRepository = nonagriculturalRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse> Handle(CreateNonAgriculturalRequest request, CancellationToken cancellationToken)
        {
            response = new BaseResponse();
            var validator = new NonAgriculturalDTOValidation();
            var validationResult = await validator.ValidateAsync(request.NonAgriculturalDTO);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Faild";
                response.Errors = validationResult.Errors.Select(x => x.ErrorMessage).ToList();
            }

            var nonagriculture = _mapper.Map<NonAgriculturalModel>(request.NonAgriculturalDTO);
            var data = await _nonagriculturalRepository.Add(nonagriculture);
            response.Success = true;
            response.Message = "Creation Successfull";
            return response;
        }
    }
}
