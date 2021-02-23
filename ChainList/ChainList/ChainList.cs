using System;
using System.Collections.Generic;
using System.Text;

namespace ChainListProgram
{
	public class ChainList
	{
		public ElementList Head { get; set; }
		public ElementList Tail { get; set; }
		private  int _listLenght { get; set; }

		public Boolean IsEmpty() 
		{ 
			return Head == null; 
		}

		public int GetLength()
		{
			return _listLenght;
		}

		internal void searchNumberWeight()
		{
			Console.WriteLine("Choose surch number:");
			int numberChoose = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Choose weight:");
			string weightSearch = Console.ReadLine();
			int index = 1;
			int number = 0;
			ElementList currentElement = Head;
			ElementList elementFound = currentElement;
			while(index<_listLenght && number<numberChoose)
			{
				if(currentElement.IsEqualWeight(weightSearch) )
				{
					number++;
					elementFound = currentElement;
				}
				currentElement = currentElement.Next;
				index ++;
			}
			if (number == numberChoose)
			{
				Console.WriteLine($"{number} eme weight {weightSearch} found! at index {index} it is : {elementFound.GetElementToString()} ");
			}
			else
			{ 
				Console.WriteLine($"weight {weightSearch} not found");
			}
		}

	

		public String SelectNthElement(int number)
		{
			int currentIndex = 1;
			ElementList currentElement = Head;
			if(number>_listLenght)
			{
				return "number > listLenght!";
			}
			while(currentIndex!=number)
			{
				currentIndex++;
				currentElement = currentElement.Next;
			}
			return currentElement.GetElementToString();
		}

		

		public string SearchLastWeight(string weightSearch)
		{
			int index = 0;
			ElementList flag = null;
			ElementList currentElement = Head;
			while(index<_listLenght)
			{
				if(currentElement.IsEqualWeight(weightSearch))
				{
					flag = currentElement;
				}
				index++;
			}
			if(flag!=null)
			{
				return flag.GetElementToString();
			}
			return "not found!!";
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
				if(currentElement.IsEqualLabel(labelSearch))
				{
					IsFound = true;
					Console.WriteLine($" label {labelSearch} is found: {currentElement.GetElementToString()} \n\t it was the {index} element ");

				}
				currentElement = currentElement.Next;
				index++;
			}
			if(!IsFound)
			{
				Console.WriteLine($"label {labelSearch} not found");
			}

		}

		public List<String> SelectAllByWeight(string weightSearch)
		{
			int index = 0;
			ElementList currentElement = Head;
			List<String> elements = new List<String>();
			while (index < _listLenght)
			{
				if (currentElement.IsEqualWeight(weightSearch))
				{
					elements.Add(currentElement.GetElementToString());
				}
				currentElement = currentElement.Next;
				index++;
			}
				return elements;
		}

		public void AddAtStart(int weight, String label)
		{
				ElementList newElement = new ElementList(weight, label, null);
				newElement.Next = Head;
				Head = newElement;
				_listLenght++;
				if(_listLenght==1)
				{
					Tail = Head;
				}
		}

		public void AddAtEnd(int weight, String label)
		{
			ElementList newElement = new ElementList(weight, label, null);
			if(_listLenght<=1)
			{
				Head = Tail = newElement;
			}
			else
			{
				Tail.Next = newElement;
				Tail = newElement;
			}
			_listLenght++;

		}

		public void AddAtChooseId(int chooseId, int weight, string label)
		{
			int intitalLength = _listLenght;
			if (chooseId == 1)
			{
				AddAtStart(weight, label);
			}
			else if (chooseId == intitalLength+1)
			{
				AddAtEnd(weight, label);
			}
			else
			{
				ElementList currentElement = Head;
				ElementList previous = currentElement;
				int currentIndex = 1;
				while(currentIndex<chooseId)
				{
					previous = currentElement;
					currentElement = currentElement.Next;
					currentIndex++;
				}
				ElementList next = currentElement;
				currentElement = new ElementList(weight, label, next);
				previous.Next = currentElement;
			}
			_listLenght++;


		}

	}
}