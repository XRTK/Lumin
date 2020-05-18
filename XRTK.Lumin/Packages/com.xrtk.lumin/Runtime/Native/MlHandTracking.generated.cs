//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using UnityEngine;

namespace XRTK.Lumin.Native
{
    using System.Runtime.InteropServices;

    internal static class MlHandTracking
    {
        /// <summary>
        /// Available hand types
        /// </summary>
        public enum MLHandType : int
        {
            /// <summary>
            /// Left hand
            /// </summary>
            MLHandType_Left,

            /// <summary>
            /// Right hand
            /// </summary>
            MLHandType_Right,

            /// <summary>
            /// Number of hands
            /// </summary>
            MLHandType_Count,

            /// <summary>
            /// Ensure enum is represented as 32 bits
            /// </summary>
            MLHandType_Ensure32Bits = unchecked((int)0x7FFFFFFF),
        }

        /// <summary>
        /// Maximum number of key points per gesture
        /// </summary>
        public const int MLHandTrackingStaticData_MaxKeyPoints = unchecked((int)24);

        /// <summary>
        /// Static key pose types which are available when both hands are separated
        /// </summary>
        /// <remarks>
        /// @apilevel 6
        /// </remarks>
        public enum MLHandTrackingKeyPose : int
        {
            /// <summary>
            /// Index finger
            /// </summary>
            Finger = unchecked((int)0),

            /// <summary>
            /// A closed fist
            /// </summary>
            Fist = unchecked((int)1),

            /// <summary>
            /// A pinch
            /// </summary>
            Pinch = unchecked((int)2),

            /// <summary>
            /// A closed fist with the thumb pointed up
            /// </summary>
            Thumb = unchecked((int)3),

            /// <summary>
            /// An L shape
            /// </summary>
            L = unchecked((int)4),

            /// <summary>
            /// An open hand with palm facing away or palm facing towards the user
            /// </summary>
            OpenHand = unchecked((int)5),

            /// <summary>
            /// A pinch with all fingers, except the index finger and the thumb, extended out
            /// </summary>
            Ok = unchecked((int)6),

            /// <summary>
            /// A rounded 'C' alphabet shape
            /// </summary>
            C = unchecked((int)7),

            /// <summary>
            /// No pose was recognized
            /// </summary>
            NoPose = unchecked((int)8),

            /// <summary>
            /// No hand was detected Should be the last pose
            /// </summary>
            NoHand = unchecked((int)9),

            /// <summary>
            /// Number of static poses
            /// </summary>
            MLHandTrackingKeyPose_Count = unchecked((int)10),

            /// <summary>
            /// Ensure enum is represented as 32 bits
            /// </summary>
            MLHandTrackingKeyPose_Ensure32Bits = unchecked((int)0x7FFFFFFF),
        }

        /// <summary>
        /// The index ordering of 24 keypoints exposed in array keypoints_mask[MLHandTrackingStaticData_MaxKeyPoints]
        /// and left/right_frame[MLHandTrackingStaticData_MaxKeyPoints]
        /// </summary>
        /// <remarks>
        /// @apilevel 7
        /// </remarks>
        public enum MLHandTrackingKeyPoint : int
        {
            Thumb_Tip = unchecked((int)0),

            Thumb_IP,

            Thumb_MCP,

            Thumb_CMC,

            Index_Tip,

            Index_DIP,

            Index_PIP,

            Index_MCP,

            Middle_Tip,

            Middle_DIP,

            Middle_PIP,

            Middle_MCP,

            Ring_Tip,

            Ring_DIP,

            Ring_PIP,

            Ring_MCP,

            Pinky_Tip,

            Pinky_DIP,

            Pinky_PIP,

            Pinky_MCP,

            Wrist_Center,

            Wrist_Ulnar,

            Wrist_Radial,

            Hand_Center,

            /// <summary>
            /// Maximum number of key points per gesture
            /// </summary>
            MLHandTrackingKeyPoint_Count = unchecked((int)MLHandTrackingStaticData_MaxKeyPoints),

            /// <summary>
            /// Maximum number of key points per gesture
            /// </summary>
            MLHandTrackingKeyPoint_Ensure32Bits = unchecked((int)0x7FFFFFFF),
        }

