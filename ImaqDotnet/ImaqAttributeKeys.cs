using System;
using System.Collections.Generic;
using System.Text;

namespace ImaqDotnet
{
    public class ImaqAttributeKeys
    {
        public const uint _IMG_BASE = 0x3FF60000;
        // public const uint IMG_ATTR_ROI_WIDTH = (_IMG_BASE + 0x01A6;;
        // uint IMG_ATTR_ROI_HEIGHT = (_IMG_BASE + 0x01A7;;
        // uint IMG_ATTR_ROWPIXELS = (_IMG_BASE + 0x00C1;;


        //----------------------------------------------------------------------------
        //  Attribute Keys
        //----------------------------------------------------------------------------
        public const uint IMG_ATTR_INTERFACE_TYPE = _IMG_BASE + 0x0001; // id of board - see public constants below
        public const uint IMG_ATTR_PIXDEPTH = _IMG_BASE + 0x0002; // pixel depth in bits
        public const uint IMG_ATTR_COLOR = _IMG_BASE + 0x0003; // true = supports color
        public const uint IMG_ATTR_HASRAM = _IMG_BASE + 0x0004; // true = has on-board SRAM
        public const uint IMG_ATTR_RAMSIZE = _IMG_BASE + 0x0005; // SRAM size
        public const uint IMG_ATTR_CHANNEL = _IMG_BASE + 0x0006;
        public const uint IMG_ATTR_FRAME_FIELD = _IMG_BASE + 0x0007; // supports frame and field
        public const uint IMG_ATTR_HORZ_RESOLUTION = _IMG_BASE + 0x0009;
        public const uint IMG_ATTR_VERT_RESOLUTION = _IMG_BASE + 0x000A;
        public const uint IMG_ATTR_LUT = _IMG_BASE + 0x000B;
        public const uint IMG_ATTR_LINESCAN = _IMG_BASE + 0x000C;
        public const uint IMG_ATTR_GAIN = _IMG_BASE + 0x000D;
        public const uint IMG_ATTR_CHROMA_FILTER = _IMG_BASE + 0x000E;
        public const uint IMG_ATTR_WHITE_REF = _IMG_BASE + 0x000F;
        public const uint IMG_ATTR_BLACK_REF = _IMG_BASE + 0x0010;

        /// <summary>
        /// pass in uInt32 array of size up to 16 elements to swap incoming data lines (0,1,2...15; - must be 16 x uInt32 array
        /// </summary>
        public const uint IMG_ATTR_DATALINES = _IMG_BASE + 0x0011;

