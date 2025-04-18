﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCarEF.DAL.Entities
{
	public class Brand
	{
        [Key]
        public int Id { get; set; }
        
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

		[MaxLength(50)]
		public string Origin { get; set; }

		public override string ToString()
		{
			return $"Marque n° {Id} : {Name} - {Origin}";
		}
	}
}
