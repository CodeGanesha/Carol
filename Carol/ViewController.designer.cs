// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Carol
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextView LyricsTextView { get; set; }

		[Outlet]
		AppKit.NSVisualEffectView MediaPlayer { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (LyricsTextView != null) {
				LyricsTextView.Dispose ();
				LyricsTextView = null;
			}

			if (MediaPlayer != null) {
				MediaPlayer.Dispose ();
				MediaPlayer = null;
			}
		}
	}
}
