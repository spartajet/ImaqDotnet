using System;
using System.Runtime.InteropServices;
using System.Text;

namespace ImaqDotnet
{
    public class ImaqWrapper
    {
        [DllImport("imaq")]
        public static extern int imgInterfaceOpen(StringBuilder interfaceName, ref uint pifid);

        [DllImport("imaq")]
        public static extern int imgClose(uint void_id, uint freeResources);

        [DllImport("imaq")]
        public static extern int imgSessionOpen(uint ifid, ref uint psid);

        [DllImport("imaq")]
        public static extern int imgInterfaceReset(uint ifid);

        [DllImport("imaq")]
        public static extern int imgGrab(uint sid, ref IntPtr bufPtr, uint syncOnVB);

        [DllImport("imaq")]
        public static extern int imgGrabSetup(uint sid, uint startNow);

        [DllImport("imaq", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int imgSetAttribute2(uint void_id, uint attribute, uint values);

        [DllImport("imaq")]
        public static extern int imgShowError(int errorCode, string errorMessage);

        [DllImport("imaq")]
        public static extern int imgSessionSerialFlush(uint sessionId);

        [DllImport("imaq")]
        public static extern int imgSessionSerialWrite(uint sessionId, byte[] buffer, ref uint bufferSize,
            uint timeOut);


        [DllImport("imaq")]
        public static extern int imgSnap(uint sid, ref IntPtr bufAddr);

        [DllImport("imaq")]
        public static extern int imgSnapArea(uint sid, ref IntPtr bufAddr, uint top, uint left, uint height, uint width,
            uint rowBytes);

        [DllImport("imaq")]
        public static extern int imgGrabArea(uint sid, ref IntPtr bufPtr, uint syncOnVB, uint top, uint left,
            uint height, uint width, uint rowBytes);

        [DllImport("imaq")]
        public static extern int imgRingSetup(uint sid, uint numberBuffer, ref IntPtr bufPtr, uint skipCount,
            uint startnow);

        [DllImport("imaq")]
        public static extern int imgSequenceSetup(uint sid, uint numberBuffer, ref IntPtr bufPtr, uint[] skipCount,
            uint startnow, uint async);

        [DllImport("imaq")]
        public static extern int imgSessionStartAcquisition(uint sid);

        [DllImport("imaq")]
        public static extern int imgSessionStopAcquisition(uint sid);

        [DllImport("imaq")]
        public static extern int imgSessionStatus(uint sid, ref uint boardStatus, ref uint bufIndex);

        [DllImport("imaq")]
        public static extern int imgSessionConfigureROI(uint sid, uint top, uint left, uint height, uint width);

        [DllImport("imaq")]
        public static extern int imgSessionGetROI(uint sid, ref uint top, ref uint left, ref uint height,
            ref uint width);

        [DllImport("imaq")]
        public static extern int imgSessionGetBufferSize(uint sid, ref uint sizeNeeded);

        [DllImport("imaq")]
        public static extern int imgGetAttribute(uint void_id, uint attribute, IntPtr value);

        [DllImport("imaq")]
        public static extern int imgCreateBuffer(uint sid, uint where, uint bufferSize, ref IntPtr bufAddr);

        [DllImport("imaq")]
        public static extern int imgDisposeBuffer(IntPtr bufferPtr);

        [DllImport("imaq")]
        public static extern int imgCreateBufList(uint numElements, ref uint bufListId);

        [DllImport("imaq")]
        public static extern int imgDisposeBufList(uint bid, uint freeResources);

        [DllImport("imaq")]
        public static extern int imgGetBufferElement(uint bid, uint element, uint itemType, IntPtr itemValue);

        [DllImport("imaq")]
        public static extern int imgSessionConfigure(uint sid, uint buflist);

        [DllImport("imaq")]
        public static extern int imgSessionAcquire(uint sid, uint async, Delegate callback);

        [DllImport("imaq")]
        public static extern int imgSessionAbort(uint sid, ref uint bufNum);

        [DllImport("imaq")]
        public static extern int imgSessionReleaseBuffer(uint sid);

        [DllImport("imaq")]
        public static extern int imgSessionClearBuffer(uint sid, uint buf_num, byte pixel_value);

        [DllImport("imaq")]
        public static extern int imgSessionGetLostFramesList(uint sid, ref uint framelist, uint numEntries);

        [DllImport("imaq")]
        public static extern int imgSessionSetUserLUT8bit(uint sid, uint lutType, ref byte lut);

        [DllImport("imaq")]
        public static extern int imgSessionSetUserLUT16bit(uint sid, uint lutType, ref ushort lut);

        [DllImport("imaq")]
        public static extern int imgGetCameraAttributeNumeric(uint sid, StringBuilder attributeString,
            ref double currentValueNumeric);

        [DllImport("imaq")]
        public static extern int imgSetCameraAttributeNumeric(uint sid, StringBuilder attributeString,
            double newValueNumeric);

        [DllImport("imaq")]
        public static extern int imgGetCameraAttributeString(uint sid, StringBuilder attributeString,
            StringBuilder currentValueString, uint sizeofCurrentValueString);

        [DllImport("imaq")]
        public static extern int imgSetCameraAttributeString(uint sid, StringBuilder attributeString,
            StringBuilder newValueString);

        [DllImport("imaq")]
        public static extern int imgSessionSerialRead(uint sid, byte[] buffer, ref uint bufSize, uint timeout);

        [DllImport("imaq")]
        public static extern int imgSessionSerialReadBytes(uint sid, byte[] buffer, ref uint bufferSize, uint timeout);

        [DllImport("imaq")]
        public static extern int imgPulseCreate2(uint timeBase, uint delay, uint width,
            ImaqEnums.IMG_SIGNAL_TYPE signalType, uint signalIdentifier, uint signalPolarity,
            ImaqEnums.IMG_SIGNAL_TYPE outputType, uint outputNumber, uint outputPolarity, uint pulseMode,
            ref uint plsID);

        [DllImport("imaq")]
        public static extern int imgPulseDispose(uint plsID);

        [DllImport("imaq")]
        public static extern int imgPulseRate(double delaytime, double widthtime, ref uint delay, ref uint width,
            ref uint timebase);

        [DllImport("imaq")]
        public static extern int imgPulseStart(uint pid, uint sid);

        [DllImport("imaq")]
        public static extern int imgPulseUpdate(uint pid, uint sid, uint delay, uint width);

        [DllImport("imaq")]
        public static extern int imgPulseStop(uint pid);

        [DllImport("imaq")]
        public static extern int imgSessionWaitSignal2(uint sid, ImaqEnums.IMG_SIGNAL_TYPE signalType,
            uint signalIdentifier, uint signalPolarity, uint timeout);

        [DllImport("imaq")]
        public static extern int imgSessionTriggerDrive2(uint sid, ImaqEnums.IMG_SIGNAL_TYPE trigType, uint trigNum,
            uint polarity, uint signal);

        [DllImport("imaq")]
        public static extern int imgSessionTriggerRead2(uint sid, ImaqEnums.IMG_SIGNAL_TYPE trigType, uint trigNum,
            uint polarity, ref uint status);

        [DllImport("imaq")]
        public static extern int imgSessionTriggerRoute2(uint sid, ImaqEnums.IMG_SIGNAL_TYPE srcTriggerType,
            uint srcTriggerNumber, ImaqEnums.IMG_SIGNAL_TYPE dstTriggerType, uint dstTriggerNumber);

        [DllImport("imaq")]
        public static extern int imgSessionTriggerClear(uint sid);

        [DllImport("imaq")]
        public static extern int imgSessionTriggerConfigure2(uint sid, ImaqEnums.IMG_SIGNAL_TYPE trigType, uint trigNum,
            uint polarity, uint timeout, uint action);

        [DllImport("imaq")]
        public static extern int imgSessionSaveBufferEx(uint sid, IntPtr buffer, StringBuilder file_name);

        [DllImport("imaq")]
        public static extern int imgInterfaceQueryNames(uint index, StringBuilder queryName);

        [DllImport("imaq")]
        public static extern int imgCalculateBayerColorLUT(double redGain, double greenGain, double blueGain,
            ref uint redLUT, ref uint greenLUT, ref uint blueLUT, uint bitDepth);

        [DllImport("imaq")]
        public static extern int imgBayerColorDecode(IntPtr dst, IntPtr src, uint rows, uint cols, uint dstRowPixels,
            uint srcRowPixels, ref uint redLUT, ref uint greenLUT, ref uint blueLUT, byte bayerPattern, uint bitDepth,
            uint reserved);

        [DllImport("imaq")]
        public static extern int imgSessionLineTrigSource2(uint sid, ImaqEnums.IMG_SIGNAL_TYPE trigType, uint trigNum,
            uint polarity, uint skip);

        [DllImport("imaq")]
        public static extern int imgSessionFitROI(uint sid, ImaqEnums.IMG_ROI_FIT_MODE fitMode, uint top, uint left,
            uint height, uint width, ref uint fittedTop, ref uint fittedLeft, ref uint fittedHeight,
            ref uint fittedWidth);

        [DllImport("imaq")]
        public static extern int imgEncoderResetPosition(uint sid);

        [DllImport("imaq")]
        public static extern int imgSessionCopyBufferByNumber(uint sid, uint bufNumber, IntPtr userBuffer,
            ImaqEnums.IMG_OVERWRITE_MODE overwriteMode, ref uint copiedNumber, ref uint copiedIndex);

        [DllImport("imaq")]
        public static extern int imgSessionCopyAreaByNumber(uint sid, uint bufNumber, uint top, uint left, uint height,
            uint width, IntPtr userBuffer, uint rowPixels, ImaqEnums.IMG_OVERWRITE_MODE overwriteMode,
            ref uint copiedNumber, ref uint copiedIndex);

        [DllImport("imaq", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int imgSetBufferElement2(uint bid, uint element, uint itemType, uint item1);

        [DllImport("imaq", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int imgSetBufferElement2(uint bid, uint element, uint itemType, uint item1, uint item2);

        [DllImport("imaq", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int imgSetBufferElement2(uint bid, uint element, uint itemType, uint item1, uint item2,
            uint item3);

        [DllImport("imaq", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int imgSetBufferElement2(uint bid, uint element, uint itemType, uint item1, uint item2,
            uint item3, uint item4);

        [DllImport("imaq")]
        public static extern int imgSessionExamineBuffer2(uint sid, uint whichBuffer, ref uint bufferNumber,
            ref IntPtr bufferAddr);

        [DllImport("imaq")]
        public static extern int imgPlot2(IntPtr hwnd, IntPtr buffer, uint leftBufOffset, uint topBufOffset, uint xsize,
            uint ysize, uint xpos, uint ypos, uint flags);

        [DllImport("imaq")]
        public static extern int imgPlotDC2(IntPtr hdc, IntPtr buffer, uint xbuffoff, uint ybuffoff, uint xsize,
            uint ysize, uint xscreen, uint yscreen, uint flags);

        [DllImport("imaq")]
        public static extern int imgSetAttributeFromVoidPtr(uint void_id, uint attribute, IntPtr valuePtr);

        [DllImport("imaq")]
        public static extern int imgSetBufferElementFromVoidPtr(uint bid, uint element, uint itemType, IntPtr valuePtr);

        [DllImport("imaq")]
        public static extern int imgSessionWaitSignalAsync3(uint sid, ImaqEnums.IMG_SIGNAL_TYPE signalType,
            uint signalIdentifier, uint signalPolarity, uint timeout, Delegate funcptr, IntPtr callbackData);


        [UnmanagedFunctionPointerAttribute(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate uint CALL_BACK_PTR(uint boardid, int err, uint signal, IntPtr data);

        [UnmanagedFunctionPointerAttribute(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public delegate uint CALL_BACK_PTR2(uint boardid, int err, ImaqEnums.IMG_SIGNAL_TYPE signalType,
            uint signalIdentifier, IntPtr data);
    }
}