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
	[Register("AFPropertyListRequestOperation", true)]
	public unsafe partial class AFPropertyListRequestOperation : AFHTTPRequestOperation {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("AFPropertyListRequestOperation");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AFPropertyListRequestOperation () : base (NSObjectFlag.Empty)
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
		protected AFPropertyListRequestOperation (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AFPropertyListRequestOperation (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual NSPropertyListReadOptions PropertyListReadOptions {
			[Export ("propertyListReadOptions")]
			get {
				NSPropertyListReadOptions ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (NSPropertyListReadOptions) ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("propertyListReadOptions"));
					} else {
						ret = (NSPropertyListReadOptions) ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("propertyListReadOptions"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (NSPropertyListReadOptions) ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("propertyListReadOptions"));
					} else {
						ret = (NSPropertyListReadOptions) ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("propertyListReadOptions"));
					}
				}
				return ret;
			}
			
			[Export ("setPropertyListReadOptions:")]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setPropertyListReadOptions:"), (UInt64)value);
					} else {
						ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setPropertyListReadOptions:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setPropertyListReadOptions:"), (UInt64)value);
					} else {
						ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setPropertyListReadOptions:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_ResponsePropertyList_var;
		[CompilerGenerated]
		public virtual NSObject ResponsePropertyList {
			[Export ("responsePropertyList")]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("responsePropertyList")));
				} else {
					ret = Runtime.GetNSObject (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("responsePropertyList")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ResponsePropertyList_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ResponsePropertyList_var = null;
			}
		}
	} /* class AFPropertyListRequestOperation */
}
