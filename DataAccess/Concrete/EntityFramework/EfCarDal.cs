﻿using Core.DataAccess_.EntityFramework_;
using DataAccess.Abstract;
using DataAccess.Concrete.Entity_Framework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{

    public class EfCarDal : EfEntityRepositoryBase<Car, RecapDatabaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RecapDatabaseContext context = new RecapDatabaseContext()) 
            {
                var result = from c in context.Cars
                             join co in context.Colors
                                on c.ColorId equals co.Id
                             join b in context.Brands
                                on c.BrandId equals b.Id
                              
                             select new CarDetailDto { 
                                 Id = c.Id,
                                 ModelYear = c.ModelYear, 
                                 ColorName = co.Name, 
                                 Description = c.Description, 
                                 BrandName=b.Name
                             };
                return result.ToList();
            }
        }
    }
}

