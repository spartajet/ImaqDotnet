using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ImaqDotnet
{
    public class ImaqWrapper
    {
        const UInt32 _IMG_BASE = 0x3FF60000;
        UInt32 IMG_ATTR_ROI_WIDTH = (_IMG_BASE + 0x01A6);
        UInt32 IMG_ATTR_ROI_HEIGHT = (_IMG_BASE + 0x01A7);
        UInt32 IMG_ATTR_ROWPIXELS = (_IMG_BASE + 0x00C1);
        [DllImport("imaq")]
        private static extern Int32 imgInterfaceOpen(StringBuilder interfaceName, ref UInt32 pifid);

        [DllImport("imaq")]
        private static extern Int32 imgClose(UInt32 void_id, UInt32 freeResources);

        [DllImport("imaq")]
        private static extern Int32 imgSessionOpen(UInt32 ifid, ref UInt32 psid);

        [DllImport("imaq")]
        private static extern Int32 imgInterfaceReset(UInt32 ifid);

        [DllImport("imaq")]
        private static extern Int32 imgGrab(UInt32 sid, ref IntPtr bufPtr, UInt32 syncOnVB);

        [DllImport("imaq")]
        private static extern Int32 imgGrabSetup(UInt32 sid, UInt32 startNow);

        [DllImport("imaq", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private static extern Int32 imgSetAttribute2(UInt32 void_id, UInt32 attribute, UInt32 values);

        [DllImport("imaq")]
        private static extern Int32 imgShowError(Int32 errorCode, string errorMessage);

        [DllImport("imaq")]
        private static extern Int32 imgSessionSerialFlush(UInt32 sessionId);

        [DllImport("imaq")]
        private static extern Int32 imgSessionSerialWrite(UInt32 sessionId, byte[] buffer, ref UInt32 bufferSize,
            UInt32 timeOut);
    }
}
