using Application.Agricultural.Request;
using Application.IRepository;
using Application.Model;
using Application.Validation.Model.Validation;
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
    public class CreateAgricultureHandler : IRequestHandler<CreateAgricultureRequest, BaseResponse>
    {
        private IAgriculturalRepository _agriculturalRepository;
        private IMapper _mapper;
        BaseResponse response;
        public CreateAgricultureHandler(IAgriculturalRepository agriculturalRepository, IMapper mapper)
        {
            _agriculturalRepository = agriculturalRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse> Handle(CreateAgricultureRequest request, CancellationToken cancellationToken)
        {
            response = new BaseResponse();
            var validator = new AgriculturalDTOValidation();
            var validationResult = await validator.ValidateAsync(request.AgricultureDTO);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Faild";
                response.Errors = validationResult.Errors.Select(x => x.ErrorMessage).ToList();
            }

            var agriculture = _mapper.Map<AgriculturalModel>(request.AgricultureDTO);
            var data = await _agriculturalRepository.Add(agriculture);
            response.Success = true;
            response.Message = "Creation Successfull";
            return response;
        }
    }
}
