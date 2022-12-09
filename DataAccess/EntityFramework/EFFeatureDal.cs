using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Repository.Bases;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EntityFramework
{
	public class EFFeatureDal : GenericRepo<Feature> , IFeatureDal
	{
        //public EFFeatureDal()
        //{

        //}
        public EFFeatureDal(CoreContext dbContext) : base(dbContext)
        {

        }
    }
}
