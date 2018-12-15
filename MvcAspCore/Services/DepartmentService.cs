using MvcAspCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcAspCore.Services
{
    public class DepartmentService
    {
        private readonly MvcAspCoreContext _context;

        public DepartmentService(MvcAspCoreContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
