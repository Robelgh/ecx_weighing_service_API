using Application.IRepository;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{

    public class NonAgriculturalRepository : GenericRepository<NonAgriculturalModel>, INonAgriculturalRepository
    {
        private readonly ECXDBContext _context;

        public NonAgriculturalRepository(ECXDBContext context) : base(context)
        {
            _context = context;
        }
    }
}
