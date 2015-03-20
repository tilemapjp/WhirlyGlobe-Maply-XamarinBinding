//
// ApiDefinition.cs
//
// Cameron Carmichael Alonso <cameron@shortlisthome.com>
//
// Copyright (c) 2015 Shortlist Home
//
using System;
using System.Drawing;

using ObjCRuntime;
using Foundation;
using UIKit;
using AFNetworking;
using CoreGraphics;

namespace WhirlyGlobeMaply
{

	/*
	 * Custom built C# objects
	 * these should fit right into the rest of the binding
	 */

	public class MaplyCoordinate {


	}

	public class MaplyBoundingBox {


	}

	public class MaplyCoordinate3d {


	}

	public class MaplyTileID {


	}

	public class WGCoordinate {


	}

	public class WGViewControllerLayer {


	}

	/*
	 * Translated objects
	 */

	// @interface MaplyActiveObject : NSObject
	[BaseType (typeof (NSObject))]
	interface MaplyActiveObject {

		// -(id)initWithViewController:(MaplyBaseViewController *)viewC;
		[Export ("initWithViewController:")]
		IntPtr Constructor (MaplyBaseViewController viewC);

		// @property (readonly, nonatomic, weak) MaplyBaseViewController * viewC;
		[Export ("viewC", ArgumentSemantic.Weak)]
		MaplyBaseViewController ViewC { get; }
	}

	// @interface MaplyAnnotation : NSObject
	[BaseType (typeof (NSObject))]
	interface MaplyAnnotation {

		// @property (assign, nonatomic) float minVis;
		[Export ("minVis", ArgumentSemantic.UnsafeUnretained)]
		float MinVis { get; set; }

		// @property (assign, nonatomic) float maxVis;
		[Export ("maxVis", ArgumentSemantic.UnsafeUnretained)]
		float MaxVis { get; set; }

		// @property (nonatomic) NSString * title;
		[Export ("title")]
		string Title { get; set; }

		// @property (nonatomic) NSString * subTitle;
		[Export ("subTitle")]
		string SubTitle { get; set; }

		// @property (nonatomic) UIView * leftAccessoryView;
		[Export ("leftAccessoryView")]
		UIView LeftAccessoryView { get; set; }

		// @property (nonatomic) UIView * rightAccessoryView;
		[Export ("rightAccessoryView")]
		UIView RightAccessoryView { get; set; }

		// @property (nonatomic) UIView * titleView;
		[Export ("titleView")]
		UIView TitleView { get; set; }

		// @property (nonatomic) UIView * subtitleView;
		[Export ("subtitleView")]
		UIView SubtitleView { get; set; }

		// @property (nonatomic) UIView * contentView;
		[Export ("contentView")]
		UIView ContentView { get; set; }

		// @property (nonatomic) _Bool repositionForVisibility;
		[Export ("repositionForVisibility")]
		bool RepositionForVisibility { get; set; }
	}

	// @interface MaplyScreenMarker : NSObject
	[BaseType (typeof (NSObject))]
	interface MaplyScreenMarker {

		[Export ("get_loc")]
		void Get_Loc(MaplyCoordinate coordinate);

		// @property (assign, nonatomic) MaplyCoordinate loc;
		[Export ("loc", ArgumentSemantic.UnsafeUnretained)]
		MaplyCoordinate loc { get; set; }

		// @property (assign, nonatomic) CGSize size;
		[Export ("size", ArgumentSemantic.UnsafeUnretained)]
		CGSize Size { get; set; }

		// @property (assign, nonatomic) double rotation;
		[Export ("rotation", ArgumentSemantic.UnsafeUnretained)]
		double Rotation { get; set; }

		// @property (nonatomic, strong) id image;
		[Export ("image", ArgumentSemantic.Retain)]
		NSObject Image { get; set; }

		// @property (nonatomic, strong) UIColor * color;
		[Export ("color", ArgumentSemantic.Retain)]
		UIColor Color { get; set; }

		// @property (assign, nonatomic) float layoutImportance;
		[Export ("layoutImportance", ArgumentSemantic.UnsafeUnretained)]
		float LayoutImportance { get; set; }

		// @property (assign, nonatomic) CGPoint offset;
		[Export ("offset", ArgumentSemantic.UnsafeUnretained)]
		CGPoint Offset { get; set; }

		// @property (assign, nonatomic) _Bool selectable;
		[Export ("selectable", ArgumentSemantic.UnsafeUnretained)]
		bool Selectable { get; set; }

		// @property (nonatomic, strong) NSObject * userObject;
		[Export ("userObject", ArgumentSemantic.Retain)]
		NSObject UserObject { get; set; }
	}

	// @interface MaplyCoordinateSystem : NSObject
	[BaseType (typeof (NSObject))]
	interface MaplyCoordinateSystem {

		// -(void)setBoundsLL:(MaplyCoordinate *)ll ur:(MaplyCoordinate *)ll;
		[Export ("setBoundsLL:ur:")]
		void SetBoundsLL (MaplyCoordinateSystem ll, MaplyCoordinateSystem ur);

		// -(void)getBoundsLL:(MaplyCoordinate *)ret_ll ur:(MaplyCoordinate *)ret_ur;
		[Export ("getBoundsLL:ur:")]
		void GetBoundsLL (MaplyCoordinateSystem ret_ll, MaplyCoordinateSystem ret_ur);

		// -(MaplyCoordinate)geoToLocal:(MaplyCoordinate)coord;
		[Export ("geoToLocal:")]
		MaplyCoordinate geoToLocal (MaplyCoordinateSystem coord);

		// -(MaplyCoordinate)localToGeo:(MaplyCoordinate)coord;
		[Export ("localToGeo:")]
		MaplyCoordinate localToGeo (MaplyCoordinateSystem coord);

		// -(NSString *)getSRS;
		[Export ("getSRS")]
		string GetSRS ();

		// -(_Bool)canBeDegrees;
		[Export ("canBeDegrees")]
		bool CanBeDegrees ();
	}

	// @interface MaplyPlateCarree : MaplyCoordinateSystem
	[BaseType (typeof (MaplyCoordinateSystem))]
	interface MaplyPlateCarree {

		// -(id)initWithBoundingBox:(MaplyBoundingBox)bbox;
		[Export ("initWithBoundingBox:")]
		IntPtr Constructor (MaplyBoundingBox bbox);
	}

	//@interface 

	// @interface MaplySphericalMercator : MaplyCoordinateSystem
	[BaseType (typeof (MaplyCoordinateSystem))]
	interface MaplySphericalMercator {

	}

	//@interface 

	// @interface MaplyVectorObject : NSObject
	[BaseType (typeof (NSObject))]
	interface MaplyVectorObject {

		// -(id)initWithPoint:(MaplyCoordinate *)coord attributes:(NSDictionary *)attr;
		[Export ("initWithPoint:attributes:")]
		IntPtr Constructor (MaplyCoordinate coord, NSDictionary attr);

		// -(id)initWithLineString:(MaplyCoordinate *)coords numCoords:(int)numCoords attributes:(NSDictionary *)attr;
		[Export ("initWithLineString:numCoords:attributes:")]
		IntPtr Constructor (MaplyCoordinate coords, int numCoords, NSDictionary attr);

		// -(id)initWithAreal:(MaplyCoordinate *)coords numCoords:(int)numCoords attributes:(NSDictionary *)attr;
		//[Export ("initWithAreal:numCoords:attributes:")]
		//IntPtr Constructor (MaplyCoordinate coords, int numCoords, NSDictionary attr);

		// @property (nonatomic, strong) NSObject * userObject;
		[Export ("userObject", ArgumentSemantic.Retain)]
		NSObject UserObject { get; set; }

		// @property (assign, nonatomic) _Bool selectable;
		[Export ("selectable", ArgumentSemantic.UnsafeUnretained)]
		bool Selectable { get; set; }

		// @property (readonly, nonatomic) NSMutableDictionary * attributes;
		[Export ("attributes")]
		NSMutableDictionary Attributes { get; }

		// +(MaplyVectorObject *)VectorObjectFromGeoJSON:(NSData *)geoJSON;
		[Static, Export ("VectorObjectFromGeoJSON:")]
		MaplyVectorObject VectorObjectFromGeoJSON (NSData geoJSON);

		// +(MaplyVectorObject *)VectorObjectFromGeoJSONApple:(NSData *)geoJSON;
		[Static, Export ("VectorObjectFromGeoJSONApple:")]
		MaplyVectorObject VectorObjectFromGeoJSONApple (NSData geoJSON);

		// +(MaplyVectorObject *)VectorObjectFromGeoJSONDictionary:(NSDictionary *)geoJSON;
		[Static, Export ("VectorObjectFromGeoJSONDictionary:")]
		MaplyVectorObject VectorObjectFromGeoJSONDictionary (NSDictionary geoJSON);

		// +(MaplyVectorObject *)VectorObjectFromFile:(NSString *)fileName;
		[Static, Export ("VectorObjectFromFile:")]
		MaplyVectorObject VectorObjectFromFile (string fileName);

		// +(MaplyVectorObject *)VectorObjectFromShapeFile:(NSString *)fileName;
		[Static, Export ("VectorObjectFromShapeFile:")]
		MaplyVectorObject VectorObjectFromShapeFile (string fileName);

		// +(NSDictionary *)VectorObjectsFromGeoJSONAssembly:(NSData *)geoJSON;
		[Static, Export ("VectorObjectsFromGeoJSONAssembly:")]
		NSDictionary VectorObjectsFromGeoJSONAssembly (NSData geoJSON);

		// -(_Bool)writeToFile:(NSString *)fileName;
		[Export ("writeToFile:")]
		bool WriteToFile (string fileName);

		// -(MaplyVectorObject *)deepCopy;
		[Export ("deepCopy")]
		MaplyVectorObject DeepCopy ();

		// -(NSString *)log;
		[Export ("log")]
		string Log ();

		// -(void)addHole:(MaplyCoordinate *)coords numCoords:(int)numCoords;
		[Export ("addHole:numCoords:")]
		void AddHole (MaplyCoordinate coords, int numCoords);

		// -(MaplyVectorObjectType)vectorType;
		[Export ("vectorType")]
		MaplyVectorObjectType VectorType ();

		// -(_Bool)pointInAreal:(MaplyCoordinate)coord;
		[Export ("pointInAreal:")]
		bool PointInAreal (bool coord);

		// -(_Bool)pointNearLinear:(MaplyCoordinate)coord distance:(float)maxDistance inViewController:(MaplyBaseViewController *)vc;
		[Export ("pointNearLinear:distance:inViewController:")]
		bool PointNearLinear (bool coord, float maxDistance, MaplyBaseViewController vc);

		// -(MaplyCoordinate)center;
		[Export ("center")]
		MaplyCoordinate Center ();

		// -(void)mergeVectorsFrom:(MaplyVectorObject *)otherVec;
		[Export ("mergeVectorsFrom:")]
		void MergeVectorsFrom (MaplyVectorObject otherVec);

		// -(_Bool)linearMiddle:(MaplyCoordinate *)middle rot:(double *)rot;
		[Export ("linearMiddle:rot:")]
		bool LinearMiddle (MaplyCoordinate middle, double rot);

		// -(_Bool)linearMiddle:(MaplyCoordinate *)middle rot:(double *)rot displayCoordSys:(MaplyCoordinateSystem *)coordSys;
		[Export ("linearMiddle:rot:displayCoordSys:")]
		bool LinearMiddle (MaplyCoordinate middle, double rot, MaplyCoordinateSystem coordSys);

		// -(_Bool)middleCoordinate:(MaplyCoordinate *)middle;
		[Export ("middleCoordinate:")]
		bool MiddleCoordinate (MaplyCoordinate middle);

		// -(_Bool)largestLoopCenter:(MaplyCoordinate *)center mbrLL:(MaplyCoordinate *)ll mbrUR:(MaplyCoordinate *)ur;
		[Export ("largestLoopCenter:mbrLL:mbrUR:")]
		bool LargestLoopCenter (MaplyCoordinate center, MaplyCoordinate ll, MaplyCoordinate ur);

		// -(_Bool)centroid:(MaplyCoordinate *)centroid;
		[Export ("centroid:")]
		bool Centroid (MaplyCoordinate centroid);

		// -(_Bool)boundingBoxLL:(MaplyCoordinate *)ll ur:(MaplyCoordinate *)ur;
		[Export ("boundingBoxLL:ur:")]
		bool BoundingBoxLL (MaplyCoordinate ll, MaplyCoordinate ur);

		// -(NSArray *)asCLLocationArrays;
		[Export ("asCLLocationArrays")]
		NSObject [] AsCLLocationArrays ();

		// -(NSArray *)asNumbers;
		[Export ("asNumbers")]
		NSObject [] AsNumbers ();

		// -(NSArray *)splitVectors;
		[Export ("splitVectors")]
		NSObject [] SplitVectors ();

		// -(void)subdivideToGlobe:(float)epsilon;
		[Export ("subdivideToGlobe:")]
		void SubdivideToGlobe (float epsilon);

		// -(void)subdivideToGlobeGreatCircle:(float)epsilon;
		[Export ("subdivideToGlobeGreatCircle:")]
		void SubdivideToGlobeGreatCircle (float epsilon);

		// -(MaplyVectorObject *)tesselate;
		[Export ("tesselate")]
		MaplyVectorObject Tesselate ();

		// -(MaplyVectorObject *)clipToGrid:(CGSize)gridSize;
		[Export ("clipToGrid:")]
		MaplyVectorObject ClipToGrid (CGSize gridSize);

		// -(MaplyVectorObject *)clipToMbr:(MaplyCoordinate)ll upperRight:(MaplyCoordinate)ur;
		[Export ("clipToMbr:upperRight:")]
		MaplyVectorObject ClipToMbr (MaplyCoordinate ll, MaplyCoordinate  ur);
	}

	// @interface MaplyVectorDatabase : NSObject
	[BaseType (typeof (NSObject))]
	interface MaplyVectorDatabase {

		// +(MaplyVectorDatabase *)vectorDatabaseWithShape:(NSString *)shapeName;
		[Static, Export ("vectorDatabaseWithShape:")]
		MaplyVectorDatabase VectorDatabaseWithShape (string shapeName);

		// -(MaplyVectorObject *)fetchMatchingVectors:(NSString *)sqlQuery;
		[Export ("fetchMatchingVectors:")]
		MaplyVectorObject FetchMatchingVectors (string sqlQuery);

		// -(MaplyVectorObject *)fetchArealsForPoint:(MaplyCoordinate)coord;
		[Export ("fetchArealsForPoint:")]
		MaplyVectorObject FetchArealsForPoint (MaplyCoordinate coord);

		// -(MaplyVectorObject *)fetchAllVectors;
		[Export ("fetchAllVectors")]
		MaplyVectorObject FetchAllVectors ();
	}

	// @interface MaplyViewTracker : NSObject
	[BaseType (typeof (NSObject))]
	interface MaplyViewTracker {

		// @property (nonatomic, strong) UIView * view;
		[Export ("view", ArgumentSemantic.Retain)]
		UIView View { get; set; }

		// @property (assign, nonatomic) MaplyCoordinate loc;
		[Export ("loc", ArgumentSemantic.UnsafeUnretained)]
		MaplyCoordinate Loc { get; set; }

		// @property (assign, nonatomic) float minVis;
		[Export ("minVis", ArgumentSemantic.UnsafeUnretained)]
		float MinVis { get; set; }

		// @property (assign, nonatomic) float maxVis;
		[Export ("maxVis", ArgumentSemantic.UnsafeUnretained)]
		float MaxVis { get; set; }
	}

	// @interface MaplyComponentObject : NSObject
	[BaseType (typeof (NSObject))]
	interface MaplyComponentObject {

