using System;
using System.Collections.Generic;
using System.Text;

namespace ChainList
{
	public class ChainList
	{
		public ElementList Start { get; set; }

		public Boolean IsEmpty() 
		{ 
			return Start == null; 
		}

		public int GetLength()
		{
			int length = 0;
			ElementList flag = Start;

			while (flag != null)
			{
				length++;
				flag = flag.next;
			}

			return length;
		}

		public void Add(int weight, String label)
		{
			if(IsEmpty())
			{
				Start = new ElementList(weight, label, null);
			}
			else
			{
				ElementList latest = GetLatestElement();
				latest.next = new ElementList (weight, label, null);
			}
		}

		public  ElementList GetLatestElement()
		{
			ElementList latest = Start;
			while (latest.next != null)
			{
				latest = latest.next;
			}
			return latest;
		}

	

	}
}