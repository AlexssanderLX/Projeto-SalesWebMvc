﻿
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Sellers> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Sellers obj)
        {

            obj.Departament = _context.Departament.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
        public Sellers FindbyId(int id)
        {
            return _context.Seller.Include(obj => obj.Departament).FirstOrDefault(obj => obj.Id == id);
        }
        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
    }
}