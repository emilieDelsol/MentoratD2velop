using System;
using System.Collections.Generic;
using System.Text;

namespace ChainListProgram
{
	public class ChainList
	{
		public ElementList Head;
		public ElementList Tail
		{
			get; set;
		}
		private ElementList _first { get; set; }

		public  int ListLenght;
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
				ListLenght++;
			}
			else
			{
				InsertHeadElement(Head,weight, label );
				ListLenght++;
			}
		}

		private void InsertHeadElement(ElementList head, int weight, string label)
		{
			ElementList newElement = new ElementList(weight, label, null);
			newElement.Next = head;
			head = newElement;
			Head = head;
		}

		internal void SearchLabel(List<WeightLabel> weighLabels)
		{
			throw new NotImplementedException();
		}

	}
}