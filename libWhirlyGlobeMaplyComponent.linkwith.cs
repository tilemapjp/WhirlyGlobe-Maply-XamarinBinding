using System;
using ObjCRuntime;

[assembly: LinkWith ("libWhirlyGlobeMaplyComponent.a", LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, SmartLink = true, ForceLoad = true)]
