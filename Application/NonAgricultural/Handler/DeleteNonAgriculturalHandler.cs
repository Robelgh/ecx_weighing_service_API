using Application.IRepository;
using Application.NonAgricultural.Request;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.NonAgricultural.Handler
{
    public class DeleteNonAgriculturalHandler : IRequestHandler<DeleteNonAgriculturalRequest>
    {
        private INonAgriculturalRepository _nonagriculturalRepository;
        private IMapper _mapper;

        public DeleteNonAgriculturalHandler(INonAgriculturalRepository nonagriculturalRepository, IMapper mapper)
        {
            _nonagriculturalRepository = nonagriculturalRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteNonAgriculturalRequest request, CancellationToken cancellationToken)
        {
            var nonAgriculture = await _nonagriculturalRepository.GetById(request.Id);
            await _nonagriculturalRepository.Delete(nonAgriculture);
            return Unit.Value;
        }


    }
}
