using NUnit.Framework;
using ChainListProgram;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System;

namespace ChainListTest
{
	public class Tests
	{

		[Test]
		public void TestChainListEmpty()
		{
			ChainList chainList = new ChainList();
			Assert.IsTrue(chainList.IsEmpty());
		}

		[Test]
		public void TestChainListNotEmpty()
		{
			ChainList chainList = new ChainList();
			chainList.AddAtStart(10, "nine");
			Assert.AreEqual(chainList.GetLength(),1);
		}

		[Test]
		public void TestSelectArray()
		{
			App app = new App();
			String path = app.SelectArray("1");
			Assert.AreEqual(path, @"../../../1K.json");
		}

		// recherche du dernier élément à partir de l'attribut weight,
		[Test]
		public void TestSelectLastElement()
		{
			ChainList chainList = new ChainList();
			chainList.AddAtStart(1, "one");
			chainList.AddAtStart(2, "two");
			chainList.AddAtStart(2, "two");
			chainList.AddAtStart(3, "three");
			chainList.AddAtStart(2, "two");

			string response = chainList.SearchLastWeight("2");
			string response2 = chainList.SearchLastWeight("10");
			
			Assert.AreEqual(response, $"weight: {2}, label: {"two"}");
			Assert.AreEqual(response2, "not found!!");

		}
	}
}