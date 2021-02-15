using System;
using System.Collections.Generic;
using System.Text;

namespace ChainList
{
	public class ChainList
	{
		public ElementList Head { get; private set; }
		public ElementList Tail
		{
			get
			{
				ElementList latest = Head;
				while (latest.next != null)
				{
					latest = latest.next;
				}
				return latest;
			}
		}
		public Boolean IsEmpty() 
		{ 
			return Head == null; 
		}

		public int GetLength()
		{
			int length = 0;
			ElementList flag = Head;

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
				Head = new ElementList(weight, label, null);
			}
			else
			{
				ElementList latest = Tail;
				latest.next = new ElementList (weight, label, null);
			}
		}


	

	}
}