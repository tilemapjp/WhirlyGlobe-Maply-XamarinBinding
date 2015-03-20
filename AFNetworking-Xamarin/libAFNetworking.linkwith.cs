using System;
using ObjCRuntime;

[assembly: LinkWith ("libAFNetworking.a", LinkTarget.ArmV7 | LinkTarget.Simulator, SmartLink = true, ForceLoad = true)]
