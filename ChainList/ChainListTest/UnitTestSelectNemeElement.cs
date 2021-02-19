using NUnit.Framework;
using ChainListProgram;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System;

namespace ChainListTest
{
	class UnitTestSelectNemeElement
	{
		//récupérer le niéme élément
		[Test]
		public void TestSelectTheNemeElement()
		{
			ChainList chainList = new ChainList();
			chainList.AddAtStart(2, "two");
			chainList.AddAtStart(1, "one");
			chainList.AddAtStart(3, "three"); 
			chainList.AddAtStart(2, "two");
			chainList.AddAtStart(1, "one");
			chainList.AddAtStart(3, "three");

			ElementList element6 = new ElementList(2, "two",null);
			ElementList element5 = new ElementList(1, "one", element6);
			ElementList element4 = new ElementList(3, "three", element5);
			ElementList element3 = new ElementList(2, "two", element4);
			ElementList element2 = new ElementList(1, "one", element3);
			ElementList element1 = new ElementList(3, "three",element2);

			String elementSelected =  chainList.SelectNemeElement(6);
			String expectedElement = element6.GetElementToString();

			Assert.AreEqual(elementSelected, expectedElement);
		}

		[Test]
		public void TestSelectTheNsupListLength()
		{
			ChainList chainList = new ChainList();
			chainList.AddAtStart(2, "two");
			chainList.AddAtStart(1, "one");
			chainList.AddAtStart(3, "three");
			chainList.AddAtStart(2, "two");
			chainList.AddAtStart(1, "one");
			chainList.AddAtStart(3, "three");

			ElementList element6 = new ElementList(2, "two", null);
			ElementList element5 = new ElementList(1, "one", element6);
			ElementList element4 = new ElementList(3, "three", element5);
			ElementList element3 = new ElementList(2, "two", element4);
			ElementList element2 = new ElementList(1, "one", element3);
			ElementList element1 = new ElementList(3, "three", element2);

			String elementSelected = chainList.SelectNemeElement(7);
			String expectedResult = "number > listLenght!";

			Assert.AreEqual(elementSelected, expectedResult);
		}
	}
}

