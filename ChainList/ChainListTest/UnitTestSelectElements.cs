﻿using NUnit.Framework;
using ChainListProgram;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System;

namespace ChainListTest
{
	class UnitTestSelectElements
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
		//rechercher tous les éléments avec weight égal à une valeur donnée
		[Test]
		public void TestSelectAllByWeightFirstAddElement()
		{
			ChainList chainList = new ChainList();
			chainList.AddAtStart(2, "two");
			chainList.AddAtStart(1, "one");
			chainList.AddAtStart(3, "three");

			List<String> response = chainList.SelectAllByWeight("2");
			List<String> expectedList = new List<String>();
			ElementList firstAddElement = new ElementList(2, "two", null);
			string elementExpected = firstAddElement.GetElementToString();
			expectedList.Add(elementExpected);
			Assert.AreEqual(expectedList, response);


		}

		[Test]
		public void TestSelectAllByWeightMiddleAddElement()
		{
			ChainList chainList = new ChainList();
			chainList.AddAtStart(2, "two");
			chainList.AddAtStart(1, "one");
			chainList.AddAtStart(3, "three");

			List<String> response = chainList.SelectAllByWeight("1");
			List<String> expectedList = new List<String>();
			ElementList firstAddElement = new ElementList(2, "two", null);
			ElementList secondAddElement = new ElementList(1, "one", firstAddElement);
			ElementList thirdAddElement = new ElementList(3, "three", secondAddElement);
			expectedList.Add(secondAddElement.GetElementToString());
			Assert.AreEqual(expectedList, response);


		}


		[Test]
		public void TestSelectAllByWeightLastAddElement()
		{
			ChainList chainList = new ChainList();
			chainList.AddAtStart(2, "two");
			chainList.AddAtStart(1, "one");
			chainList.AddAtStart(3, "three");

			List<String> response = chainList.SelectAllByWeight("3");
			List<String> expectedList = new List<String>();
			ElementList firstAddElement = new ElementList(2, "two", null);
			ElementList secondAddElement = new ElementList(1, "one", firstAddElement);
			ElementList thirdAddElement = new ElementList(3, "three", secondAddElement);
			expectedList.Add(thirdAddElement.GetElementToString());
			Assert.AreEqual(expectedList, response);

		}

		[Test]
		public void TestSelectAllByWeightMultiplesElements()
		{
			ChainList chainList = new ChainList();
			chainList.AddAtStart(1, "one");
			chainList.AddAtStart(2, "two");
			chainList.AddAtStart(1, "one");
			chainList.AddAtStart(1, "one");
			chainList.AddAtStart(1, "one");
			chainList.AddAtStart(3, "three");

			List<String> response = chainList.SelectAllByWeight("1");
			List<String> expectedList = new List<String>();
			ElementList firstAddElement = new ElementList(1, "one", null);
			ElementList secondAddElement = new ElementList(2, "two", firstAddElement);
			ElementList thirdAddElement = new ElementList(1, "one", secondAddElement);
			ElementList fourAddElement = new ElementList(1, "one", thirdAddElement);
			ElementList fiveAddElement = new ElementList(1, "one", fourAddElement);
			ElementList sixAddElement = new ElementList(3, "three", fiveAddElement);

			expectedList.Add(firstAddElement.GetElementToString());
			expectedList.Add(thirdAddElement.GetElementToString());
			expectedList.Add(fourAddElement.GetElementToString());
			expectedList.Add(fiveAddElement.GetElementToString());
			Assert.AreEqual(expectedList, response);

		}
	}
}
