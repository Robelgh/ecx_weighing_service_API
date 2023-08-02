using Application.IRepository;
using Application.Model;
using Application.Truck.Request;
using Application.Validation.Model.Validation;
using AutoMapper;
using Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Truck.Handler
{
    public class CreateTruckHandler : IRequestHandler<CreateTruckRequest, BaseResponse>
    {
        private ITruckRepository _truckRepository;
        private IMapper _mapper;
        BaseResponse response;

        public CreateTruckHandler(ITruckRepository truckRepository, IMapper mapper)
        {
            _truckRepository = truckRepository;
            _mapper = mapper;
        }
        public async Task<BaseResponse> Handle(CreateTruckRequest request, CancellationToken cancellationToken)
        {
            response = new BaseResponse();
            var validator = new TruckDTOValidation();
            var validationResult = await validator.ValidateAsync(request.TruckDTO);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Faild";
                response.Errors = validationResult.Errors.Select(x => x.ErrorMessage).ToList();
            }

            var truck = _mapper.Map<TruckModel>(request.TruckDTO);
            var data = await _truckRepository.Add(truck);
            response.Success = true;
            response.Message = "Creation Successfull";
            return response;
        }
    }
}
