using NUnit.Framework;
using ChainListProgram;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System;

namespace ChainListTest
{
	class UnitTestSelectElementWithWeight
	{
		// recherche du dernier élément à partir de l'attribut weight,
		[Test]
		public void TestSelectLastElementNotFound()
		{
			ChainList chainList = new ChainList();
			chainList.AddAtStart(1, "one");
			chainList.AddAtStart(2, "two");
			chainList.AddAtStart(2, "two");
			chainList.AddAtStart(3, "three");
			chainList.AddAtStart(2, "two");

			string response2 = chainList.SearchLastWeight("10");

			Assert.AreEqual(response2, "not found!!");

		}

		[Test]
		public void TestSelectLastElementFound()
		{
			ChainList chainList = new ChainList();
			chainList.AddAtStart(1, "one");
			chainList.AddAtStart(2, "two");
			chainList.AddAtStart(2, "two");
			chainList.AddAtStart(3, "three");
			chainList.AddAtStart(2, "two");

			string response = chainList.SearchLastWeight("2");

			Assert.AreEqual(response, $"weight: {2}, label: {"two"}");

		}
		
		
	}
}
