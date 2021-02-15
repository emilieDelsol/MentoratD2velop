﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChainList
{
	public class ChainList
	{
		public ElementList Head;
		public ElementList Tail
		{
			get; set;
		}
		private ElementList _first { get; set; }

		public readonly int ListLenght;
		public Boolean IsEmpty() 
		{ 
			return Head == null; 
		}

		public int GetLength()
		{
			int length = 0;
			ElementList currentElement = Head;

			while (currentElement != null)
			{
				length++;
				currentElement = currentElement.Next;
			}

			return length;
		}

		public void Add(int weight, String label)
		{
			if(IsEmpty())
			{
				Tail = new ElementList(weight, label, null);
				Head = Tail;
			}
			else
			{
				InsertHeadElement(Head,weight, label );
			}
		}

		private void InsertHeadElement(ElementList head, int weight, string label)
		{
			ElementList newElement = new ElementList(weight, label, null);
			newElement.Next = head;
			head = newElement;
			Head = head;
		}

		private ElementList GetLatest()
		{
			ElementList latest = Head;
			while (latest.Next != null)
			{
				latest = latest.Next;
			}
			return latest;
		}
	}
}