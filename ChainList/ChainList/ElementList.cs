using Newtonsoft.Json;
using System;

namespace ChainList
{
	public class ElementList
	{
		public Int32 weight {get; private set; }

		public String label { get; private set; }
		
		public ElementList next;

		public ElementList(int weightEntry, String labelEntry, ElementList nextEntry)
		{
			weight = weightEntry;
			label = labelEntry;
			next = nextEntry;
		}

	}
}