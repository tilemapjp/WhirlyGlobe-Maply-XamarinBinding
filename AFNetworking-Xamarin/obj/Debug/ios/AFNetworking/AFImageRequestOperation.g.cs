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
	[Register("AFImageRequestOperation", true)]
	public unsafe partial class AFImageRequestOperation : AFHTTPRequestOperation {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("AFImageRequestOperation");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AFImageRequestOperation () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected AFImageRequestOperation (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AFImageRequestOperation (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("imageRequestOperationWithRequest:success:")]
		[CompilerGenerated]
		public unsafe static AFImageRequestOperation ImageRequestOperationWithRequest (NSUrlRequest urlRequest, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAFImageRequestCallback))]AFImageRequestCallback success)
		{
			if (urlRequest == null)
				throw new ArgumentNullException ("urlRequest");
			if (success == null)
				throw new ArgumentNullException ("success");
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDAFImageRequestCallback.Handler, success);
			
			AFImageRequestOperation ret;
			ret =  Runtime.GetNSObject<AFImageRequestOperation> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("imageRequestOperationWithRequest:success:"), urlRequest.Handle, (IntPtr) block_ptr_success));
			block_ptr_success->CleanupBlock ();
			
			return ret;
		}
		
		[Export ("imageRequestOperationWithRequest:imageProcessingBlock:success:failure:")]
		[CompilerGenerated]
		public unsafe static AFImageRequestOperation ImageRequestOperationWithRequest (NSUrlRequest urlRequest, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAFImageRequestImageProcessingCallback))]AFImageRequestImageProcessingCallback imageProcessingBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAFImageRequestDetailedCallback))]AFImageRequestDetailedCallback success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAFImageRequestFailedCallback))]AFImageRequestFailedCallback failed)
		{
			if (urlRequest == null)
				throw new ArgumentNullException ("urlRequest");
			if (imageProcessingBlock == null)
				throw new ArgumentNullException ("imageProcessingBlock");
			if (success == null)
				throw new ArgumentNullException ("success");
			if (failed == null)
				throw new ArgumentNullException ("failed");
			BlockLiteral *block_ptr_imageProcessingBlock;
			BlockLiteral block_imageProcessingBlock;
			block_imageProcessingBlock = new BlockLiteral ();
			block_ptr_imageProcessingBlock = &block_imageProcessingBlock;
			block_imageProcessingBlock.SetupBlock (Trampolines.SDAFImageRequestImageProcessingCallback.Handler, imageProcessingBlock);
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDAFImageRequestDetailedCallback.Handler, success);
			BlockLiteral *block_ptr_failed;
			BlockLiteral block_failed;
			block_failed = new BlockLiteral ();
			block_ptr_failed = &block_failed;
			block_failed.SetupBlock (Trampolines.SDAFImageRequestFailedCallback.Handler, failed);
			
			AFImageRequestOperation ret;
			ret =  Runtime.GetNSObject<AFImageRequestOperation> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("imageRequestOperationWithRequest:imageProcessingBlock:success:failure:"), urlRequest.Handle, (IntPtr) block_ptr_imageProcessingBlock, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failed));
			block_ptr_imageProcessingBlock->CleanupBlock ();
			block_ptr_success->CleanupBlock ();
			block_ptr_failed->CleanupBlock ();
			
			return ret;
		}
		
		[CompilerGenerated]
		object __mt_ResponseImage_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIImage ResponseImage {
			[Export ("responseImage")]
			get {
				global::UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("responseImage")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIImage> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("responseImage")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ResponseImage_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ResponseImage_var = null;
			}
		}
	} /* class AFImageRequestOperation */
}
