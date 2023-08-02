using Application.IRepository;
using Application.Model;
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
    public class GetAllTruckByIdHandler : IRequestHandler<GetAllTruckByIdRequest, TruckDTO>
    {
        private ITruckRepository _truckRepository;
        private IMapper _mapper;
        public GetAllTruckByIdHandler(ITruckRepository truckRepository, IMapper mapper)
        {
            _truckRepository = truckRepository;
            _mapper = mapper;
        }

        public async Task<TruckDTO> Handle(GetAllTruckByIdRequest request, CancellationToken cancellationToken)
        {
            var truck = await _truckRepository.GetById(request.Id);
            return _mapper.Map<TruckDTO>(truck);
        }
    }
}
