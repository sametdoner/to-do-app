using System;
using System.Collections.Generic;

namespace ToDoApp.Models
{
	public class SearchViewModel
	{
		public string SearchText { get; set; }

		public bool ShowAll { get; set; }

		public List<TodoItem> Result { get; set; }

		public bool SearchDesc { get; set; }

		public List<Category> CategoryResult { get; set; }
	}
}
