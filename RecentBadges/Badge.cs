using System;
using Newtonsoft.Json;

namespace RecentBadges
{

	public class RootProject
	{
		public Badge[] Badge{ get; set; }
	}

	public class Badge
	{
		//internal readonly string counter;

		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		[JsonProperty(PropertyName = "id")]
		public int Id { get; set; }

		[JsonProperty(PropertyName = "earned_date")]
		public DateTime EarnedDate { get; set; }

		public string ClassTopic { get; set; }
	}

}
