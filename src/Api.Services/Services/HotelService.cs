using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Hotel;

namespace Api.Services.Services
{
    public class HotelService : IHotelService
    {
        private IRepository<HotelEntity> _repository;
        public HotelService(IRepository<HotelEntity> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<HotelEntity> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<HotelEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<HotelEntity> Post(HotelEntity hotel)
        {
            return await _repository.InsertAsync(hotel);
        }

        public async Task<HotelEntity> Put(HotelEntity hotel)
        {
            return await _repository.UpdateAsync(hotel);
        }
    }
}