using System;
using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Models
{
	public class TodoItem
	{
		public TodoItem()
		{
			CreatedDate = DateTime.Now;
		}

		public int Id { get; set; }

		[Required(ErrorMessage = "Enter Title for next to do")]
		[MaxLength(200)]
		public string Title { get; set; }

		[MaxLength(1500)]
		[DataType(DataType.MultilineText)]
		public string Description { get; set; }

		[Display(Name = "Is Completed")]
		public bool IsCompleted { get; set; }

		[Display(Name = "Due Date")]
		public DateTime DueDate { get; set; }

		[ScaffoldColumn(false)]
		public DateTime CreatedDate { get; set; }

		[ScaffoldColumn(false)]
		public DateTime CompletedDate { get; set; }

		public int CategoryId { get; set; }

		public virtual Category Category { get; set; }

		public int RemainingHour
		{
			get
			{
				var remainingTime = (DueDate - DateTime.Now);
				return (int)remainingTime.TotalHours;
			}
		}

	}
}
