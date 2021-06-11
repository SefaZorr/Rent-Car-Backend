using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentCarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetByRentalDetails()
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from ca in context.Cars
                             join re in context.Rentals on ca.Id equals re.CarId
                             join cu in context.Customers on re.CustomerId equals cu.Id
                             join u in context.Users on cu.UserId equals u.Id
                             join br in context.Brands on ca.BrandId equals br.Id

                             select new RentalDetailDto
                             {
                                 RentalId = re.Id,
                                 CarName = ca.Description,
                                 CompanyName = cu.CompanyName,
                                 RentDate = re.RentDate,
                                 ReturnDate = re.ReturnDate,
                                 Name = u.FirstName,
                                 LastName = u.LastName,
                                 BrandName=br.BrandName
                             };
                return result.ToList();

            }
        }
    }
}
