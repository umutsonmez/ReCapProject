﻿using Core.DataAccess.EntityFamework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (RentACarContext context=new RentACarContext())
            {
                var result = from c in context.Cars
                             join co in context.Colors on c.ColorId equals co.Id
                             join b in context.Brands on c.BrandId equals b.Id
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandId = b.Id,
                                 ColorId = co.Id,
                                 CarName = c.Name,
                                 BrandName = b.Name,
                                 ColorName = co.Name,
                                 DailyPrice = c.DailyPrice,
                                 Description =c.Description,
                                 ModelYear=c.ModelYear,
                                 ImagePath = (from m in context.CarImages where m.CarId == c.Id select m.ImagePath).FirstOrDefault()
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
