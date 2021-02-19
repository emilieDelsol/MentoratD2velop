using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ChainListProgram
{
	class Program
	{
		static void Main(string[] args)
		{
			App app = new App();

			app.ChooseArray();
			ChainList chainList = app.FillUpChainList();

			chainList.SearchLabel();

			chainList.searchNumberWeight();

			string weightSearch = app.ChooseWeight();

			Console.WriteLine($"\n***********************************\nI search the last element with this weight: {weightSearch}");

			string resultSearchLastWeight = chainList.SearchLastWeight(weightSearch);
			Console.WriteLine($"last weight {weightSearch}  element is : {resultSearchLastWeight}");

			Console.WriteLine($"\n***********************************\nI search all elements with this weight: {weightSearch}");
			List<String> resultSearchAllWeights = chainList.SelectAllByWeight(weightSearch);
			foreach(String element in resultSearchAllWeights)
			{
				Console.WriteLine(element);
			}

			Console.WriteLine("\n\n***********************************\nSelect number you want to see:");
			int numberChoose = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine($"\nI search all elements with this weight: {numberChoose}");
			String result = chainList.SelectNemeElement(numberChoose);

			Console.WriteLine(result);
		}
	}
}
