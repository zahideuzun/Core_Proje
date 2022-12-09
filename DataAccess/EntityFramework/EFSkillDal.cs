using System;
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
	public class EFSkillDal : GenericRepo<Skill>, ISkillDal
	{
        protected EFSkillDal(CoreContext dbContext) : base(dbContext)
        {

        }
    }
}
