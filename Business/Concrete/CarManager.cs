using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities;
using DataAccesss.Abstract;
using Entity.Concrete;
using FluentValidation;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _cardal;
        public CarManager(ICarDal cardal)
        {
            _cardal = cardal;    
        }

        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Car car)
        {
            if(_cardal.GetAll().Count > 10)
            {
                return new ErrorResult("Araba adeti 10 u geçemez");
            }

            //ValidationTool.Validate(new ProductValidator(), car);
            _cardal.Add(car);
            return new SuccessResult("Ürün eklendi");
        }

        public IResult Delete(int id)
        {
            
            _cardal.Delete(_cardal.Get(c=>c.CarId == id));
            return new SuccessResult("Ürün silindi");
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_cardal.GetAll(),"Ürünler başarıyle listelendi");
        }

        public IDataResult<Car> GetById(int id)
        {
            if (id > 3)
            {
                return new ErrorDataResult<Car>("id numarası 0 dan küçük olamaz");
            }
            return new SuccessDataResult<Car>(_cardal.Get(c => c.CarId == id), "başarıyla ürün getirildi.");
        }

        public IDataResult<Car> GetByName(string name)
        {
            return new SuccessDataResult<Car>(_cardal.Get(c => c.Brand == name),"başarıyla ürün getirildi.");
        }

        public IResult Update(Car car)
        {
            throw new NotImplementedException();
        }
    }

    
}
