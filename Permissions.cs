﻿using System.IO;
using TShockAPI;

namespace CommandTimelines
{
	public static class Permissions
	{
		public static string Use => "timeline.use";

		public static string Show => "timeline.show";

		public static string Admin => "timeline.admin.useall";

		public static bool CanUseTimeline(this TSPlayer player, string path)
		{
			return player.HasPermission(Admin)
				|| player.HasPermission($"{Use}-{Path.GetFileNameWithoutExtension(path)}")
				|| player.HasPermission($"{Use}-{Path.GetDirectoryName(path)}")
				|| player.HasPermission($"{Use}-{Path.GetDirectoryName(path).Replace("\\", "/")}");
		}
	}
}
