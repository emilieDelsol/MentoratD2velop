﻿using Newtonsoft.Json;
using System;

namespace ChainListProgram
{
	public class ElementList
	{
		private Int32 _weight {get; set; }

		private String _label { get;  set; }
		
		public ElementList Next;

		public ElementList(int weightEntry, String labelEntry, ElementList nextEntry)
		{
			_weight = weightEntry;
			_label = labelEntry;
			Next = nextEntry;
		}

		internal bool IsDifferent(string labelSearch)
		{
			return _label != labelSearch;
		}

		internal bool IsEqual( string labelSearch)
		{
			return _label == labelSearch;
		}

		internal object GetElementToString()
		{
			return $"label: {_label}, weight: {_weight}";
		}

		internal bool LabelNotNull()
		{
			return _label != null;
		}
	}
}