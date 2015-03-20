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

namespace WhirlyGlobeMaply {
	[Register("MaplyAnnotation", true)]
	public unsafe partial class MaplyAnnotation : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MaplyAnnotation");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MaplyAnnotation () : base (NSObjectFlag.Empty)
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
		protected MaplyAnnotation (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MaplyAnnotation (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		object __mt_ContentView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIView ContentView {
			[Export ("contentView")]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("contentView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("contentView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ContentView_var = ret;
				return ret;
			}
			
			[Export ("setContentView:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setContentView:"), value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setContentView:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_ContentView_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_LeftAccessoryView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIView LeftAccessoryView {
			[Export ("leftAccessoryView")]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("leftAccessoryView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("leftAccessoryView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_LeftAccessoryView_var = ret;
				return ret;
			}
			
			[Export ("setLeftAccessoryView:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLeftAccessoryView:"), value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLeftAccessoryView:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_LeftAccessoryView_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual float MaxVis {
			[Export ("maxVis", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("maxVis"));
				} else {
					return ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("maxVis"));
				}
			}
			
			[Export ("setMaxVis:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setMaxVis:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setMaxVis:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float MinVis {
			[Export ("minVis", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("minVis"));
				} else {
					return ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("minVis"));
				}
			}
			
			[Export ("setMinVis:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setMinVis:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setMinVis:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool RepositionForVisibility {
			[Export ("repositionForVisibility")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("repositionForVisibility"));
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("repositionForVisibility"));
				}
			}
			
			[Export ("setRepositionForVisibility:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRepositionForVisibility:"), value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setRepositionForVisibility:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_RightAccessoryView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIView RightAccessoryView {
			[Export ("rightAccessoryView")]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rightAccessoryView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rightAccessoryView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_RightAccessoryView_var = ret;
				return ret;
			}
			
			[Export ("setRightAccessoryView:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRightAccessoryView:"), value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRightAccessoryView:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_RightAccessoryView_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string SubTitle {
			[Export ("subTitle")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("subTitle")));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("subTitle")));
				}
			}
			
			[Export ("setSubTitle:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSubTitle:"), nsvalue);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSubTitle:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_SubtitleView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIView SubtitleView {
			[Export ("subtitleView")]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("subtitleView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("subtitleView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_SubtitleView_var = ret;
				return ret;
			}
			
			[Export ("setSubtitleView:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSubtitleView:"), value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSubtitleView:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_SubtitleView_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string Title {
			[Export ("title")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("title")));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("title")));
				}
			}
			
			[Export ("setTitle:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTitle:"), nsvalue);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTitle:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_TitleView_var;
		[CompilerGenerated]
		public virtual global::UIKit.UIView TitleView {
			[Export ("titleView")]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("titleView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("titleView")));
				}
				if (!IsNewRefcountEnabled ())
					__mt_TitleView_var = ret;
				return ret;
			}
			
			[Export ("setTitleView:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTitleView:"), value.Handle);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTitleView:"), value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_TitleView_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ContentView_var = null;
				__mt_LeftAccessoryView_var = null;
				__mt_RightAccessoryView_var = null;
				__mt_SubtitleView_var = null;
				__mt_TitleView_var = null;
			}
		}
	} /* class MaplyAnnotation */
}
