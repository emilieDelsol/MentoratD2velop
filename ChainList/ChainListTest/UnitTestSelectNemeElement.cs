using NUnit.Framework;
using ChainListProgram;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System;

namespace ChainListTest
{
	class UnitTestSelectNthElement
	{
		
		//récupérer le niéme élément
		[Test]
		public void TestSelectTheNthElement()
		{
			ChainList chainList = CreateChainList();
			String expectedElement = GetLastElement();

			String elementSelected =  chainList.SelectNthElement(chainList.GetLength());

			Assert.AreEqual(elementSelected, expectedElement);
		}


		[Test]
		public void TestSelectTheNthNsupListLength()
		{
			ChainList chainList = CreateChainList();
			String elementSelected = chainList.SelectNthElement(chainList.GetLength()+1);
			String expectedResult = "number > listLenght!";

			Assert.AreEqual(elementSelected, expectedResult);
		}

		private ChainList CreateChainList()
		{
			ChainList chainList = new ChainList();
			chainList.AddAtStart(2, "two");
			chainList.AddAtStart(1, "one");
			chainList.AddAtStart(3, "three");
			chainList.AddAtStart(2, "two");
			chainList.AddAtStart(1, "one");
			chainList.AddAtStart(3, "three");
			return chainList;
		}
		private string GetLastElement()
		{
			ElementList element6 = new ElementList(2, "two", null);
			ElementList element5 = new ElementList(1, "one", element6);
			ElementList element4 = new ElementList(3, "three", element5);
			ElementList element3 = new ElementList(2, "two", element4);
			ElementList element2 = new ElementList(1, "one", element3);
			ElementList element1 = new ElementList(3, "three", element2);
			String expectedElement = element6.GetElementToString();
			return expectedElement;
		}
	}
}

