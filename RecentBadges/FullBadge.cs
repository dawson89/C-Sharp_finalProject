using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerStats
{

	public class RootObject
	{
		public string Name { get; set; }
		public string Profile_name { get; set; }
		public string Profile_url { get; set; }
		public string Gravatar_url { get; set; }
		public string Gravatar_hash { get; set; }
		public BadgeNew[] BadgeNew { get; set; }
		public Points Points { get; set; }
	}

	public class Points
	{
		public int total { get; set; }
		public int HTML { get; set; }
		public int CSS { get; set; }
		public int Design { get; set; }
		public int JavaScript { get; set; }
		public int Ruby { get; set; }
		public int PHP { get; set; }
		public int WordPress { get; set; }
		public int iOS { get; set; }
		public int Android { get; set; }
		public int DevelopmentTools { get; set; }
		public int Business { get; set; }
		public int Python { get; set; }
		public int Java { get; set; }
		public int DigitalLiteracy { get; set; }
		public int C { get; set; }
		public int Databases { get; set; }
		public int DataAnalysis { get; set; }
		public int APIs { get; set; }
		public int Security { get; set; }
		public int Go { get; set; }
		public int QualityAssurance { get; set; }
		public int MachineLearning { get; set; }
		public int ComputerScience { get; set; }
	}

	public class BadgeNew
	{
		public int id { get; set; }
		public string name { get; set; }
		public string url { get; set; }
		public string icon_url { get; set; }
		public DateTime earned_date { get; set; }
		public Cours[] courses { get; set; }
	}

	public class Cours
	{
		public string title { get; set; }
		public string url { get; set; }
		public int badge_count { get; set; }
	}

}
