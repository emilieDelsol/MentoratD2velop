using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ChainListProgram
{
	public class App
	{
		private String _path;
		public String SelectArray(String  userChoice)
		{
			if (userChoice == "1")
			{
				_path = @"../../../1K.json";
			}
			else if (userChoice == "2")
			{
				_path = @"../../../1M.json";
			}
			else if (userChoice == "3")
			{
				_path = @"../../../50K.json";
			}
			else
			{
				Console.WriteLine("no selected array!");
				ChooseArray();
			}
			return _path;
		}

		internal void ChooseArray()
		{
			Console.WriteLine("select an array: \n\t1 for 1K, \n\t2 for 1M , \n\t3 for 50K");
			string userChoice = Console.ReadLine();
			_path=SelectArray(userChoice);
		}

		public ChainList FillUpChainList()
		{
			StreamReader streamReader = new StreamReader(_path);
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