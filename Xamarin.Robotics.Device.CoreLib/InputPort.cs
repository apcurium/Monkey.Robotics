﻿using System;

namespace Xamarin.Robotics
{
	public class InputPort : Port
		//where TUnits : UnitsT//, new()
	{
//		readonly TUnits units;

		public InputPort (BlockBase block, string name, Units units, double initialValue = 0)
			: base (block, name, units, initialValue)
		{
//			units = new TUnits ();
		}
	}
}

