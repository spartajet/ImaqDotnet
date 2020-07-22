using System;
using System.Collections.Generic;
using System.Text;
using ImaqDotnet;

namespace ImaqDotnet
{
    public class ImaqAttributeDefines
    {
        #region LUT

        public const uint IMG_LUT_NORMAL = 0;
        public const uint IMG_LUT_INVERSE = 1;
        public const uint IMG_LUT_LOG = 2;
        public const uint IMG_LUT_INVERSE_LOG = 3;
        public const uint IMG_LUT_BINARY = 4;
        public const uint IMG_LUT_INVERSE_BINARY = 5;
        public const uint IMG_LUT_USER = 6;

        const ushort IMG_LUT_TYPE_DEFAULT = 0x00000010;
        const ushort IMG_LUT_TYPE_RED = 0x00000020;
        const ushort IMG_LUT_TYPE_GREEN = 0x00000040;
        const ushort IMG_LUT_TYPE_BLUE = 0x00000080;
        const ushort IMG_LUT_TYPE_TAP0 = 0x00000100;
        const ushort IMG_LUT_TYPE_TAP1 = 0x00000200;
        const ushort IMG_LUT_TYPE_TAP2 = 0x00000400;
        const ushort IMG_LUT_TYPE_TAP3 = 0x00000800;

        #endregion

        #region Frame or Field Mode

        public const uint IMG_FIELD_MODE = 0;
        public const uint IMG_FRAME_MODE = 1;

        #endregion

        #region Chrominance Filters

        public const uint IMG_FILTER_NONE = 0;
        public const uint IMG_FILTER_NTSC = 1;
        public const uint IMG_FILTER_PAL = 2;

        #endregion

        #region Possible start field values

        public const uint IMG_FIELD_EVEN = 0;
        public const uint IMG_FIELD_ODD = 1;

        #endregion

        #region Scaling

        public const uint IMG_SCALE_NONE = 1;
        public const uint IMG_SCALE_DIV2 = 2;
        public const uint IMG_SCALE_DIV4 = 4;
        public const uint IMG_SCALE_DIV8 = 8;

        #endregion

        #region Triggering Mode

        public const uint IMG_TRIGMODE_NONE = 0;
        public const uint IMG_TRIGMODE_NOREPEAT = 1;
        public const uint IMG_TRIGMODE_REPEAT = 2;

        #endregion

        #region Field Acquisition Selection

        public const uint IMG_ACQUIRE_EVEN = 0;
        public const uint IMG_ACQUIRE_ODD = 1;
        public const uint IMG_ACQUIRE_ALL = 2;
        public const uint IMG_ACQUIRE_ALTERNATING = 3;

        #endregion

        #region Luma bandwidth

        public const uint
            IMG_COLOR_LUMA_BANDWIDTH_FULL =
                0; // All filters including decimation filter disabled. Default for CCIR or RS-170

        public const uint
            IMG_COLOR_LUMA_BANDWIDTH_HIGH =
                1; // Highest available bandwidth with decimation filter enabled. Default for PAL or NTSC

        public const uint IMG_COLOR_LUMA_BANDWIDTH_MEDIUM = 2; // Decimation filtered enabled, medium bandwidth.
        public const uint IMG_COLOR_LUMA_BANDWIDTH_LOW = 3; // Decimation filtered enabled, lowest bandwidth.

        #endregion

        #region Comb filters

        public const uint IMG_COLOR_COMB_OFF = 0; // Comb filtered disabled (default in S-Video/Y/C mode)
        public const uint IMG_COLOR_COMB_1LINE = 1; // Comb filtered using 1 delayed line
        public const uint IMG_COLOR_COMB_2LINES = 2; // Comb filtered using 2 delayed lines

        #endregion

        #region Chroma processing

        public const uint
            IMG_COLOR_CHROMA_PROCESS_ALWAYS_OFF =
                0; // should be used when a monochrome camera is used. Default for RS-170 or CCIR

        public const uint
            IMG_COLOR_CHROMA_PROCESS_ALWAYS_ON =
                1; // should be used when a color camera is used.  Default for NTSC or PAL

        public const uint IMG_COLOR_CHROMA_PROCESS_AUTODETECT = 2; // can be used if the camera type is unknown.

        #endregion

        #region Chroma bandwidth

        public const uint IMG_COLOR_CHROMA_BANDWIDTH_HIGH = 0; // Highest bandwidth (default)
        public const uint IMG_COLOR_CHROMA_BANDWIDTH_LOW = 1; // Lowest bandwidth

