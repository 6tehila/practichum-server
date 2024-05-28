using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workers_management.Core.Entities;
using Workers_management.Core.Repositories;

namespace Workers_management.Data.Repositories
{
    public class PositionRepository : IPositionRepository
    {

        private readonly DataContext _context;

        public PositionRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Position> AddPositionAsync(Position position)
        {
            _context.Positions.Add(position);
            await _context.SaveChangesAsync();  
            return position;
        }

        public async Task DeletePositionAsync(int id)
        {
    
            var position = await GetByIdAsync(id);
            _context.Positions.Remove(position);
            await _context.SaveChangesAsync();
        }

        public async Task<Position> GetByIdAsync(int id)
        {
            return await _context.Positions.FirstAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Position>> GetPositionsAsync()
        {
            return await _context.Positions.ToListAsync();
        }

        public async Task<Position> UpdatePositionAsync(int id, Position position)
        {
            var updatePo = await GetByIdAsync(position.Id);           

            if (updatePo != null)
            {
                updatePo.Id = position.Id;
                updatePo.Name = position.Name;
                updatePo.entryDate = position.entryDate;
                return updatePo;
            }
            return null;
        }
    }
}
