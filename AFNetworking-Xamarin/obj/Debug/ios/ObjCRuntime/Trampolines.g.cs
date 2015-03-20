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

namespace ObjCRuntime {
	
	[CompilerGenerated]
	static partial class Trampolines {
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern IntPtr _Block_copy (IntPtr ptr);
		
		[DllImport ("/usr/lib/libobjc.dylib")]
		static extern void _Block_release (IntPtr ptr);
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity2V0 (IntPtr block, IntPtr arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity2V0 {
			static internal readonly DActionArity2V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity2V0))]
			static unsafe void Invoke (IntPtr block, IntPtr arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::AFNetworking.AFHTTPRequestOperation, NSObject>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<AFNetworking.AFHTTPRequestOperation> (arg1),  Runtime.GetNSObject<Foundation.NSObject> (arg2));
			}
		} /* class SDActionArity2V0 */
		
		internal class NIDActionArity2V0 {
			IntPtr blockPtr;
			DActionArity2V0 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity2V0 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity2V0> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity2V0 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::AFNetworking.AFHTTPRequestOperation, NSObject> Create (IntPtr block)
			{
				return new NIDActionArity2V0 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::AFNetworking.AFHTTPRequestOperation arg1, NSObject arg2)
			{
				invoker (blockPtr, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2 == null ? IntPtr.Zero : arg2.Handle);
			}
		} /* class NIDActionArity2V0 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DActionArity2V1 (IntPtr block, IntPtr arg1, IntPtr arg2);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity2V1 {
			static internal readonly DActionArity2V1 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity2V1))]
			static unsafe void Invoke (IntPtr block, IntPtr arg1, IntPtr arg2) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::AFNetworking.AFHTTPRequestOperation, NSError>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<AFNetworking.AFHTTPRequestOperation> (arg1),  Runtime.GetNSObject<Foundation.NSError> (arg2));
			}
		} /* class SDActionArity2V1 */
		
		internal class NIDActionArity2V1 {
			IntPtr blockPtr;
			DActionArity2V1 invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDActionArity2V1 (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DActionArity2V1> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDActionArity2V1 ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action<global::AFNetworking.AFHTTPRequestOperation, NSError> Create (IntPtr block)
			{
				return new NIDActionArity2V1 ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::AFNetworking.AFHTTPRequestOperation arg1, NSError arg2)
			{
				invoker (blockPtr, arg1 == null ? IntPtr.Zero : arg1.Handle, arg2 == null ? IntPtr.Zero : arg2.Handle);
			}
		} /* class NIDActionArity2V1 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DAFHttpRequestSuccessCallback (IntPtr block, IntPtr operation, IntPtr responseObject);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDAFHttpRequestSuccessCallback {
			static internal readonly DAFHttpRequestSuccessCallback Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DAFHttpRequestSuccessCallback))]
			static unsafe void Invoke (IntPtr block, IntPtr operation, IntPtr responseObject) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::AFNetworking.AFHttpRequestSuccessCallback) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<AFNetworking.AFHTTPRequestOperation> (operation),  Runtime.GetNSObject<Foundation.NSObject> (responseObject));
			}
		} /* class SDAFHttpRequestSuccessCallback */
		
		internal class NIDAFHttpRequestSuccessCallback {
			IntPtr blockPtr;
			DAFHttpRequestSuccessCallback invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDAFHttpRequestSuccessCallback (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DAFHttpRequestSuccessCallback> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDAFHttpRequestSuccessCallback ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::AFNetworking.AFHttpRequestSuccessCallback Create (IntPtr block)
			{
				return new NIDAFHttpRequestSuccessCallback ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::AFNetworking.AFHTTPRequestOperation operation, NSObject responseObject)
			{
				invoker (blockPtr, operation == null ? IntPtr.Zero : operation.Handle, responseObject == null ? IntPtr.Zero : responseObject.Handle);
			}
		} /* class NIDAFHttpRequestSuccessCallback */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DAFHttpRequestFailureCallback (IntPtr block, IntPtr operation, IntPtr error);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDAFHttpRequestFailureCallback {
			static internal readonly DAFHttpRequestFailureCallback Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DAFHttpRequestFailureCallback))]
			static unsafe void Invoke (IntPtr block, IntPtr operation, IntPtr error) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::AFNetworking.AFHttpRequestFailureCallback) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<AFNetworking.AFHTTPRequestOperation> (operation),  Runtime.GetNSObject<Foundation.NSError> (error));
			}
		} /* class SDAFHttpRequestFailureCallback */
		
		internal class NIDAFHttpRequestFailureCallback {
			IntPtr blockPtr;
			DAFHttpRequestFailureCallback invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDAFHttpRequestFailureCallback (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DAFHttpRequestFailureCallback> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDAFHttpRequestFailureCallback ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::AFNetworking.AFHttpRequestFailureCallback Create (IntPtr block)
			{
				return new NIDAFHttpRequestFailureCallback ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::AFNetworking.AFHTTPRequestOperation operation, NSError error)
			{
				invoker (blockPtr, operation == null ? IntPtr.Zero : operation.Handle, error == null ? IntPtr.Zero : error.Handle);
			}
		} /* class NIDAFHttpRequestFailureCallback */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DAFImageRequestCallback (IntPtr block, IntPtr image);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDAFImageRequestCallback {
			static internal readonly DAFImageRequestCallback Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DAFImageRequestCallback))]
			static unsafe void Invoke (IntPtr block, IntPtr image) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::AFNetworking.AFImageRequestCallback) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<UIKit.UIImage> (image));
			}
		} /* class SDAFImageRequestCallback */
		
		internal class NIDAFImageRequestCallback {
			IntPtr blockPtr;
			DAFImageRequestCallback invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDAFImageRequestCallback (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DAFImageRequestCallback> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDAFImageRequestCallback ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::AFNetworking.AFImageRequestCallback Create (IntPtr block)
			{
				return new NIDAFImageRequestCallback ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (global::UIKit.UIImage image)
			{
				invoker (blockPtr, image == null ? IntPtr.Zero : image.Handle);
			}
		} /* class NIDAFImageRequestCallback */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate IntPtr DAFImageRequestImageProcessingCallback (IntPtr block, IntPtr image);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDAFImageRequestImageProcessingCallback {
			static internal readonly DAFImageRequestImageProcessingCallback Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DAFImageRequestImageProcessingCallback))]
			static unsafe IntPtr Invoke (IntPtr block, IntPtr image) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::AFNetworking.AFImageRequestImageProcessingCallback) (descriptor->Target);
				UIKit.UIImage retval = del ( Runtime.GetNSObject<UIKit.UIImage> (image));
				return retval != null ? retval.Handle : IntPtr.Zero;
			}
		} /* class SDAFImageRequestImageProcessingCallback */
		
		internal class NIDAFImageRequestImageProcessingCallback {
			IntPtr blockPtr;
			DAFImageRequestImageProcessingCallback invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDAFImageRequestImageProcessingCallback (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DAFImageRequestImageProcessingCallback> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDAFImageRequestImageProcessingCallback ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::AFNetworking.AFImageRequestImageProcessingCallback Create (IntPtr block)
			{
				return new NIDAFImageRequestImageProcessingCallback ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe global::UIKit.UIImage Invoke (global::UIKit.UIImage image)
			{
				var ret =  Runtime.GetNSObject<global::UIKit.UIImage> (invoker (blockPtr, image == null ? IntPtr.Zero : image.Handle));
				return ret;
			}
		} /* class NIDAFImageRequestImageProcessingCallback */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DAFImageRequestDetailedCallback (IntPtr block, IntPtr request, IntPtr response, IntPtr image);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDAFImageRequestDetailedCallback {
			static internal readonly DAFImageRequestDetailedCallback Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DAFImageRequestDetailedCallback))]
			static unsafe void Invoke (IntPtr block, IntPtr request, IntPtr response, IntPtr image) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::AFNetworking.AFImageRequestDetailedCallback) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Foundation.NSUrlRequest> (request),  Runtime.GetNSObject<Foundation.NSHttpUrlResponse> (response),  Runtime.GetNSObject<UIKit.UIImage> (image));
			}
		} /* class SDAFImageRequestDetailedCallback */
		
		internal class NIDAFImageRequestDetailedCallback {
			IntPtr blockPtr;
			DAFImageRequestDetailedCallback invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDAFImageRequestDetailedCallback (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DAFImageRequestDetailedCallback> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDAFImageRequestDetailedCallback ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::AFNetworking.AFImageRequestDetailedCallback Create (IntPtr block)
			{
				return new NIDAFImageRequestDetailedCallback ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSUrlRequest request, NSHttpUrlResponse response, global::UIKit.UIImage image)
			{
				invoker (blockPtr, request == null ? IntPtr.Zero : request.Handle, response == null ? IntPtr.Zero : response.Handle, image == null ? IntPtr.Zero : image.Handle);
			}
		} /* class NIDAFImageRequestDetailedCallback */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DAFImageRequestFailedCallback (IntPtr block, IntPtr request, IntPtr response, IntPtr error);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDAFImageRequestFailedCallback {
			static internal readonly DAFImageRequestFailedCallback Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DAFImageRequestFailedCallback))]
			static unsafe void Invoke (IntPtr block, IntPtr request, IntPtr response, IntPtr error) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::AFNetworking.AFImageRequestFailedCallback) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<Foundation.NSUrlRequest> (request),  Runtime.GetNSObject<Foundation.NSHttpUrlResponse> (response),  Runtime.GetNSObject<Foundation.NSError> (error));
			}
		} /* class SDAFImageRequestFailedCallback */
		
		internal class NIDAFImageRequestFailedCallback {
			IntPtr blockPtr;
			DAFImageRequestFailedCallback invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDAFImageRequestFailedCallback (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DAFImageRequestFailedCallback> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDAFImageRequestFailedCallback ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::AFNetworking.AFImageRequestFailedCallback Create (IntPtr block)
			{
				return new NIDAFImageRequestFailedCallback ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke (NSUrlRequest request, NSHttpUrlResponse response, NSError error)
			{
				invoker (blockPtr, request == null ? IntPtr.Zero : request.Handle, response == null ? IntPtr.Zero : response.Handle, error == null ? IntPtr.Zero : error.Handle);
			}
		} /* class NIDAFImageRequestFailedCallback */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		internal delegate void DAction (IntPtr block);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDAction {
			static internal readonly DAction Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DAction))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action) (descriptor->Target);
				if (del != null)
					del ();
			}
		} /* class SDAction */
		
		internal class NIDAction {
			IntPtr blockPtr;
			DAction invoker;
			
			[Preserve (Conditional=true)]
			public unsafe NIDAction (BlockLiteral *block)
			{
				blockPtr = _Block_copy ((IntPtr) block);
				invoker = block->GetDelegateForBlock<DAction> ();
			}
			
			[Preserve (Conditional=true)]
			~NIDAction ()
			{
				_Block_release (blockPtr);
			}
			
			[Preserve (Conditional=true)]
			public unsafe static global::System.Action Create (IntPtr block)
			{
				return new NIDAction ((BlockLiteral *) block).Invoke;
			}
			
			[Preserve (Conditional=true)]
			unsafe void Invoke ()
			{
				invoker (blockPtr);
			}
		} /* class NIDAction */
	}
}