        #endregion

        #region RGB Coring

        public const uint IMG_COLOR_RGB_CORING_LEVEL_NOCORING = 0; // The coring function is disabled
        public const uint IMG_COLOR_RGB_CORING_LEVEL_C1 = 1; // Coring activated for saturation equal or below 1 lsb
        public const uint IMG_COLOR_RGB_CORING_LEVEL_C3 = 2; // Coring activated for saturation equal or below 3 lsb
        public const uint IMG_COLOR_RGB_CORING_LEVEL_C7 = 3; // Coring activated for saturation equal or below 7 lsb

        #endregion

        #region Video Signal Types

        public const uint IMG_VIDEO_NTSC = 0;
        public const uint IMG_VIDEO_PAL = 1;

        #endregion

        #region imgSessionExamineBuffer constants

        public const uint IMG_LAST_BUFFER = 0xFFFFFFFE;
        public const uint IMG_OLDEST_BUFFER = 0xFFFFFFFD;
        public const uint IMG_CURRENT_BUFFER = 0xFFFFFFFC;

        #endregion

        #region Buffer Element Specifiers

        public const uint IMG_BUFF_ADDRESS = ImaqAttributeKeys._IMG_BASE + 0x007E; //  void*
        public const uint IMG_BUFF_COMMAND = ImaqAttributeKeys._IMG_BASE + 0x007F; //  uInt32
        public const uint IMG_BUFF_SKIPCOUNT = ImaqAttributeKeys._IMG_BASE + 0x0080; //  uInt32
        public const uint IMG_BUFF_SIZE = ImaqAttributeKeys._IMG_BASE + 0x0082; //  uInt32
        public const uint IMG_BUFF_TRIGGER = ImaqAttributeKeys._IMG_BASE + 0x0083; //  uInt32
        public const uint IMG_BUFF_NUMBUFS = ImaqAttributeKeys._IMG_BASE + 0x00B0; //  uInt32
        public const uint IMG_BUFF_CHANNEL = ImaqAttributeKeys._IMG_BASE + 0x00Bc; //  uInt32
        public const uint IMG_BUFF_ACTUALHEIGHT = ImaqAttributeKeys._IMG_BASE + 0x0400; //  uInt32

        #endregion

        #region Possible Buffer Command Values

        public const uint IMG_CMD_NEXT = 0x01; // Proceed to next list entry

        public const uint
            IMG_CMD_LOOP = 0x02; // Loop back to start of buffer list and continue processing - RING ACQUISITION

        public const uint IMG_CMD_PASS = 0x04; // Do nothing here
        public const uint IMG_CMD_STOP = 0x08; // Stop
        public const uint IMG_CMD_INVALID = 0x10; // Reserved for internal use

        #endregion

        #region Possible Triggered Acquisition Actions

        public const uint IMG_TRIG_ACTION_NONE = 0; // no trigger action
        public const uint IMG_TRIG_ACTION_CAPTURE = 1; // one trigger required to start the acquisition once
        public const uint IMG_TRIG_ACTION_BUFLIST = 2; // one trigger required to start the buflist each time
        public const uint IMG_TRIG_ACTION_BUFFER = 3; // one trigger required for each buffer
        public const uint IMG_TRIG_ACTION_STOP = 4; // one trigger is used to stop the acquisition

        #endregion

        #region Old RTSI mapping constants (imgSessionSetRTSImap)

        public const uint IMG_TRIG_MAP_RTSI0_DISABLED = 0x0000000f;
        public const uint IMG_TRIG_MAP_RTSI0_EXT0 = 0x00000001;
        public const uint IMG_TRIG_MAP_RTSI0_EXT1 = 0x00000002;
        public const uint IMG_TRIG_MAP_RTSI0_EXT2 = 0x00000003;
        public const uint IMG_TRIG_MAP_RTSI0_EXT3 = 0x00000004;
        public const uint IMG_TRIG_MAP_RTSI0_EXT4 = 0x00000005;
        public const uint IMG_TRIG_MAP_RTSI0_EXT5 = 0x00000006;
        public const uint IMG_TRIG_MAP_RTSI0_EXT6 = 0x00000007;

        public const uint IMG_TRIG_MAP_RTSI1_DISABLED = 0x000000f0;
        public const uint IMG_TRIG_MAP_RTSI1_EXT0 = 0x00000010;
        public const uint IMG_TRIG_MAP_RTSI1_EXT1 = 0x00000020;
        public const uint IMG_TRIG_MAP_RTSI1_EXT2 = 0x00000030;
        public const uint IMG_TRIG_MAP_RTSI1_EXT3 = 0x00000040;
        public const uint IMG_TRIG_MAP_RTSI1_EXT4 = 0x00000050;
        public const uint IMG_TRIG_MAP_RTSI1_EXT5 = 0x00000060;
        public const uint IMG_TRIG_MAP_RTSI1_EXT6 = 0x00000070;

