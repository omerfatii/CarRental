﻿using Core;
using Core.Entities_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto:IDto
    {
        public int Id { get; set; }
        public int ModelYear { get; set; }
        public string BrandName { get; set; }
        public string Description { get; set; }

        public string ColorName { get; set; }

    }
}
