﻿using Core.DataAccess_;
using Core.DataAccess_.EntityFramework_;
using DataAccess.Concrete.Entity_Framework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IRentalDal:IEntityRepository<Rental>
    {
       
    }
}