        /// <summary>
        /// Keypoint data structure
        /// </summary>
        [Serializable]
        [StructLayout(LayoutKind.Sequential)]
        public struct MLKeyPointState
        {
            /// <summary>
            /// Keypoint coordinate frame
            /// Only the position component of the transform contains valid data
            /// The orientation component is same as head pose orientation
            /// </summary>
            public MlTypes.MLCoordinateFrameUID frame_id;

            /// <summary>
            /// Keypoint is valid or not
            /// </summary>
            [MarshalAs(UnmanagedType.U1)]
            public bool is_valid;

            public override string ToString()
            {
                return $"{nameof(is_valid)}:{is_valid}";
            }
        }

        /// <summary>
        /// Thumb data structure
        /// </summary>
        [Serializable]
        [StructLayout(LayoutKind.Sequential)]
        public struct MLThumbState
        {
            /// <summary>
            /// Tip of finger
            /// </summary>
            public MlHandTracking.MLKeyPointState tip;

            /// <summary>
            /// Inter-phalengial
            /// </summary>
            public MlHandTracking.MLKeyPointState ip;

            /// <summary>
            /// Meta-carpal phalengial
            /// </summary>
            public MlHandTracking.MLKeyPointState mcp;

            /// <summary>
            /// Carpals-Meta-carpal
            /// </summary>
            public MlHandTracking.MLKeyPointState cmc;

            public override string ToString()
            {
                return $"{nameof(tip)}:{tip}|{nameof(ip)}:{ip}|{nameof(mcp)}:{mcp}|{nameof(cmc)}:{cmc}";
            }
        }

        /// <summary>
        /// Finger data structure
        /// </summary>
        [Serializable]
        [StructLayout(LayoutKind.Sequential)]
        public struct MLFingerState
        {
            /// <summary>
            /// Tip of finger
            /// </summary>
            public MlHandTracking.MLKeyPointState tip;

            /// <summary>
            /// Distal-inter-phalengial
            /// </summary>
            public MlHandTracking.MLKeyPointState dip;

            /// <summary>
            /// Proximal-inter-phalengial
            /// </summary>
            public MlHandTracking.MLKeyPointState pip;

            /// <summary>
            /// Meta-carpal phalengial
            /// </summary>
            public MlHandTracking.MLKeyPointState mcp;

            public override string ToString()
            {
                return $"{nameof(tip)}:{tip}|{nameof(dip)}:{dip}|{nameof(mcp)}:{mcp}|{nameof(mcp)}:{mcp}";
            }
        }

        /// <summary>
        /// Wrist data structure
        /// </summary>
        [Serializable]
        [StructLayout(LayoutKind.Sequential)]
        public struct MLWristState
        {
            /// <summary>
            /// Wrist center
            /// </summary>
            public MlHandTracking.MLKeyPointState center;

            /// <summary>
            /// Ulnar-sided wrist
            /// </summary>
            public MlHandTracking.MLKeyPointState ulnar;

            /// <summary>
            /// Radial-sided wrist
            /// </summary>
            public MlHandTracking.MLKeyPointState radial;

            public override string ToString()
            {
                return $"{nameof(center)}:{center}|{nameof(ulnar)}:{ulnar}|{nameof(radial)}:{radial}";
            }
        }

        /// <summary>
        /// Static information for one hand
        /// </summary>
        [Serializable]
        [StructLayout(LayoutKind.Sequential)]
        public struct MLHandTrackingStaticHandState
        {
            /// <summary>
            /// The keypoints on thumb
            /// </summary>
            public MlHandTracking.MLThumbState thumb;

            /// <summary>
            /// The keypoints on index finger
            /// </summary>
            public MlHandTracking.MLFingerState index;

            /// <summary>
            /// The keypoints on middle finger
            /// </summary>
            public MlHandTracking.MLFingerState middle;

            /// <summary>
            /// The keypoints on ring finger
            /// </summary>
            public MlHandTracking.MLFingerState ring;

            /// <summary>
            /// The keypoints on pinky finger
            /// </summary>
            public MlHandTracking.MLFingerState pinky;

