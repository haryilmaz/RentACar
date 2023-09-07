using Core.DataAccess.EntityFramework;
using DataAccesss.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesss.Concrete
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentalContext>,ICarDal
    {
    }
}
