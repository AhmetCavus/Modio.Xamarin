﻿using System;

namespace Modio.Xamarin.UI.Controls
{
	[Flags]
	public enum CalandarChanges
	{
		MaxMin = 1,
		StartDate = 1 << 1,
		StartDay = 1 << 2,
		All = MaxMin | StartDate | StartDay
	}
}