        public const uint IMG_ATTR_NUM_EXT_LINES = _IMG_BASE + 0x0012;
        public const uint IMG_ATTR_NUM_RTSI_LINES = _IMG_BASE + 0x0013;
        public const uint IMG_ATTR_NUM_RTSI_IN_USE = _IMG_BASE + 0x0014;
        public const uint IMG_ATTR_MEM_LOCKED = _IMG_BASE + 0x0065;
        public const uint IMG_ATTR_BITSPERPIXEL = _IMG_BASE + 0x0066;
        public const uint IMG_ATTR_BYTESPERPIXEL = _IMG_BASE + 0x0067;
        public const uint IMG_ATTR_ACQWINDOW_LEFT = _IMG_BASE + 0x0068;
        public const uint IMG_ATTR_ACQWINDOW_TOP = _IMG_BASE + 0x0069;
        public const uint IMG_ATTR_ACQWINDOW_WIDTH = _IMG_BASE + 0x006A;
        public const uint IMG_ATTR_ACQWINDOW_HEIGHT = _IMG_BASE + 0x006B;
        public const uint IMG_ATTR_LINE_COUNT = _IMG_BASE + 0x0070;
        public const uint IMG_ATTR_FREE_BUFFERS = _IMG_BASE + 0x0071;
        public const uint IMG_ATTR_HSCALE = _IMG_BASE + 0x0072;
        public const uint IMG_ATTR_VSCALE = _IMG_BASE + 0x0073;
        public const uint IMG_ATTR_ACQ_IN_PROGRESS = _IMG_BASE + 0x0074;
        public const uint IMG_ATTR_START_FIELD = _IMG_BASE + 0x0075;
        public const uint IMG_ATTR_FRAME_COUNT = _IMG_BASE + 0x0076;
        public const uint IMG_ATTR_LAST_VALID_BUFFER = _IMG_BASE + 0x0077;
        public const uint IMG_ATTR_ROWBYTES = _IMG_BASE + 0x0078;
        public const uint IMG_ATTR_CALLBACK = _IMG_BASE + 0x007B;
        public const uint IMG_ATTR_CURRENT_BUFLIST = _IMG_BASE + 0x007C;
        public const uint IMG_ATTR_FRAMEWAIT_MSEC = _IMG_BASE + 0x007D;
        public const uint IMG_ATTR_TRIGGER_MODE = _IMG_BASE + 0x007E;
        public const uint IMG_ATTR_INVERT = _IMG_BASE + 0x0082;
        public const uint IMG_ATTR_XOFF_BUFFER = _IMG_BASE + 0x0083;
        public const uint IMG_ATTR_YOFF_BUFFER = _IMG_BASE + 0x0084;
        public const uint IMG_ATTR_NUM_BUFFERS = _IMG_BASE + 0x0085;
        public const uint IMG_ATTR_LOST_FRAMES = _IMG_BASE + 0x0088;
        public const uint IMG_ATTR_COLOR_WHITE_REF = _IMG_BASE + 0x008F; // Color white reference
        public const uint IMG_ATTR_COLOR_BLACK_REF = _IMG_BASE + 0x0090; // Color black reference
        public const uint IMG_ATTR_COLOR_CLAMP_START = _IMG_BASE + 0x0091; // Color clamp start
        public const uint IMG_ATTR_COLOR_CLAMP_STOP = _IMG_BASE + 0x0092; // Color clamp stop
        public const uint IMG_ATTR_COLOR_ZERO_START = _IMG_BASE + 0x0093; // Color zero start
        public const uint IMG_ATTR_COLOR_ZERO_STOP = _IMG_BASE + 0x0094; // Color zero stop
        public const uint IMG_ATTR_COLOR_AVG_COUNT = _IMG_BASE + 0x0095; // Color averaging count
        public const uint IMG_ATTR_COLOR_SW_CHROMA_FILTER = _IMG_BASE + 0x0096; // Color SW chroma filter
        public const uint IMG_ATTR_COLOR_NTSC_SETUP_ENABLE = _IMG_BASE + 0x0097; // Color NTSC Setup enable
        public const uint IMG_ATTR_COLOR_NTSC_SETUP_VALUE = _IMG_BASE + 0x0098; // Color NTSC Setup value
        public const uint IMG_ATTR_COLOR_BRIGHTNESS = _IMG_BASE + 0x0099; // Color brightness
        public const uint IMG_ATTR_COLOR_CONTRAST = _IMG_BASE + 0x009A; // Color contrast
        public const uint IMG_ATTR_COLOR_SATURATION = _IMG_BASE + 0x009B; // Color saturation
        public const uint IMG_ATTR_COLOR_TINT = _IMG_BASE + 0x009C; // Color tint (chroma phase;
        public const uint IMG_ATTR_COLOR_SW_POST_GAIN = _IMG_BASE + 0x009D; // Color SW post-gain
        public const uint IMG_ATTR_COLOR_BURST_START = _IMG_BASE + 0x009E; // Color burst start
        public const uint IMG_ATTR_COLOR_BURST_STOP = _IMG_BASE + 0x009F; // Color burst stop
        public const uint IMG_ATTR_COLOR_BLANK_START = _IMG_BASE + 0x00A0; // Color blank start
        public const uint IMG_ATTR_COLOR_BLANK_STOP = _IMG_BASE + 0x00A1; // Color blank stop
        public const uint IMG_ATTR_COLOR_IMAGE_X_SHIFT = _IMG_BASE + 0x00A2; // Color acquisition left shift
        public const uint IMG_ATTR_COLOR_GAIN = _IMG_BASE + 0x00A3; // Color HW pre-gain
        public const uint IMG_ATTR_COLOR_CLAMP_START_REF = _IMG_BASE + 0x00A5; // Color clamp start reference
        public const uint IMG_ATTR_COLOR_CLAMP_STOP_REF = _IMG_BASE + 0x00A6; // Color clamp stop reference
        public const uint IMG_ATTR_COLOR_ZERO_START_REF = _IMG_BASE + 0x00A7; // Color zero start reference
        public const uint IMG_ATTR_COLOR_ZERO_STOP_REF = _IMG_BASE + 0x00A8; // Color zero stop reference
        public const uint IMG_ATTR_COLOR_BURST_START_REF = _IMG_BASE + 0x00A9; // Color burst start reference
        public const uint IMG_ATTR_COLOR_BURST_STOP_REF = _IMG_BASE + 0x00AA; // Color burst stop reference
        public const uint IMG_ATTR_COLOR_BLANK_START_REF = _IMG_BASE + 0x00AB; // Color blank start reference
        public const uint IMG_ATTR_COLOR_BLANK_STOP_REF = _IMG_BASE + 0x00AC; // Color blank stop reference
        public const uint IMG_ATTR_COLOR_MODE = _IMG_BASE + 0x00AD; // Color acquisition mode
        public const uint IMG_ATTR_COLOR_IMAGE_REP = _IMG_BASE + 0x00AE; // Color Image representation
        public const uint IMG_ATTR_GENLOCK_SWITCH_CHAN = _IMG_BASE + 0x00AF; // switch channel fast
        public const uint IMG_ATTR_CLAMP_START = _IMG_BASE + 0x00B0; // clamp start
        public const uint IMG_ATTR_CLAMP_STOP = _IMG_BASE + 0x00B1; // clamp stop
        public const uint IMG_ATTR_ZERO_START = _IMG_BASE + 0x00B2; // zero start
        public const uint IMG_ATTR_ZERO_STOP = _IMG_BASE + 0x00B3; // zero stop
        public const uint IMG_ATTR_COLOR_HUE_OFFS_ANGLE = _IMG_BASE + 0x00B5; // Color hue offset angle

