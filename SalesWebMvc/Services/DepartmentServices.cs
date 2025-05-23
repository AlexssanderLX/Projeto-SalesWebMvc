﻿using SalesWebMvc.Data;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
    public class DepartmentServices
    {
        private readonly SalesWebMvcContext _context;

        public DepartmentServices(SalesWebMvcContext context)
        {
            _context = context;
        }
        public List<Departament> FindAll()
        {
            return _context.Departament.OrderBy(x => x.Name).ToList();
        }
    }
}
