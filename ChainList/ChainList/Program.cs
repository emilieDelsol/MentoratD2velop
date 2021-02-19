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
			string resultSearchLastWeight = chainList.SearchLastWeight(weightSearch);
			Console.WriteLine($"last weight {weightSearch}  element is : {resultSearchLastWeight}");
		}

	}
}