        public const uint
            IMG_ATTR_COLOR_IMAGE_X_SHIFT_REF = _IMG_BASE + 0x00B6; // Color acquisition left shift reference

        public const uint
            IMG_ATTR_LAST_VALID_FRAME = _IMG_BASE + 0x00BA; // returns the cummulative buffer index (frame#;

        public const uint IMG_ATTR_CLOCK_FREQ = _IMG_BASE + 0x00BB; // returns the max clock freq of the board
        public const uint IMG_ATTR_BLACK_REF_VOLT = _IMG_BASE + 0x00BC; // defines the black reference in volts
        public const uint IMG_ATTR_WHITE_REF_VOLT = _IMG_BASE + 0x00BD; // defines the white reference in volts
        public const uint IMG_ATTR_COLOR_LOW_REF_VOLT = _IMG_BASE + 0x00BE; // defines the color low reference in volts
        public const uint IMG_ATTR_COLOR_HIGH_REF_VOLT = _IMG_BASE + 0x00BF;
        public const uint IMG_ATTR_GETSERIAL = _IMG_BASE + 0x00C0; // get the serial number of the board
        public const uint IMG_ATTR_ROWPIXELS = _IMG_BASE + 0x00C1;
        public const uint IMG_ATTR_ACQUIRE_FIELD = _IMG_BASE + 0x00C2;
        public const uint IMG_ATTR_PCLK_DETECT = _IMG_BASE + 0x00C3;
        public const uint IMG_ATTR_VHA_MODE = _IMG_BASE + 0x00C4; // Variable Height Acquisition mode
        public const uint IMG_ATTR_BIN_THRESHOLD_LOW = _IMG_BASE + 0x00C5; // Binary threshold low
        public const uint IMG_ATTR_BIN_THRESHOLD_HIGH = _IMG_BASE + 0x00C6; // Binary threshold hi

        public const uint
            IMG_ATTR_COLOR_LUMA_BANDWIDTH =
                _IMG_BASE + 0x00C7; // selects different bandwidths for the luminance signal                                          =

        public const uint
            IMG_ATTR_COLOR_CHROMA_TRAP =
                _IMG_BASE + 0x00C8; // enables and disables the chroma trap filter in the luma signal path                            =