            /// <summary>
            /// The keypoints on the wrist
            /// </summary>
            public MlHandTracking.MLWristState wrist;

            /// <summary>
            /// Hand center
            /// </summary>
            public MlHandTracking.MLKeyPointState hand_center;

            public override string ToString()
            {
                return $"{nameof(hand_center)}:{hand_center}\n{nameof(wrist)}:{wrist}\n{nameof(thumb)}:{thumb}\n{nameof(index)}:{index}\n{nameof(middle)}:{middle}\n{nameof(ring)}:{ring}\n{nameof(pinky)}:{pinky}";
            }
        }

        /// <summary>
        /// Static information about a hand tracker Populate this structure with <see cref="MLHandTrackingGetStaticData"/>
        /// </summary>
        [Serializable]
        [StructLayout(LayoutKind.Sequential)]
        public struct MLHandTrackingStaticData
        {
            /// <summary>
            /// Left hand frame
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
            public MlHandTracking.MLKeyPointState[] left_frame;

            /// <summary>
            /// Left hand state
            /// </summary>
            public MlHandTracking.MLHandTrackingStaticHandState left;

            /// <summary>
            /// Right hand frame
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
            public MlHandTracking.MLKeyPointState[] right_frame;

            /// <summary>
            /// Right hand state
            /// </summary>
            public MlHandTracking.MLHandTrackingStaticHandState right;

            public override string ToString()
            {
                return $"{nameof(left)}:{left}\n{nameof(right)}:{right}";
            }
        }

        /// <summary>
        /// State of a single hand.
        /// </summary>
        [Serializable]
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public unsafe struct MLHandTrackingHandState
        {
            /// <summary>
            /// The static keypose currently being performed by the single hand.
            /// </summary>
            public MLHandTrackingKeyPose keypose;

            /// <summary>
            /// The confidence level of a hand is present in the scene. Value is between [0, 1], 0 is low, 1 is high degree of confidence.
            /// </summary>
            public float hand_confidence;

            /// <summary>
            /// The confidence for all poses.
            /// </summary>
            public fixed float keypose_confidence[10];

            /// <summary>
            /// The filtered confidence for all poses.
            /// </summary>
            public fixed float keypose_confidence_filtered[10];

            /// <summary>
            /// Mask indicates if a keypoint is present or not.
            /// </summary>
            [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.U1, SizeConst = 24)]
            public bool[] keypoints_mask;

            /// <summary>
            /// Normalized position of hand center within depth-sensor view. Each dimension is between [-1, 1].
            /// </summary>
            public MlTypes.MLVec3f hand_center_normalized;

            public override string ToString()
            {
                return $"{nameof(hand_confidence)}:{hand_confidence}|{nameof(hand_center_normalized)}:{hand_center_normalized}";
            }
        }

        /// <summary>
        ///  Data which is received when querying hand tracker from <see cref="MLHandTrackingGetData"/>
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public partial struct MLHandTrackingData
        {
            /// <summary>
            /// Hand tracker state of the left hand.
            /// </summary>
            public MLHandTrackingHandState left_hand_state;

            /// <summary>
            /// Hand tracker state of the right hand.
            /// </summary>
            public MLHandTrackingHandState right_hand_state;
            public override string ToString()
            {
                return $"{nameof(left_hand_state)}:{left_hand_state}\n{nameof(left_hand_state)}:{right_hand_state}";
            }
        }

        /// <summary>
        /// Extended state of a single hand
        /// </summary>
        /// <remarks>
        /// @apilevel 7
        /// </remarks>
        [Serializable]
        [StructLayout(LayoutKind.Sequential)]
        public struct MLHandTrackingHandStateEx
        {
            /// <summary>
            /// The static keypose currently being performed by the single hand
            /// </summary>
            public MlHandTracking.MLHandTrackingKeyPose keypose;

            /// <summary>
            /// The confidence level of a hand is present in the scene
            /// </summary>
            /// <remarks>
            /// Value is between [0, 1], 0 is low, 1 is high degree of confidence
            /// </remarks>
            public float hand_confidence;

            public float keypose_confidence_finger;

