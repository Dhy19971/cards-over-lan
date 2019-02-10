﻿using Newtonsoft.Json;
using System.Linq;

namespace LahServer.Game.Trophies
{
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public sealed class LostToBotTrophyRequirement : TrophyRequirement
	{
		public override bool CheckPlayer(LahPlayer player)
		{
			var winners = player.Game.GetWinningPlayers().ToArray();
			return !winners.Contains(player) && winners.Any(w => w.IsAutonomous);
		}
	}
}
