﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainListProgram
{
	public class WeightLabel
	{
		[JsonProperty("weight")]
		public Int32 weight { get; set; }

		[JsonProperty("label")]
		public String label { get; set; }
	}
}

