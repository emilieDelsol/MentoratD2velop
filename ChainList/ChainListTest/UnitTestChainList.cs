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
			chainList.Add(10, "nine");
			Assert.IsFalse(chainList.IsEmpty());
		}

		[Test]
		public void TestSelectArray()
		{
			App app = new App();
			String path = app.SelectArray("1");
			Assert.AreEqual(path, @"../../../1K.json");
		}

		
	}
}