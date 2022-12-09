using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class Contact
	{
		[Key]
		public int ContactId { get; set; }
		public string Title { get; set; }
		public string Desciption { get; set; }
		public string Mail { get; set; }
		public string Phone { get; set; }
	}
}
