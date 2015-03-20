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
	[Register("MaplyActiveObject", true)]
	public unsafe partial class MaplyActiveObject : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("MaplyActiveObject");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MaplyActiveObject () : base (NSObjectFlag.Empty)
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
		protected MaplyActiveObject (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MaplyActiveObject (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithViewController:")]
		[CompilerGenerated]
		public MaplyActiveObject (MaplyBaseViewController viewC)
			: base (NSObjectFlag.Empty)
		{
			if (viewC == null)
				throw new ArgumentNullException ("viewC");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithViewController:"), viewC.Handle), "initWithViewController:");
			} else {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithViewController:"), viewC.Handle), "initWithViewController:");
			}
		}
		
		[CompilerGenerated]
		object __mt_ViewC_var;
		[CompilerGenerated]
		public virtual MaplyBaseViewController ViewC {
			[Export ("viewC", ArgumentSemantic.Weak)]
			get {
				MaplyBaseViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MaplyBaseViewController> (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("viewC")));
				} else {
					ret =  Runtime.GetNSObject<MaplyBaseViewController> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("viewC")));
				}
				MarkDirty ();
				__mt_ViewC_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ViewC_var = null;
			}
		}
	} /* class MaplyActiveObject */
}