            public float keypose_confidence_fist;

            public float keypose_confidence_pinch;

            public float keypose_confidence_thumb;

            public float keypose_confidence_l;

            public float keypose_confidence_open_hand;

            public float keypose_confidence_ok;

            public float keypose_confidence_c;

            public float keypose_confidence_no_pose;

            public float keypose_confidence_no_hand;

            public float keypose_confidence_filtered_finger;

            public float keypose_confidence_filtered_fist;

            public float keypose_confidence_filtered_pinch;

            public float keypose_confidence_filtered_thumb;

            public float keypose_confidence_filtered_l;

            public float keypose_confidence_filtered_open_hand;

            public float keypose_confidence_filtered_ok;

            public float keypose_confidence_filtered_c;

            public float keypose_confidence_filtered_no_pose;

            public float keypose_confidence_filtered_no_hand;

            [MarshalAs(UnmanagedType.U1)]
            public bool keypoints_mask_thumb_tip;

            [MarshalAs(UnmanagedType.U1)]
            public bool keypoints_mask_thumb_ip;

            [MarshalAs(UnmanagedType.U1)]
            public bool keypoints_mask_thumb_mcp;

            [MarshalAs(UnmanagedType.U1)]
            public bool keypoints_mask_thumb_cmc;

            [MarshalAs(UnmanagedType.U1)]
            public bool keypoints_mask_index_tip;

            [MarshalAs(UnmanagedType.U1)]
            public bool keypoints_mask_index_dip;

            [MarshalAs(UnmanagedType.U1)]
            public bool keypoints_mask_index_pip;

            [MarshalAs(UnmanagedType.U1)]
            public bool keypoints_mask_index_mcp;

            [MarshalAs(UnmanagedType.U1)]
            public bool keypoints_mask_middle_tip;

            [MarshalAs(UnmanagedType.U1)]
            public bool keypoints_mask_middle_dip;

            [MarshalAs(UnmanagedType.U1)]
            public bool keypoints_mask_middle_pip;

            [MarshalAs(UnmanagedType.U1)]
            public bool keypoints_mask_middle_mcp;

            [MarshalAs(UnmanagedType.U1)]
            public bool keypoints_mask_ring_tip;

            [MarshalAs(UnmanagedType.U1)]
            public bool keypoints_mask_ring_dip;

            [MarshalAs(UnmanagedType.U1)]
            public bool keypoints_mask_ring_pip;

            [MarshalAs(UnmanagedType.U1)]
            public bool keypoints_mask_ring_mcp;

            [MarshalAs(UnmanagedType.U1)]
            public bool keypoints_mask_pinky_tip;

            [MarshalAs(UnmanagedType.U1)]
            public bool keypoints_mask_pinky_dip;

            [MarshalAs(UnmanagedType.U1)]
            public bool keypoints_mask_pinky_pip;

            [MarshalAs(UnmanagedType.U1)]
            public bool keypoints_mask_pinky_mcp;

            [MarshalAs(UnmanagedType.U1)]
            public bool keypoints_mask_wrist_center;

            [MarshalAs(UnmanagedType.U1)]
            public bool keypoints_mask_wrist_ulnar;

            [MarshalAs(UnmanagedType.U1)]
            public bool keypoints_mask_wrist_radial;

            [MarshalAs(UnmanagedType.U1)]
            public bool keypoints_mask_hand_center;

            /// <summary>
            /// Normalized position of hand center within depth-sensor view Each dimension is between [-1, 1]
            /// </summary>
            public MlTypes.MLVec3f hand_center_normalized;

            /// <summary>
            /// Is control currently being held in the single hand
            /// </summary>
            [MarshalAs(UnmanagedType.U1)]
            public bool is_holding_control;

            public override string ToString()
            {
                return $"{nameof(hand_confidence)}:{hand_confidence}|{nameof(is_holding_control)}:{is_holding_control}|{nameof(hand_center_normalized)}:{hand_center_normalized}";
            }
        }

