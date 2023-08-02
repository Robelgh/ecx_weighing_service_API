using Application.IRepository;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repository
{
    public class TruckRepository : GenericRepository<TruckModel>, ITruckRepository
    {
        private readonly ECXDBContext _context;

        public TruckRepository(ECXDBContext context) : base(context)
        {
            _context = context;
        }
    }

}