		// -(id)initWithDesc:(NSDictionary *)desc;
		[Export ("initWithDesc:")]
		IntPtr Constructor (NSDictionary desc);
	}

	// @interface MaplyViewControllerLayer : NSObject
	[BaseType (typeof (NSObject))]
	interface MaplyViewControllerLayer {

		// @property (assign, nonatomic) int drawPriority;
		[Export ("drawPriority", ArgumentSemantic.UnsafeUnretained)]
		int DrawPriority { get; set; }
	}

	// @interface MaplyLight : NSObject
	[BaseType (typeof (NSObject))]
	interface MaplyLight {

		// @property (assign, nonatomic) MaplyCoordinate3d pos;
		[Export ("pos", ArgumentSemantic.UnsafeUnretained)]
		MaplyCoordinate3d Pos { get; set; }

		// @property (assign, nonatomic) _Bool viewDependent;
		[Export ("viewDependent", ArgumentSemantic.UnsafeUnretained)]
		bool ViewDependent { get; set; }

		// @property (nonatomic, strong) UIColor * ambient;
		[Export ("ambient", ArgumentSemantic.Retain)]
		UIColor Ambient { get; set; }

		// @property (nonatomic, strong) UIColor * diffuse;
		[Export ("diffuse", ArgumentSemantic.Retain)]
		UIColor Diffuse { get; set; }
	}

	// @interface MaplyShader : NSObject
	[BaseType (typeof (NSObject))]
	interface MaplyShader {

		// -(id)initWithName:(NSString *)name vertexFile:(NSString *)vertexFileName fragmentFile:(NSString *)fragFileName viewC:(MaplyBaseViewController *)baseViewC;
		[Export ("initWithName:vertexFile:fragmentFile:viewC:")]
		IntPtr Constructor (string name, string vertexFileName, string fragFileName, MaplyBaseViewController baseViewC);

		// -(id)initWithName:(NSString *)name vertex:(NSString *)vertexProg fragment:(NSString *)fragProg viewC:(MaplyBaseViewController *)baseViewC;
		//[Export ("initWithName:vertex:fragment:viewC:")]
		//IntPtr Constructor (string name, string vertexProg, string fragProg, MaplyBaseViewController baseViewC);

		// @property NSString * name;
		[Export ("name")]
		string Name { get; set; }

		// -(void)addTextureNamed:(NSString *)shaderAttrName image:(UIImage *)image;
		[Export ("addTextureNamed:image:")]
		void AddTextureNamed (string shaderAttrName, UIImage image);

		// -(_Bool)setUniformFloatNamed:(NSString *)uniName val:(float)val;
		[Export ("setUniformFloatNamed:val:")]
		bool SetUniformFloatNamed (string uniName, float val);

		// -(_Bool)setUniformIntNamed:(NSString *)uniName val:(int)val;
		[Export ("setUniformIntNamed:val:")]
		bool SetUniformIntNamed (string uniName, int val);

		// -(_Bool)setUniformVector2Named:(NSString *)uniName x:(float)x y:(float)y;
		[Export ("setUniformVector2Named:x:y:")]
		bool SetUniformVector2Named (string uniName, float x, float y);

		// -(_Bool)setUniformVector3Named:(NSString *)uniName x:(float)x y:(float)y z:(float)z;
		[Export ("setUniformVector3Named:x:y:z:")]
		bool SetUniformVector3Named (string uniName, float x, float y, float z);

		// -(_Bool)setUniformVector4Named:(NSString *)uniName x:(float)x y:(float)y z:(float)z w:(float)w;
		[Export ("setUniformVector4Named:x:y:z:w:")]
		bool SetUniformVector4Named (string uniName, float x, float y, float z, float w);

		// -(_Bool)valid;
		[Export ("valid")]
		bool Valid ();

		// -(NSString *)getError;
		[Export ("getError")]
		string GetError ();
	}

	// @interface MaplyImageTile : NSObject
	[BaseType (typeof (NSObject))]
	interface MaplyImageTile {

		// -(id)initWithRawImage:(NSData *)data width:(int)width height:(int)height;
		[Export ("initWithRawImage:width:height:")]
		IntPtr Constructor (NSData data, int width, int height);

		// -(id)initWithRawImageArray:(NSArray *)data width:(int)width height:(int)height;
		[Export ("initWithRawImageArray:width:height:")]
		IntPtr Constructor (NSObject [] data, int width, int height);

		// -(id)initWithImage:(UIImage *)image;
		[Export ("initWithImage:")]
		IntPtr Constructor (UIImage image);

		// -(id)initWithImageArray:(NSArray *)images;
		[Export ("initWithImageArray:")]
		IntPtr Constructor (NSObject [] images);

		// -(id)initWithPNGorJPEGData:(NSData *)data;
		[Export ("initWithPNGorJPEGData:")]
		IntPtr Constructor (NSData data);

		// -(id)initWithPNGorJPEGDataArray:(NSArray *)data;
		//[Export ("initWithPNGorJPEGDataArray:")]
		//IntPtr Constructor (NSObject [] data);

		// -(id)initWithRandomData:(id)theObj;
		[Export ("initWithRandomData:")]
		IntPtr Constructor (NSObject theObj);

		// @property (nonatomic) CGSize targetSize;
		[Export ("targetSize")]
		CGSize TargetSize { get; set; }
	}

	// @protocol MaplyTileSource
	[Protocol, Model]
	interface MaplyTileSource {

		// @required -(int)minZoom;
		[Export ("minZoom")]
		[Abstract]
		int MinZoom ();

		// @required -(int)maxZoom;
		[Export ("maxZoom")]
		[Abstract]
		int MaxZoom ();

		// @required -(int)tileSize;
		[Export ("tileSize")]
		[Abstract]
		int TileSize ();

		// @required -(_Bool)tileIsLocal:(MaplyTileID)tileID;
		[Export ("tileIsLocal:")]
		[Abstract]
		bool TileIsLocal (MaplyTileID tileID);

		// @required -(MaplyCoordinateSystem *)coordSys;
		[Export ("coordSys")]
		[Abstract]
		MaplyCoordinateSystem CoordSys ();

		// @optional -(_Bool)validTile:(MaplyTileID)tileID bbox:(MaplyBoundingBox *)bbox;
		[Export ("validTile:bbox:")]
		bool ValidTile (MaplyTileID tileID, MaplyBoundingBox bbox);

		// @optional -(int)tileSizeForTile:(MaplyTileID)tileID;
		[Export ("tileSizeForTile:")]
		int TileSizeForTile (MaplyTileID tileID);

		// @optional -(id)imageForTile:(MaplyTileID)tileID;
		[Export ("imageForTile:")]
		NSObject ImageForTile (MaplyTileID tileID);

		// @optional -(id)imageForTile:(MaplyTileID)tileID frame:(int)frame;
		[Export ("imageForTile:frame:")]
		NSObject ImageForTile (MaplyTileID tileID, int frame);

		// @optional -(void)startFetchLayer:(id)layer tile:(MaplyTileID)tileID;
		[Export ("startFetchLayer:tile:")]
		void StartFetchLayer (NSObject layer, MaplyTileID tileID);

		// @optional -(void)startFetchLayer:(id)layer tile:(MaplyTileID)tileID frame:(int)frame;
		[Export ("startFetchLayer:tile:frame:")]
		void StartFetchLayer (NSObject layer, MaplyTileID tileID, int frame);

		// @optional -(void)tileUnloaded:(MaplyTileID)tileID;
		[Export ("tileUnloaded:")]
		void TileUnloaded (MaplyTileID tileID);
	}

	// @interface MaplyElevationChunk : NSObject
	[BaseType (typeof (NSObject))]
	interface MaplyElevationChunk {

		// -(id)initWithData:(NSData *)data numX:(unsigned int)numX numY:(unsigned int)numY;
		[Export ("initWithData:numX:numY:")]
		IntPtr Constructor (NSData data, uint numX, uint numY);

		// @property unsigned int numX;
		[Export ("numX")]
		uint NumX { get; set; }

		// @property unsigned int numY;
		[Export ("numY")]
		uint NumY { get; set; }

		// @property NSData * data;
		[Export ("data")]
		NSData Data { get; set; }
	}

	// @protocol MaplyElevationSourceDelegate
	[Protocol, Model]
	interface MaplyElevationSourceDelegate {

		// @required -(MaplyCoordinateSystem *)getCoordSystem;
		[Export ("getCoordSystem")]
		[Abstract]
		MaplyCoordinateSystem GetCoordSystem ();

		// @required -(int)minZoom;
		[Export ("minZoom")]
		[Abstract]
		int MinZoom ();

		// @required -(int)maxZoom;
		[Export ("maxZoom")]
		[Abstract]
		int MaxZoom ();

		// @required -(MaplyElevationChunk *)elevForTile:(MaplyTileID)tileID;
		[Export ("elevForTile:")]
		[Abstract]
		MaplyElevationChunk ElevForTile (MaplyTileID tileID);

		// @required -(_Bool)tileIsLocal:(MaplyTileID)tileID;
		[Export ("tileIsLocal:")]
		[Abstract]
		bool TileIsLocal (MaplyTileID tileID);
	}

	// @interface MaplyElevationSourceTester : NSObject <MaplyElevationSourceDelegate>
	[BaseType (typeof (NSObject))]
	interface MaplyElevationSourceTester : MaplyElevationSourceDelegate {

	}

	// @interface MaplyQuadImageTilesLayer : MaplyViewControllerLayer
	[BaseType (typeof (MaplyViewControllerLayer))]
	interface MaplyQuadImageTilesLayer {

		// -(id)initWithCoordSystem:(MaplyCoordinateSystem *)coordSys tileSource:(NSObject<MaplyTileSource> *)tileSource;
		[Export ("initWithCoordSystem:tileSource:")]
		IntPtr Constructor (MaplyCoordinateSystem coordSys, NSObject tileSource);

		// @property (nonatomic) NSObject<MaplyTileSource> * tileSource;
		[Export ("tileSource")]
		NSObject TileSource { get; set; }

		// @property (assign, nonatomic) _Bool enable;
		[Export ("enable", ArgumentSemantic.UnsafeUnretained)]
		bool Enable { get; set; }

		// @property (assign, nonatomic) int numSimultaneousFetches;
		[Export ("numSimultaneousFetches", ArgumentSemantic.UnsafeUnretained)]
		int NumSimultaneousFetches { get; set; }

		// @property (assign, nonatomic) _Bool handleEdges;
		[Export ("handleEdges", ArgumentSemantic.UnsafeUnretained)]
		bool HandleEdges { get; set; }

		// @property (assign, nonatomic) _Bool coverPoles;
		[Export ("coverPoles", ArgumentSemantic.UnsafeUnretained)]
		bool CoverPoles { get; set; }

		// @property (assign, nonatomic) float minVis;
		[Export ("minVis", ArgumentSemantic.UnsafeUnretained)]
		float MinVis { get; set; }

		// @property (assign, nonatomic) float maxVis;
		[Export ("maxVis", ArgumentSemantic.UnsafeUnretained)]
		float MaxVis { get; set; }

		// @property (assign, nonatomic) _Bool asyncFetching;
		[Export ("asyncFetching", ArgumentSemantic.UnsafeUnretained)]
		bool AsyncFetching { get; set; }

		// @property (assign, nonatomic) NSTimeInterval viewUpdatePeriod;
		[Export ("viewUpdatePeriod", ArgumentSemantic.UnsafeUnretained)]
		double ViewUpdatePeriod { get; set; }

		// @property (assign, nonatomic) float minUpdateDist;
		[Export ("minUpdateDist", ArgumentSemantic.UnsafeUnretained)]
		float MinUpdateDist { get; set; }

		// @property (assign, nonatomic) _Bool waitLoad;
		[Export ("waitLoad", ArgumentSemantic.UnsafeUnretained)]
		bool WaitLoad { get; set; }

		// @property (assign, nonatomic) NSTimeInterval waitLoadTimeout;
		[Export ("waitLoadTimeout", ArgumentSemantic.UnsafeUnretained)]
		double WaitLoadTimeout { get; set; }

		// @property (assign, nonatomic) unsigned int imageDepth;
		[Export ("imageDepth", ArgumentSemantic.UnsafeUnretained)]
		uint ImageDepth { get; set; }

		// @property (assign, nonatomic) float currentImage;
		[Export ("currentImage", ArgumentSemantic.UnsafeUnretained)]
		float CurrentImage { get; set; }

		// @property (assign, nonatomic) float maxCurrentImage;
		[Export ("maxCurrentImage", ArgumentSemantic.UnsafeUnretained)]
		float MaxCurrentImage { get; set; }

		// @property (assign, nonatomic) float animationPeriod;
		[Export ("animationPeriod", ArgumentSemantic.UnsafeUnretained)]
		float AnimationPeriod { get; set; }

		// @property (assign, nonatomic) _Bool animationWrap;
		[Export ("animationWrap", ArgumentSemantic.UnsafeUnretained)]
		bool AnimationWrap { get; set; }

		// @property (assign, nonatomic) _Bool includeElevAttrForShader;
		[Export ("includeElevAttrForShader", ArgumentSemantic.UnsafeUnretained)]
		bool IncludeElevAttrForShader { get; set; }

		// @property (assign, nonatomic) _Bool useElevAsZ;
		[Export ("useElevAsZ", ArgumentSemantic.UnsafeUnretained)]
		bool UseElevAsZ { get; set; }

		// @property (assign, nonatomic) _Bool requireElev;
		[Export ("requireElev", ArgumentSemantic.UnsafeUnretained)]
		bool RequireElev { get; set; }

		// @property (nonatomic) UIColor * color;
		[Export ("color")]
		UIColor Color { get; set; }

		// @property (nonatomic) int maxTiles;
		[Export ("maxTiles")]
		int MaxTiles { get; set; }

		// @property (nonatomic) float importanceScale;
		[Export ("importanceScale")]
		float ImportanceScale { get; set; }

		// @property (nonatomic) NSString * shaderProgramName;
		[Export ("shaderProgramName")]
		string ShaderProgramName { get; set; }

		// @property (nonatomic) unsigned int texturAtlasSize;
		[Export ("texturAtlasSize")]
		uint TexturAtlasSize { get; set; }

		// @property (nonatomic) MaplyQuadImageFormat imageFormat;
		[Export ("imageFormat")]
		MaplyQuadImageFormat ImageFormat { get; set; }

		// @property (nonatomic) int borderTexel;
		[Export ("borderTexel")]
		int BorderTexel { get; set; }

		// @property (nonatomic) _Bool flipY;
		[Export ("flipY")]
		bool FlipY { get; set; }

		// @property (nonatomic) _Bool useTargetZoomLevel;
		[Export ("useTargetZoomLevel")]
		bool UseTargetZoomLevel { get; set; }

		// @property (nonatomic) _Bool singleLevelLoading;
		[Export ("singleLevelLoading")]
		bool SingleLevelLoading { get; set; }

		// @property (nonatomic) NSArray * multilLevelLoads;
		[Export ("multilLevelLoads")]
		NSObject [] MultilLevelLoads { get; set; }

		// -(int)targetZoomLevel;
		[Export ("targetZoomLevel")]
		int TargetZoomLevel ();

		// -(void)reload;
		[Export ("reload")]
		void Reload ();

		// -(void)loadedImages:(id)images forTile:(MaplyTileID)tileID;
		[Export ("loadedImages:forTile:")]
		void LoadedImages (NSObject images, MaplyTileID tileID);

		// -(void)loadedImages:(id)images forTile:(MaplyTileID)tileID frame:(int)frame;
		[Export ("loadedImages:forTile:frame:")]
		void LoadedImages (NSObject images, MaplyTileID tileID, int frame);

