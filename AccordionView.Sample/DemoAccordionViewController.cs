// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// This file is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Huge thanks to http://CloudZync.com for open sourcing this UIView
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
	public class DemoAccordionViewController : UIViewController
	{
		private AccordionView.Mode _mode;
		private AccordionView _accordionView;

		public DemoAccordionViewController (AccordionView.Mode mode)
		{
			_mode = mode;	
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad();

			_accordionView = new AccordionView (View.Frame)
			{
				DisplayMode = _mode // AccordionView.Mode.SingleSelection_OneAlwaysOpen,
			};
			
			Add (_accordionView);

			var colors = new [] {
				"Red", "Green", "Blue", "Cyan", "Magenta", "Orange", "Purple", "Black", "Brown", "Yellow"
			}; 

			foreach (var c in colors)
			{
				_accordionView.Add(c, CreateItemView(c.ToColor()));
			}

			if (_accordionView.DisplayMode != AccordionView.Mode.MultipleSelection)
			{
				_accordionView.SelectionIndicies = new List<int>() { 1 }; 
			}
			else
			{				
				_accordionView.SelectionIndicies = new List<int>() { 0,2,4 }; 
			}
		}

		UIView CreateItemView (UIColor color)
		{
			var v = new UIView(new RectangleF(0,0,320,120));
			v.BackgroundColor = color;
			return v;
		}

		public override void ViewWillLayoutSubviews ()
		{
			base.ViewWillLayoutSubviews ();

			_accordionView.Frame = View.Frame;
		}
	}
	
}