        public const uint
            IMG_ATTR_COLOR_LUMA_COMB =
                _IMG_BASE + 0x00C9; // select the type of comb filter used in the luma path                                            =

        public const uint
            IMG_ATTR_COLOR_PEAKING_ENABLE = _IMG_BASE + 0x00CA; // enable the peaking filter in the luma path

        public const uint IMG_ATTR_COLOR_PEAKING_LEVEL = _IMG_BASE + 0x00CB;

        public const uint
            IMG_ATTR_COLOR_CHROMA_PROCESS =
                _IMG_BASE + 0x00CC; // specifies the processing applied to the chroma signal                                          =

        public const uint
            IMG_ATTR_COLOR_CHROMA_BANDWIDTH = _IMG_BASE + 0x00CD; // bandwidth of the chroma information of the image

        public const uint
            IMG_ATTR_COLOR_CHROMA_COMB =
                _IMG_BASE + 0x00CE; // select the type of comb filter used in the chroma path                                     =

        public const uint
            IMG_ATTR_COLOR_CHROMA_PHASE =
                _IMG_BASE + 0x00CF; // sets value of correction angle applied to the chroma vector.  Active only for NTSC cameras    =

        public const uint IMG_ATTR_COLOR_RGB_CORING_LEVEL = _IMG_BASE + 0x00D0; // select RGB coring level
        public const uint IMG_ATTR_COLOR_HSL_CORING_LEVEL = _IMG_BASE + 0x00D1; // select HSL coring level

        public const uint
            IMG_ATTR_COLOR_HUE_REPLACE_VALUE =
                _IMG_BASE + 0x00D2; // hue value to replace if saturation value is less than HSL coring level                          =

        public const uint IMG_ATTR_COLOR_GAIN_RED = _IMG_BASE + 0x00D3; // Red Gain
        public const uint IMG_ATTR_COLOR_GAIN_GREEN = _IMG_BASE + 0x00D4; // Green Gian
        public const uint IMG_ATTR_COLOR_GAIN_BLUE = _IMG_BASE + 0x00D5; // Blue Gain

        public const uint
            IMG_ATTR_CALIBRATION_DATE_LV =
                _IMG_BASE + 0x00D6; // 0 if board is uncalibrated, else seconds since Jan 1 1904                                      =

        public const uint
            IMG_ATTR_CALIBRATION_DATE =
                _IMG_BASE + 0x00D7; // 0 if board is uncalibrated, else seconds since Jan 1 1970                                      =

        public const uint IMG_ATTR_IMAGE_TYPE = _IMG_BASE + 0x00D8; // return the IMAQ Vision image type for LabVIEW

        public const uint
            IMG_ATTR_DYNAMIC_RANGE =
                _IMG_BASE + 0x00D9; // the effective bits per pixel of the user's white-black level                               =

        public const uint IMG_ATTR_ACQUIRE_TO_SYSTEM_MEMORY = _IMG_BASE + 0x011B;
        public const uint IMG_ATTR_ONBOARD_HOLDING_BUFFER_PTR = _IMG_BASE + 0x011C; // invalid on 64-bit OS
        public const uint IMG_ATTR_SYNCHRONICITY = _IMG_BASE + 0x011D;
        public const uint IMG_ATTR_LAST_ACQUIRED_BUFFER_NUM = _IMG_BASE + 0x011E;
        public const uint IMG_ATTR_LAST_ACQUIRED_BUFFER_INDEX = _IMG_BASE + 0x011F;
        public const uint IMG_ATTR_LAST_TRANSFERRED_BUFFER_NUM = _IMG_BASE + 0x0120;
        public const uint IMG_ATTR_LAST_TRANSFERRED_BUFFER_INDEX = _IMG_BASE + 0x0121;

        public const uint
            IMG_ATTR_SERIAL_NUM_BYTES_RECEIVED =
                _IMG_BASE + 0x012C; // # bytes currently in the internal serial read buffer                                          =

        public const uint
            IMG_ATTR_EXPOSURE_TIME_INTERNAL =
                _IMG_BASE + 0x013C; // exposure time for 1454 (internal value - specified in 40MHz clks;                        =