		// -(void)loadError:(NSError *)error forTile:(MaplyTileID)tileID;
		[Export ("loadError:forTile:")]
		void LoadError (NSError error, MaplyTileID tileID);

		// -(void)reset;
		[Export ("reset")]
		void Reset ();
	}

	// @interface MaplyTexture : NSObject
	[BaseType (typeof (NSObject))]
	interface MaplyTexture {

	}

	// @interface MaplyBaseViewController : UIViewController
	[BaseType (typeof (UIViewController))]
	interface MaplyBaseViewController {

		// @property (assign, nonatomic) _Bool selection;
		[Export ("selection", ArgumentSemantic.UnsafeUnretained)]
		bool Selection { get; set; }

		// @property (nonatomic, strong) UIColor * clearColor;
		[Export ("clearColor", ArgumentSemantic.Retain)]
		UIColor ClearColor { get; set; }

		// @property (assign, nonatomic) int frameInterval;
		[Export ("frameInterval", ArgumentSemantic.UnsafeUnretained)]
		int FrameInterval { get; set; }

		// @property (nonatomic, weak) NSObject<MaplyElevationSourceDelegate> * elevDelegate;
		[Export ("elevDelegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakElevDelegate { get; set; }

		// @property (nonatomic, weak) NSObject<MaplyElevationSourceDelegate> * elevDelegate;
		[Wrap ("WeakElevDelegate")]
		NSObject ElevDelegate { get; set; }

		// @property (assign, nonatomic) _Bool threadPerLayer;
		[Export ("threadPerLayer", ArgumentSemantic.UnsafeUnretained)]
		bool ThreadPerLayer { get; set; }

		// @property (assign, nonatomic) _Bool performanceOutput;
		[Export ("performanceOutput", ArgumentSemantic.UnsafeUnretained)]
		bool PerformanceOutput { get; set; }

		// -(void)clearLights;
		[Export ("clearLights")]
		void ClearLights ();

		// -(void)addLight:(MaplyLight *)light;
		[Export ("addLight:")]
		void AddLight (MaplyLight light);

		// -(void)removeLight:(MaplyLight *)light;
		[Export ("removeLight:")]
		void RemoveLight (MaplyLight light);

		// -(void)setHints:(NSDictionary *)hintsDict;
		[Export ("setHints:")]
		void SetHints (NSDictionary hintsDict);

		// -(MaplyComponentObject *)addScreenMarkers:(NSArray *)markers desc:(NSDictionary *)desc;
		[Export ("addScreenMarkers:desc:")]
		MaplyComponentObject AddScreenMarkers (NSObject [] markers, NSDictionary desc);

		// -(MaplyComponentObject *)addScreenMarkers:(NSArray *)markers desc:(NSDictionary *)desc mode:(MaplyThreadMode)threadMode;
		[Export ("addScreenMarkers:desc:mode:")]
		MaplyComponentObject AddScreenMarkers (NSObject [] markers, NSDictionary desc, MaplyThreadMode threadMode);

		// -(MaplyComponentObject *)addMarkers:(NSArray *)markers desc:(NSDictionary *)desc;
		[Export ("addMarkers:desc:")]
		MaplyComponentObject AddMarkers (NSObject [] markers, NSDictionary desc);

		// -(MaplyComponentObject *)addMarkers:(NSArray *)markers desc:(NSDictionary *)desc mode:(MaplyThreadMode)threadMode;
		[Export ("addMarkers:desc:mode:")]
		MaplyComponentObject AddMarkers (NSObject [] markers, NSDictionary desc, MaplyThreadMode threadMode);

		// -(MaplyComponentObject *)addScreenLabels:(NSArray *)labels desc:(NSDictionary *)desc;
		[Export ("addScreenLabels:desc:")]
		MaplyComponentObject AddScreenLabels (NSObject [] labels, NSDictionary desc);

		// -(MaplyComponentObject *)addScreenLabels:(NSArray *)labels desc:(NSDictionary *)desc mode:(MaplyThreadMode)threadMode;
		[Export ("addScreenLabels:desc:mode:")]
		MaplyComponentObject AddScreenLabels (NSObject [] labels, NSDictionary desc, MaplyThreadMode threadMode);

		// -(MaplyComponentObject *)addLabels:(NSArray *)labels desc:(NSDictionary *)desc;
		[Export ("addLabels:desc:")]
		MaplyComponentObject AddLabels (NSObject [] labels, NSDictionary desc);

		// -(MaplyComponentObject *)addLabels:(NSArray *)labels desc:(NSDictionary *)desc mode:(MaplyThreadMode)threadMode;
		[Export ("addLabels:desc:mode:")]
		MaplyComponentObject AddLabels (NSObject [] labels, NSDictionary desc, MaplyThreadMode threadMode);

		// -(MaplyComponentObject *)addVectors:(NSArray *)vectors desc:(NSDictionary *)desc;
		[Export ("addVectors:desc:")]
		MaplyComponentObject AddVectors (NSObject [] vectors, NSDictionary desc);

		// -(MaplyComponentObject *)addVectors:(NSArray *)vectors desc:(NSDictionary *)desc mode:(MaplyThreadMode)threadMode;
		[Export ("addVectors:desc:mode:")]
		MaplyComponentObject AddVectors (NSObject [] vectors, NSDictionary desc, MaplyThreadMode threadMode);

		// -(MaplyComponentObject *)instanceVectors:(MaplyComponentObject *)baseObj desc:(NSDictionary *)desc mode:(MaplyThreadMode)threadMode;
		[Export ("instanceVectors:desc:mode:")]
		MaplyComponentObject InstanceVectors (MaplyComponentObject baseObj, NSDictionary desc, MaplyThreadMode threadMode);

		// -(MaplyComponentObject *)addWideVectors:(NSArray *)vectors desc:(NSDictionary *)desc mode:(MaplyThreadMode)threadMode;
		[Export ("addWideVectors:desc:mode:")]
		MaplyComponentObject AddWideVectors (NSObject [] vectors, NSDictionary desc, MaplyThreadMode threadMode);

		// -(MaplyComponentObject *)addWideVectors:(NSArray *)vectors desc:(NSDictionary *)desc;
		[Export ("addWideVectors:desc:")]
		MaplyComponentObject AddWideVectors (NSObject [] vectors, NSDictionary desc);

		// -(MaplyComponentObject *)addShapes:(NSArray *)shapes desc:(NSDictionary *)desc;
		[Export ("addShapes:desc:")]
		MaplyComponentObject AddShapes (NSObject [] shapes, NSDictionary desc);

		// -(MaplyComponentObject *)addShapes:(NSArray *)shapes desc:(NSDictionary *)desc mode:(MaplyThreadMode)threadMode;
		[Export ("addShapes:desc:mode:")]
		MaplyComponentObject AddShapes (NSObject [] shapes, NSDictionary desc, MaplyThreadMode threadMode);

		// -(MaplyComponentObject *)addStickers:(NSArray *)stickers desc:(NSDictionary *)desc;
		[Export ("addStickers:desc:")]
		MaplyComponentObject AddStickers (NSObject [] stickers, NSDictionary desc);

		// -(MaplyComponentObject *)addStickers:(NSArray *)stickers desc:(NSDictionary *)desc mode:(MaplyThreadMode)threadMode;
		[Export ("addStickers:desc:mode:")]
		MaplyComponentObject AddStickers (NSObject [] stickers, NSDictionary desc, MaplyThreadMode threadMode);

		// -(void)changeSticker:(MaplyComponentObject *)compObj desc:(NSDictionary *)desc mode:(MaplyThreadMode)threadMode;
		[Export ("changeSticker:desc:mode:")]
		void ChangeSticker (MaplyComponentObject compObj, NSDictionary desc, MaplyThreadMode threadMode);

		// -(MaplyComponentObject *)addBillboards:(NSArray *)billboards desc:(NSDictionary *)desc mode:(MaplyThreadMode)threadMode;
		[Export ("addBillboards:desc:mode:")]
		MaplyComponentObject AddBillboards (NSObject [] billboards, NSDictionary desc, MaplyThreadMode threadMode);

		// -(MaplyComponentObject *)addSelectionVectors:(NSArray *)vectors;
		[Export ("addSelectionVectors:")]
		MaplyComponentObject AddSelectionVectors (NSObject [] vectors);

		// -(void)changeVector:(MaplyComponentObject *)compObj desc:(NSDictionary *)desc;
		[Export ("changeVector:desc:")]
		void ChangeVector (MaplyComponentObject compObj, NSDictionary desc);

		// -(MaplyComponentObject *)addLoftedPolys:(NSArray *)polys key:(NSString *)key cache:(MaplyVectorDatabase *)cacheDb desc:(NSDictionary *)desc;
		[Export ("addLoftedPolys:key:cache:desc:")]
		MaplyComponentObject AddLoftedPolys (NSObject [] polys, string key, MaplyVectorDatabase cacheDb, NSDictionary desc);

		// -(void)addViewTracker:(MaplyViewTracker *)viewTrack;
		[Export ("addViewTracker:")]
		void AddViewTracker (MaplyViewTracker viewTrack);

		// -(void)addAnnotation:(MaplyAnnotation *)annotate forPoint:(MaplyCoordinate)coord offset:(CGPoint)offset;
		[Export ("addAnnotation:forPoint:offset:")]
		void AddAnnotation (MaplyAnnotation annotate, MaplyCoordinate coord, CGPoint offset);

		// -(void)removeAnnotation:(MaplyAnnotation *)annotate;
		[Export ("removeAnnotation:")]
		void RemoveAnnotation (MaplyAnnotation annotate);

		// -(void)freezeAnnotation:(MaplyAnnotation *)annotate;
		[Export ("freezeAnnotation:")]
		void FreezeAnnotation (MaplyAnnotation annotate);

		// -(void)unfreezeAnnotation:(MaplyAnnotation *)annotate;
		[Export ("unfreezeAnnotation:")]
		void UnfreezeAnnotation (MaplyAnnotation annotate);

		// -(void)clearAnnotations;
		[Export ("clearAnnotations")]
		void ClearAnnotations ();

		// -(NSArray *)annotations;
		[Export ("annotations")]
		NSObject [] Annotations ();

		// -(void)removeViewTrackForView:(UIView *)view;
		[Export ("removeViewTrackForView:")]
		void RemoveViewTrackForView (UIView view);

		// -(CGPoint)screenPointFromGeo:(MaplyCoordinate)geoCoord;
		[Export ("screenPointFromGeo:")]
		CGPoint ScreenPointFromGeo (MaplyCoordinate geoCoord);

		// -(_Bool)animateToPosition:(MaplyCoordinate)newPos onScreen:(CGPoint)loc time:(NSTimeInterval)howLong;
		[Export ("animateToPosition:onScreen:time:")]
		bool AnimateToPosition (MaplyCoordinate newPos, CGPoint loc, double howLong);

		// -(MaplyTexture *)addTexture:(UIImage *)image imageFormat:(MaplyQuadImageFormat)imageFormat wrapFlags:(int)wrapFlags mode:(MaplyThreadMode)threadMode;
		[Export ("addTexture:imageFormat:wrapFlags:mode:")]
		MaplyTexture AddTexture (UIImage image, MaplyQuadImageFormat imageFormat, int wrapFlags, MaplyThreadMode threadMode);

		// -(void)removeTexture:(MaplyTexture *)image mode:(MaplyThreadMode)threadMode;
		[Export ("removeTexture:mode:")]
		void RemoveTexture (MaplyTexture image, MaplyThreadMode threadMode);

		// -(void)setMaxLayoutObjects:(int)maxLayoutObjects;
		[Export ("setMaxLayoutObjects:")]
		void SetMaxLayoutObjects (int maxLayoutObjects);

		// -(void)removeObject:(MaplyComponentObject *)theObj;
		[Export ("removeObject:")]
		void RemoveObject (MaplyComponentObject theObj);

		// -(void)removeObjects:(NSArray *)theObjs;
		[Export ("removeObjects:")]
		void RemoveObjects (NSObject [] theObjs);

		// -(void)removeObjects:(NSArray *)theObjs mode:(MaplyThreadMode)threadMode;
		[Export ("removeObjects:mode:")]
		void RemoveObjects (NSObject [] theObjs, MaplyThreadMode threadMode);

		// -(void)disableObjects:(NSArray *)theObjs mode:(MaplyThreadMode)threadMode;
		[Export ("disableObjects:mode:")]
		void DisableObjects (NSObject [] theObjs, MaplyThreadMode threadMode);

		// -(void)enableObjects:(NSArray *)theObjs mode:(MaplyThreadMode)threadMode;
		[Export ("enableObjects:mode:")]
		void EnableObjects (NSObject [] theObjs, MaplyThreadMode threadMode);

		// -(void)startChanges;
		[Export ("startChanges")]
		void StartChanges ();

		// -(void)endChanges;
		[Export ("endChanges")]
		void EndChanges ();

		// -(void)addActiveObject:(MaplyActiveObject *)theObj;
		[Export ("addActiveObject:")]
		void AddActiveObject (MaplyActiveObject theObj);

		// -(void)removeActiveObject:(MaplyActiveObject *)theObj;
		[Export ("removeActiveObject:")]
		void RemoveActiveObject (MaplyActiveObject theObj);

		// -(void)removeActiveObjects:(NSArray *)theObjs;
		[Export ("removeActiveObjects:")]
		void RemoveActiveObjects (NSObject [] theObjs);

		// -(_Bool)addLayer:(MaplyViewControllerLayer *)layer;
		[Export ("addLayer:")]
		bool AddLayer (MaplyViewControllerLayer layer);

		// -(void)removeLayer:(MaplyViewControllerLayer *)layer;
		[Export ("removeLayer:")]
		void RemoveLayer (MaplyViewControllerLayer layer);

		// -(void)removeLayers:(NSArray *)layers;
		[Export ("removeLayers:")]
		void RemoveLayers (NSObject [] layers);

		// -(void)removeAllLayers;
		[Export ("removeAllLayers")]
		void RemoveAllLayers ();

		// -(MaplyCoordinate3d)displayPointFromGeo:(MaplyCoordinate)geoCoord;
		[Export ("displayPointFromGeo:")]
		MaplyCoordinate3d DisplayPointFromGeo (MaplyCoordinate geoCoord);

		// -(void)startAnimation;
		[Export ("startAnimation")]
		void StartAnimation ();

		// -(void)stopAnimation;
		[Export ("stopAnimation")]
		void StopAnimation ();

		// -(void)addShaderProgram:(MaplyShader *)shader sceneName:(NSString *)sceneName;
		[Export ("addShaderProgram:sceneName:")]
		void AddShaderProgram (MaplyShader shader, string sceneName);

		// -(MaplyShader *)getShaderByName:(NSString *)name;
		[Export ("getShaderByName:")]
		MaplyShader GetShaderByName (string name);

		// -(float)currentMapScale;
		[Export ("currentMapScale")]
		float CurrentMapScale ();

		// -(float)heightForMapScale:(float)scale;
		[Export ("heightForMapScale:")]
		float HeightForMapScale (float scale);

		// -(UIImage *)snapshot;
		[Export ("snapshot")]
		UIImage Snapshot ();

		// -(float)currentMapZoom:(MaplyCoordinate)coordinate;
		[Export ("currentMapZoom:")]
		float CurrentMapZoom (MaplyCoordinate coordinate);

		// -(MaplyCoordinateSystem *)coordSystem;
		[Export ("coordSystem")]
		MaplyCoordinateSystem CoordSystem ();
	}

	// @interface MaplyLabel : NSObject
	[BaseType (typeof (NSObject))]
	interface MaplyLabel {

		// @property (assign, nonatomic) MaplyCoordinate loc;
		[Export ("loc", ArgumentSemantic.UnsafeUnretained)]
		MaplyCoordinate Loc { get; set; }

		// @property (assign, nonatomic) CGSize size;
		[Export ("size", ArgumentSemantic.UnsafeUnretained)]
		CGSize Size { get; set; }

		// @property (nonatomic, strong) NSString * text;
		[Export ("text", ArgumentSemantic.Retain)]
		string Text { get; set; }

		// @property (nonatomic, strong) id iconImage;
		[Export ("iconImage", ArgumentSemantic.Retain)]
		NSObject IconImage { get; set; }

		// @property (nonatomic, strong) UIColor * color;
		[Export ("color", ArgumentSemantic.Retain)]
		UIColor Color { get; set; }

		// @property (assign, nonatomic) _Bool selectable;
		[Export ("selectable", ArgumentSemantic.UnsafeUnretained)]
		bool Selectable { get; set; }

		// @property (assign, nonatomic) MaplyLabelJustify justify;
		[Export ("justify", ArgumentSemantic.UnsafeUnretained)]
		MaplyLabelJustify Justify { get; set; }

		// @property (nonatomic, strong) NSObject * userObject;
		[Export ("userObject", ArgumentSemantic.Retain)]
		NSObject UserObject { get; set; }
	}

	// @interface MaplyScreenLabel : NSObject
	[BaseType (typeof (NSObject))]
	interface MaplyScreenLabel {

		// @property (assign, nonatomic) MaplyCoordinate loc;
		[Export ("loc", ArgumentSemantic.UnsafeUnretained)]
		MaplyCoordinate Loc { get; set; }

		// @property (assign, nonatomic) float rotation;
		[Export ("rotation", ArgumentSemantic.UnsafeUnretained)]
		float Rotation { get; set; }

		// @property (assign, nonatomic) _Bool keepUpright;
		[Export ("keepUpright", ArgumentSemantic.UnsafeUnretained)]
		bool KeepUpright { get; set; }

		// @property (nonatomic, strong) NSString * text;
		[Export ("text", ArgumentSemantic.Retain)]
		string Text { get; set; }

		// @property (nonatomic, strong) UIImage * iconImage;
		[Export ("iconImage", ArgumentSemantic.Retain)]
		UIImage IconImage { get; set; }

		// @property (assign, nonatomic) CGSize iconSize;
		[Export ("iconSize", ArgumentSemantic.UnsafeUnretained)]
		CGSize IconSize { get; set; }

		// @property (assign, nonatomic) CGPoint offset;
		[Export ("offset", ArgumentSemantic.UnsafeUnretained)]
		CGPoint Offset { get; set; }

		// @property (nonatomic, strong) UIColor * color;
		[Export ("color", ArgumentSemantic.Retain)]
		UIColor Color { get; set; }

		// @property (assign, nonatomic) _Bool selectable;
		[Export ("selectable", ArgumentSemantic.UnsafeUnretained)]
		bool Selectable { get; set; }

		// @property (assign, nonatomic) float layoutImportance;
		[Export ("layoutImportance", ArgumentSemantic.UnsafeUnretained)]
		float LayoutImportance { get; set; }

		// @property (assign, nonatomic) int layoutPlacement;
		[Export ("layoutPlacement", ArgumentSemantic.UnsafeUnretained)]
		int LayoutPlacement { get; set; }

		// @property (nonatomic, strong) NSObject * userObject;
		[Export ("userObject", ArgumentSemantic.Retain)]
		NSObject UserObject { get; set; }
	}

	// @interface MaplyMarker : NSObject
	[BaseType (typeof (NSObject))]
	interface MaplyMarker {

		// @property (assign, nonatomic) MaplyCoordinate loc;
		[Export ("loc", ArgumentSemantic.UnsafeUnretained)]
		MaplyCoordinate Loc { get; set; }

		// @property (assign, nonatomic) CGSize size;
		[Export ("size", ArgumentSemantic.UnsafeUnretained)]
		CGSize Size { get; set; }

		// @property (nonatomic, strong) id image;
		[Export ("image", ArgumentSemantic.Retain)]
		NSObject Image { get; set; }

		// @property (assign, nonatomic) _Bool selectable;
		[Export ("selectable", ArgumentSemantic.UnsafeUnretained)]
		bool Selectable { get; set; }

		// @property (nonatomic, strong) NSObject * userObject;
		[Export ("userObject", ArgumentSemantic.Retain)]
		NSObject UserObject { get; set; }
	}

	// @interface MaplyShape : NSObject
	[BaseType (typeof (NSObject))]
	interface MaplyShape {

		// @property (nonatomic, strong) UIColor * color;
		[Export ("color", ArgumentSemantic.Retain)]
		UIColor Color { get; set; }

		// @property (nonatomic, strong) NSObject * userObject;
		[Export ("userObject", ArgumentSemantic.Retain)]
		NSObject UserObject { get; set; }
	}

	// @interface MaplyShapeCircle : MaplyShape
	[BaseType (typeof (MaplyShape))]
	interface MaplyShapeCircle {

		// @property (assign, nonatomic) MaplyCoordinate center;
		[Export ("center", ArgumentSemantic.UnsafeUnretained)]
		MaplyCoordinate Center { get; set; }

		// @property (assign, nonatomic) float radius;
		[Export ("radius", ArgumentSemantic.UnsafeUnretained)]
		float Radius { get; set; }

		// @property (assign, nonatomic) float height;
		[Export ("height", ArgumentSemantic.UnsafeUnretained)]
		float Height { get; set; }
	}

	// @interface MaplyShapeSphere : MaplyShape
	[BaseType (typeof (MaplyShape))]
	interface MaplyShapeSphere {

		// @property (assign, nonatomic) MaplyCoordinate center;
		[Export ("center", ArgumentSemantic.UnsafeUnretained)]
		MaplyCoordinate Center { get; set; }

		// @property (assign, nonatomic) float radius;
		[Export ("radius", ArgumentSemantic.UnsafeUnretained)]
		float Radius { get; set; }

		// @property (assign, nonatomic) float height;
		[Export ("height", ArgumentSemantic.UnsafeUnretained)]
		float Height { get; set; }

		// @property (assign, nonatomic) _Bool selectable;
		[Export ("selectable", ArgumentSemantic.UnsafeUnretained)]
		bool Selectable { get; set; }
	}

	// @interface MaplyShapeCylinder : MaplyShape
	[BaseType (typeof (MaplyShape))]
	interface MaplyShapeCylinder {

		// @property (assign, nonatomic) MaplyCoordinate baseCenter;
		[Export ("baseCenter", ArgumentSemantic.UnsafeUnretained)]
		MaplyCoordinate BaseCenter { get; set; }

		// @property (assign, nonatomic) float baseHeight;
		[Export ("baseHeight", ArgumentSemantic.UnsafeUnretained)]
		float BaseHeight { get; set; }

		// @property (assign, nonatomic) float radius;
		[Export ("radius", ArgumentSemantic.UnsafeUnretained)]
		float Radius { get; set; }

		// @property (assign, nonatomic) float height;
		[Export ("height", ArgumentSemantic.UnsafeUnretained)]
		float Height { get; set; }

		// @property (assign, nonatomic) _Bool selectable;
		[Export ("selectable", ArgumentSemantic.UnsafeUnretained)]
		bool Selectable { get; set; }
	}

	// @interface MaplyShapeGreatCircle : MaplyShape
	[BaseType (typeof (MaplyShape))]
	interface MaplyShapeGreatCircle {

		// @property (assign, nonatomic) MaplyCoordinate startPt;
		[Export ("startPt", ArgumentSemantic.UnsafeUnretained)]
		MaplyCoordinate StartPt { get; set; }

		// @property (assign, nonatomic) MaplyCoordinate endPt;
		[Export ("endPt", ArgumentSemantic.UnsafeUnretained)]
		MaplyCoordinate EndPt { get; set; }

		// @property (assign, nonatomic) float height;
		[Export ("height", ArgumentSemantic.UnsafeUnretained)]
		float Height { get; set; }

		// @property (assign, nonatomic) float lineWidth;
		[Export ("lineWidth", ArgumentSemantic.UnsafeUnretained)]
		float LineWidth { get; set; }

		// -(float)calcAngleBetween;
		[Export ("calcAngleBetween")]
		float CalcAngleBetween ();
	}

	// @interface MaplyShapeLinear : MaplyShape
	[BaseType (typeof (MaplyShape))]
	interface MaplyShapeLinear {

		// -(id)initWithCoords:(MaplyCoordinate3d *)coords numCoords:(int)numCoords;
		[Export ("initWithCoords:numCoords:")]
		IntPtr Constructor (MaplyCoordinate3d coords, int numCoords);

		// @property (assign, nonatomic) float lineWidth;
		[Export ("lineWidth", ArgumentSemantic.UnsafeUnretained)]
		float LineWidth { get; set; }

		// -(int)getCoords:(MaplyCoordinate3d **)retCoords;
		[Export ("getCoords:")]
		int GetCoords (MaplyCoordinate3d retCoords);
	}

	// @interface MaplySticker : NSObject
	[BaseType (typeof (NSObject))]
	interface MaplySticker {

		// @property (assign, nonatomic) MaplyCoordinate ll;
		[Export ("ll", ArgumentSemantic.UnsafeUnretained)]
		MaplyCoordinate Ll { get; set; }

		// @property (assign, nonatomic) MaplyCoordinate ur;
		[Export ("ur", ArgumentSemantic.UnsafeUnretained)]
		MaplyCoordinate Ur { get; set; }

		// @property (assign, nonatomic) float rotation;
		[Export ("rotation", ArgumentSemantic.UnsafeUnretained)]
		float Rotation { get; set; }

		// @property (nonatomic) MaplyCoordinateSystem * coordSys;
		[Export ("coordSys")]
		MaplyCoordinateSystem CoordSys { get; set; }

		// @property (nonatomic, strong) id image;
		[Export ("image", ArgumentSemantic.Retain)]
		NSObject Image { get; set; }

		// @property (nonatomic) NSArray * images;
		[Export ("images")]
		NSObject [] Images { get; set; }

		// @property (nonatomic) MaplyQuadImageFormat imageFormat;
		[Export ("imageFormat")]
		MaplyQuadImageFormat ImageFormat { get; set; }
	}

	// @interface MaplyBillboard : NSObject
	[BaseType (typeof (NSObject))]
	interface MaplyBillboard {

		// @property (nonatomic) MaplyCoordinate3d center;
		[Export ("center")]
		MaplyCoordinate3d Center { get; set; }

		// @property (nonatomic) CGSize size;
		[Export ("size")]
		CGSize Size { get; set; }

		// @property (nonatomic) UIColor * color;
		[Export ("color")]
		UIColor Color { get; set; }

		// @property (nonatomic, strong) id image;
		[Export ("image", ArgumentSemantic.Retain)]
		NSObject Image { get; set; }

		// @property (nonatomic) _Bool selectable;
		[Export ("selectable")]
		bool Selectable { get; set; }
	}

	// @protocol MaplyViewControllerDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface MaplyViewControllerDelegate {

		// @optional -(void)maplyViewController:(MaplyViewController *)viewC didSelect:(NSObject *)selectedObj;
		[Export ("maplyViewController:didSelect:")]
		void DidSelect (MaplyViewController viewC, NSObject selectedObj);

		// @optional -(void)maplyViewController:(MaplyViewController *)viewC didSelect:(NSObject *)selectedObj atLoc:(WGCoordinate)coord onScreen:(CGPoint)screenPt;
		[Export ("maplyViewController:didSelect:atLoc:onScreen:")]
		void DidSelect (MaplyViewController viewC, NSObject selectedObj, WGCoordinate coord, CGPoint screenPt);

		// @optional -(void)maplyViewController:(MaplyViewController *)viewC didTapAt:(MaplyCoordinate)coord;
		[Export ("maplyViewController:didTapAt:")]
		void DidTapAt (MaplyViewController viewC, MaplyCoordinate coord);

		// @optional -(void)maplyViewControllerDidStartMoving:(MaplyViewController *)viewC userMotion:(_Bool)userMotion;
		[Export ("maplyViewControllerDidStartMoving:userMotion:")]
		void UserMotion (MaplyViewController viewC, bool userMotion);

		// @optional -(void)maplyViewController:(MaplyViewController *)viewC didStopMoving:(MaplyCoordinate *)corners userMotion:(_Bool)userMotion;
		[Export ("maplyViewController:didStopMoving:userMotion:")]
		void DidStopMoving (MaplyViewController viewC, MaplyCoordinate corners, bool userMotion);

		// @optional -(void)maplyViewController:(MaplyViewController *)viewC didTapAnnotation:(MaplyAnnotation *)annotation;
		[Export ("maplyViewController:didTapAnnotation:")]
		void DidTapAnnotation (MaplyViewController viewC, MaplyAnnotation annotation);

		// @optional -(void)maplyViewController:(MaplyViewController *)viewC didClickAnnotation:(MaplyAnnotation *)annotation;
		[Export ("maplyViewController:didClickAnnotation:")]
		void DidClickAnnotation (MaplyViewController viewC, MaplyAnnotation annotation);
	}

