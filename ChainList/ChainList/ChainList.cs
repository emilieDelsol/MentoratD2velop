using System;
using System.Collections.Generic;
using System.Text;

namespace ChainList
{
	class ChainList
	{
		private ElementList _start;

		public Boolean IsEmpty() 
		{ 
			return _start == null; 
		}
		public ElementList GetStart() 
		{ 
			return _start; 
		}
		public void AddStart(int value, String label) 
		{ 
			ElementList oldFirst = _start; 
			_start = new ElementList(value,label, oldFirst); 
		}
		
		public int GetLength()
		{
			int length = 0;
			ElementList flag = GetStart();
			while (flag != null)
			{
				length++;
				flag = flag.GetNext();
			}
			return length;
		}
		public Boolean Contain(int value)
		{
			Boolean isFound = false;
			ElementList flag = GetStart();
			while(! isFound && flag!=null)
			{
				if(flag.GetValue()==value)
				{
					isFound = true;
				}
				else
				{
					flag = flag.GetNext();
				}
			}
			return isFound;
		}

		public void AddEnd(int value, String label)
		{
			if(IsEmpty())
			{
				_start = new ElementList(value, label);
			}
			else
			{
				ElementList latest = GetLatestElement();
				latest.SetNext(new ElementList (value, label));
			}
		}

		private ElementList GetLatestElement()
		{
			ElementList latest = _start;
			while (latest.GetNext() != null)
			{
				latest = latest.GetNext();
			}
			return latest;
		}


		public void DeleteFirstOccurence(int value)
		{
			if(IsEmpty())
			{
				return;
			}
			if(_start.GetValue()==value)
			{
				_start = _start.GetNext();
			}
			else
			{
				ElementList previous = _start;
				ElementList flag = _start.GetNext();
				while (flag != null)
				{
					previous = flag;
					flag = flag.GetNext();
				}
				if(flag!=null)
				{
					previous.SetNext(flag.GetNext());
				}
			}
		}
	}
}