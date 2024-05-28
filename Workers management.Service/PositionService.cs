using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workers_management.Core.Entities;
using Workers_management.Core.Repositories;
using Workers_management.Core.Services;

namespace Workers_management.Service
{
    public class PositionService: IPositionService
    {
        private readonly IPositionRepository _positionRepository;

        public PositionService(IPositionRepository positionRepository)
        {
            this._positionRepository = positionRepository;
        }

        public async Task<Position> AddPositionAsync(Position position)
        {
            return await _positionRepository.AddPositionAsync(position);    
        }

        public async Task DeletePositionAsync(int id)
        {
            await _positionRepository.DeletePositionAsync(id);  
        }

        public async Task<Position> GetByIdAsync(int id)
        {
            return await _positionRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Position>> GetPositionsAsync()
        {
            return  await _positionRepository.GetPositionsAsync();
        }

        //public async Task<Position> UpdatePositionAsync(int id, Position position)
        //{
        //    return await _positionRepository.UpdatePositionAsync(id, position);
        //}
    }
}