	// @interface MaplyViewController : MaplyBaseViewController
	[BaseType (typeof (MaplyBaseViewController))]
	interface MaplyViewController {

		// -(id)initAsTetheredFlatMap:(UIScrollView *)scrollView tetherView:(UIView *)tetherView;
		[Export ("initAsTetheredFlatMap:tetherView:")]
		IntPtr Constructor (UIScrollView scrollView, UIView tetherView);

		// @property (readonly, nonatomic) _Bool flatMode;
		[Export ("flatMode")]
		bool FlatMode { get; }

		// @property (nonatomic, weak) UIView * tetherView;
		[Export ("tetherView", ArgumentSemantic.Weak)]
		UIView TetherView { get; set; }

		// @property (assign, nonatomic) _Bool tetheredMode;
		[Export ("tetheredMode", ArgumentSemantic.UnsafeUnretained)]
		bool TetheredMode { get; set; }

		// @property (nonatomic) MaplyCoordinateSystem * coordSys;
		[Export ("coordSys")]
		MaplyCoordinateSystem CoordSys { get; set; }

		// @property (nonatomic) MaplyCoordinate3d displayCenter;
		[Export ("displayCenter")]
		MaplyCoordinate3d DisplayCenter { get; set; }

		// @property (assign, nonatomic) _Bool pinchGesture;
		[Export ("pinchGesture", ArgumentSemantic.UnsafeUnretained)]
		bool PinchGesture { get; set; }

		// @property (assign, nonatomic) _Bool rotateGesture;
		[Export ("rotateGesture", ArgumentSemantic.UnsafeUnretained)]
		bool RotateGesture { get; set; }

		// @property (assign, nonatomic) _Bool panGesture;
		[Export ("panGesture", ArgumentSemantic.UnsafeUnretained)]
		bool PanGesture { get; set; }

		// @property (assign, nonatomic) _Bool doubleTapZoomGesture;
		[Export ("doubleTapZoomGesture", ArgumentSemantic.UnsafeUnretained)]
		bool DoubleTapZoomGesture { get; set; }

		// @property (assign, nonatomic) _Bool twoFingerTapGesture;
		[Export ("twoFingerTapGesture", ArgumentSemantic.UnsafeUnretained)]
		bool TwoFingerTapGesture { get; set; }

		// @property (assign, nonatomic) _Bool doubleTapDragGesture;
		[Export ("doubleTapDragGesture", ArgumentSemantic.UnsafeUnretained)]
		bool DoubleTapDragGesture { get; set; }

		// @property (assign, nonatomic) _Bool cancelAnimationOnTouch;
		[Export ("cancelAnimationOnTouch", ArgumentSemantic.UnsafeUnretained)]
		bool CancelAnimationOnTouch { get; set; }

