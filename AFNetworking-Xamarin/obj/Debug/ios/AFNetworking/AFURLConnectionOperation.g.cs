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
	[Register("AFURLConnectionOperation", true)]
	public unsafe partial class AFURLConnectionOperation : NSOperation {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("AFURLConnectionOperation");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AFURLConnectionOperation () : base (NSObjectFlag.Empty)
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
		protected AFURLConnectionOperation (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AFURLConnectionOperation (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithRequest:")]
		[CompilerGenerated]
		public AFURLConnectionOperation (NSUrlRequest urlRequest)
			: base (NSObjectFlag.Empty)
		{
			if (urlRequest == null)
				throw new ArgumentNullException ("urlRequest");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithRequest:"), urlRequest.Handle), "initWithRequest:");
			} else {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithRequest:"), urlRequest.Handle), "initWithRequest:");
			}
		}
		
		[Export ("isPaused")]
		[CompilerGenerated]
		public virtual bool IsPaused ()
		{
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isPaused"));
			} else {
				return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isPaused"));
			}
		}
		
		[Export ("pause")]
		[CompilerGenerated]
		public virtual void Pause ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("pause"));
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("pause"));
			}
		}
		
		[Export ("resume")]
		[CompilerGenerated]
		public virtual void Resume ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("resume"));
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("resume"));
			}
		}
		
		[Export ("setCompletionBlock:")]
		[CompilerGenerated]
		public unsafe virtual void SetCompletionBlock ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action block)
		{
			if (block == null)
				throw new ArgumentNullException ("block");
			BlockLiteral *block_ptr_block;
			BlockLiteral block_block;
			block_block = new BlockLiteral ();
			block_ptr_block = &block_block;
			block_block.SetupBlock (Trampolines.SDAction.Handler, block);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCompletionBlock:"), (IntPtr) block_ptr_block);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCompletionBlock:"), (IntPtr) block_ptr_block);
			}
			block_ptr_block->CleanupBlock ();
			
		}
		
		[CompilerGenerated]
		object __mt_Credential_var;
		[CompilerGenerated]
		public virtual NSUrlCredential Credential {
			[Export ("credential")]
			get {
				NSUrlCredential ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrlCredential> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("credential")));
				} else {
					ret =  Runtime.GetNSObject<NSUrlCredential> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("credential")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Credential_var = ret;
				return ret;
			}
			
			[Export ("setCredential:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCredential:"), value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCredential:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Credential_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Error_var;
		[CompilerGenerated]
		public virtual NSError Error {
			[Export ("error")]
			get {
				NSError ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSError> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("error")));
				} else {
					ret =  Runtime.GetNSObject<NSError> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("error")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Error_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_InputStream_var;
		[CompilerGenerated]
		public virtual NSInputStream InputStream {
			[Export ("inputStream")]
			get {
				NSInputStream ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSInputStream> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("inputStream")));
				} else {
					ret =  Runtime.GetNSObject<NSInputStream> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("inputStream")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_InputStream_var = ret;
				return ret;
			}
			
			[Export ("setInputStream:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setInputStream:"), value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setInputStream:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_InputStream_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_OutputStream_var;
		[CompilerGenerated]
		public virtual NSOutputStream OutputStream {
			[Export ("outputStream")]
			get {
				NSOutputStream ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSOutputStream> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("outputStream")));
				} else {
					ret =  Runtime.GetNSObject<NSOutputStream> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("outputStream")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_OutputStream_var = ret;
				return ret;
			}
			
			[Export ("setOutputStream:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setOutputStream:"), value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setOutputStream:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_OutputStream_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Request_var;
		[CompilerGenerated]
		public virtual NSUrlRequest Request {
			[Export ("request")]
			get {
				NSUrlRequest ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrlRequest> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("request")));
				} else {
					ret =  Runtime.GetNSObject<NSUrlRequest> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("request")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Request_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_Response_var;
		[CompilerGenerated]
		public virtual NSUrlResponse Response {
			[Export ("response")]
			get {
				NSUrlResponse ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrlResponse> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("response")));
				} else {
					ret =  Runtime.GetNSObject<NSUrlResponse> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("response")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Response_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ResponseData_var;
		[CompilerGenerated]
		public virtual NSData ResponseData {
			[Export ("responseData")]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("responseData")));
				} else {
					ret =  Runtime.GetNSObject<NSData> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("responseData")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ResponseData_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string ResponseString {
			[Export ("responseString")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("responseString")));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("responseString")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual NSStringEncoding ResponseStringEncoding {
			[Export ("responseStringEncoding")]
			get {
				NSStringEncoding ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (NSStringEncoding) ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("responseStringEncoding"));
					} else {
						ret = (NSStringEncoding) ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("responseStringEncoding"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (NSStringEncoding) ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("responseStringEncoding"));
					} else {
						ret = (NSStringEncoding) ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("responseStringEncoding"));
					}
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_RunLoopModes_var;
		[CompilerGenerated]
		public virtual NSSet RunLoopModes {
			[Export ("runLoopModes")]
			get {
				NSSet ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSSet> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("runLoopModes")));
				} else {
					ret =  Runtime.GetNSObject<NSSet> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("runLoopModes")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_RunLoopModes_var = ret;
				return ret;
			}
			
			[Export ("setRunLoopModes:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRunLoopModes:"), value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRunLoopModes:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_RunLoopModes_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool ShouldUseCredentialStorage {
			[Export ("shouldUseCredentialStorage")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("shouldUseCredentialStorage"));
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("shouldUseCredentialStorage"));
				}
			}
			
			[Export ("setShouldUseCredentialStorage:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setShouldUseCredentialStorage:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setShouldUseCredentialStorage:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_UserInfo_var;
		[CompilerGenerated]
		public virtual NSDictionary UserInfo {
			[Export ("userInfo")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userInfo")));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userInfo")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_UserInfo_var = ret;
				return ret;
			}
			
			[Export ("setUserInfo:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUserInfo:"), value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUserInfo:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_UserInfo_var = value;
			}
		}
		
		[CompilerGenerated]
		static NSString _AFNetworkingErrorDomain;
		[Field ("AFNetworkingErrorDomain",  "__Internal")]
		public static unsafe NSString AFNetworkingErrorDomain {
			get {
				if (_AFNetworkingErrorDomain == null)
					_AFNetworkingErrorDomain = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "AFNetworkingErrorDomain");
				return _AFNetworkingErrorDomain;
			}
		}
		[CompilerGenerated]
		static NSString _AFNetworkingOperationDidFinishNotification;
		[Field ("AFNetworkingOperationDidFinishNotification",  "__Internal")]
		public static unsafe NSString AFNetworkingOperationDidFinishNotification {
			get {
				if (_AFNetworkingOperationDidFinishNotification == null)
					_AFNetworkingOperationDidFinishNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "AFNetworkingOperationDidFinishNotification");
				return _AFNetworkingOperationDidFinishNotification;
			}
		}
		[CompilerGenerated]
		static NSString _AFNetworkingOperationDidStartNotification;
		[Field ("AFNetworkingOperationDidStartNotification",  "__Internal")]
		public static unsafe NSString AFNetworkingOperationDidStartNotification {
			get {
				if (_AFNetworkingOperationDidStartNotification == null)
					_AFNetworkingOperationDidStartNotification = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "AFNetworkingOperationDidStartNotification");
				return _AFNetworkingOperationDidStartNotification;
			}
		}
		[CompilerGenerated]
		static NSString _AFNetworkingOperationFailingURLRequestErrorKey;
		[Field ("AFNetworkingOperationFailingURLRequestErrorKey",  "__Internal")]
		public static unsafe NSString AFNetworkingOperationFailingURLRequestErrorKey {
			get {
				if (_AFNetworkingOperationFailingURLRequestErrorKey == null)
					_AFNetworkingOperationFailingURLRequestErrorKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "AFNetworkingOperationFailingURLRequestErrorKey");
				return _AFNetworkingOperationFailingURLRequestErrorKey;
			}
		}
		[CompilerGenerated]
		static NSString _AFNetworkingOperationFailingURLResponseErrorKey;
		[Field ("AFNetworkingOperationFailingURLResponseErrorKey",  "__Internal")]
		public static unsafe NSString AFNetworkingOperationFailingURLResponseErrorKey {
			get {
				if (_AFNetworkingOperationFailingURLResponseErrorKey == null)
					_AFNetworkingOperationFailingURLResponseErrorKey = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "AFNetworkingOperationFailingURLResponseErrorKey");
				return _AFNetworkingOperationFailingURLResponseErrorKey;
			}
		}
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Credential_var = null;
				__mt_Error_var = null;
				__mt_InputStream_var = null;
				__mt_OutputStream_var = null;
				__mt_Request_var = null;
				__mt_Response_var = null;
				__mt_ResponseData_var = null;
				__mt_RunLoopModes_var = null;
				__mt_UserInfo_var = null;
			}
		}
		
		
		//
		// Notifications
		//
		public static partial class Notifications {
		
			public static NSObject ObserveAFNetworkingOperationDidFinish (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AFNetworkingOperationDidFinishNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
			public static NSObject ObserveAFNetworkingOperationDidStart (EventHandler<NSNotificationEventArgs> handler)
			{
				return NSNotificationCenter.DefaultCenter.AddObserver (AFNetworkingOperationDidStartNotification, notification => handler (null, new NSNotificationEventArgs (notification)));
			}
		
		}
	} /* class AFURLConnectionOperation */
}
