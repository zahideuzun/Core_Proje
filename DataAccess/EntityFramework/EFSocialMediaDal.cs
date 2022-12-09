﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Repository.Bases;
using Entities.Concrete;

namespace DataAccess.EntityFramework
{
	public class EFSocialMediaDal : GenericRepo<SocialMedia>, ISocialMediaDal
	{
        protected EFSocialMediaDal(CoreContext dbContext) : base(dbContext)
        {

        }
    }
}
