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
	[Register("AFHTTPClient", true)]
	public unsafe partial class AFHTTPClient : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("AFHTTPClient");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AFHTTPClient () : base (NSObjectFlag.Empty)
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
		protected AFHTTPClient (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AFHTTPClient (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithBaseURL:")]
		[CompilerGenerated]
		public AFHTTPClient (NSUrl url)
			: base (NSObjectFlag.Empty)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithBaseURL:"), url.Handle), "initWithBaseURL:");
			} else {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithBaseURL:"), url.Handle), "initWithBaseURL:");
			}
		}
		
		[Export ("cancelAllHTTPOperationsWithMethod:path:")]
		[CompilerGenerated]
		public virtual void CancelAllHTTPOperationsWithMethod (string method, string path)
		{
			if (method == null)
				throw new ArgumentNullException ("method");
			if (path == null)
				throw new ArgumentNullException ("path");
			var nsmethod = NSString.CreateNative (method);
			var nspath = NSString.CreateNative (path);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("cancelAllHTTPOperationsWithMethod:path:"), nsmethod, nspath);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("cancelAllHTTPOperationsWithMethod:path:"), nsmethod, nspath);
			}
			NSString.ReleaseNative (nsmethod);
			NSString.ReleaseNative (nspath);
			
		}
		
		[Export ("clearAuthorizationHeader")]
		[CompilerGenerated]
		public virtual void ClearAuthorizationHeader ()
		{
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("clearAuthorizationHeader"));
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("clearAuthorizationHeader"));
			}
		}
		
		[Export ("clientWithBaseURL:")]
		[CompilerGenerated]
		public static AFHTTPClient ClientWithBaseURL (NSUrl url)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			return  Runtime.GetNSObject<AFHTTPClient> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, Selector.GetHandle ("clientWithBaseURL:"), url.Handle));
		}
		
		[Export ("defaultValueForHeader:")]
		[CompilerGenerated]
		public virtual string DefaultValueForHeader (string header)
		{
			if (header == null)
				throw new ArgumentNullException ("header");
			var nsheader = NSString.CreateNative (header);
			
			string ret;
			if (IsDirectBinding) {
				ret = NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("defaultValueForHeader:"), nsheader));
			} else {
				ret = NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("defaultValueForHeader:"), nsheader));
			}
			NSString.ReleaseNative (nsheader);
			
			return ret;
		}
		
		[Export ("deletePath:parameters:success:failure:")]
		[CompilerGenerated]
		public unsafe virtual void DeletePath (string path, NSDictionary parameters, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<AFHTTPRequestOperation, NSObject> success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V1))]global::System.Action<AFHTTPRequestOperation, NSError> failure)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			if (parameters == null)
				throw new ArgumentNullException ("parameters");
			if (success == null)
				throw new ArgumentNullException ("success");
			var nspath = NSString.CreateNative (path);
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDActionArity2V0.Handler, success);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			if (failure == null){
				block_ptr_failure = null;
			} else {
				block_failure = new BlockLiteral ();
				block_ptr_failure = &block_failure;
				block_failure.SetupBlock (Trampolines.SDActionArity2V1.Handler, failure);
			}
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("deletePath:parameters:success:failure:"), nspath, parameters.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("deletePath:parameters:success:failure:"), nspath, parameters.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			}
			NSString.ReleaseNative (nspath);
			block_ptr_success->CleanupBlock ();
			if (block_ptr_failure != null)
				block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("enqueueHTTPRequestOperation:")]
		[CompilerGenerated]
		public virtual void EnqueueHTTPRequestOperation (AFHTTPRequestOperation operation)
		{
			if (operation == null)
				throw new ArgumentNullException ("operation");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("enqueueHTTPRequestOperation:"), operation.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("enqueueHTTPRequestOperation:"), operation.Handle);
			}
		}
		
		[Export ("getPath:parameters:success:failure:")]
		[CompilerGenerated]
		public unsafe virtual void GetPath (string path, NSDictionary parameters, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<AFHTTPRequestOperation, NSObject> success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V1))]global::System.Action<AFHTTPRequestOperation, NSError> failure)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			if (success == null)
				throw new ArgumentNullException ("success");
			var nspath = NSString.CreateNative (path);
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDActionArity2V0.Handler, success);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			if (failure == null){
				block_ptr_failure = null;
			} else {
				block_failure = new BlockLiteral ();
				block_ptr_failure = &block_failure;
				block_failure.SetupBlock (Trampolines.SDActionArity2V1.Handler, failure);
			}
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("getPath:parameters:success:failure:"), nspath, parameters == null ? IntPtr.Zero : parameters.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("getPath:parameters:success:failure:"), nspath, parameters == null ? IntPtr.Zero : parameters.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			}
			NSString.ReleaseNative (nspath);
			block_ptr_success->CleanupBlock ();
			if (block_ptr_failure != null)
				block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("patchPath:parameters:success:failure:")]
		[CompilerGenerated]
		public unsafe virtual void PatchPath (string path, NSDictionary parameters, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<AFHTTPRequestOperation, NSObject> success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V1))]global::System.Action<AFHTTPRequestOperation, NSError> failure)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			if (parameters == null)
				throw new ArgumentNullException ("parameters");
			if (success == null)
				throw new ArgumentNullException ("success");
			var nspath = NSString.CreateNative (path);
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDActionArity2V0.Handler, success);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			if (failure == null){
				block_ptr_failure = null;
			} else {
				block_failure = new BlockLiteral ();
				block_ptr_failure = &block_failure;
				block_failure.SetupBlock (Trampolines.SDActionArity2V1.Handler, failure);
			}
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("patchPath:parameters:success:failure:"), nspath, parameters.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("patchPath:parameters:success:failure:"), nspath, parameters.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			}
			NSString.ReleaseNative (nspath);
			block_ptr_success->CleanupBlock ();
			if (block_ptr_failure != null)
				block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("postPath:parameters:success:failure:")]
		[CompilerGenerated]
		public unsafe virtual void PostPath (string path, NSDictionary parameters, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<AFHTTPRequestOperation, NSObject> success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V1))]global::System.Action<AFHTTPRequestOperation, NSError> failure)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			if (parameters == null)
				throw new ArgumentNullException ("parameters");
			if (success == null)
				throw new ArgumentNullException ("success");
			var nspath = NSString.CreateNative (path);
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDActionArity2V0.Handler, success);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			if (failure == null){
				block_ptr_failure = null;
			} else {
				block_failure = new BlockLiteral ();
				block_ptr_failure = &block_failure;
				block_failure.SetupBlock (Trampolines.SDActionArity2V1.Handler, failure);
			}
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("postPath:parameters:success:failure:"), nspath, parameters.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("postPath:parameters:success:failure:"), nspath, parameters.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			}
			NSString.ReleaseNative (nspath);
			block_ptr_success->CleanupBlock ();
			if (block_ptr_failure != null)
				block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("putPath:parameters:success:failure:")]
		[CompilerGenerated]
		public unsafe virtual void PutPath (string path, NSDictionary parameters, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V0))]global::System.Action<AFHTTPRequestOperation, NSObject> success, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity2V1))]global::System.Action<AFHTTPRequestOperation, NSError> failure)
		{
			if (path == null)
				throw new ArgumentNullException ("path");
			if (parameters == null)
				throw new ArgumentNullException ("parameters");
			if (success == null)
				throw new ArgumentNullException ("success");
			var nspath = NSString.CreateNative (path);
			BlockLiteral *block_ptr_success;
			BlockLiteral block_success;
			block_success = new BlockLiteral ();
			block_ptr_success = &block_success;
			block_success.SetupBlock (Trampolines.SDActionArity2V0.Handler, success);
			BlockLiteral *block_ptr_failure;
			BlockLiteral block_failure;
			if (failure == null){
				block_ptr_failure = null;
			} else {
				block_failure = new BlockLiteral ();
				block_ptr_failure = &block_failure;
				block_failure.SetupBlock (Trampolines.SDActionArity2V1.Handler, failure);
			}
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("putPath:parameters:success:failure:"), nspath, parameters.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("putPath:parameters:success:failure:"), nspath, parameters.Handle, (IntPtr) block_ptr_success, (IntPtr) block_ptr_failure);
			}
			NSString.ReleaseNative (nspath);
			block_ptr_success->CleanupBlock ();
			if (block_ptr_failure != null)
				block_ptr_failure->CleanupBlock ();
			
		}
		
		[Export ("registerHTTPOperationClass:")]
		[CompilerGenerated]
		public virtual bool RegisterHTTPOperationClass (Class operationClass)
		{
			if (operationClass == null)
				throw new ArgumentNullException ("operationClass");
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("registerHTTPOperationClass:"), operationClass.Handle);
			} else {
				return ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("registerHTTPOperationClass:"), operationClass.Handle);
			}
		}
		
		[Export ("requestWithMethod:path:parameters:")]
		[CompilerGenerated]
		public virtual NSMutableUrlRequest RequestWithMethod (string method, string path, NSDictionary parameters)
		{
			if (method == null)
				throw new ArgumentNullException ("method");
			if (path == null)
				throw new ArgumentNullException ("path");
			var nsmethod = NSString.CreateNative (method);
			var nspath = NSString.CreateNative (path);
			
			NSMutableUrlRequest ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSMutableUrlRequest> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("requestWithMethod:path:parameters:"), nsmethod, nspath, parameters == null ? IntPtr.Zero : parameters.Handle));
			} else {
				ret =  Runtime.GetNSObject<NSMutableUrlRequest> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("requestWithMethod:path:parameters:"), nsmethod, nspath, parameters == null ? IntPtr.Zero : parameters.Handle));
			}
			NSString.ReleaseNative (nsmethod);
			NSString.ReleaseNative (nspath);
			
			return ret;
		}
		
		[Export ("setAuthorizationHeaderWithToken:")]
		[CompilerGenerated]
		public virtual void SetAuthorizationHeaderWithToken (string token)
		{
			if (token == null)
				throw new ArgumentNullException ("token");
			var nstoken = NSString.CreateNative (token);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAuthorizationHeaderWithToken:"), nstoken);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAuthorizationHeaderWithToken:"), nstoken);
			}
			NSString.ReleaseNative (nstoken);
			
		}
		
		[Export ("setAuthorizationHeaderWithUsername:password:")]
		[CompilerGenerated]
		public virtual void SetAuthorizationHeaderWithUsername (string username, string password)
		{
			if (username == null)
				throw new ArgumentNullException ("username");
			if (password == null)
				throw new ArgumentNullException ("password");
			var nsusername = NSString.CreateNative (username);
			var nspassword = NSString.CreateNative (password);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setAuthorizationHeaderWithUsername:password:"), nsusername, nspassword);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("setAuthorizationHeaderWithUsername:password:"), nsusername, nspassword);
			}
			NSString.ReleaseNative (nsusername);
			NSString.ReleaseNative (nspassword);
			
		}
		
		[Export ("setDefaultCredential:")]
		[CompilerGenerated]
		public virtual void SetDefaultCredential (NSUrlCredential credential)
		{
			if (credential == null)
				throw new ArgumentNullException ("credential");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDefaultCredential:"), credential.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDefaultCredential:"), credential.Handle);
			}
		}
		
		[Export ("setDefaultHeader:value:")]
		[CompilerGenerated]
		public virtual void SetDefaultHeader (string header, string value)
		{
			if (header == null)
				throw new ArgumentNullException ("header");
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsheader = NSString.CreateNative (header);
			var nsvalue = NSString.CreateNative (value);
			
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("setDefaultHeader:value:"), nsheader, nsvalue);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("setDefaultHeader:value:"), nsheader, nsvalue);
			}
			NSString.ReleaseNative (nsheader);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[Export ("unregisterHTTPOperationClass:")]
		[CompilerGenerated]
		public virtual void UnregisterHTTPOperationClass (Class operationClass)
		{
			if (operationClass == null)
				throw new ArgumentNullException ("operationClass");
			if (IsDirectBinding) {
				ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("unregisterHTTPOperationClass:"), operationClass.Handle);
			} else {
				ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("unregisterHTTPOperationClass:"), operationClass.Handle);
			}
		}
		
		[CompilerGenerated]
		object __mt_BaseURL_var;
		[CompilerGenerated]
		public virtual NSUrl BaseURL {
			[Export ("baseURL")]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("baseURL")));
				} else {
					ret =  Runtime.GetNSObject<NSUrl> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("baseURL")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_BaseURL_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_OperationQueue_var;
		[CompilerGenerated]
		public virtual NSOperationQueue OperationQueue {
			[Export ("operationQueue")]
			get {
				NSOperationQueue ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSOperationQueue> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("operationQueue")));
				} else {
					ret =  Runtime.GetNSObject<NSOperationQueue> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("operationQueue")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_OperationQueue_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual AFHTTPClientParameterEncoding ParameterEncoding {
			[Export ("parameterEncoding")]
			get {
				if (IsDirectBinding) {
					return (AFHTTPClientParameterEncoding) ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("parameterEncoding"));
				} else {
					return (AFHTTPClientParameterEncoding) ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("parameterEncoding"));
				}
			}
			
			[Export ("setParameterEncoding:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setParameterEncoding:"), (int)value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setParameterEncoding:"), (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual NSStringEncoding StringEncoding {
			[Export ("stringEncoding")]
			get {
				NSStringEncoding ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (NSStringEncoding) ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("stringEncoding"));
					} else {
						ret = (NSStringEncoding) ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("stringEncoding"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (NSStringEncoding) ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stringEncoding"));
					} else {
						ret = (NSStringEncoding) ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stringEncoding"));
					}
				}
				return ret;
			}
			
			[Export ("setStringEncoding:")]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setStringEncoding:"), (UInt64)value);
					} else {
						ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setStringEncoding:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setStringEncoding:"), (UInt64)value);
					} else {
						ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setStringEncoding:"), (UInt32)value);
					}
				}
			}
		}
		
		[Field ("kAFUploadStream3GSuggestedDelay",  "__Internal")]
		public static unsafe global::System.Double kAFUploadStream3GSuggestedDelay {
			get {
				return Dlfcn.GetDouble (Libraries.__Internal.Handle, "kAFUploadStream3GSuggestedDelay");
			}
		}
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_BaseURL_var = null;
				__mt_OperationQueue_var = null;
			}
		}
	} /* class AFHTTPClient */
}
