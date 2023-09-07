using Core.Utilities;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int id);
        IDataResult<Car> GetByName(string name);
        IResult Add(Car car);
        IResult Update(Car car);   
        IResult Delete(int id);








    }
}
