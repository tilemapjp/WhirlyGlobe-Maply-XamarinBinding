//
// StructsAndEnums.cs
//
// Cameron Carmichael Alonso <cameron@shortlisthome.com>
//
// Copyright (c) 2015 Shortlist Home
//
using System;

namespace WhirlyGlobeMaply
{

	public enum MaplyVectorType : uint {
		MaplyVectorNoneType,
		MaplyVectorPointType,
		MaplyVectorLinearType,
		MaplyVectorArealType,
		MaplyVectorMultiType
	}

	public enum MaplyImage : uint {
		MaplyImageIntRGBA,
		MaplyImageUShort565,
		MaplyImageUShort4444,
		MaplyImageUShort5551,
		MaplyImageUByteRed,
		MaplyImageUByteGreen,
		MaplyImageUByteBlue,
		MaplyImageUByteAlpha,
		MaplyImageUByteRGB,
		MaplyImageETC2RGB8,
		MaplyImageETC2RGBA8,
		MaplyImageETC2RGBPA8,
		MaplyImageEACR11,
		MaplyImageEACR11S,
		MaplyImageEACRG11,
		MaplyImageEACRG11S,
		MaplyImage4Layer8Bit
	}

	public enum MaplyThread : uint {
		MaplyThreadCurrent,
		MaplyThreadAny
	}

	public enum MaplyLabel: uint {
		MaplyLabelJustifyLeft,
		MaplyLabelJustifyMiddle,
		MaplyLabelJustifyRight
	}

	public enum MaplyDataStyle : uint {
		MaplyDataStyleAdd,
		MaplyDataStyleReplace
	}

	public enum MaplyOpacity : uint {
		MaplyOpacityFlat,
		MaplyOpacityLinear,
		MaplyOpacitySin1,
		MaplyOpacitySin2,
		MaplyOpacitySin3
	}

	public enum MaplyGeomType : uint {
		GeomTypeUnknown = 0,
		GeomTypePoint = 1,
		GeomTypeLineString = 2,
		GeomTypePolygon = 3
	}

	public enum SEG : uint {
		SEG_END = 0,
		SEG_MOVETO = 1,
		SEG_LINETO = 2,
		SEG_CLOSE = (64 | 15)
	}



}

