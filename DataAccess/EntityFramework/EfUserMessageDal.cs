using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Repository.Bases;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.EntityFramework
{
	public class EfUserMessageDal : GenericRepo<UserMessage, CoreContext>, IUserMessageDal
	{
		public List<UserMessage> GetUserMessagesWithUser()
		{
			using (var context = new CoreContext())
			{
				return context.UserMessages.Include(x=>x.User).ToList();
			}
		}
	}
}
