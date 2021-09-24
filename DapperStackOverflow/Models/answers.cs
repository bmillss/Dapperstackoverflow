using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;


namespace DapperStackOverflow.Models
{
	[Table("answers")]
	public class answers
	{
		[Key]
		public int id { get; set; }
		public string Username { get; set; }
		public string Title { get; set; }
		public string Detail { get; set; }
		public DateTime posted { get; set; }
		public string Category { get; set; }
		public string Tags { get; set; }
		public int Status { get; set; }

		public override string ToString()
		{
			return $"<div>{Username} {Detail}</div>";
		}
	}
}
