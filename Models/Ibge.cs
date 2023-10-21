using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DesafioBalta.Models
{
	public class Ibge
	{
		public int Id { get; set; }
        public required string City { get; set; }
        public required string State { get; set; }		
	}
}