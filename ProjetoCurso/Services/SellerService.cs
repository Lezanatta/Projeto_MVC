﻿using ProjetoCurso.Data;
using ProjetoCurso.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ProjetoCurso.Services.Exceptions;
using System.Threading.Tasks;

namespace ProjetoCurso.Services
{
    public class SellerService
    {
        private readonly ProjetoCursoContext _context;

        public SellerService(ProjetoCursoContext context)
        {
            _context = context;
        }

        public async Task<List<Seller>> FindAllAsync()
        {
            return await _context.Seller.ToListAsync();
        }
        //outro teste

        public async Task InsertAsync(Seller obj)
        {
            _context.Add(obj);
           await _context.SaveChangesAsync();
        }

        public async Task<Seller> FindByIdAsync(int id)
        {
            return await _context.Seller.Include(obj => obj.Department).FirstOrDefaultAsync(obj => obj.Id == id);
        }
        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Seller.FindAsync(id);
                _context.Seller.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException(e.Message);
            }
        }
        public async Task UpdateAsync(Seller obj)
        {
            bool hasAny = await _context.Seller.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id not Found!");
            }
            try 
            {
                _context.Update(obj);
               await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
