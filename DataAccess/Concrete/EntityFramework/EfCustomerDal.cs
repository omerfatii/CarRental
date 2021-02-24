using Core.DataAccess_.EntityFramework_;
using DataAccess.Abstract;
using DataAccess.Concrete.Entity_Framework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RecapDatabaseContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (RecapDatabaseContext context=new RecapDatabaseContext())
            {
                var result = from c in context.Customers
                             join u in context.Users
                             on c.UserId equals u.Id

                             select new CustomerDetailDto
                             {
                                 Id = c.Id,
                                 CompanyName=c.CompanyName,
                                 FirstName=u.FirstName,
                                 LastName=u.LastName,
                                 Email=u.Email
                             };


                            return result.ToList();
            }
           
        }
    }
}
