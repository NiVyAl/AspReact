using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace exampleAspReact.Models
{
	public class User
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int UserId { get; set; }
		public string name { get; set; }
		public string surname { get; set; }
		public int years { get; set; }
		public bool isSubscribe { get; set; }
	}
}
