﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract.Bases;
using Entities.Concrete;

namespace DataAccess.Abstract
{
	public interface IUserDal : IGenericDal<User>
	{

	}
}
