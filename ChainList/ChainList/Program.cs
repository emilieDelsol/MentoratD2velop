using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ChainList
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			string path = SelectArray();

			StreamReader streamReader = new StreamReader(path);
			string json = streamReader.ReadToEnd();

			List<WeightLabel> weighLabels = JsonConvert.DeserializeObject<List<WeightLabel>>(json);
			
			ChainList chainList = new ChainList();
			foreach(WeightLabel element in weighLabels)
			{
				chainList.Add(element.weight, element.label);
			}
			
			Console.WriteLine($"The chainList length is  {chainList.GetLength()}");
			
			searchLabel(chainList);
		}

		private static void searchLabel(ChainList chainList)
		{
			Console.WriteLine("Enter Label you search:");
			string labelSearch = Console.ReadLine();
			ElementList start = chainList.Start;
			int number = 0;
			if(start.label==labelSearch)
			{
				Console.WriteLine($"The first label = {labelSearch} is: number {number}:  {start.weight} {start.label} ");
			}
			else
			{
				ElementList previous = chainList.Start;
				ElementList flag = chainList.Start.next;
				while(flag.label!=labelSearch || flag.label!=null)
				{
					previous=flag;
					flag = flag.next;
					number++;
				}
				if(flag!=null)
				{
					Console.WriteLine($"The first label = {labelSearch} is: number {number}:  {start.weight} {start.label} ");
				}

			}

		}

		private static string SelectArray()
		{
			Console.WriteLine("select an array: \n\t1 for 1K, \n\t2 for 1M , \n\t3 for 50K");
			string userChoice = Console.ReadLine();

			if (userChoice == "1")
			{
				return @"D:\Documents\exercicesMentorat\arraySearch\arraySearch\1K.json";
			}
			else if (userChoice == "2")
			{
				return @"D:\Documents\exercicesMentorat\arraySearch\arraySearch\1M.json";
			}
			else if (userChoice == "3")
			{
				return @"D:\Documents\exercicesMentorat\arraySearch\arraySearch\50K.json";
			}
			throw new NotImplementedException();
		}
	}
}
