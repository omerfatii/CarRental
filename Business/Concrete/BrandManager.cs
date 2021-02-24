using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }    

        public Brand GetById(int id)
        {
            return _brandDal.Get(b => b.Id == id);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }
    }
}
