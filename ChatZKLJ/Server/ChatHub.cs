using ChatZKLJ.Shared;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatZKLJ.Server
{
	public class ChatHub : Hub
	{
		public void PrimiPoruku(Poruka p)
		{
			Clients.All.SendAsync("PorukaKaKlijentu", p);
		}
	}
}
