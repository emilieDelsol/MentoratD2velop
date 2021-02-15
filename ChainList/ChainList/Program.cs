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
			
			SearchLabel(chainList);
		}


		//rechercher un élément dans le tableau à partir du label: 
		private static void SearchLabel(ChainList chainList)
		{
			Console.WriteLine("Enter Label you search:");
			string labelSearch = Console.ReadLine();
			ElementList start = chainList.Head;
			int number = 0;

			if(start.IsEqual(labelSearch))
			{
				Console.WriteLine($"The first label = {labelSearch} is: number {number}:  {start.GetElementToString()} ");
			}
			else
			{
				ElementList previousElement = chainList.Head;
				ElementList currentElement = chainList.Head.next;
				while(currentElement.IsDifferent(labelSearch) || currentElement.LabelNotNull())
				{
					previousElement=currentElement;
					currentElement = currentElement.next;
					number++;
				}
				if(currentElement!=null)
				{
					Console.WriteLine($"The first label = {labelSearch} is: number {number}:  {start.GetElementToString()} ");
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
