﻿using Core.Ultilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> GetById(int customerId);
        IResult Update(Customer customer);
        IResult Delete(Customer customer);
        IResult Add(Customer customer);

    }
}