        /// <summary>
        /// Data which is received when querying hand tracker from MLHandTrackingGetDataEx
        /// </summary>
        /// <remarks>
        /// This structure must be initialized by calling MLHandTrackingDataExInit before use
        /// @apilevel 7
        /// </remarks>
        [Serializable]
        [StructLayout(LayoutKind.Sequential)]
        public struct MLHandTrackingDataEx
        {
            /// <summary>
            /// Version of this structure
            /// </summary>
            public uint version;

            /// <summary>
            /// Hand tracker state of the left hand
            /// </summary>
            public MlHandTracking.MLHandTrackingHandStateEx left_hand_state;

            /// <summary>
            /// Hand tracker state of the right hand
            /// </summary>
            public MlHandTracking.MLHandTrackingHandStateEx right_hand_state;

            public override string ToString()
            {
                return $"{nameof(left_hand_state)}:{left_hand_state}\n{nameof(left_hand_state)}:{right_hand_state}";
            }
        }

        /// <summary>
        /// Configuration of the hand tracking system This is used to activate or
        /// deactivate the poses the system will look for
        /// </summary>
        [Serializable]
        [StructLayout(LayoutKind.Sequential)]
        public struct MLHandTrackingConfiguration
        {
            /// <summary>
            /// Configuration for the static poses True will enable the pose to be
            /// tracked by the system, false will disable it Note that the size of keypose_config
            /// is set to MLHandTrackingKeyPose_Count-1 Disabling NoHand is not allowed
            /// If a disabled pose is performed, the most probable enabled pose will be reported
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, ArraySubType = UnmanagedType.U1, SizeConst = 9)]
            public bool[] keypose_config;

            /// <summary>
            /// True activates hand tracking False deactivates the handtracking pipeline
            /// entirely and no recognition will take place
            /// </summary>
            [MarshalAs(UnmanagedType.U1)]
            public bool handtracking_pipeline_enabled;

            /// <summary>
            /// Keypoint filter levels
            /// </summary>
            public MLKeyPointFilterLevel key_points_filter_level;

            /// <summary>
            /// Pose filter levels
            /// </summary>
            public MLPoseFilterLevel pose_filter_level;

            public override string ToString()
            {
                return JsonUtility.ToJson(this, true);
            }
        }

        /// <summary>
        /// Creates a hand tracker
        /// MLResult_InvalidParam out_handle is null
        /// MLResult_Ok The tracker was created successfully
        /// MLResult_PrivilegeDenied The application lacks privilege
        /// MLResult_UnspecifiedFailure It failed to create the tracker
        /// </summary>
        /// <param name="out_handle">A pointer to an MLHandle which can be used with MLHandTrackingGetData
        /// to get information about the hand, or ML_INVALID_HANDLE if the tracker could not be created</param>
        /// <remarks>
        /// @priv LowLatencyLightwear
        /// </remarks>
        [DllImport("ml_perception_client", CallingConvention = CallingConvention.Cdecl)]
        public static extern MlApi.MLResult MLHandTrackingCreate(ref MlApi.MLHandle out_handle);

        /// <summary>
        /// Destroys a hand tracker
        /// MLResult_Ok It successfully destroyed the tracker
        /// MLResult_UnspecifiedFailure It failed to destroy the tracker
        /// </summary>
        /// <param name="hand_tracker">A handle to a Hand Tracker created by MLHandTrackingCreate</param>
        /// <remarks>
        /// @priv LowLatencyLightwear
        /// </remarks>
        [DllImport("ml_perception_client", CallingConvention = CallingConvention.Cdecl)]
        public static extern MlApi.MLResult MLHandTrackingDestroy(MlApi.MLHandle hand_tracker);

        /// <summary>
        /// Queries the current state of the hand tracker.@retval MLResult_InvalidParam out_data is null.
        /// MLResult_Ok The hand information was available and the information in out_data is valid.
        /// MLResult_UnspecifiedFailure It failed to get the hand information.
        /// </summary>
        /// <param name="hand_tracker">A handle to a Hand Tracker created by MLHandTrackingCreate().</param>
        /// <param name="out_data">Pointer to a variable that receives information about the tracked hands.</param>
        /// <remarks>
        /// @priv LowLatencyLightwear
        /// </remarks>
        [DllImport("ml_perception_client", CallingConvention = CallingConvention.Cdecl)]
        public static extern MlApi.MLResult MLHandTrackingGetData(MlApi.MLHandle hand_tracker, ref MLHandTrackingData out_data);

        /// <summary>
        /// Initializes default values for <see cref="MLHandTrackingDataEx"/>.
        /// </summary>
        /// <param name="out_data"></param>
        [DllImport("ml_perception_client", CallingConvention = CallingConvention.Cdecl)]
        public static extern void MLHandTrackingDataExInit(ref MlHandTracking.MLHandTrackingDataEx out_data);

        /// <summary>
        /// Queries the state of the hand tracker
        /// MLResult_InvalidParam out_data is null
        /// MLResult_Ok The hand information was available and the information in out_data is valid
        /// MLResult_UnspecifiedFailure It failed to get the hand information
        /// </summary>
        /// <param name="hand_tracker">A handle to a Hand Tracker created by MLHandTrackingCreate</param>
        /// <param name="out_data">Pointer to a variable that receives information about the tracked hands</param>
        /// <remarks>
        /// @apilevel 7
        /// @priv LowLatencyLightwear
        /// </remarks>
        [DllImport("ml_perception_client", CallingConvention = CallingConvention.Cdecl)]
        public static extern MlApi.MLResult MLHandTrackingGetDataEx(MlApi.MLHandle hand_tracker, ref MlHandTracking.MLHandTrackingDataEx out_data);

        /// <summary>
        /// Gets static information about hand tracking
        /// MLResult_InvalidParam out_data is null
        /// MLResult_Ok The hand information was available and the information in out_data is valid
        /// MLResult_PrivilegeDenied The application lacks privilege
        /// MLResult_UnspecifiedFailure It failed to get the hand information
        /// </summary>
        /// <param name="hand_tracker">A handle to a Hand Tracker created by MLHandTrackingCreate</param>
        /// <param name="out_data">Pointer to a variable that receives static data about the hand tracker</param>
        /// <remarks>
        /// @priv LowLatencyLightwear, GesturesSubscribe
        /// </remarks>
        [DllImport("ml_perception_client", CallingConvention = CallingConvention.Cdecl)]
        public static extern MlApi.MLResult MLHandTrackingGetStaticData(MlApi.MLHandle hand_tracker, ref MlHandTracking.MLHandTrackingStaticData out_data);

        /// <summary>
        /// Sets the configuration of the hand tracking system
        /// MLResult_InvalidParam config is null
        /// MLResult_Ok It successfully updated the hand configuration
        /// MLResult_PrivilegeDenied The application lacks privilege
        /// MLResult_UnspecifiedFailure It failed to update the hand configuration
        /// </summary>
        /// <param name="hand_tracker">A handle to a Hand Tracker created by MLHandTrackingCreate</param>
        /// <param name="out_config">Pointer to a variable that contains the configuration</param>
        /// <remarks>
        /// @priv GesturesConfig
        /// </remarks>
        [DllImport("ml_perception_client", CallingConvention = CallingConvention.Cdecl)]
        public static extern MlApi.MLResult MLHandTrackingSetConfiguration(MlApi.MLHandle hand_tracker, ref MlHandTracking.MLHandTrackingConfiguration out_config);

        /// <summary>
        /// Gets the current configuration of the hand tracking system
        /// MLResult_InvalidParam out_config is null
        /// MLResult_Ok The information in out_config is valid
        /// MLResult_PrivilegeDenied The application lacks privilege
        /// MLResult_UnspecifiedFailure It failed to get the current configuration
        /// </summary>
        /// <param name="hand_tracker">A handle to a Hand Tracker created by MLHandTrackingCreate</param>
        /// <param name="out_config">Pointer to a variable that receives information about the current configuration</param>
        /// <remarks>
        /// @priv GesturesConfig, GesturesSubscribe
        /// </remarks>
        [DllImport("ml_perception_client", CallingConvention = CallingConvention.Cdecl)]
        public static extern MlApi.MLResult MLHandTrackingGetConfiguration(MlApi.MLHandle hand_tracker, ref MlHandTracking.MLHandTrackingConfiguration out_config);
    }
}
