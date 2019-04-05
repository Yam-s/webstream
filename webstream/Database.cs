using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace webstream
{
	public static class Database
	{
		public static List<WebServer> Servers { get; private set; } = new List<WebServer>();
		public static List<FileTask> Tasks { get; private set; } = new List<FileTask>();

		static Database()
		{

		}
		public static bool Load(string jsonDir)
		{
			if (!File.Exists(jsonDir))
				return false;

			var json = File.ReadAllText(jsonDir);
			var data = JsonConvert.DeserializeObject<Data>(json);

			if (data == null)
				return false;

			Servers = data.Servers;
			Tasks = data.Tasks;
			return true;
		}

		public static void UpdateDB()
		{
			var jsonDir = System.IO.Directory.GetCurrentDirectory() + "db.json";
			File.WriteAllText(jsonDir, JsonConvert.SerializeObject(new Data(Servers, Tasks), Formatting.Indented));
		}
	}

	[Serializable]
	public class Data
	{
		public List<WebServer> Servers { get; set; }
		public List<FileTask> Tasks { get; set; }
		public Data(List<WebServer> servers, List<FileTask> tasks)
		{
			Servers = servers;
			Tasks = tasks;
		}
	}
}
