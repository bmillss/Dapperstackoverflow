using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;


namespace DapperStackOverflow.Models
{
	[Table("questions")]
	public class questions
	{
		[Key]
		public int ID { get; set; }
		public string Username { get; set; }
		public string Title { get; set; }
		public string Detail { get; set; }
		public DateTime Posted { get; set; }
		public string Category { get; set; }
		public string Tags { get; set; }
		public int status { get; set; }
		public int QuestionsID { get; set; }
		public override string ToString()
		{
			return $"<div>{Username} {Detail}</div>";
		}
	}

}
