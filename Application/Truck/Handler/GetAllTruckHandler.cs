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
    public class GetAllTruckHandler : IRequestHandler<GetAllTruckRequest, List<TruckDTO>>
    {
        private ITruckRepository _truckRepository;
        private IMapper _mapper;

        public GetAllTruckHandler(ITruckRepository truckRepository, IMapper mapper)
        {
            _truckRepository = truckRepository;
            _mapper = mapper;
        }
        public async Task<List<TruckDTO>> Handle(GetAllTruckRequest request, CancellationToken cancellationToken)
        {
            var truck = await _truckRepository.GetAll();
            return _mapper.Map<List<TruckDTO>>(truck);
        }
    }
}