		// @property (assign, nonatomic) float heading;
		[Export ("heading", ArgumentSemantic.UnsafeUnretained)]
		float Heading { get; set; }

		// @property (assign, nonatomic) _Bool autoMoveToTap;
		[Export ("autoMoveToTap", ArgumentSemantic.UnsafeUnretained)]
		bool AutoMoveToTap { get; set; }

		// @property (nonatomic, weak) NSObject<MaplyViewControllerDelegate> * delegate;
		[Export ("delegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, weak) NSObject<MaplyViewControllerDelegate> * delegate;
		[Wrap ("WeakDelegate")]
		NSObject Delegate { get; set; }

		// @property (assign, nonatomic) float height;
		[Export ("height", ArgumentSemantic.UnsafeUnretained)]
		float Height { get; set; }

		// @property (assign, nonatomic) _Bool viewWrap;
		[Export ("viewWrap", ArgumentSemantic.UnsafeUnretained)]
		bool ViewWrap { get; set; }

		// -(void)resetTetheredFlatMap:(UIScrollView *)scrollView tetherView:(UIView *)tetherView;
		[Export ("resetTetheredFlatMap:tetherView:")]
		void ResetTetheredFlatMap (UIScrollView scrollView, UIView tetherView);

		// -(void)getViewExtentsLL:(MaplyCoordinate *)ll ur:(MaplyCoordinate *)ur;
		[Export ("getViewExtentsLL:ur:")]
		void GetViewExtentsLL (MaplyCoordinate ll, MaplyCoordinate ur);

		// -(void)setViewExtentsLL:(MaplyCoordinate)ll ur:(MaplyCoordinate)ur;
		[Export ("setViewExtentsLL:ur:")]
		void SetViewExtentsLL (MaplyCoordinate ll, MaplyCoordinate ur);

		// -(void)animateToPosition:(MaplyCoordinate)newPos time:(NSTimeInterval)howLong;
		[Export ("animateToPosition:time:")]
		void AnimateToPosition (MaplyCoordinate newPos, double howLong);

		// -(void)animateToExtentsWindowSize:(CGSize)windowSize contentOffset:(CGPoint)contentOffset time:(NSTimeInterval)howLong;
		[Export ("animateToExtentsWindowSize:contentOffset:time:")]
		void AnimateToExtentsWindowSize (CGSize windowSize, CGPoint contentOffset, double howLong);

		// -(_Bool)animateToPosition:(MaplyCoordinate)newPos onScreen:(CGPoint)loc time:(NSTimeInterval)howLong;
		[Export ("animateToPosition:onScreen:time:")]
		bool AnimateToPosition (MaplyCoordinate newPos, CGPoint loc, double howLong);

		// -(void)setPosition:(MaplyCoordinate)newPos;
		[Export ("setPosition:")]
		void SetPosition (MaplyCoordinate newPos);

		// -(void)setPosition:(MaplyCoordinate)newPos height:(float)height;
		[Export ("setPosition:height:")]
		void SetPosition (MaplyCoordinate newPos, float height);

		// -(void)getPosition:(MaplyCoordinate *)pos height:(float *)height;
		[Export ("getPosition:height:")]
		void GetPosition (MaplyCoordinate pos, float height);

		// -(void)getZoomLimitsMin:(float *)minHeight max:(float *)maxHeight;
		[Export ("getZoomLimitsMin:max:")]
		void GetZoomLimitsMin (float minHeight, float maxHeight);

		// -(void)setZoomLimitsMin:(float)minHeight max:(float)maxHeight;
		[Export ("setZoomLimitsMin:max:")]
		void SetZoomLimitsMin (float minHeight, float maxHeight);

		// -(MaplyCoordinate)geoFromScreenPoint:(CGPoint)point;
		[Export ("geoFromScreenPoint:")]
		MaplyCoordinate GeoFromScreenPoint (CGPoint point);

		// -(float)findHeightToViewBounds:(MaplyBoundingBox *)bbox pos:(MaplyCoordinate)pos;
		[Export ("findHeightToViewBounds:pos:")]
		float FindHeightToViewBounds (MaplyBoundingBox bbox, MaplyCoordinate pos);

		// -(MaplyBoundingBox)getCurrentExtents;
		[Export ("getCurrentExtents")]
		MaplyBoundingBox GetCurrentExtents ();
	}

	// @protocol MaplyPagingDelegate
	[Protocol, Model]
	interface MaplyPagingDelegate {

		// @required -(int)minZoom;
		[Export ("minZoom")]
		[Abstract]
		int MinZoom ();

		// @required -(int)maxZoom;
		[Export ("maxZoom")]
		[Abstract]
		int MaxZoom ();

		// @required -(void)startFetchForTile:(MaplyTileID)tileID forLayer:(MaplyQuadPagingLayer *)layer;
		[Export ("startFetchForTile:forLayer:")]
		[Abstract]
		void StartFetchForTile (MaplyTileID tileID, MaplyQuadPagingLayer layer);
	}

	// @interface MaplyQuadPagingLayer : MaplyViewControllerLayer
	[BaseType (typeof (MaplyViewControllerLayer))]
	interface MaplyQuadPagingLayer {

		// -(id)initWithCoordSystem:(MaplyCoordinateSystem *)coordSys delegate:(NSObject<MaplyPagingDelegate> *)tileSource;
		[Export ("initWithCoordSystem:delegate:")]
		IntPtr Constructor (MaplyCoordinateSystem coordSys, NSObject tileSource);

		// @property (assign, nonatomic) int numSimultaneousFetches;
		[Export ("numSimultaneousFetches", ArgumentSemantic.UnsafeUnretained)]
		int NumSimultaneousFetches { get; set; }

		// @property (assign, nonatomic) float importance;
		[Export ("importance", ArgumentSemantic.UnsafeUnretained)]
		float Importance { get; set; }

		// @property (nonatomic) _Bool flipY;
		[Export ("flipY")]
		bool FlipY { get; set; }

		// @property (readonly, nonatomic, weak) MaplyBaseViewController * viewC;
		[Export ("viewC", ArgumentSemantic.Weak)]
		MaplyBaseViewController ViewC { get; }

		// @property (nonatomic) _Bool useTargetZoomLevel;
		[Export ("useTargetZoomLevel")]
		bool UseTargetZoomLevel { get; set; }

		// @property (nonatomic) _Bool singleLevelLoading;
		[Export ("singleLevelLoading")]
		bool SingleLevelLoading { get; set; }

		// -(int)targetZoomLevel;
		[Export ("targetZoomLevel")]
		int TargetZoomLevel ();

		// -(void)addData:(NSArray *)dataObjects forTile:(MaplyTileID)tileID;
		[Export ("addData:forTile:")]
		void AddData (NSObject [] dataObjects, MaplyTileID tileID);

		// -(void)addData:(NSArray *)dataObjects forTile:(MaplyTileID)tileID style:(MaplyQuadPagingDataStyle)dataStyle;
		[Export ("addData:forTile:style:")]
		void AddData (NSObject [] dataObjects, MaplyTileID tileID, MaplyQuadPagingDataStyle dataStyle);

		// -(void)tileFailedToLoad:(MaplyTileID)tileID;
		[Export ("tileFailedToLoad:")]
		void TileFailedToLoad (MaplyTileID tileID);

		// -(void)tileDidLoad:(MaplyTileID)tileID;
		[Export ("tileDidLoad:")]
		void TileDidLoad (MaplyTileID tileID);

		// -(void)tile:(MaplyTileID)tileID hasNumParts:(int)numParts;
		[Export ("tile:hasNumParts:")]
		void Tile (MaplyTileID tileID, int numParts);

		// -(void)tileDidLoad:(MaplyTileID)tileID part:(int)whichPart;
		[Export ("tileDidLoad:part:")]
		void TileDidLoad (MaplyTileID tileID, int whichPart);

		// -(void)geoBoundsforTile:(MaplyTileID)tileID ll:(MaplyCoordinate *)ll ur:(MaplyCoordinate *)ur;
		[Export ("geoBoundsforTile:ll:ur:")]
		void GeoBoundsforTile (MaplyTileID tileID, MaplyCoordinate ll, MaplyCoordinate ur);

		// -(void)boundsforTile:(MaplyTileID)tileID ll:(MaplyCoordinate *)ll ur:(MaplyCoordinate *)ur;
		[Export ("boundsforTile:ll:ur:")]
		void BoundsforTile (MaplyTileID tileID, MaplyCoordinate ll, MaplyCoordinate ur);

		// -(void)reload;
		[Export ("reload")]
		void Reload ();

		// -(NSObject<MaplyPagingDelegate> *)pagingDelegate;
		[Export ("pagingDelegate")]
		NSObject PagingDelegate ();
	}

	// @interface MaplyOfflineImage : NSObject
	[BaseType (typeof (NSObject))]
	interface MaplyOfflineImage {

		// @property (nonatomic) MaplyBoundingBox bbox;
		[Export ("bbox")]
		MaplyBoundingBox Bbox { get; set; }

		// @property (nonatomic) NSArray * textures;
		[Export ("textures")]
		NSObject [] Textures { get; set; }

		// @property (nonatomic) CGSize centerSize;
		[Export ("centerSize")]
		CGSize CenterSize { get; set; }
	}

	// @protocol MaplyQuadImageOfflineDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface MaplyQuadImageOfflineDelegate {

		// @required -(void)offlineLayer:(MaplyQuadImageOfflineLayer *)layer images:(MaplyOfflineImage *)offlineImage;
		[Export ("offlineLayer:images:")]
		[Abstract]
		void Images (MaplyQuadImageOfflineLayer layer, MaplyOfflineImage offlineImage);
	}

	// @interface MaplyQuadImageOfflineLayer : MaplyViewControllerLayer
	[BaseType (typeof (MaplyViewControllerLayer))]
	interface MaplyQuadImageOfflineLayer {

		// -(id)initWithCoordSystem:(MaplyCoordinateSystem *)coordSys tileSource:(NSObject<MaplyTileSource> *)tileSource;
		[Export ("initWithCoordSystem:tileSource:")]
		IntPtr Constructor (MaplyCoordinateSystem coordSys, NSObject tileSource);

		// @property (nonatomic) NSObject<MaplyTileSource> * tileSource;
		[Export ("tileSource")]
		NSObject TileSource { get; set; }

		// @property (assign, nonatomic) _Bool on;
		[Export ("on", ArgumentSemantic.UnsafeUnretained)]
		bool On { get; set; }

		// @property (assign, nonatomic) int numSimultaneousFetches;
		[Export ("numSimultaneousFetches", ArgumentSemantic.UnsafeUnretained)]
		int NumSimultaneousFetches { get; set; }

		// @property (assign, nonatomic) unsigned int imageDepth;
		[Export ("imageDepth", ArgumentSemantic.UnsafeUnretained)]
		uint ImageDepth { get; set; }

		// @property (nonatomic) _Bool flipY;
		[Export ("flipY")]
		bool FlipY { get; set; }

		// @property (nonatomic) int maxTiles;
		[Export ("maxTiles")]
		int MaxTiles { get; set; }

		// @property (nonatomic) float importanceScale;
		[Export ("importanceScale")]
		float ImportanceScale { get; set; }

		// @property (nonatomic) int previewLevels;
		[Export ("previewLevels")]
		int PreviewLevels { get; set; }

		// @property (nonatomic) CGSize textureSize;
		[Export ("textureSize")]
		CGSize TextureSize { get; set; }

		// @property (nonatomic) _Bool autoRes;
		[Export ("autoRes")]
		bool AutoRes { get; set; }

		// @property (assign, nonatomic) _Bool asyncFetching;
		[Export ("asyncFetching", ArgumentSemantic.UnsafeUnretained)]
		bool AsyncFetching { get; set; }

		// @property (nonatomic) float period;
		[Export ("period")]
		float Period { get; set; }

		// @property (nonatomic) _Bool singleLevelLoading;
		[Export ("singleLevelLoading")]
		bool SingleLevelLoading { get; set; }

		// @property (nonatomic) MaplyBoundingBox bbox;
		[Export ("bbox")]
		MaplyBoundingBox Bbox { get; set; }

