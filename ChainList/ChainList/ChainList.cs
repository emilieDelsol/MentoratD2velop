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

		private  int _listLenght;
		public Boolean IsEmpty() 
		{ 
			return Head == null; 
		}

		public int GetLength()
		{
			return _listLenght;
		}

		public void Add(int weight, String label)
		{
			if(IsEmpty())
			{
				Tail = new ElementList(weight, label, null);
				Head = Tail;
				_listLenght++;
			}
			else
			{
				InsertHeadElement(Head,weight, label );
				_listLenght++;
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