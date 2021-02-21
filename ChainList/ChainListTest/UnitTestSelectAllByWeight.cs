using ChainListProgram;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainListTest
{
	class UnitTestSelectAllByWeight
	{
		//rechercher tous les éléments avec weight égal à une valeur donnée
		[Test]
		public void TestSelectAllByWeightEnterLastElement()
		{
			ChainList chainList = CreateChainListTest();
			
			List<String> response = chainList.SelectAllByWeight("2");

			ElementList lastElement = GetElement(chainList, chainList.GetLength()); 
			List<String> expectedList = new List<String>();
			string elementExpected = lastElement.GetElementToString();
			expectedList.Add(elementExpected);
			Assert.AreEqual(expectedList, response);

		}

		

		[Test]
		public void TestSelectAllByWeightMiddleAddElement()
		{
			ChainList chainList = CreateChainListTest();

			List<String> response = chainList.SelectAllByWeight("1");
			List<String> expectedList = new List<String>();
			ElementList secondAddElement = GetElement(chainList,2);
			expectedList.Add(secondAddElement.GetElementToString());
			Assert.AreEqual(expectedList, response);


		}


		[Test]
		public void TestSelectAllByWeightFirstElement()
		{
			ChainList chainList = CreateChainListTest();

			List<String> response = chainList.SelectAllByWeight("3");
			List<String> expectedList = new List<String>();
			ElementList firstElement = GetElement(chainList, 1);
			
			expectedList.Add(firstElement.GetElementToString());
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

		private ChainList CreateChainListTest()
		{
			ChainList chainList = new ChainList();
			chainList.AddAtStart(2, "two");
			chainList.AddAtStart(1, "one");
			chainList.AddAtStart(3, "three");
			return chainList;
		}

		private ElementList GetElement(ChainList chainList, int indexSearch)
		{
			ElementList currentElement = chainList.Head;
			for (int i = 1; i <= chainList.GetLength(); i++)
			{

				if (i == indexSearch)
				{
					return currentElement;
				}
				currentElement = currentElement.Next;
			}
			return null;
		}
	}
}
