//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace XRTK.Lumin.Native
{
    using System.Runtime.InteropServices;

    internal static class MlPlanes
    {
        /// <summary>
        /// Control flags for plane queries
        /// </summary>
        [Flags]
        public enum MLPlanesQueryFlags : int
        {
            /// <summary>
            /// Include planes whose normal is perpendicular to gravity
            /// </summary>
            MLPlanesQueryFlag_Vertical = unchecked((int)1 << (int)0),

            /// <summary>
            /// Include planes whose normal is parallel to gravity
            /// </summary>
            MLPlanesQueryFlag_Horizontal = unchecked((int)1 << (int)1),

            /// <summary>
            /// Include planes with arbitrary normals
            /// </summary>
            MLPlanesQueryFlag_Arbitrary = unchecked((int)1 << (int)2),

            /// <summary>
            /// Include all plane orientations
            /// </summary>
            MLPlanesQueryFlag_AllOrientations = unchecked((int)MLPlanesQueryFlag_Vertical | MLPlanesQueryFlag_Horizontal | MLPlanesQueryFlag_Arbitrary),

            /// <summary>
            /// For non-horizontal planes, setting this flag will result in the top of
            /// the plane rectangle being perpendicular to gravity
            /// </summary>
            MLPlanesQueryFlag_OrientToGravity = unchecked((int)1 << (int)3),

            /// <summary>
            /// If this flag is set, inner planes will be returned; if it is not set,
            /// outer planes will be returned
            /// </summary>
            MLPlanesQueryFlag_Inner = unchecked((int)1 << (int)4),

            /// <summary>
            /// Include planes semantically tagged as ceiling
            /// </summary>
            MLPlanesQueryFlag_Semantic_Ceiling = unchecked((int)1 << (int)6),

            /// <summary>
            /// Include planes semantically tagged as floor
            /// </summary>
            MLPlanesQueryFlag_Semantic_Floor = unchecked((int)1 << (int)7),

            /// <summary>
            /// Include planes semantically tagged as wall
            /// </summary>
            MLPlanesQueryFlag_Semantic_Wall = unchecked((int)1 << (int)8),

            /// <summary>
            /// Include all planes that are semantically tagged
            /// </summary>
            MLPlanesQueryFlag_Semantic_All = unchecked((int)MLPlanesQueryFlag_Semantic_Ceiling | MLPlanesQueryFlag_Semantic_Floor | MLPlanesQueryFlag_Semantic_Wall),

            /// <summary>
            /// Include polygonal planes
            /// When this flag is set:
            /// - MLPlanesQueryGetResultsWithBoundaries returns polygons along with
            /// other applicable rectangular planes MLPlanesReleaseBoundariesList
            /// MUST be called before the next call to MLPlanesQueryGetResultsWithBoundaries,
            /// otherwise UnspecifiedFailure will be returned
            /// When this flag is not set:
            /// - MLPlanesQueryGetResultsWithBoundaries returns just rectangular planes
            /// No need to call MLPlanesReleaseBoundariesList
            /// @apilevel 2
            /// </summary>
            MLPlanesQueryFlag_Polygons = unchecked((int)1 << (int)9),
        }

        /// <summary>
        /// A plane with width and height
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct MLPlane
        {
            /// <summary>
            /// Plane center
            /// </summary>
            public MlTypes.MLVec3f position;

            /// <summary>
            /// Plane rotation
            /// </summary>
            public MlTypes.MLQuaternionf rotation;

            /// <summary>
            /// Plane width
            /// </summary>
            public float width;

            /// <summary>
            /// Plane height
            /// </summary>
            public float height;

            /// <summary>
            /// Flags which describe this plane
            /// </summary>
            public uint flags;

            /// <summary>
            /// Plane ID All inner planes within an outer plane will have the
            /// same ID (outer plane's ID) These IDs are persistent across
            /// plane queries unless a map merge occurs On a map merge, IDs
            /// could be different
            /// </summary>
            public MlApi.MLHandle id;
        }

        /// <summary>
        /// Coplanar connected line segments representing the outer boundary of a polygon,
        /// an n sided polygon where n is the number of vertices
        /// @apilevel 2
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct MLPolygon
        {
            /// <summary>
            /// Vertices of all line segments
            /// </summary>
            public IntPtr vertices;

            /// <summary>
            /// Number of vertices
            /// </summary>
            public uint vertices_count;
        }

        /// <summary>
        /// Type used to represent a region boundary on a 2D plane
        /// @apilevel 2
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct MLPlaneBoundary
        {
            /// <summary>
            /// The polygon that defines the region, the boundary vertices in MLPolygon will be in CCW order
            /// </summary>
            public IntPtr polygon;

            /// <summary>
            /// A polygon may contains multiple holes, the boundary vertices in MLPolygon will be in CW order
            /// </summary>
            public IntPtr holes;

            /// <summary>
            /// Count of the holes
            /// </summary>
            public uint holes_count;
        }

        /// <summary>
        /// Type to represent multiple regions on a 2D plane
        /// @apilevel 2
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct MLPlaneBoundaries
        {
            /// <summary>
            /// Plane ID, the same value associating to the ID in MLPlane if they belong to the same plane
            /// </summary>
            public MlApi.MLHandle id;

            /// <summary>
            /// The boundaries in a plane
            /// </summary>
            public IntPtr boundaries;

            /// <summary>
            /// Count of boundaries A plane may contain multiple boundaries each of which defines a region
            /// </summary>
            public uint boundaries_count;
        }

        /// <summary>
        /// Type to represent polygons of all returned planes
        /// @apilevel 2
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct MLPlaneBoundariesList
        {
            public uint version;

            /// <summary>
            /// List of MLPlaneBoundaries
            /// @apilevel 2
            /// </summary>
            public IntPtr plane_boundaries;

            /// <summary>
            /// Count of MLPlaneBoundaries in the array
            /// @apilevel 2
            /// </summary>
            public uint plane_boundaries_count;
        }

        /// <summary>
        /// Type used to represent a plane query
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct MLPlanesQuery
        {
            /// <summary>
            /// The flags to apply to this query
            /// </summary>
            public uint flags;

            /// <summary>
            /// The center of the bounding box which defines where planes extraction should occur
            /// </summary>
            public MlTypes.MLVec3f bounds_center;

            /// <summary>
            /// The rotation of the bounding box where planes extraction will occur
            /// </summary>
            public MlTypes.MLQuaternionf bounds_rotation;

            /// <summary>
            /// The size of the bounding box where planes extraction will occur
            /// </summary>
            public MlTypes.MLVec3f bounds_extents;

            /// <summary>
            /// The maximum number of results that should be returned This is also
            /// the minimum expected size of the array of results passed to the
            /// MLPlanesGetResult function
            /// </summary>
            public uint max_results;

            /// <summary>
            /// The minimum area (in squared meters) of planes to be returned This value
            /// cannot be lower than 004 (lower values will be capped to this minimum)
            /// A good default value is 025
            /// </summary>
            public float min_plane_area;
        }

        /// <summary>
        /// Create a planes tracker
        /// MLResult_InvalidParam The parameter out_handle was not valid (null)
        /// MLResult_Ok The planes tracker was created successfully
        /// MLResult_UnspecifiedFailure The operation failed with an unspecified error
        /// </summary>
        /// <param name="out_handle">A pointer to an MLHandle which will contain the handle to the planes tracker
        /// If this operation fails, out_handle will be ML_INVALID_HANDLE</param>
        /// <remarks>
        /// @priv WorldReconstruction
        /// </remarks>
        [DllImport("ml_perception_client", CallingConvention = CallingConvention.Cdecl)]
        public static extern MlApi.MLResult MLPlanesCreate(ref MlApi.MLHandle out_handle);

        /// <summary>
        /// Destroy a planes tracker
        /// MLResult_Ok The planes tracker was successfully destroyed
        /// MLResult_UnspecifiedFailure The operation failed with an unspecified error
        /// </summary>
        /// <param name="planes_tracker">MLHandle to planes tracker to destroy</param>
        /// <remarks>
        /// @priv WorldReconstruction
        /// </remarks>
        [DllImport("ml_perception_client", CallingConvention = CallingConvention.Cdecl)]
        public static extern MlApi.MLResult MLPlanesDestroy(MlApi.MLHandle planes_tracker);

        /// <summary>
        /// Initiates a plane query
        /// MLResult_InvalidParam A parameter was not valid (null)
        /// MLResult_Ok Planes query was successfully submitted
        /// MLResult_UnspecifiedFailure The operation failed with an unspecified error
        /// </summary>
        /// <param name="planes_tracker">Handle produced by MLPlanesCreate</param>
        /// <param name="query">Pointer to MLPlanesQuery structure containing query parameters</param>
        /// <param name="out_handle">A pointer to an MLHandle which will contain the handle to the query
        /// If this operation fails, out_handle will be ML_INVALID_HANDLE</param>
        /// <remarks>
        /// @priv WorldReconstruction
        /// </remarks>
        [DllImport("ml_perception_client", CallingConvention = CallingConvention.Cdecl)]
        public static extern MlApi.MLResult MLPlanesQueryBegin(MlApi.MLHandle planes_tracker, in MlPlanes.MLPlanesQuery query, ref MlApi.MLHandle out_handle);

        /// <summary>
        /// Gets the result of a plane query with boundaries on each plane
        /// After this function has returned successfully, the handle is invalid and should be discarded
        /// Also check MLPlanesQueryFlag_Polygons description for this API's further behavior
        /// MLResult_Ok Query completed and out_results has been populated
        /// MLResult_Pending Query has not yet completed This is not a failure
        /// MLResult_UnspecifiedFailure The operation failed with an unspecified error
        /// </summary>
        /// <param name="planes_tracker">Handle produced by MLPlanesCreate</param>
        /// <param name="planes_query">Handle produced by MLPlanesQueryBegin</param>
        /// <param name="out_results">An array of MLPlane structures</param>
        /// <param name="out_num_results">The count of results pointed to by out_results</param>
        /// <param name="out_boundaries">A pointer to MLPlaneBoundariesList for the returned polygons
        /// If out_boundaries is NULL, the function call will not return any polygons,
        /// otherwise *out_boundaries must be zero initialized</param>
        /// <remarks>
        /// @apilevel 2
        /// @priv WorldReconstruction
        /// </remarks>
        [DllImport("ml_perception_client", CallingConvention = CallingConvention.Cdecl)]
        public static extern MlApi.MLResult MLPlanesQueryGetResultsWithBoundaries(MlApi.MLHandle planes_tracker, MlApi.MLHandle planes_query, ref MlPlanes.MLPlane out_results, ref uint out_num_results, ref MlPlanes.MLPlaneBoundariesList out_boundaries);

        /// <summary>
        /// Release the polygons data owned by the MLPlaneBoundariesList
        /// Also, check MLPlanesQueryFlag_Polygons description for this API's further behavior
        /// MLResult_InvalidParam A parameter was not valid (null)
        /// MLResult_Ok memory pointed by plane_boundaries is released successfully
        /// MLResult_UnspecifiedFailure The operation failed with an unspecified error
        /// </summary>
        /// <param name="planes_tracker"></param>
        /// <param name="plane_boundaries">Polygons Pointer to the MLPlaneBoundariessList</param>
        /// <remarks>
        /// @apilevel 2
        /// @priv WorldReconstruction
        /// </remarks>
        [DllImport("ml_perception_client", CallingConvention = CallingConvention.Cdecl)]
        public static extern MlApi.MLResult MLPlanesReleaseBoundariesList(MlApi.MLHandle planes_tracker, ref MlPlanes.MLPlaneBoundariesList plane_boundaries);
    }
}