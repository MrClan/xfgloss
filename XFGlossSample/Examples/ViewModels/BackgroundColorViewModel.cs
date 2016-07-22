﻿namespace XFGlossSample.Examples.ViewModels
{
	public class BackgroundColorViewModel : IExamplesViewModel
	{
		public string PropertyDefault
		{
			get { return "Color.Default"; }
		}

		public string[] PropertyDescription
		{
			get
			{
				return new string[]
				{
					"Specifies a numeric or named XF.Color value to apply as the element's background color.",
				};
			}
		}

		public string PropertyType
		{
			get { return "Xamarin.Forms.Color"; }
		}

		public string TargetClasses
		{
			get { return "EntryCell, ImageCell, SwitchCell, TextCell, ViewCell"; }
		}
	}
}