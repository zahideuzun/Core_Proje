﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class Testimonial
	{
		[Key]
		public int TestimonialId { get; set; }
		public string ClientName { get; set; }
		public string Company { get; set; }
		public string Comment { get; set; }
		public int ImageUrl { get; set; }

	}
}