		// @property (nonatomic, weak) NSObject<MaplyQuadImageOfflineDelegate> * delegate;
		[Export ("delegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, weak) NSObject<MaplyQuadImageOfflineDelegate> * delegate;
		[Wrap ("WeakDelegate")]
		NSObject Delegate { get; set; }

		// -(void)reload;
		[Export ("reload")]
		void Reload ();
	}

	// @interface MaplyWMSLayerBoundingBox : NSObject
	[BaseType (typeof (NSObject))]
	interface MaplyWMSLayerBoundingBox {

		// @property (nonatomic) NSString * crs;
		[Export ("crs")]
		string Crs { get; set; }

		// @property (nonatomic) double minx;
		[Export ("minx")]
		double Minx { get; set; }

		// @property (nonatomic) double miny;
		[Export ("miny")]
		double Miny { get; set; }

		// @property (nonatomic) double maxx;
		[Export ("maxx")]
		double Maxx { get; set; }

		// @property (nonatomic) double maxy;
		[Export ("maxy")]
		double Maxy { get; set; }

		// -(MaplyCoordinateSystem *)buildCoordinateSystem;
		[Export ("buildCoordinateSystem")]
		MaplyCoordinateSystem BuildCoordinateSystem ();
	}

	// @interface MaplyWMSStyle : NSObject
	[BaseType (typeof (NSObject))]
	interface MaplyWMSStyle {

		// @property (nonatomic) NSString * name;
		[Export ("name")]
		string Name { get; set; }

		// @property (nonatomic) NSString * title;
		[Export ("title")]
		string Title { get; set; }
	}

	// @interface MaplyWMSLayer : NSObject
	[BaseType (typeof (NSObject))]
	interface MaplyWMSLayer {

		// @property (nonatomic) NSString * name;
		[Export ("name")]
		string Name { get; set; }

		// @property (nonatomic) NSString * title;
		[Export ("title")]
		string Title { get; set; }

		// @property (nonatomic) NSString * abstract;
		[Export ("abstract")]
		string Abstract { get; set; }

		// @property (nonatomic) NSArray * coordRefSystems;
		[Export ("coordRefSystems")]
		NSObject [] CoordRefSystems { get; set; }

		// @property (nonatomic) NSArray * styles;
		[Export ("styles")]
		NSObject [] Styles { get; set; }

		// @property (nonatomic) NSArray * boundingBoxes;
		[Export ("boundingBoxes")]
		NSObject [] BoundingBoxes { get; set; }

		// @property (nonatomic) MaplyCoordinate ll;
		[Export ("ll")]
		MaplyCoordinate Ll { get; set; }

		// @property (nonatomic) MaplyCoordinate ur;
		[Export ("ur")]
		MaplyCoordinate Ur { get; set; }

		// -(MaplyCoordinateSystem *)buildCoordSystem;
		[Export ("buildCoordSystem")]
		MaplyCoordinateSystem BuildCoordSystem ();

		// -(MaplyWMSStyle *)findStyle:(NSString *)styleName;
		[Export ("findStyle:")]
		MaplyWMSStyle FindStyle (string styleName);
	}

	// @interface MaplyWMSCapabilities : NSObject
	[BaseType (typeof (NSObject))]
	interface MaplyWMSCapabilities {

		// -(id)initWithXML:(DDXMLDocument *)xmlDoc;
		//[Export ("initWithXML:")]
		//IntPtr Constructor (DDXMLDocument xmlDoc);

		// @property (nonatomic) NSString * name;
		[Export ("name")]
		string Name { get; set; }

		// @property (nonatomic) NSString * title;
		[Export ("title")]
		string Title { get; set; }

		// @property (nonatomic) NSArray * formats;
		[Export ("formats")]
		NSObject [] Formats { get; set; }

		// @property (nonatomic) NSArray * layers;
		[Export ("layers")]
		NSObject [] Layers { get; set; }

		// +(NSString *)CapabilitiesURLFor:(NSString *)baseURL;
		[Static, Export ("CapabilitiesURLFor:")]
		string CapabilitiesURLFor (string baseURL);

		// -(MaplyWMSLayer *)findLayer:(NSString *)name;
		[Export ("findLayer:")]
		MaplyWMSLayer FindLayer (string name);
	}

	// @interface MaplyWMSTileSource : NSObject <MaplyTileSource>
	[BaseType (typeof (NSObject))]
	interface MaplyWMSTileSource : MaplyTileSource {

		// -(id)initWithBaseURL:(NSString *)baseURL capabilities:(MaplyWMSCapabilities *)cap layer:(MaplyWMSLayer *)layer style:(MaplyWMSStyle *)style coordSys:(MaplyCoordinateSystem *)coordSys minZoom:(int)minZoom maxZoom:(int)maxZoom tileSize:(int)tileSize;
		[Export ("initWithBaseURL:capabilities:layer:style:coordSys:minZoom:maxZoom:tileSize:")]
		IntPtr Constructor (string baseURL, MaplyWMSCapabilities cap, MaplyWMSLayer layer, MaplyWMSStyle style, MaplyCoordinateSystem coordSys, int minZoom, int maxZoom, int tileSize);

		// @property (nonatomic) NSString * baseURL;
		[Export ("baseURL")]
		string BaseURL { get; set; }

		// @property (nonatomic) MaplyWMSCapabilities * capabilities;
		[Export ("capabilities")]
		MaplyWMSCapabilities Capabilities { get; set; }

		// @property (nonatomic) NSString * imageType;
		[Export ("imageType")]
		string ImageType { get; set; }

		// @property (nonatomic) MaplyWMSLayer * layer;
		[Export ("layer")]
		MaplyWMSLayer Layer { get; set; }

		// @property (nonatomic) MaplyWMSStyle * style;
		[Export ("style")]
		MaplyWMSStyle Style { get; set; }

		// @property (readonly, nonatomic) int minZoom;
		[Export ("minZoom")]
		int MinZoom { get; }

		// @property (readonly, nonatomic) int maxZoom;
		[Export ("maxZoom")]
		int MaxZoom { get; }

		// @property (readonly, nonatomic) int tileSize;
		[Export ("tileSize")]
		int TileSize { get; }

		// @property (nonatomic) _Bool transparent;
		[Export ("transparent")]
		bool Transparent { get; set; }

		// @property (readonly, nonatomic) MaplyCoordinateSystem * coordSys;
		[Export ("coordSys")]
		MaplyCoordinateSystem CoordSys { get; }

		// @property (nonatomic) NSString * cacheDir;
		[Export ("cacheDir")]
		string CacheDir { get; set; }
	}

	// @interface MaplyMBTileSource : NSObject <MaplyTileSource>
	[BaseType (typeof (NSObject))]
	interface MaplyMBTileSource : MaplyTileSource {

		// -(id)initWithMBTiles:(NSString *)fileName;
		[Export ("initWithMBTiles:")]
		IntPtr Constructor (string fileName);

		// @property (nonatomic) int maxZoom;
		[Export ("maxZoom")]
		int MaxZoom { get; set; }

		// @property (nonatomic) int minZoom;
		[Export ("minZoom")]
		int MinZoom { get; set; }

		// @property (readonly, nonatomic) MaplyCoordinateSystem * coordSys;
		[Export ("coordSys")]
		MaplyCoordinateSystem CoordSys { get; }
	}

	// @interface MaplyGDALRetileSource : NSObject <MaplyTileSource>
	[BaseType (typeof (NSObject))]
	interface MaplyGDALRetileSource : MaplyTileSource {

		// -(id)initWithURL:(NSString *)baseURL baseName:(NSString *)baseName ext:(NSString *)ext coordSys:(MaplyCoordinateSystem *)coordSys levels:(int)numLevels;
		[Export ("initWithURL:baseName:ext:coordSys:levels:")]
		IntPtr Constructor (string baseURL, string baseName, string ext, MaplyCoordinateSystem coordSys, int numLevels);

		// @property (nonatomic) NSString * cacheDir;
		[Export ("cacheDir")]
		string CacheDir { get; set; }
	}

	// @interface MaplyRemoteTileInfo : NSObject
	[BaseType (typeof (NSObject))]
	interface MaplyRemoteTileInfo {

		// -(id)initWithBaseURL:(NSString *)baseURL ext:(NSString *)ext minZoom:(int)minZoom maxZoom:(int)maxZoom;
		[Export ("initWithBaseURL:ext:minZoom:maxZoom:")]
		IntPtr Constructor (string baseURL, string ext, int minZoom, int maxZoom);

		// -(id)initWithTilespec:(NSDictionary *)jsonSpec;
		[Export ("initWithTilespec:")]
		IntPtr Constructor (NSDictionary jsonSpec);

		// @property (readonly, nonatomic) NSString * baseURL;
		[Export ("baseURL")]
		string BaseURL { get; }

		// @property (nonatomic) int minZoom;
		[Export ("minZoom")]
		int MinZoom { get; set; }

		// @property (nonatomic) int maxZoom;
		[Export ("maxZoom")]
		int MaxZoom { get; set; }

		// @property (nonatomic, strong) NSString * ext;
		[Export ("ext", ArgumentSemantic.Retain)]
		string Ext { get; set; }

		// @property (assign, nonatomic) float timeOut;
		[Export ("timeOut", ArgumentSemantic.UnsafeUnretained)]
		float TimeOut { get; set; }

		// @property (nonatomic) int pixelsPerSide;
		[Export ("pixelsPerSide")]
		int PixelsPerSide { get; set; }

		// @property (nonatomic, strong) MaplyCoordinateSystem * coordSys;
		[Export ("coordSys", ArgumentSemantic.Retain)]
		MaplyCoordinateSystem CoordSys { get; set; }

		// @property (nonatomic, strong) NSString * cacheDir;
		[Export ("cacheDir", ArgumentSemantic.Retain)]
		string CacheDir { get; set; }

		// @property (nonatomic) int cachedFileLifetime;
		[Export ("cachedFileLifetime")]
		int CachedFileLifetime { get; set; }

		// -(void)addBoundingBox:(MaplyBoundingBox *)bbox;
		[Export ("addBoundingBox:")]
		void AddBoundingBox (MaplyBoundingBox bbox);

		// -(void)addGeoBoundingBox:(MaplyBoundingBox *)bbox;
		[Export ("addGeoBoundingBox:")]
		void AddGeoBoundingBox (MaplyBoundingBox bbox);

		// -(NSURLRequest *)requestForTile:(MaplyTileID)tileID;
		[Export ("requestForTile:")]
		NSUrlRequest RequestForTile (MaplyTileID tileID);

		// -(NSString *)fileNameForTile:(MaplyTileID)tileID;
		[Export ("fileNameForTile:")]
		string FileNameForTile (MaplyTileID tileID);

		// -(_Bool)tileIsLocal:(MaplyTileID)tileID;
		[Export ("tileIsLocal:")]
		bool TileIsLocal (MaplyTileID tileID);

		// -(_Bool)validTile:(MaplyTileID)tileID bbox:(MaplyBoundingBox *)bbox;
		[Export ("validTile:bbox:")]
		bool ValidTile (MaplyTileID tileID, MaplyBoundingBox bbox);
	}

	// @protocol MaplyRemoteTileSourceDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface MaplyRemoteTileSourceDelegate {

		// @optional -(void)remoteTileSource:(id)tileSource tileDidLoad:(MaplyTileID)tileID;
		[Export ("remoteTileSource:tileDidLoad:")]
		void TileDidLoad (NSObject tileSource, MaplyTileID tileID);

		// @optional -(void)remoteTileSource:(id)tileSource tileDidNotLoad:(MaplyTileID)tileID error:(NSError *)error;
		[Export ("remoteTileSource:tileDidNotLoad:error:")]
		void TileDidNotLoad (NSObject tileSource, MaplyTileID tileID, NSError error);
	}

	// @interface MaplyRemoteTileSource : NSObject <MaplyTileSource>
	[BaseType (typeof (NSObject))]
	interface MaplyRemoteTileSource : MaplyTileSource {

		// -(id)initWithBaseURL:(NSString *)baseURL ext:(NSString *)ext minZoom:(int)minZoom maxZoom:(int)maxZoom;
		[Export ("initWithBaseURL:ext:minZoom:maxZoom:")]
		IntPtr Constructor (string baseURL, string ext, int minZoom, int maxZoom);

		// -(id)initWithTilespec:(NSDictionary *)jsonSpec;
		[Export ("initWithTilespec:")]
		IntPtr Constructor (NSDictionary jsonSpec);

		// -(id)initWithInfo:(MaplyRemoteTileInfo *)info;
		[Export ("initWithInfo:")]
		IntPtr Constructor (MaplyRemoteTileInfo info);

		// @property (readonly, nonatomic) MaplyRemoteTileInfo * tileInfo;
		[Export ("tileInfo")]
		MaplyRemoteTileInfo TileInfo { get; }

