using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
			for(int i= weighLabels.Count()-1; i>=0; i--)
			{
				chainList.Add(weighLabels[i].weight, weighLabels[i].label);
			}
			
			Console.WriteLine($"The chainList length is  {chainList.GetLength()}");
			Console.WriteLine($"Head next =  {chainList.Head.Next.GetElementToString()}");
			Console.WriteLine($"Head next next =  {chainList.Head.Next.Next.GetElementToString()}");
			Console.WriteLine($"Head next next next =  {chainList.Head.Next.Next.Next.GetElementToString()}");
			Console.WriteLine($"Tail =  {chainList.Tail.GetElementToString()}");

			
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
				ElementList currentElement = chainList.Head.Next;
				while(currentElement.IsDifferent(labelSearch) || currentElement.Next ==null  )
				{
					previousElement=currentElement;
					currentElement = currentElement.Next;
					number++;
				}
				if(currentElement!=null)
				{
					Console.WriteLine($"The first label = {labelSearch} is: number {number}:  {start.GetElementToString()} ");
				}
				else
				{
					Console.WriteLine($"List don't contain  label = {labelSearch} ");

				}

			}

		}

		

		private static string SelectArray()
		{
			Console.WriteLine("select an array: \n\t1 for 1K, \n\t2 for 1M , \n\t3 for 50K");
			string userChoice = Console.ReadLine();

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
			throw new NotImplementedException();
		}
	}
}
