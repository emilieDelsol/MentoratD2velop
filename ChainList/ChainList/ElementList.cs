using System;
using System.Collections.Generic;
using System.Text;

namespace ChainList
{
	class ElementList
	{
		private int _value;
		private String _label;
		private ElementList _next;
		public ElementList(int value, String label, ElementList next)
		{
			_value = value;
			_label = label;
			_next = next;
		}
		public ElementList(int value, String label)
		{
			_value = value;
			_label = label;
			_next = null;
		}

		public int GetValue() 
		{ 
			return _value; 
		}
		public String GetLabel() 
		{ 
			return _label; 
		}
		public void SetValue(int value)
		{
			_value = value;
		}
		public void SetLabel(String label)
		{
			_label = label;
		}

		public ElementList GetNext() 
		{ 
			return _next; 
		}
		public void SetNext(ElementList next)
		{
			_next = next;
		}
	}
}
