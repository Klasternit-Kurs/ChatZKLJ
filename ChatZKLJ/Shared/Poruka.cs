using System;
using System.Collections.Generic;
using System.Text;

namespace ChatZKLJ.Shared
{
	public class Poruka
	{
		public string TeloPoruke { get; set; }
		public DateTime Poslata { get; set; } = DateTime.Now;
		public Korisnik Posiljaoc { get; set; }
	}
}