        public const uint IMG_TRIG_MAP_RTSI2_DISABLED = 0x00000f00;
        public const uint IMG_TRIG_MAP_RTSI2_EXT0 = 0x00000100;
        public const uint IMG_TRIG_MAP_RTSI2_EXT1 = 0x00000200;
        public const uint IMG_TRIG_MAP_RTSI2_EXT2 = 0x00000300;
        public const uint IMG_TRIG_MAP_RTSI2_EXT3 = 0x00000400;
        public const uint IMG_TRIG_MAP_RTSI2_EXT4 = 0x00000500;
        public const uint IMG_TRIG_MAP_RTSI2_EXT5 = 0x00000600;
        public const uint IMG_TRIG_MAP_RTSI2_EXT6 = 0x00000700;

        public const uint IMG_TRIG_MAP_RTSI3_DISABLED = 0x0000f000;
        public const uint IMG_TRIG_MAP_RTSI3_EXT0 = 0x00001000;
        public const uint IMG_TRIG_MAP_RTSI3_EXT1 = 0x00002000;
        public const uint IMG_TRIG_MAP_RTSI3_EXT2 = 0x00003000;
        public const uint IMG_TRIG_MAP_RTSI3_EXT3 = 0x00004000;
        public const uint IMG_TRIG_MAP_RTSI3_EXT4 = 0x00005000;
        public const uint IMG_TRIG_MAP_RTSI3_EXT5 = 0x00006000;
        public const uint IMG_TRIG_MAP_RTSI3_EXT6 = 0x00007000;

        #endregion

        #region Frame timeout values

        public const uint IMG_FRAMETIME_STANDARD = 100; //    100 milliseconds
        public const uint IMG_FRAMETIME_1SECOND = 1000; //   1000 milliseconds -  1 second
        public const uint IMG_FRAMETIME_2SECONDS = 2000; //   2000 milliseconds -  2 seconds
        public const uint IMG_FRAMETIME_5SECONDS = 5000; //   5000 milliseconds -  5 seconds
        public const uint IMG_FRAMETIME_10SECONDS = 10000; //  10000 milliseconds - 10 seconds
        public const uint IMG_FRAMETIME_1MINUTE = 60000; //  60000 milliseconds -  1 minute
        public const uint IMG_FRAMETIME_2MINUTES = 120000; // 120000 milliseconds -  2 minutes
        public const uint IMG_FRAMETIME_5MINUTES = 300000; // 300000 milliseconds -  5 minutes
        public const uint IMG_FRAMETIME_10MINUTES = 600000; // 600000 milliseconds - 10 minutes

        #endregion

        #region Timeout values

        public const uint IMG_TIMEOUT_INFINITE = 0xFFFFFFFF;

        #endregion

        #region Gain values

        public const uint IMG_GAIN_0DB = 0;
        public const uint IMG_GAIN_3DB = 1;
        public const uint IMG_GAIN_6DB = 2;

        #endregion

        #region Gain values for the 1409

        public const uint IMG_GAIN_2_00 = 0;
        public const uint IMG_GAIN_1_75 = 1;
        public const uint IMG_GAIN_1_50 = 2;
        public const uint IMG_GAIN_1_00 = 3;

        #endregion

        #region Analog bandwidth

        public const uint IMG_BANDWIDTH_FULL = 0;
        public const uint IMG_BANDWIDTH_9MHZ = 1;

        #endregion

        #region White and black reference ranges

        public const uint IMG_WHITE_REFERENCE_MIN = 0;
        public const uint IMG_WHITE_REFERENCE_MAX = 63;
        public const uint IMG_BLACK_REFERENCE_MIN = 0;
        public const uint IMG_BLACK_REFERENCE_MAX = 63;

        #endregion

        #region Possible Trigger Polarities

        public const uint IMG_TRIG_POLAR_ACTIVEH = 0;
        public const uint IMG_TRIG_POLAR_ACTIVEL = 1;

        #endregion

        #region The Trigger Lines

