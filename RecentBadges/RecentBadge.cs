using System.Collections.Generic;

namespace RecentBadges
{
	public class RecentBadge : IComparer<Badge>
	{
		public int Compare(Badge x, Badge y)
		{
			return x.EarnedDate.CompareTo(y.EarnedDate) * -1;
		} 

	}
}
