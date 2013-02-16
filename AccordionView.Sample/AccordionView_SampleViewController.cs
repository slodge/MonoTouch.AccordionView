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
	public partial class AccordionView_SampleViewController : UIViewController
	{
		public AccordionView_SampleViewController () : base ("AccordionView_SampleViewController", null)
		{
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
		}
		
		public override void ViewDidUnload ()
		{
			base.ViewDidUnload ();
			
			// Clear any references to subviews of the main view in order to
			// allow the Garbage Collector to collect them sooner.
			//
			// e.g. myOutlet.Dispose (); myOutlet = null;
			
			ReleaseDesignerOutlets ();
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}

		private void ShowDemo(AccordionView.Mode mode)
		{
			var vc = new DemoAccordionViewController(mode);
			this.NavigationController.PushViewController(vc, true);
		}

		partial void DoMultiOpen (MonoTouch.Foundation.NSObject sender)
		{
			ShowDemo(AccordionView.Mode.MultipleSelection);
		}

		partial void DoSingleOpen (MonoTouch.Foundation.NSObject sender)
		{
			ShowDemo(AccordionView.Mode.SingleSelection);
		}

		partial void DoSingleOpenPlus (MonoTouch.Foundation.NSObject sender)
		{
			ShowDemo(AccordionView.Mode.SingleSelection_OneAlwaysOpen);
		}
	}
}