        //  Important!!!  If you change the number of lines or add a different
        //  kind of line, be sure to update IsExtTrigLine(), IsRTSILine(), or add
        //  a new IsXXXLine() function, as appropriate.
        public const uint IMG_EXT_TRIG0 = 0;
        public const uint IMG_EXT_TRIG1 = 1;
        public const uint IMG_EXT_TRIG2 = 2;
        public const uint IMG_EXT_TRIG3 = 3;
        public const uint IMG_EXT_RTSI0 = 4;
        public const uint IMG_EXT_RTSI1 = 5;
        public const uint IMG_EXT_RTSI2 = 6;
        public const uint IMG_EXT_RTSI3 = 7;
        public const uint IMG_EXT_RTSI4 = 12;
        public const uint IMG_EXT_RTSI5 = 13;
        public const uint IMG_EXT_RTSI6 = 14;
        public const uint IMG_TRIG_ROUTE_DISABLED = 0xFFFFFFFF;

        #endregion

        #region Internal Signals

        //  These are the signals that you can wait on or use to trigger the start
        //  of pulse generation.

        public const uint IMG_AQ_DONE = 8; // wait for the entire acquisition to complete
        public const uint IMG_FRAME_START = 9; // wait for the frame to start
        public const uint IMG_FRAME_DONE = 10; // wait for the frame to complete
        public const uint IMG_BUF_COMPLETE = 11; // wait for the buffer to complete
        public const uint IMG_AQ_IN_PROGRESS = 15;
        public const uint IMG_IMMEDIATE = 16;
        public const uint IMG_FIXED_FREQUENCY = 17; // used in imgSessionLineTrigSrouce (linescan)
        public const uint IMG_LINE_VALID = 18; // wait for line valid signal (HSYNC)
        public const uint IMG_FRAME_VALID = 19; // wait for frame valid signal (VSYNC)

        #endregion

        #region IMAQ Vision Compatible Image Types.

        public const uint IMG_IMAGE_U8 = 0; // Unsigned 8-bit image
        public const uint IMG_IMAGE_I16 = 1; // Signed 16-bit image
        public const uint IMG_IMAGE_RGB32 = 4; // 32-bit RGB image
        public const uint IMG_IMAGE_HSL32 = 5; // 32-bit HSL image
        public const uint IMG_IMAGE_RGB64 = 6; // 64-bit RGB image
        public const uint IMG_IMAGE_U16 = 7; // Unsigned 16-bit image

        #endregion

        #region MyRegion

        public const uint IMG_COLOR_REP_RGB32 = 0; // 32 bits RGB
        public const uint IMG_COLOR_REP_RED8 = 1; // 8 bits Red
        public const uint IMG_COLOR_REP_GREEN8 = 2; // 8 bits Green
        public const uint IMG_COLOR_REP_BLUE8 = 3; // 8 bits Blue
        public const uint IMG_COLOR_REP_LUM8 = 4; // 8 bits Light
        public const uint IMG_COLOR_REP_HUE8 = 5; // 8 bits Hue
        public const uint IMG_COLOR_REP_SAT8 = 6; // 8 bits Saturation
        public const uint IMG_COLOR_REP_INT8 = 7; // 8 bits Intensity
        public const uint IMG_COLOR_REP_LUM16 = 8; // 16 bits Light
        public const uint IMG_COLOR_REP_HUE16 = 9; // 16 bits Hue
        public const uint IMG_COLOR_REP_SAT16 = 10; // 16 bits Saturation
        public const uint IMG_COLOR_REP_INT16 = 11; // 16 bits Intensity
        public const uint IMG_COLOR_REP_RGB48 = 12; // 48 bits RGB
        public const uint IMG_COLOR_REP_RGB24 = 13; // 24 bits RGB
        public const uint IMG_COLOR_REP_RGB16 = 14; // 16 bits RGB (x555)
        public const uint IMG_COLOR_REP_HSL32 = 15; // 32 bits HSL
        public const uint IMG_COLOR_REP_HSI32 = 16; // 32 bits HSI
        public const uint IMG_COLOR_REP_NONE = 17; // No color information. Use bit-depth
        public const uint IMG_COLOR_REP_MONO10 = 18; // 10 bit Monochrome

        #endregion

        #region Specifies the size of each array element in the interface names array
        public const uint INTERFACE_NAME_SIZE = 256;

        #endregion

        #region Pulse timebases

        public const uint PULSE_TIMEBASE_PIXELCLK = 0x00000001;
        public const uint PULSE_TIMEBASE_50MHZ = 0x00000002;
        public const uint PULSE_TIMEBASE_100KHZ = 0x00000003;
        public const uint PULSE_TIMEBASE_SCALED_ENCODER = 0x00000004;

