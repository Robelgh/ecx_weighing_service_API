using Application.IRepository;
using Application.NonAgricultural.Request;
using Application.Truck.Request;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Truck.Handler
{
    public class DeleteTruckHandler : IRequestHandler<DeleteTruckRequest,Unit>
    {
        private ITruckRepository _truckRepository;
        private IMapper _mapper;
        public DeleteTruckHandler(ITruckRepository truckRepository, IMapper mapper)
        {
            _truckRepository = truckRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteTruckRequest request, CancellationToken cancellationToken)
        {
            var truck = await _truckRepository.GetById(request.Id);
            await _truckRepository.Delete(truck);
            return Unit.Value;
        }
    }
}
