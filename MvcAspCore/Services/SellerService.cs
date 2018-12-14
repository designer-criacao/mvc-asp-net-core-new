using MvcAspCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcAspCore.Services
{
    public class SellerService
    {
        private readonly MvcAspCoreContext _context;

        public SellerService(MvcAspCoreContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