        #endregion

        #region Pulse mode

        public const uint PULSE_MODE_TRAIN = 0x00000001;
        public const uint PULSE_MODE_SINGLE = 0x00000002;
        public const uint PULSE_MODE_SINGLE_REARM = 0x00000003;

        #endregion

        #region Pulse polarities

        public const uint IMG_PULSE_POLAR_ACTIVEH = 0;
        public const uint IMG_PULSE_POLAR_ACTIVEL = 1;

        #endregion

        #region Power Over CameraLink states

        public const uint IMG_POCL_UNKNOWN = 0xFFFFFFFF; // The PoCL circuitry is in an unknown state
        public const uint IMG_POCL_NOT_SUPPORTED = 0; // The PoCL circuitry does not exist on the device

        public const uint
            IMG_POCL_NO_AUX_POWER =
                1; // The PoCL circuitry has no power supply and thus cannot provide power                              

        public const uint
            IMG_POCL_BAD_FUSE =
                2; // The PoCL circuitry has a blown fuse and thus cannot provide power                                      

        public const uint IMG_POCL_DISABLED = 3; // The PoCL circuitry is disabled
        public const uint IMG_POCL_FAULT = 4; // The PoCL circuitry has detected a fault
        public const uint IMG_POCL_INITIALIZING = 5; // The PoCL circuitry is initializing
        public const uint IMG_POCL_INACTIVE = 6; // The PoCL circuitry is enabled but not providing power
        public const uint IMG_POCL_ACTIVE = 7; // The PoCL circuitry is enabled and providing power

        #endregion

        #region Trigger drive

        public const uint IMG_TRIG_DRIVE_DISABLED = 0;
        public const uint IMG_TRIG_DRIVE_AQ_IN_PROGRESS = 1;
        public const uint IMG_TRIG_DRIVE_AQ_DONE = 2;
        public const uint IMG_TRIG_DRIVE_PIXEL_CLK = 3;
        public const uint IMG_TRIG_DRIVE_UNASSERTED = 4;
        public const uint IMG_TRIG_DRIVE_ASSERTED = 5;
        public const uint IMG_TRIG_DRIVE_HSYNC = 6;
        public const uint IMG_TRIG_DRIVE_VSYNC = 7;
        public const uint IMG_TRIG_DRIVE_FRAME_START = 8;
        public const uint IMG_TRIG_DRIVE_FRAME_DONE = 9;
        public const uint IMG_TRIG_DRIVE_SCALED_ENCODER = 10;

        #endregion

        #region imgPlot Flags

        public const uint IMGPLOT_MONO_8 = 0x00000000;
        public const uint IMGPLOT_INVERT = 0x00000001;
        public const uint IMGPLOT_COLOR_RGB24 = 0x00000002;
        public const uint IMGPLOT_COLOR_RGB32 = 0x00000004;
        public const uint IMGPLOT_MONO_10 = 0x00000008;
        public const uint IMGPLOT_MONO_12 = 0x00000010;
        public const uint IMGPLOT_MONO_14 = 0x00000020;
        public const uint IMGPLOT_MONO_16 = 0x00000040;
        public const uint IMGPLOT_MONO_32 = 0x00000080;
        public const uint IMGPLOT_AUTO = 0x00000100;

        #endregion

        #region Stillcolor modes.  OBSOLETE.

        public const uint IMG_COLOR_MODE_DISABLED = 0; // Color mode disabled
        public const uint IMG_COLOR_MODE_RGB = 1; // Color mode RGB StillColor
        public const uint IMG_COLOR_MODE_COMPOSITE_STLC = 2; // Color mode Composite StillColor

        #endregion

        #region Buffer location specifier.

        public const uint IMG_HOST_FRAME = 0;
        public const uint IMG_DEVICE_FRAME = 1;

        #endregion

        #region Bayer decoding pattern.

        public const uint IMG_BAYER_PATTERN_NONE = 0xFFFFFFFF;
        public const uint IMG_BAYER_PATTERN_GBGB_RGRG = 0;
        public const uint IMG_BAYER_PATTERN_GRGR_BGBG = 1;
        public const uint IMG_BAYER_PATTERN_BGBG_GRGR = 2;
        public const uint IMG_BAYER_PATTERN_RGRG_GBGB = 3;

        #endregion

        #region Bayer decoding algorithm

        public const uint IMG_BAYER_ALGORITHM_BILINEAR = 0;
        public const uint IMG_BAYER_ALGORITHM_VNG = 1;

        #endregion
    }
}