        public const uint IMG_ATTR_SERIAL_TERM_STRING = _IMG_BASE + 0x0150; // The serial termination string

        public const uint
            IMG_ATTR_DETECT_VIDEO =
                _IMG_BASE + 0x01A3; // Determines whether to detect a video signal prior to acquiring                              =

        public const uint IMG_ATTR_ROI_LEFT = _IMG_BASE + 0x01A4;
        public const uint IMG_ATTR_ROI_TOP = _IMG_BASE + 0x01A5;
        public const uint IMG_ATTR_ROI_WIDTH = _IMG_BASE + 0x01A6;
        public const uint IMG_ATTR_ROI_HEIGHT = _IMG_BASE + 0x01A7;

        public const uint
            IMG_ATTR_NUM_ISO_IN_LINES = _IMG_BASE + 0x01A8; // The number of iso in lines the device supports

        public const uint
            IMG_ATTR_NUM_ISO_OUT_LINES = _IMG_BASE + 0x01A9; // The number of iso out lines the device supports

        public const uint
            IMG_ATTR_NUM_POST_TRIGGER_BUFFERS =
                _IMG_BASE + 0x01AA; // The number of buffers that hardware should continue acquire after sensing a stop trigger be=ore it finally does stop

        public const uint
            IMG_ATTR_EXT_TRIG_LINE_FILTER =
                _IMG_BASE + 0x01AB; // Whether to use filtering on the TTL trigger lines                                           =

        public const uint
            IMG_ATTR_RTSI_LINE_FILTER =
                _IMG_BASE + 0x01AC; // Whether to use filtering on the RTSI trigger lines                                           =

        public const uint
            IMG_ATTR_NUM_PORTS =
                _IMG_BASE + 0x01AD; // Returns the number of ports that this device supports.                                       =

        public const uint
            IMG_ATTR_CURRENT_PORT_NUM =
                _IMG_BASE + 0x01AE; // Returns the port number that the given interface is using.                                      =

        public const uint
            IMG_ATTR_ENCODER_PHASE_A_POLARITY = _IMG_BASE + 0x01AF; // The polarity of the phase A encoder input

        public const uint
            IMG_ATTR_ENCODER_PHASE_B_POLARITY = _IMG_BASE + 0x01B0; // The polarity of the phase B encoder input

        public const uint
            IMG_ATTR_ENCODER_FILTER =
                _IMG_BASE + 0x01B1; // Specifies whether to use filtering on the encoder input                                   =

        public const uint
            IMG_ATTR_ENCODER_DIVIDE_FACTOR = _IMG_BASE + 0x01B2; // The divide factor for the encoder scaler

        public const uint
            IMG_ATTR_ENCODER_POSITION =
                _IMG_BASE + 0x01B3; // Returns the current value of the absolute encoder position as a uInt64                    =

        public const uint IMG_ATTR_TEMPERATURE = _IMG_BASE + 0x01B4; // The device's current temperature, in degrees C
        public const uint IMG_ATTR_LED_PASS = _IMG_BASE + 0x01B5; // The state of the Pass LED
        public const uint IMG_ATTR_LED_FAIL = _IMG_BASE + 0x01B6; // The state of the Fail LED
        public const uint IMG_ATTR_SENSOR_PARTIAL_SCAN = _IMG_BASE + 0x01B7; // The sensor's partial scan mode
        public const uint IMG_ATTR_SENSOR_BINNING = _IMG_BASE + 0x01B8; // The sensor's binning mode
        public const uint IMG_ATTR_SENSOR_GAIN = _IMG_BASE + 0x01B9; // The sensor's gain factor
        public const uint IMG_ATTR_LIGHTING_MODE = _IMG_BASE + 0x01BB; // The internal lighting mode to use

        public const uint
            IMG_ATTR_LIGHTING_CURRENT =
                _IMG_BASE + 0x01BC; // The amount of current sourced by the internal lighting controller (mA;                        =

        public const uint
            IMG_ATTR_LIGHTING_MAX_CURRENT =
                _IMG_BASE + 0x01BD; // Returns the maximum current that can be souced by the internal lighting controller given the cu=rent configuration

