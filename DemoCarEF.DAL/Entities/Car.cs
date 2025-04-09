using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCarEF.DAL.Entities
{
	public class Car
	{
		[Key]
        public int Id { get; set; }

		[MaxLength(50)]
		[Column("ModelDeLaVoiture")]
		[Required]
		public string Model { get; set; }

		[ForeignKey("BrandId")]
        public Brand Brand { get; set; }

		public override string ToString()
		{
			return $"Voiture n° {Id} : {Brand.Name} {Model}";
		}
	}
}
