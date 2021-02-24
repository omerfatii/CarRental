using Core.Entities_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto:IDto
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public DateTime RentDate { get; set; }
    }
}
