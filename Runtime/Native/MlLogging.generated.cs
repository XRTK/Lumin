//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XRTK.Lumin.Native
{
    using System.Runtime.InteropServices;

    internal static class MlLogging
    {
        /// <summary>
        /// The maximum length of a log tag Tags will be truncated if longer
        /// </summary>
        public const int MLLogging_MaxTagLength = unchecked((int)23);

        /// <summary>
        /// Log levels
        /// </summary>
        public enum MLLogLevel : int
        {
            /// <summary>
            /// Output a fatal error which causes program termination
            /// </summary>
            MLLogLevel_Fatal = unchecked((int)0),

            /// <summary>
            /// Output a serious error The program may continue
            /// </summary>
            MLLogLevel_Error = unchecked((int)1),

            /// <summary>
            /// Output a warning which may be ignorable
            /// </summary>
            MLLogLevel_Warning = unchecked((int)2),

            /// <summary>
            /// Output an informational message
            /// </summary>
            MLLogLevel_Info = unchecked((int)3),

            /// <summary>
            /// Output a message used during debugging
            /// </summary>
            MLLogLevel_Debug = unchecked((int)4),

            /// <summary>
            /// Output a message used for noisier informational messages
            /// </summary>
            MLLogLevel_Verbose = unchecked((int)5),

            /// <summary>
            /// Ensure enum is represented as 32 bits
            /// </summary>
            MLLogLevel_Ensure32Bits = unchecked((int)0x7FFFFFFF),
        }

        /// <summary>
        /// Enable output of log messages up to and including the log level
        /// </summary>
        /// <param name="level">The MLLogLevel to enable</param>
        /// <remarks>
        /// Log level filtering is enforced only when logging through the convenience
        /// macros (ML_LOG, ML_LOG_TAG, etc) Any log messages below or equal to the
        /// specified log level will be output The default log level is MLLogLevel_Info
        /// @priv None
        /// </remarks>
        [DllImport("ml_ext_logging", CallingConvention = CallingConvention.Cdecl)]
        public static extern void MLLoggingEnableLogLevel(MlLogging.MLLogLevel level);

        /// <summary>
        /// Check whether or not a log level is currently enabled
        /// </summary>
        /// <param name="level">The MLLogLevel to check</param>
        /// <returns>
        /// @c true if the log level is currently enabled, @c false otherwise
        /// </returns>
        /// <remarks>
        /// @priv None
        /// </remarks>
        [DllImport("ml_ext_logging", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern bool MLLoggingLogLevelIsEnabled(MlLogging.MLLogLevel level);

        /// <summary>
        /// Convert a format specification string into single buffer that is then output
        /// </summary>
        /// <param name="level">The MLLogLevel at which to log the message</param>
        /// <param name="tag">The tag to use for this log message Tag will be truncated to
        /// MLLogging_MaxTagLength characters</param>
        /// <param name="fmt">The printf style format specification string</param>
        /// <remarks>
        /// This function does not filter the message against the currently
        /// enabled log level, only the convenience macros filter against the log level
        /// @priv None
        /// </remarks>
        [DllImport("ml_ext_logging", CallingConvention = CallingConvention.Cdecl)]
        public static extern void MLLoggingLogVargs(MlLogging.MLLogLevel level, [MarshalAs(UnmanagedType.LPStr)] string tag, [MarshalAs(UnmanagedType.LPStr)] string fmt);

        /// <summary>
        /// Raw logging function This function does not filter the message against
        /// the currently enabled log level, it will simply output the given message
        /// </summary>
        /// <param name="level">The MLLogLevel at which to log the message</param>
        /// <param name="tag">The tag to use for this log message Tag will be truncated to
        /// MLLogging_MaxTagLength characters</param>
        /// <param name="message">The full contents of the log message</param>
        /// <remarks>
        /// Only the convenience macros filter against the log level
        /// @priv None
        /// </remarks>
        [DllImport("ml_ext_logging", CallingConvention = CallingConvention.Cdecl)]
        public static extern void MLLoggingLog(MlLogging.MLLogLevel level, [MarshalAs(UnmanagedType.LPStr)] string tag, [MarshalAs(UnmanagedType.LPStr)] string message);
    }
}