using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Domain.Entities
{
    public class HotelEntity : BaseEntity
    {
        public string  Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Stars { get; set; }
        public string Cnpj { get; set; }
    }
}