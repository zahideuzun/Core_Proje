﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
	public class SkillManager : ISkillService
	{
		private ISkillDal _skillDal;

		public SkillManager(ISkillDal skillDal)
		{
			_skillDal = skillDal;
		}
		public void TAdd(Skill t)
		{
			_skillDal.Insert(t);
		}

		public void TDelete(Skill t)
		{
			_skillDal.Delete(t);
		}

		public void TUpdate(Skill t)
		{
			_skillDal.Update(t);
		}

		public List<Skill> GetList()
		{
			return _skillDal.GetList();
		}

		public Skill GetById(int id)
		{
			return _skillDal.GetById(id);
		}

		public List<Skill> TGetListByFilter()
		{
			throw new NotImplementedException();
		}
	}
}
