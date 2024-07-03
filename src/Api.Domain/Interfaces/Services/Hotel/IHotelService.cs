using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Hotel
{
    public interface IHotelService
    {
        Task<HotelEntity> Get (Guid id);
        Task<IEnumerable<HotelEntity>> GetAll ();
        Task<HotelEntity> Post (HotelEntity user);
        Task<HotelEntity> Put (HotelEntity user);
        Task<bool> Delete (Guid id);

    }
}