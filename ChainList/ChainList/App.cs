using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ChainListProgram
{
	public class App
	{
		public String SelectArray(String  userChoice)
		{
			if (userChoice == "1")
			{
				return @"../../../1K.json";
			}
			else if (userChoice == "2")
			{
				return @"../../../1M.json";
			}
			else if (userChoice == "3")
			{
				return @"../../../50K.json";
			}
			else
			{
				Console.WriteLine("no selected array!");
				return "";
			}
		}


		public ChainList FillUpChainList(string path)
		{
			StreamReader streamReader = new StreamReader(path);
			string json = streamReader.ReadToEnd();

			List<WeightLabel> weighLabels = JsonConvert.DeserializeObject<List<WeightLabel>>(json);

			ChainList chainList = new ChainList();
			for (int i = weighLabels.Count() - 1; i >= 0; i--)
			{
				chainList.Add(weighLabels[i].weight, weighLabels[i].label);
			}
			return chainList;
		}
	}
}