		// @property (nonatomic, weak) NSObject<MaplyRemoteTileSourceDelegate> * delegate;
		[Export ("delegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, weak) NSObject<MaplyRemoteTileSourceDelegate> * delegate;
		[Wrap ("WeakDelegate")]
		NSObject Delegate { get; set; }

		// @property (nonatomic, strong) MaplyCoordinateSystem * coordSys;
		[Export ("coordSys", ArgumentSemantic.Retain)]
		MaplyCoordinateSystem CoordSys { get; set; }

		// @property (nonatomic, strong) NSString * cacheDir;
		[Export ("cacheDir", ArgumentSemantic.Retain)]
		string CacheDir { get; set; }

		// -(id)imageForTile:(MaplyTileID)tileID;
		[Export ("imageForTile:")]
		NSObject ImageForTile (MaplyTileID tileID);
	}

	// @interface MaplyMultiplexTileSource : NSObject <MaplyTileSource>
	[BaseType (typeof (NSObject))]
	interface MaplyMultiplexTileSource : MaplyTileSource {

		// -(id)initWithSources:(NSArray *)tileSources;
		[Export ("initWithSources:")]
		IntPtr Constructor (NSObject [] tileSources);

		// @property (readonly, nonatomic) MaplyCoordinateSystem * coordSys;
		[Export ("coordSys")]
		MaplyCoordinateSystem CoordSys { get; }

		// @property (nonatomic, weak) NSObject<MaplyRemoteTileSourceDelegate> * delegate;
		[Export ("delegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, weak) NSObject<MaplyRemoteTileSourceDelegate> * delegate;
		[Wrap ("WeakDelegate")]
		NSObject Delegate { get; set; }

		// @property (nonatomic) _Bool acceptFailures;
		[Export ("acceptFailures")]
		bool AcceptFailures { get; set; }
	}

	// @interface MaplyAnimationTestTileSource : NSObject <MaplyTileSource>
	[BaseType (typeof (NSObject))]
	interface MaplyAnimationTestTileSource : MaplyTileSource {

		// -(id)initWithCoordSys:(MaplyCoordinateSystem *)coordSys minZoom:(int)minZoom maxZoom:(int)maxZoom depth:(int)depth;
		[Export ("initWithCoordSys:minZoom:maxZoom:depth:")]
		IntPtr Constructor (MaplyCoordinateSystem coordSys, int minZoom, int maxZoom, int depth);

		// @property (readonly, nonatomic) MaplyCoordinateSystem * coordSys;
		[Export ("coordSys")]
		MaplyCoordinateSystem CoordSys { get; }

		// @property (nonatomic) int pixelsPerSide;
		[Export ("pixelsPerSide")]
		int PixelsPerSide { get; set; }
	}

	// @interface MaplyPagingVectorTestTileSource : NSObject <MaplyPagingDelegate>
	[BaseType (typeof (NSObject))]
	interface MaplyPagingVectorTestTileSource : MaplyPagingDelegate {

		// -(id)initWithCoordSys:(MaplyCoordinateSystem *)coordSys minZoom:(int)minZoom maxZoom:(int)maxZoom;
		[Export ("initWithCoordSys:minZoom:maxZoom:")]
		IntPtr Constructor (MaplyCoordinateSystem coordSys, int minZoom, int maxZoom);

		// @property (readonly, nonatomic) MaplyCoordinateSystem * coordSys;
		[Export ("coordSys")]
		MaplyCoordinateSystem CoordSys { get; }

		// @property (nonatomic) int minZoom;
		[Export ("minZoom")]
		int MinZoom { get; set; }

		// @property (nonatomic) int maxZoom;
		[Export ("maxZoom")]
		int MaxZoom { get; set; }
	}

	// @interface MaplyElevationDatabase : NSObject <MaplyElevationSourceDelegate>
	[BaseType (typeof (NSObject))]
	interface MaplyElevationDatabase : MaplyElevationSourceDelegate {

		// -(id)initWithName:(NSString *)name;
		[Export ("initWithName:")]
		IntPtr Constructor (string name);

		// @property (nonatomic) double minX;
		[Export ("minX")]
		double MinX { get; set; }

		// @property (nonatomic) double minY;
		[Export ("minY")]
		double MinY { get; set; }

		// @property (nonatomic) double maxX;
		[Export ("maxX")]
		double MaxX { get; set; }

		// @property (nonatomic) double maxY;
		[Export ("maxY")]
		double MaxY { get; set; }

		// @property (nonatomic) unsigned int tileSizeX;
		[Export ("tileSizeX")]
		uint TileSizeX { get; set; }

		// @property (nonatomic) unsigned int tileSizeY;
		[Export ("tileSizeY")]
		uint TileSizeY { get; set; }

		// -(int)minZoom;
		[Export ("minZoom")]
		int MinZoom ();

		// -(int)maxZoom;
		[Export ("maxZoom")]
		int MaxZoom ();

		// -(MaplyElevationChunk *)elevForTile:(MaplyTileID)tileID;
		[Export ("elevForTile:")]
		MaplyElevationChunk ElevForTile (MaplyTileID tileID);
	}

	// @interface MaplyVectorTileStyleSettings : NSObject
	[BaseType (typeof (NSObject))]
	interface MaplyVectorTileStyleSettings {

		// @property (nonatomic) float lineScale;
		[Export ("lineScale")]
		float LineScale { get; set; }

		// @property (nonatomic) float textScale;
		[Export ("textScale")]
		float TextScale { get; set; }

		// @property (nonatomic) float markerScale;
		[Export ("markerScale")]
		float MarkerScale { get; set; }

		// @property (nonatomic) float markerImportance;
		[Export ("markerImportance")]
		float MarkerImportance { get; set; }

		// @property (nonatomic) float markerSize;
		[Export ("markerSize")]
		float MarkerSize { get; set; }

		// @property (nonatomic) float mapScaleScale;
		[Export ("mapScaleScale")]
		float MapScaleScale { get; set; }

		// @property (nonatomic) float dashPatternScale;
		[Export ("dashPatternScale")]
		float DashPatternScale { get; set; }

		// @property (nonatomic) _Bool useWideVectors;
		[Export ("useWideVectors")]
		bool UseWideVectors { get; set; }

		// @property (nonatomic) float wideVecCuttoff;
		[Export ("wideVecCuttoff")]
		float WideVecCuttoff { get; set; }

		// @property (nonatomic, strong) NSString * fontName;
		[Export ("fontName", ArgumentSemantic.Retain)]
		string FontName { get; set; }
	}

	// @interface MaplyVectorTileStyle : NSObject
	[BaseType (typeof (NSObject))]
	interface MaplyVectorTileStyle {

		// -(id)initWithStyleEntry:(NSDictionary *)styleEntry viewC:(MaplyBaseViewController *)viewC;
		[Export ("initWithStyleEntry:viewC:")]
		IntPtr Constructor (NSDictionary styleEntry, MaplyBaseViewController viewC);

		// @property (nonatomic) id<NSCopying> uuid;
		[Export ("uuid")]
		NSCopying Uuid { get; set; }

		// @property (nonatomic) _Bool geomAdditive;
		[Export ("geomAdditive")]
		bool GeomAdditive { get; set; }

		// @property (nonatomic, weak) MaplyBaseViewController * viewC;
		[Export ("viewC", ArgumentSemantic.Weak)]
		MaplyBaseViewController ViewC { get; set; }

		// @property (nonatomic) _Bool selectable;
		[Export ("selectable")]
		bool Selectable { get; set; }

		// +(id)styleFromStyleEntry:(NSDictionary *)styleEntry settings:(MaplyVectorTileStyleSettings *)settings viewC:(MaplyBaseViewController *)viewC;
		[Static, Export ("styleFromStyleEntry:settings:viewC:")]
		NSObject StyleFromStyleEntry (NSDictionary styleEntry, MaplyVectorTileStyleSettings settings, MaplyBaseViewController viewC);

		// -(void)resolveVisibility:(NSDictionary *)styleEntry settings:(MaplyVectorTileStyleSettings *)settings desc:(NSMutableDictionary *)desc;
		[Export ("resolveVisibility:settings:desc:")]
		void ResolveVisibility (NSDictionary styleEntry, MaplyVectorTileStyleSettings settings, NSMutableDictionary desc);

		// -(NSArray *)buildObjects:(NSArray *)vecObjs viewC:(MaplyBaseViewController *)viewC;
		[Export ("buildObjects:viewC:")]
		NSObject [] BuildObjects (NSObject [] vecObjs, MaplyBaseViewController viewC);

		// -(NSString *)formatText:(NSString *)formatString forObject:(MaplyVectorObject *)vec;
		[Export ("formatText:forObject:")]
		string FormatText (string formatString, MaplyVectorObject vec);
	}

	// @interface MaplyVectorTiles : NSObject <MaplyPagingDelegate>
	[BaseType (typeof (NSObject))]
	interface MaplyVectorTiles : MaplyPagingDelegate {

		// -(id)initWithDatabase:(NSString *)tilesDB viewC:(MaplyBaseViewController *)viewC;
		[Export ("initWithDatabase:viewC:")]
		IntPtr Constructor (string tilesDB, MaplyBaseViewController viewC);

		// -(id)initWithTileSpec:(NSDictionary *)jsonSpec styles:(NSDictionary *)styles viewC:(MaplyBaseViewController *)viewC;
		[Export ("initWithTileSpec:styles:viewC:")]
		IntPtr Constructor (NSDictionary jsonSpec, NSDictionary styles, MaplyBaseViewController viewC);

		// @property (readonly, nonatomic) int minLevel;
		[Export ("minLevel")]
		int MinLevel { get; }

		// @property (readonly, nonatomic) int maxLevel;
		[Export ("maxLevel")]
		int MaxLevel { get; }

		// @property (nonatomic, weak) MaplyBaseViewController * viewC;
		[Export ("viewC", ArgumentSemantic.Weak)]
		MaplyBaseViewController ViewC { get; set; }

		// @property (nonatomic) MaplyVectorTileStyleSettings * settings;
		[Export ("settings")]
		MaplyVectorTileStyleSettings Settings { get; set; }

		// @property (readonly, nonatomic) NSArray * layerNames;
		[Export ("layerNames")]
		NSObject [] LayerNames { get; }

		// @property (readonly, nonatomic) NSArray * styles;
		[Export ("styles")]
		NSObject [] Styles { get; }

		// @property (nonatomic) NSString * cacheDir;
		[Export ("cacheDir")]
		string CacheDir { get; set; }

		// @property (nonatomic) _Bool selectable;
		[Export ("selectable")]
		bool Selectable { get; set; }

		// +(UIColor *)ParseColor:(NSString *)colorStr;
		[Static, Export ("ParseColor:")]
		UIColor ParseColor (string colorStr);

		// +(UIColor *)ParseColor:(NSString *)colorStr alpha:(CGFloat)alpha;
		[Static, Export ("ParseColor:alpha:")]
		UIColor ParseColor (string colorStr, nfloat alpha);

		// +(void)StartRemoteVectorTiles:(NSString *)jsonURL cacheDir:(NSString *)cacheDir viewC:(MaplyBaseViewController *)viewC block:(void (^)(MaplyVectorTiles *))callbackBlock;
		[Static, Export ("StartRemoteVectorTiles:cacheDir:viewC:block:")]
		void StartRemoteVectorTiles (string jsonURL, string cacheDir, MaplyBaseViewController viewC, Action<MaplyVectorTiles> callbackBlock);
	}

	// @interface MaplyIconManager : NSObject
	[BaseType (typeof (NSObject))]
	interface MaplyIconManager {

		// +(UIImage *)iconForName:(NSString *)name size:(CGSize)size;
		[Static, Export ("iconForName:size:")]
		UIImage IconForName (string name, CGSize size);

		// +(UIImage *)iconForName:(NSString *)name size:(CGSize)size color:(UIColor *)color circleColor:(UIColor *)circleColor strokeSize:(float)strokeSize strokeColor:(UIColor *)strokeColor;
		[Static, Export ("iconForName:size:color:circleColor:strokeSize:strokeColor:")]
		UIImage IconForName (string name, CGSize size, UIColor color, UIColor circleColor, float strokeSize, UIColor strokeColor);
	}

	// @interface MaplyLinearTextureBuilder : NSObject
	[BaseType (typeof (NSObject))]
	interface MaplyLinearTextureBuilder {

		// -(id)initWithSize:(CGSize)size;
		[Export ("initWithSize:")]
		IntPtr Constructor (CGSize size);

		// @property (assign, nonatomic) MaplyLinearTextureOpacity opacityFunc;
		//[Export ("opacityFunc", ArgumentSemantic.UnsafeUnretained)]
		//MaplyLinearTextureOpacity opactiyFunc { get; set; }

		// -(void)setPattern:(NSArray *)elements;
		[Export ("setPattern:")]
		void SetPattern (NSObject [] elements);

		// -(UIImage *)makeImage;
		[Export ("makeImage")]
		UIImage MakeImage ();
	}

	// @interface MaplyVectorTileStyleLine : MaplyVectorTileStyle
	[BaseType (typeof (MaplyVectorTileStyle))]
	interface MaplyVectorTileStyleLine {

		// -(id)initWithStyleEntry:(NSDictionary *)styleEntry settings:(MaplyVectorTileStyleSettings *)settings viewC:(MaplyBaseViewController *)viewC;
		[Export ("initWithStyleEntry:settings:viewC:")]
		IntPtr Constructor (NSDictionary styleEntry, MaplyVectorTileStyleSettings settings, MaplyBaseViewController viewC);
	}

	// @interface MaplyVectorTileStyleMarker : MaplyVectorTileStyle
	[BaseType (typeof (MaplyVectorTileStyle))]
	interface MaplyVectorTileStyleMarker {

		// -(id)initWithStyleEntry:(NSDictionary *)styleEntry settings:(MaplyVectorTileStyleSettings *)settings viewC:(MaplyBaseViewController *)viewC;
		[Export ("initWithStyleEntry:settings:viewC:")]
		IntPtr Constructor (NSDictionary styleEntry, MaplyVectorTileStyleSettings settings, MaplyBaseViewController viewC);
	}

	// @interface MaplyVectorTileStylePolygon : MaplyVectorTileStyle
	[BaseType (typeof (MaplyVectorTileStyle))]
	interface MaplyVectorTileStylePolygon {

		// -(id)initWithStyleEntry:(NSDictionary *)styleEntry settings:(MaplyVectorTileStyleSettings *)settings viewC:(MaplyBaseViewController *)viewC;
		[Export ("initWithStyleEntry:settings:viewC:")]
		IntPtr Constructor (NSDictionary styleEntry, MaplyVectorTileStyleSettings settings, MaplyBaseViewController viewC);
	}

	// @interface MaplyVectorTileStyleText : MaplyVectorTileStyle
	[BaseType (typeof (MaplyVectorTileStyle))]
	interface MaplyVectorTileStyleText {

		// -(id)initWithStyleEntry:(NSDictionary *)styleEntry settings:(MaplyVectorTileStyleSettings *)settings viewC:(MaplyBaseViewController *)viewC;
		[Export ("initWithStyleEntry:settings:viewC:")]
		IntPtr Constructor (NSDictionary styleEntry, MaplyVectorTileStyleSettings settings, MaplyBaseViewController viewC);
	}

	// @interface WhirlyGlobeViewControllerAnimationState : NSObject
	[BaseType (typeof (NSObject))]
	interface WhirlyGlobeViewControllerAnimationState {

		// @property (nonatomic) float heading;
		[Export ("heading")]
		float Heading { get; set; }

		// @property (nonatomic) float height;
		[Export ("height")]
		float Height { get; set; }

		// @property (nonatomic) float tilt;
		[Export ("tilt")]
		float Tilt { get; set; }

		// @property (nonatomic) MaplyCoordinate pos;
		[Export ("pos")]
		MaplyCoordinate pos { get; set; }
	}

	// @protocol WhirlyGlobeViewControllerAnimationDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface WhirlyGlobeViewControllerAnimationDelegate {

		// @required -(void)globeViewController:(WhirlyGlobeViewController *)viewC startState:(WhirlyGlobeViewControllerAnimationState *)startState startTime:(NSTimeInterval)startTime endTime:(NSTimeInterval)endTime;
		[Export ("globeViewController:startState:startTime:endTime:")]
		[Abstract]
		void StartState (WhirlyGlobeViewController viewC, WhirlyGlobeViewControllerAnimationState startState, double startTime, double endTime);

		// @required -(WhirlyGlobeViewControllerAnimationState *)globeViewController:(WhirlyGlobeViewController *)viewC stateForTime:(NSTimeInterval)currentTime;
		[Export ("globeViewController:stateForTime:")]
		[Abstract]
		WhirlyGlobeViewControllerAnimationState StateForTime (WhirlyGlobeViewController viewC, double currentTime);
	}

	// @protocol WhirlyGlobeViewControllerDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface WhirlyGlobeViewControllerDelegate {

		// @optional -(void)globeViewController:(WhirlyGlobeViewController *)viewC didSelect:(NSObject *)selectedObj;
		[Export ("globeViewController:didSelect:")]
		void DidSelect (WhirlyGlobeViewController viewC, NSObject selectedObj);

		// @optional -(void)globeViewController:(WhirlyGlobeViewController *)viewC didSelect:(NSObject *)selectedObj atLoc:(MaplyCoordinate)coord onScreen:(CGPoint)screenPt;
		[Export ("globeViewController:didSelect:atLoc:onScreen:")]
		void DidSelect (WhirlyGlobeViewController viewC, NSObject selectedObj, MaplyCoordinate coord, CGPoint screenPt);

		// @optional -(void)globeViewControllerDidTapOutside:(WhirlyGlobeViewController *)viewC;
		[Export ("globeViewControllerDidTapOutside:")]
		void GlobeViewControllerDidTapOutside (WhirlyGlobeViewController viewC);

		// @optional -(void)globeViewController:(WhirlyGlobeViewController *)viewC didTapAt:(WGCoordinate)coord;
		[Export ("globeViewController:didTapAt:")]
		void DidTapAt (WhirlyGlobeViewController viewC, WGCoordinate coord);

		// @optional -(void)globeViewController:(WhirlyGlobeViewController *)viewC layerDidLoad:(WGViewControllerLayer *)layer;
		[Export ("globeViewController:layerDidLoad:")]
		void LayerDidLoad (WhirlyGlobeViewController viewC, WGViewControllerLayer layer);

		// @optional -(void)globeViewControllerDidStartMoving:(WhirlyGlobeViewController *)viewC userMotion:(_Bool)userMotion;
		[Export ("globeViewControllerDidStartMoving:userMotion:")]
		void UserMotion (WhirlyGlobeViewController viewC, bool userMotion);

		// @optional -(void)globeViewController:(WhirlyGlobeViewController *)viewC didStopMoving:(MaplyCoordinate *)corners userMotion:(_Bool)userMotion;
		[Export ("globeViewController:didStopMoving:userMotion:")]
		void DidStopMoving (WhirlyGlobeViewController viewC, MaplyCoordinate corners, bool userMotion);

		// @optional -(void)globeViewController:(WhirlyGlobeViewController *)viewC willStopMoving:(MaplyCoordinate *)corners userMotion:(_Bool)userMotion;
		[Export ("globeViewController:willStopMoving:userMotion:")]
		void WillStopMoving (WhirlyGlobeViewController viewC, MaplyCoordinate corners, bool userMotion);

		// @optional -(void)globeViewController:(WhirlyGlobeViewController *)viewC didMove:(MaplyCoordinate *)corners;
		[Export ("globeViewController:didMove:")]
		void DidMove (WhirlyGlobeViewController viewC, MaplyCoordinate corners);
	}

	// @interface WhirlyGlobeViewController : MaplyBaseViewController
	[BaseType (typeof (MaplyBaseViewController))]
	interface WhirlyGlobeViewController {

		// @property (assign, nonatomic) _Bool keepNorthUp;
		[Export ("keepNorthUp", ArgumentSemantic.UnsafeUnretained)]
		bool KeepNorthUp { get; set; }

		// @property (assign, nonatomic) _Bool pinchGesture;
		[Export ("pinchGesture", ArgumentSemantic.UnsafeUnretained)]
		bool PinchGesture { get; set; }

		// @property (assign, nonatomic) _Bool rotateGesture;
		[Export ("rotateGesture", ArgumentSemantic.UnsafeUnretained)]
		bool RotateGesture { get; set; }

		// @property (assign, nonatomic) _Bool doubleTapZoomGesture;
		[Export ("doubleTapZoomGesture", ArgumentSemantic.UnsafeUnretained)]
		bool DoubleTapZoomGesture { get; set; }

		// @property (assign, nonatomic) _Bool twoFingerTapGesture;
		[Export ("twoFingerTapGesture", ArgumentSemantic.UnsafeUnretained)]
		bool TwoFingerTapGesture { get; set; }

		// @property (assign, nonatomic) _Bool doubleTapDragGesture;
		[Export ("doubleTapDragGesture", ArgumentSemantic.UnsafeUnretained)]
		bool DoubleTapDragGesture { get; set; }

		// @property (assign, nonatomic) _Bool autoMoveToTap;
		[Export ("autoMoveToTap", ArgumentSemantic.UnsafeUnretained)]
		bool AutoMoveToTap { get; set; }

		// @property (nonatomic, weak) NSObject<WhirlyGlobeViewControllerDelegate> * delegate;
		[Export ("delegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		// @property (nonatomic, weak) NSObject<WhirlyGlobeViewControllerDelegate> * delegate;
		[Wrap ("WeakDelegate")]
		NSObject Delegate { get; set; }

		// @property (assign, nonatomic) float height;
		[Export ("height", ArgumentSemantic.UnsafeUnretained)]
		float Height { get; set; }

		// @property (assign, nonatomic) float tilt;
		[Export ("tilt", ArgumentSemantic.UnsafeUnretained)]
		float Tilt { get; set; }

		// @property (assign, nonatomic) float heading;
		[Export ("heading", ArgumentSemantic.UnsafeUnretained)]
		float Heading { get; set; }

		// @property (nonatomic) float zoomTapFactor;
		[Export ("zoomTapFactor")]
		float ZoomTapFactor { get; set; }

		// @property (nonatomic) float zoomTapAnimationDuration;
		[Export ("zoomTapAnimationDuration")]
		float ZoomTapAnimationDuration { get; set; }

		// -(void)getZoomLimitsMin:(float *)minHeight max:(float *)maxHeight;
		[Export ("getZoomLimitsMin:max:")]
		void GetZoomLimitsMin (float minHeight, float maxHeight);

		// -(void)setZoomLimitsMin:(float)minHeight max:(float)maxHeight;
		[Export ("setZoomLimitsMin:max:")]
		void SetZoomLimitsMin (float minHeight, float maxHeight);

		// -(void)setTiltMinHeight:(float)minHeight maxHeight:(float)maxHeight minTilt:(float)minTilt maxTilt:(float)maxTilt;
		[Export ("setTiltMinHeight:maxHeight:minTilt:maxTilt:")]
		void SetTiltMinHeight (float minHeight, float maxHeight, float minTilt, float maxTilt);

		// -(void)clearTiltHeight;
		[Export ("clearTiltHeight")]
		void ClearTiltHeight ();

		// -(void)setAutoRotateInterval:(float)autoRotateInterval degrees:(float)autoRotateDegrees;
		[Export ("setAutoRotateInterval:degrees:")]
		void SetAutoRotateInterval (float autoRotateInterval, float autoRotateDegrees);

		// -(void)animateToPosition:(MaplyCoordinate)newPos time:(NSTimeInterval)howLong;
		[Export ("animateToPosition:time:")]
		void AnimateToPosition (MaplyCoordinate newPos, double howLong);

		// -(_Bool)animateToPosition:(MaplyCoordinate)newPos onScreen:(CGPoint)loc time:(NSTimeInterval)howLong;
		[Export ("animateToPosition:onScreen:time:")]
		bool AnimateToPosition (MaplyCoordinate newPos, CGPoint loc, double howLong);

		// -(void)animateWithDelegate:(NSObject<WhirlyGlobeViewControllerAnimationDelegate> *)animationDelegate time:(NSTimeInterval)howLong;
		[Export ("animateWithDelegate:time:")]
		void AnimateWithDelegate (NSObject animationDelegate, double howLong);

		// -(void)setPosition:(MaplyCoordinate)newPos;
		[Export ("setPosition:")]
		void SetPosition (MaplyCoordinate newPos);

		// -(void)setPosition:(MaplyCoordinate)newPos height:(float)height;
		[Export ("setPosition:height:")]
		void SetPosition (MaplyCoordinate newPos, float height);

		// -(void)getPosition:(MaplyCoordinate *)pos height:(float *)height;
		[Export ("getPosition:height:")]
		void GetPosition (MaplyCoordinate pos, float height);

		// -(id)findObjectAtLocation:(CGPoint)screenPt;
		[Export ("findObjectAtLocation:")]
		NSObject FindObjectAtLocation (CGPoint screenPt);

		// -(WGViewControllerLayer *)addSphericalEarthLayerWithImageSet:(NSString *)name;
		[Export ("addSphericalEarthLayerWithImageSet:")]
		WGViewControllerLayer AddSphericalEarthLayerWithImageSet (string name);

		// -(_Bool)screenPointFromGeo:(MaplyCoordinate)geoCoord screenPt:(CGPoint *)screenPt;
		[Export ("screenPointFromGeo:screenPt:")]
		bool ScreenPointFromGeo (MaplyCoordinate geoCoord, CGPoint screenPt);

		// -(_Bool)geoPointFromScreen:(CGPoint)screenPt geoCoord:(MaplyCoordinate *)geoCoord;
		[Export ("geoPointFromScreen:geoCoord:")]
		bool GeoPointFromScreen (CGPoint screenPt, MaplyCoordinate geoCoord);

		// -(_Bool)geocPointFromScreen:(CGPoint)screenPt geocCoord:(double *)retCoords;
		[Export ("geocPointFromScreen:geocCoord:")]
		bool GeocPointFromScreen (CGPoint screenPt, double retCoords);

		// -(float)findHeightToViewBounds:(MaplyBoundingBox *)bbox pos:(MaplyCoordinate)pos;
		[Export ("findHeightToViewBounds:pos:")]
		float FindHeightToViewBounds (MaplyBoundingBox bbox, MaplyCoordinate pos);

		// -(_Bool)getCurrentExtents:(MaplyBoundingBox *)bbox;
		[Export ("getCurrentExtents:")]
		bool GetCurrentExtents (MaplyBoundingBox bbox);
	}

	// @interface MaplySphericalQuadEarthWithTexGroup : MaplyViewControllerLayer
	[BaseType (typeof (MaplyViewControllerLayer))]
	interface MaplySphericalQuadEarthWithTexGroup {

		// -(id)initWithWithTexGroup:(NSString *)texGroupName;
		[Export ("initWithWithTexGroup:")]
		IntPtr Constructor (string texGroupName);
	}

	// @protocol VectorStyleDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface VectorStyleDelegate {

		// @required -(NSArray *)stylesForFeatureWithAttributes:(NSDictionary *)attributes onTile:(MaplyTileID)tileID inLayer:(NSString *)layer;
		[Export ("stylesForFeatureWithAttributes:onTile:inLayer:")]
		[Abstract]
		NSObject [] StylesForFeatureWithAttributes (NSDictionary attributes, MaplyTileID tileID, string layer);

		// @required -(BOOL)layerShouldDisplay:(NSString *)layer;
		[Export ("layerShouldDisplay:")]
		[Abstract]
		bool LayerShouldDisplay (string layer);

		// @required -(MaplyVectorTileStyle *)styleForUUID:(NSString *)uiid;
		[Export ("styleForUUID:")]
		[Abstract]
		MaplyVectorTileStyle StyleForUUID (string uiid);
	}

	// @interface MaplyMapnikVectorTiles : NSObject <MaplyPagingDelegate>
	[BaseType (typeof (NSObject))]
	interface MaplyMapnikVectorTiles : MaplyPagingDelegate {

		// -(instancetype)initWithTileSource:(NSObject<MaplyTileSource> *)tileSource;
		[Export ("initWithTileSource:")]
		IntPtr Constructor (NSObject tileSource);

		// -(instancetype)initWithTileSources:(NSArray *)tileSources;
		[Export ("initWithTileSources:")]
		IntPtr Constructor (NSObject [] tileSources);

		// -(instancetype)initWithMBTiles:(MaplyMBTileSource *)tileSource;
		[Export ("initWithMBTiles:")]
		IntPtr Constructor (MaplyMBTileSource tileSource);

		// @property (readonly, nonatomic) NSArray * tileSources;
		[Export ("tileSources")]
		NSObject [] TileSources { get; }

		// @property (nonatomic, strong) NSObject<VectorStyleDelegate> * styleDelegate;
		[Export ("styleDelegate", ArgumentSemantic.Retain)]
		[NullAllowed]
		NSObject WeakStyleDelegate { get; set; }

		// @property (nonatomic, strong) NSObject<VectorStyleDelegate> * styleDelegate;
		[Wrap ("WeakStyleDelegate")]
		NSObject StyleDelegate { get; set; }

		// @property (assign, nonatomic) BOOL debugLabel;
		[Export ("debugLabel", ArgumentSemantic.UnsafeUnretained)]
		bool DebugLabel { get; set; }

		// @property (assign, nonatomic) BOOL debugOutline;
		[Export ("debugOutline", ArgumentSemantic.UnsafeUnretained)]
		bool DebugOutline { get; set; }

		// @property (assign, nonatomic) int minZoom;
		[Export ("minZoom", ArgumentSemantic.UnsafeUnretained)]
		int MinZoom { get; set; }

		// @property (assign, nonatomic) int maxZoom;
		[Export ("maxZoom", ArgumentSemantic.UnsafeUnretained)]
		int MaxZoom { get; set; }

		// +(void)StartRemoteVectorTilesWithTileSpec:(NSString *)tileSpec style:(NSString *)styleFile cacheDir:(NSString *)cacheDir viewC:(MaplyBaseViewController *)viewC success:(void (^)(MaplyMapnikVectorTiles *))successBlock failure:(void (^)(NSError *))failureBlock;
		[Static, Export ("StartRemoteVectorTilesWithTileSpec:style:cacheDir:viewC:success:failure:")]
		void StartRemoteVectorTilesWithTileSpec (string tileSpec, string styleFile, string cacheDir, MaplyBaseViewController viewC, Action<MaplyMapnikVectorTiles> successBlock, Action<NSError> failureBlock);

		// +(void)StartRemoteVectorTilesWithURL:(NSString *)tileURL ext:(NSString *)ext minZoom:(int)minZoom maxZoom:(int)maxZoom style:(NSString *)styleFile cacheDir:(NSString *)cacheDir viewC:(MaplyBaseViewController *)viewC success:(void (^)(MaplyMapnikVectorTiles *))successBlock failure:(void (^)(NSError *))failureBlock;
		[Static, Export ("StartRemoteVectorTilesWithURL:ext:minZoom:maxZoom:style:cacheDir:viewC:success:failure:")]
		void StartRemoteVectorTilesWithURL (string tileURL, string ext, int minZoom, int maxZoom, string styleFile, string cacheDir, MaplyBaseViewController viewC, Action<MaplyMapnikVectorTiles> successBlock, Action<NSError> failureBlock);
	}

	// @interface MapnikStyleSet : NSObject <NSXMLParserDelegate, VectorStyleDelegate>
	[BaseType (typeof (NSObject))]
	interface MapnikStyleSet : /*NSXMLParserDelegate,*/ VectorStyleDelegate {

		// -(instancetype)initForViewC:(MaplyBaseViewController *)viewC;
		[Export ("initForViewC:")]
		IntPtr Constructor (MaplyBaseViewController viewC);

		// @property (nonatomic, strong) MaplyVectorTileStyleSettings * tileStyleSettings;
		[Export ("tileStyleSettings", ArgumentSemantic.Retain)]
		MaplyVectorTileStyleSettings TileStyleSettings { get; set; }

		// @property (nonatomic, strong) NSMutableDictionary * styleDictionary;
		[Export ("styleDictionary", ArgumentSemantic.Retain)]
		NSMutableDictionary StyleDictionary { get; set; }

		// @property (nonatomic, weak) MaplyBaseViewController * viewC;
		[Export ("viewC", ArgumentSemantic.Weak)]
		MaplyBaseViewController ViewC { get; set; }

		// @property (readonly, nonatomic) BOOL parsing;
		[Export ("parsing")]
		bool Parsing { get; }

		// @property (nonatomic, strong) UIColor * backgroundColor;
		[Export ("backgroundColor", ArgumentSemantic.Retain)]
		UIColor BackgroundColor { get; set; }

		// @property (assign, nonatomic) NSInteger tileMaxZoom;
		[Export ("tileMaxZoom", ArgumentSemantic.UnsafeUnretained)]
		nint TileMaxZoom { get; set; }

		// @property (assign, nonatomic) NSInteger drawPriorityOffset;
		[Export ("drawPriorityOffset", ArgumentSemantic.UnsafeUnretained)]
		nint DrawPriorityOffset { get; set; }

		// @property (assign, nonatomic) CGFloat alpha;
		[Export ("alpha", ArgumentSemantic.UnsafeUnretained)]
		nfloat Alpha { get; set; }

		// -(void)loadXmlFile:(NSString *)filePath;
		[Export ("loadXmlFile:")]
		void LoadXmlFile (string filePath);

		// -(void)loadXmlData:(NSData *)docData;
		[Export ("loadXmlData:")]
		void LoadXmlData (NSData docData);

		// -(void)loadJsonData:(NSData *)jsonData;
		[Export ("loadJsonData:")]
		void LoadJsonData (NSData jsonData);

		// -(void)loadJsonFile:(NSString *)filePath;
		[Export ("loadJsonFile:")]
		void LoadJsonFile (string filePath);

		// -(void)saveAsJSON:(NSString *)filePath;
		[Export ("saveAsJSON:")]
		void SaveAsJSON (string filePath);

		// -(void)generateStyles;
		[Export ("generateStyles")]
		void GenerateStyles ();
	}

	// @interface MapnikStyleRule : NSObject
	[BaseType (typeof (NSObject))]
	interface MapnikStyleRule {

		// @property (nonatomic, strong) NSPredicate * filterPredicate;
		[Export ("filterPredicate", ArgumentSemantic.Retain)]
		NSPredicate FilterPredicate { get; set; }

		// @property (assign, nonatomic) NSUInteger minScaleDenominator;
		[Export ("minScaleDenominator", ArgumentSemantic.UnsafeUnretained)]
		nuint MinScaleDenominator { get; set; }

		// @property (assign, nonatomic) NSUInteger maxScaleDenomitator;
		[Export ("maxScaleDenomitator", ArgumentSemantic.UnsafeUnretained)]
		nuint MaxScaleDenomitator { get; set; }

		// @property (assign, nonatomic) NSUInteger minZoom;
		[Export ("minZoom", ArgumentSemantic.UnsafeUnretained)]
		nuint MinZoom { get; set; }

		// @property (assign, nonatomic) NSUInteger maxZoom;
		[Export ("maxZoom", ArgumentSemantic.UnsafeUnretained)]
		nuint MaxZoom { get; set; }

		// @property (readonly, nonatomic) NSMutableArray * symbolizers;
		[Export ("symbolizers")]
		NSMutableArray Symbolizers { get; }

		// -(void)setFilter:(NSString *)filterExpression;
		[Export ("setFilter:")]
		void SetFilter (string filterExpression);
	}

	// @interface zlib (NSData)
	[Category]
	[BaseType (typeof (NSData))]
	interface zlib {

		// -(NSData *)compressData;
		[Export ("compressData")]
		NSData CompressData ();

		// -(NSData *)uncompressGZip;
		[Export ("uncompressGZip")]
		NSData UncompressGZip ();

		// -(BOOL)isCompressed;
		[Export ("isCompressed")]
		bool IsCompressed ();
	}

	// @interface StyleRules (NSMutableDictionary)
	[Category]
	[BaseType (typeof (NSMutableDictionary))]
	interface StyleRules {

		// -(NSMutableArray *)styles;
		[Export ("styles")]
		NSMutableArray Styles ();

		// -(NSMutableArray *)rules;
		[Export ("rules")]
		NSMutableArray Rules ();

		// -(NSMutableArray *)symbolizers;
		[Export ("symbolizers")]
		NSMutableArray Symbolizers ();

		// -(NSMutableArray *)layers;
		[Export ("layers")]
		NSMutableArray Layers ();

		// -(NSString *)filter;
		[Export ("filter")]
		string Filter ();

		// -(void)setFilter:(NSString *)filter;
		[Export ("setFilter:")]
		void SetFilter (string filter);

		// -(NSString *)name;
		[Export ("name")]
		string Name ();

		// -(NSNumber *)minScaleDenom;
		[Export ("minScaleDenom")]
		NSNumber MinScaleDenom ();

		// -(void)setMinScaleDenom:(NSNumber *)num;
		[Export ("setMinScaleDenom:")]
		void SetMinScaleDenom (NSNumber num);

		// -(NSNumber *)maxScaleDenom;
		[Export ("maxScaleDenom")]
		NSNumber MaxScaleDenom ();

		// -(void)setMaxScaleDenom:(NSNumber *)num;
		[Export ("setMaxScaleDenom:")]
		void SetMaxScaleDenom (NSNumber num);

		// -(NSMutableDictionary *)parameters;
		[Export ("parameters")]
		NSMutableDictionary Parameters ();
	}


}

