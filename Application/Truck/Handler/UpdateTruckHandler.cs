using Application.IRepository;
using Application.Model;
using Application.NonAgricultural.Request;
using Application.Truck.Request;
using Application.Validation.Model.Validation;
using AutoMapper;
using Application.Validation.Exception.Validation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Truck.Handler
{
    public class UpdateTruckHandler : IRequestHandler<UpdateTruckRequest>
    {
        private ITruckRepository _truckRepository;
        private IMapper _mapper;
        public UpdateTruckHandler(ITruckRepository truckRepository, IMapper mapper)
        {
            _truckRepository = truckRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateTruckRequest request, CancellationToken cancellationToken)
        {
            var validator = new TruckDTOValidation();
            var validationResult = await validator.ValidateAsync(request.TruckDTO);
            if (validationResult.IsValid == false)
                throw new ValidationException(validationResult);
            var truck = await _truckRepository.GetById(request.TruckDTO.Id);
            _mapper.Map(request.TruckDTO, truck);
            await _truckRepository.Update(truck);
            return Unit.Value;
        }

      
    }

}