        public const uint
            IMG_ATTR_LIGHTING_EXT_STROBE_5V_TTL =
                _IMG_BASE + 0x01BE; // Whether to enable stobing on the external 5V lighting output                                 =

        public const uint
            IMG_ATTR_LIGHTING_EXT_STROBE_24V =
                _IMG_BASE + 0x01BF; // Whether to enable stobing on the external 24V (VCC; lighting output                           =

        public const uint IMG_ATTR_SENSOR_EXPOSURE = _IMG_BASE + 0x01C0; // The sensor's exposure time in milliseconds.
        public const uint IMG_ATTR_FRAME_RATE = _IMG_BASE + 0x01C1; // The frame rate.
        public const uint IMG_ATTR_MAX_FRAME_RATE = _IMG_BASE + 0x01C2; // The maximum frame rate.

        public const uint
            IMG_ATTR_SEND_SOFTWARE_TRIGGER =
                _IMG_BASE + 0x01C3; // Set to issue a software trigger to the action that was configured to wait for a software trigg=r.

        public const uint
            IMG_ATTR_FIXED_FRAME_RATE_MODE =
                _IMG_BASE + 0x01C4; // Controls whether the sensor operates in fixed-frame-rate mode (true; or free-run mode (off;.  =hen in fixed-frame-rate mode the sensor will run at the frame rate specified by IMG_ATTR_FRAME_RATE.  When in free-=un mode, the sensor will run at the maximum frame rate possible.

        public const uint
            IMG_ATTR_UNSIGNED_16BIT_IMAGE =
                _IMG_BASE + 0x01C5; // Whether to interpret 16 bits of pixel data as signed or unsigned.                             =

        public const uint IMG_ATTR_POCL_STATUS = _IMG_BASE + 0x01C6; // Returns the status of the PoCL circuitry.

        public const uint
            IMG_ATTR_ROWPIXELS_ALIGNMENT = _IMG_BASE + 0x01C7; // Alignment public constraint of row pixels

        public const uint
            IMG_ATTR_ROWPIXELS_SUGGESTED_ALIGNMENT =
                _IMG_BASE + 0x01C8; // Suggested alignment public constraint of row pixels

        public const uint IMG_ATTR_SUPPORTS_PULSE_UPDATE = _IMG_BASE + 0x01C9; // Whether pulse updates are supported.
        public const uint IMG_ATTR_BAYER_PATTERN = _IMG_BASE + 0x01CB; // The bayer pattern
        public const uint IMG_ATTR_BAYER_RED_GAIN = _IMG_BASE + 0x01CC; // The Bayer red gain
        public const uint IMG_ATTR_BAYER_GREEN_GAIN = _IMG_BASE + 0x01CD; // The Bayer green gain
        public const uint IMG_ATTR_BAYER_BLUE_GAIN = _IMG_BASE + 0x01CE; // The Bayer blue gain
        public const uint IMG_ATTR_BAYER_ALGORITHM = _IMG_BASE + 0x01CF; // The Bayer decode algorithm

        public const uint
            IMG_ATTR_BAYER_ONBOARD_DECODE_ENABLE = _IMG_BASE + 0x01D0; // Whether to enable onboard Bayer decoding

        public const uint
            IMG_ATTR_BAYER_ONBOARD_DECODE_FORCE_RGB =
                _IMG_BASE + 0x01D1; // Whether to force the decoded RGB image to be 32 bits.  By default pixel depths greater than 8=return a 64-bit RGB image.

        public const uint
            IMG_ATTR_ENCODER_USE_IO_BOARD_INPUT =
                _IMG_BASE + 0x01D2; // Whether to use the I/O board inputs (TRUE; or the front connector inputs (FALSE; for the scale= encoder.

        public const uint
            IMG_ATTR_POCL_STATUS_BASE =
                _IMG_BASE + 0x01D3; // Returns the status of the PoCL circuitry for the Base connector                                 =

        public const uint
            IMG_ATTR_POCL_STATUS_MED_FULL =
                _IMG_BASE + 0x01D4; // Returns the status of the PoCL circuitry for the Medium/Full connector                          =

        public const uint
            IMG_ATTR_IO_BOARD_PRESENT =
                _IMG_BASE + 0x01D5; // Returns true if there is an IO board attached to the device
    }
}