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
			Assert.AreEqual(chainList.GetLength(), 1);
		}

		[Test]
		public void TestSelectArray()
		{
			App app = new App();
			String path = app.SelectArray("1");
			Assert.AreEqual(path, @"../../../1K.json");
		}

		[Test]
		public void TestAddAtEnd()
		{
			ChainList chainList = new ChainList();
			chainList.AddAtEnd(10, "nine");
			ElementList expectedElement = new ElementList(10, "nine", null);
			ElementList result = chainList.Tail;
			Assert.AreEqual(result.GetElementToString(), expectedElement.GetElementToString());
		}
		[Test]
		public void TestAddAtEndListLength()
		{
			ChainList chainList = new ChainList();
			chainList.AddAtStart(10,"test");
			chainList.AddAtEnd(10, "nine");
			chainList.AddAtEnd(10, "nine");
			int length = chainList.GetLength();
			Assert.AreEqual(length, 3);
		}
		[Test]
		public void TestAddAtChooseIdWhenIdFirst()
		{
			ChainList chainList = new ChainList();
			chainList.AddAtStart(1, "nine");
			chainList.AddAtStart(2, "nine");
			chainList.AddAtStart(3, "nine");
			chainList.AddAtChooseId(1,4,"add");
			Assert.AreEqual("weight: 4, label: add",chainList.Head.GetElementToString());
		}

		[Test]
		public void TestAddAtChooseIdEndList()
		{
			ChainList chainList = new ChainList();
			chainList.AddAtStart(1, "nine");
			chainList.AddAtStart(2, "nine");
			chainList.AddAtStart(3, "nine");
			chainList.AddAtChooseId(4, 4, "add");
			Assert.AreEqual("weight: 4, label: add", chainList.Tail.GetElementToString());
		}

		[Test]
		public void TestAddAtChooseIdListLength()
		{
			ChainList chainList = new ChainList();
			chainList.AddAtStart(1, "nine");
			chainList.AddAtStart(2, "nine");
			chainList.AddAtStart(3, "nine");
			chainList.AddAtChooseId(2, 4, "add");
			Assert.AreEqual(4, chainList.GetLength());
		}

		[Test]
		public void TestAddAtChooseId()
		{
			ChainList chainList = new ChainList();
			chainList.AddAtStart(1, "nine");
			chainList.AddAtStart(2, "nine");
			chainList.AddAtStart(3, "nine");
			chainList.AddAtChooseId(3, 4, "add");
			Assert.AreEqual("weight: 4, label: add", chainList.Head.Next.Next.GetElementToString());
		}

	

	}
}