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

		private  int _listLenght;

		public Boolean IsEmpty() 
		{ 
			return Head == null; 
		}

		public int GetLength()
		{
			return _listLenght;
		}

		internal void SearchLabel()
		{
			Console.WriteLine("Enter Label you search:");
			string labelSearch = Console.ReadLine();
			int index = 1;
			bool IsFound = false;
			ElementList currentElement = Head;
			
			while(!IsFound && index<=_listLenght)
			{
				if(currentElement.IsEqual(labelSearch))
				{
					IsFound = true;
					Console.WriteLine($" label {labelSearch} is found: {currentElement.GetElementToString()} \n\t it was the {index} element ");

				}
				currentElement = Head;
				Head = Head.Next;
				index++;
			}
			if(index>_listLenght)
			{
				Console.WriteLine($"label {labelSearch} not found");
			}

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
				InsertHeadElement(weight, label );
				_listLenght++;
			}
		}

		private void InsertHeadElement(int weight, string label)
		{
			ElementList newElement = new ElementList(weight, label, null);
			newElement.Next = Head;
			Head = newElement;
		}

		

	}
}