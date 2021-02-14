using System;
using System.Collections.Generic;
using System.Text;

namespace ChainList
{
	class ElementList
	{
		private Int32 _weight;
		private String _label;
		private ElementList _next;
		public ElementList(Int32 weight, String label, ElementList next)
		{
			_weight = weight;
			_label = label;
			_next = next;
		}

		public Int32 Getweight() 
		{ 
			return _weight; 
		}
		public String GetLabel() 
		{ 
			return _label; 
		}
		public void Setweight(Int32 weight)
		{
			_weight = weight;
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
