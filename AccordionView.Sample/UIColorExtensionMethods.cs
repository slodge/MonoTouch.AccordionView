// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// This file is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Thanks to http://CloudZync.com for open sourcing this UIView
//
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Cirrious.Touch.Controls;
using System.Collections.Generic;

namespace Sample
{
	public static class UIColorExtensionMethods
	{
		public static UIColor ToColor (this string color)
		{
			var type = typeof(UIColor);
			var colorProp = type.GetProperty(color);
			var uiColor = (UIColor)colorProp.GetGetMethod().Invoke(null, new object[0]);
			return uiColor;
		}
	}
	
}
