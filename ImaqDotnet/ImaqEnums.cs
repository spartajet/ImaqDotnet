using System;
using System.Collections.Generic;
using System.Text;

namespace ImaqDotnet
{
    public class ImaqEnums
    {
        /// <summary>
        /// Signal states
        /// </summary>
        public enum IMG_SIGNAL_STATE
        {
            IMG_SIGNAL_STATE_RISING = 0,
            IMG_SIGNAL_STATE_FALLING = 1,
            IMG_SIGNAL_STATE_HIGH = 2,
            IMG_SIGNAL_STATE_LOW = 3,
            IMG_SIGNAL_STATE_HI_Z = 4
        }

        /// <summary>
        /// ROI Fit Modes
        /// </summary>
        public enum IMG_ROI_FIT_MODE
        {
            IMG_ROI_FIT_LARGER,
            IMG_ROI_FIT_SMALLER
        }

        /// <summary>
        /// Signal Types
        /// </summary>
        public enum IMG_SIGNAL_TYPE
        {
            IMG_SIGNAL_NONE = -1, //0xFFFFFFFF
            IMG_SIGNAL_EXTERNAL = 0,
            IMG_SIGNAL_RTSI = 1,
            IMG_SIGNAL_ISO_IN = 2,
            IMG_SIGNAL_ISO_OUT = 3,
            IMG_SIGNAL_STATUS = 4,
            IMG_SIGNAL_SCALED_ENCODER = 5,
            IMG_SIGNAL_SOFTWARE_TRIGGER = 6
        }

        /// <summary>
        /// Overwrite Modes
        /// </summary>
        public enum IMG_OVERWRITE_MODE
        {
            IMG_OVERWRITE_GET_OLDEST = 0,
            IMG_OVERWRITE_GET_NEXT_ITERATION = 1,
            IMG_OVERWRITE_FAIL = 2,
            IMG_OVERWRITE_GET_NEWEST = 3
        }

        /// <summary>
        /// Sensor Scan Modes
        /// 
        /// </summary>
        public enum IMG_SENSOR_PARTIAL_SCAN
        {
            IMG_SENSOR_PARTIAL_SCAN_OFF = 0,
            IMG_SENSOR_PARTIAL_SCAN_HALF = 1,
            IMG_SENSOR_PARTIAL_SCAN_QUARTER = 2
        }

        /// <summary>
        /// Sensor Binning Modes
        /// </summary>
        public enum IMG_SENSOR_BINNING
        {
            IMG_SENSOR_BINNING_OFF = 0,
            IMG_SENSOR_BINNING_1x2 = 1,
        }

        /// <summary>
        /// LED States
        /// </summary>
        public enum IMG_LED_STATE
        {
            MG_LED_OFF = 0,
            IMG_LED_ON = 1
        }

        /// <summary>
        /// Timebases
        /// </summary>
        public enum IMG_TIMEBASE
        {
            IMG_TIMEBASE_PIXELCLK = 1,
            IMG_TIMEBASE_50MHZ = 2,
            IMG_TIMEBASE_100KHZ = 3,
            IMG_TIMEBASE_SCALED_ENCODER = 4,
            IMG_TIMEBASE_MILLISECONDS = 5
        }

        /// <summary>
        ///  Internal Lighting Modes
        /// </summary>
        public enum IMG_LIGHTING_MODE
        {
            IMG_LIGHTING_OFF = 0,
            IMG_LIGHTING_CONTINUOUS = 1,
            IMG_LIGHTING_STROBED = 2
        }

        /// <summary>
        /// External Lighting Modes
        /// </summary>
        public enum IMG_LIGHTING_EXTERNAL_STROBE_MODE
        {
            IMG_LIGHTING_EXTERNAL_STROBE_OFF = 0,
            IMG_LIGHTING_EXTERNAL_STROBE_RISING = 1,
            IMG_LIGHTING_EXTERNAL_STROBE_FALLING = 2
        }
    }
}