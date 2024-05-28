using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workers_management.Core.Entities;

namespace Workers_management.Core.Services
{
    public interface IPositionService
    {
        Task<IEnumerable<Position>> GetPositionsAsync();
        Task<Position> GetByIdAsync(int id);
        Task<Position> AddPositionAsync(Position position);
        //Task<Position> UpdatePositionAsync(int id, Position position);
        Task DeletePositionAsync(int id);

    }
}
