//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using MapKit;
using Security;
using SceneKit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using NewsstandKit;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;

namespace AFNetworking {
	public unsafe static partial class AFNetworkingImageExtras  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("global::UIKit.UIImageView");
		
		[Export ("setImageWithURL:")]
		[CompilerGenerated]
		public static void SetImageUrl (this global::UIKit.UIImageView This, NSUrl url)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setImageWithURL:"), url.Handle);
		}
		
		[Export ("setImageWithURL:placeholderImage:")]
		[CompilerGenerated]
		public static void SetImageUrl (this global::UIKit.UIImageView This, NSUrl url, global::UIKit.UIImage placeholderImage)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (placeholderImage == null)
				throw new ArgumentNullException ("placeholderImage");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("setImageWithURL:placeholderImage:"), url.Handle, placeholderImage.Handle);
		}
		
	} /* class AFNetworkingImageExtras */
}
