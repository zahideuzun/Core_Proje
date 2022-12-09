﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
	public class SocialMedia
	{
		[Key]
		public int SocialMediaId { get; set; }
		public string Name { get; set; }
		public string Url { get; set; }
		public string Icon { get; set; }
		public bool Status { get; set; }
	}
}
