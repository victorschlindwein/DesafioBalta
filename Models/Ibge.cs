using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DesafioBalta.Models
{
	public class Ibge
	{
		[Key]
		public int Id { get; set; }
		public string State { get; set; }
		public string City { get; set; }
	}
}