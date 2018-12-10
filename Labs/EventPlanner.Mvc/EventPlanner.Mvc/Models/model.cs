using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventPlanner.Mvc.Models
{
	public class model
	{
		public model() { }

		public model(ScheduledEvent item)
		{
			if (item != null)
			{
				Id = item.Id;
				Name = item.Name;
				Description = item.Description;
				StartDate = item.StartDate;
				EndDate = item.EndDate;
			}
		}

		public ScheduledEvent ToDomain()
		{
			return new ScheduledEvent
			{
				Name = Name,
				Description = Description,
				StartDate = StartDate,
				EndDate = EndDate,
			};
		}

		public int Id { get; set; }

		[Required(AllowEmptyStrings = false)]
		public string Name { get; set; }

		public string Description { get; set; }

		[Display(Name = "Start Date")]
		public DateTime StartDate { get; set; }

		[Display(Name = "End Date")]
		[Range(10, Int32.MaxValue, ErrorMessage = "End date must be greater than or equal to start date")]
		public DateTime EndDate { get; set; }


	}
}