using Core.Utilities.Results;
using Entities.Concrete;
using System;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetByCarId(int id);
        IDataResult<CarImage> GetById(int id);
        IResult Delete(CarImage carImage);
        IResult Add(CarImage carImage, IFormFile file); 
        IResult Update(CarImage carImage, IFormFile file);
    }
}
