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
	[Register("AFHTTPRequestOperation", true)]
	public unsafe partial class AFHTTPRequestOperation : AFURLConnectionOperation {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("AFHTTPRequestOperation");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AFHTTPRequestOperation () : base (NSObjectFlag.Empty)
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
		protected AFHTTPRequestOperation (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AFHTTPRequestOperation (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithRequest:")]
		[CompilerGenerated]
		public AFHTTPRequestOperation (NSUrlRequest request)
			: base (NSObjectFlag.Empty)
		{
			if (request == null)
				throw new ArgumentNullException ("request");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithRequest:"), request.Handle), "initWithRequest:");
			} else {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithRequest:"), request.Handle), "initWithRequest:");
			}
		}
		
		[Export ("acceptableContentTypes")]
		[CompilerGenerated]
		public static NSSet AcceptableContentTypes ()
		{
			return  Runtime.GetNSObject<NSSet> (ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("acceptableContentTypes")));
		}
		
		[Export ("acceptableStatusCodes")]
		[CompilerGenerated]
		public static NSIndexSet AcceptableStatusCodes ()
		{
			return  Runtime.GetNSObject<NSIndexSet> (ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("acceptableStatusCodes")));
		}
		
		[Export ("addAcceptableContentTypes:")]
		[CompilerGenerated]
		public static void AddAcceptableContentTypes (NSSet contentTypes)
		{
			if (contentTypes == null)
				throw new ArgumentNullException ("contentTypes");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("addAcceptableContentTypes:"), contentTypes.Handle);
		}
		
		[Export ("addAcceptableStatusCodes:")]
		[CompilerGenerated]
		public static void AddAcceptableStatusCodes (NSIndexSet statusCodes)
		{
			if (statusCodes == null)
				throw new ArgumentNullException ("statusCodes");
			ApiDefinition.Messaging.void_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("addAcceptableStatusCodes:"), statusCodes.Handle);
		}
		
		[Export ("canProcessRequest:")]
		[CompilerGenerated]
		public static bool CanProcessRequest (NSUrlRequest urlRequest)
		{
			if (urlRequest == null)
				throw new ArgumentNullException ("urlRequest");
			return ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("canProcessRequest:"), urlRequest.Handle);
		}
		
		[Export ("setCompletionBlockWithSuccess:failure:")]
		[CompilerGenerated]
		public unsafe virtual void SetCompletionBlockWithSuccess ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAFHttpRequestSuccessCallback))]AFHttpRequestSuccessCallback success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAFHttpRequestFailureCallback))]AFHttpRequestFailureCallback failure)
		{
			if (success == null)
				throw new ArgumentNullException ("success");
			if (failure == null)
				throw new ArgumentNullException ("failure");
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDAFHttpRequestSuccessCallback.Handler, success);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			block_failure = new BlockLiteral ();
			block_ptr_failure = &block_failure;
			block_failure.SetupBlock (Trampolines.SDAFHttpRequestFailureCallback.Handler, failure);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setCompletionBlockWithSuccess:failure:"), (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("setCompletionBlockWithSuccess:failure:"), (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			}
			block_ptr_success->CleanupBlock ();
			block_ptr_failure->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		public virtual global::CoreFoundation.DispatchQueue FailureCallbackQueue {
			[Export ("failureCallbackQueue")]
			get {
				if (IsDirectBinding) {
					return new global::CoreFoundation.DispatchQueue (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("failureCallbackQueue")));
				} else {
					return new global::CoreFoundation.DispatchQueue (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("failureCallbackQueue")));
				}
			}
			
			[Export ("setFailureCallbackQueue:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setFailureCallbackQueue:"), value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setFailureCallbackQueue:"), value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool HasAcceptableContentType {
			[Export ("hasAcceptableContentType")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasAcceptableContentType"));
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hasAcceptableContentType"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool HasAcceptableStatusCode {
			[Export ("hasAcceptableStatusCode")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasAcceptableStatusCode"));
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hasAcceptableStatusCode"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::CoreFoundation.DispatchQueue SuccessCallbackQueue {
			[Export ("successCallbackQueue")]
			get {
				if (IsDirectBinding) {
					return new global::CoreFoundation.DispatchQueue (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("successCallbackQueue")));
				} else {
					return new global::CoreFoundation.DispatchQueue (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("successCallbackQueue")));
				}
			}
			
			[Export ("setSuccessCallbackQueue:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSuccessCallbackQueue:"), value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSuccessCallbackQueue:"), value.Handle);
				}
			}
		}
		
	} /* class AFHTTPRequestOperation */
}
