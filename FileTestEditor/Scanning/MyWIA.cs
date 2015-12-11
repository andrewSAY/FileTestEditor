using System;
using System .Collections .Generic;
using System .Runtime .InteropServices;
using System .Linq;
using System .Drawing;
using WIA;
using System .IO;
using System .Text;

namespace FileTestEditor .Scanning {
    public class MyWIA {               
        private class WIA_DPS_DOCUMENT_HANDLING_SELECT {
            public const uint FEEDER = 0x00000001;
            public const uint FLATBED = 0x00000002;
        }

        private class WIA_DPS_DOCUMENT_HANDLING_STATUS {
            public const uint FEED_READY = 0x00000001;
        }

        private class WIA_PROPERTIES {
            //Base
            public const uint UNIQUE_DEVICE_ID = 2;
            public const uint DESCRIPTION = 4;
            public const uint NAME = 7;

            //Items            
            public const uint HORIZONTAL_RESOLUTION = 6147;
            public const uint VERTICAL_RESOLUTION = 6148;
            public const uint HORIZONTAL_EXTENT = 6151;
            public const uint VERTICAL_EXTENT = 6152;
            public const uint CONTRAST = 6155;
            public const uint CURRENT_INTENT = 6146; //(РЕЖИМ СКАНИРОВАНИЯ 2 - ОТТЕНКИ СЕРОГО)
            public const uint THRESHOLD = 6159; //(БИТНОСТЬ ЦВЕТОВОЙ ПАЛИТРЫ)
            public const uint BITS_PER_CHANNEL = 4110;

            //

            public const uint WIA_RESERVED_FOR_NEW_PROPS = 1024;
            public const uint WIA_IPS_DOCUMENT_HANDLING_SELECT = 3088;
            public const uint WIA_DIP_FIRST = 2;
            public const uint WIA_DPA_FIRST = WIA_DIP_FIRST + WIA_RESERVED_FOR_NEW_PROPS;
            public const uint WIA_DPC_FIRST = WIA_DPA_FIRST + WIA_RESERVED_FOR_NEW_PROPS;
            //
            // Scanner only device properties (DPS)
            //
            public const uint WIA_DPS_FIRST = WIA_DPC_FIRST + WIA_RESERVED_FOR_NEW_PROPS;
            public const uint WIA_DPS_DOCUMENT_HANDLING_STATUS = WIA_DPS_FIRST + 13;
            public const uint WIA_DPS_DOCUMENT_HANDLING_SELECT = WIA_DPS_FIRST + 14;
            public const uint HORIZONTAL_OPTICAL_RESOLUTION = 3090;
            public const uint VERTICAL_OPTICAL_RESOLUTION = 3091;
        }
        
        private CommonDialog wiaDiag = new CommonDialog();
        private Device device = null;
        private const string wiaFormatJPEG = "{B96B3CAE-0728-11D3-9D7B-0000F81EF32E}";
        private List<WiaException> _wiaExceptionList { get; set; }

        public class WiaException {
            public uint hResult { get; private set;}
            public string hResultString { get; private set; }
            public string name { get; private set; }
            public string message { get; private set; }

            public WiaException(uint hResult , string name , string message) {
                this .hResult = hResult;
                this .hResultString = "0x"+hResult .ToString("X");
                this .name = name;
                this .message = message;
            }
        }

        public enum ColorMode : int { 
            halftone = 0,
            color = 1,
            greyscale = 2,
            blackAndWhite = 4
        }        

        public MyWIA() {

            WiaException error = null;
            this ._wiaExceptionList = new List<WiaException>();

            error = new WiaException(0x80210001 , "general" , "General error");
            this ._wiaExceptionList .Add(error);

            error = new WiaException(0x80210002 , "paperJam" , "Замятие бумаги");
            this ._wiaExceptionList .Add(error);

            error = new WiaException(0x80210003 , "paperEmpty" , "Нет бумаги");
            this ._wiaExceptionList .Add(error);

            error = new WiaException(0x80210004 , "paperProblem" , "Проблемы с бумагой");
            this ._wiaExceptionList .Add(error);

            error = new WiaException(0x80210005 , "offline" , "Устройство офлайн");
            this ._wiaExceptionList .Add(error);

            error = new WiaException(0x80210006 , "busy" , "Устройство занято");
            this ._wiaExceptionList .Add(error);

            error = new WiaException(0x80210007 , "warmingUp" , "Идет разогрев устройства");
            this ._wiaExceptionList .Add(error);

            error = new WiaException(0x80210008 , "userIntervention" , "Вмешательство пользователя");
            this ._wiaExceptionList .Add(error);

            error = new WiaException(0x80210009 , "itemDeleted" , "Объект сканирования(item) удален");
            this ._wiaExceptionList .Add(error);

            error = new WiaException(0x8021000A , "deviceCommunication" , "Идет установка связи с устройством");
            this ._wiaExceptionList .Add(error);

            error = new WiaException(0x8021000B , "invalidCommand" , "Неверная команда");
            this ._wiaExceptionList .Add(error);

            error = new WiaException(0x8021000C , "incorrectHardwareSettings" , "Некорректные аппаратные настройки");
            this ._wiaExceptionList .Add(error);

            error = new WiaException(0x8021000D , "deviceLocked" , "Устройство заблокировано");
            this ._wiaExceptionList .Add(error);

            error = new WiaException(0x8021000E , "exceptionDriver" , "Ислючение на уровне дроайвера устройства");
            this ._wiaExceptionList .Add(error);

            error = new WiaException(0x8021000F , "invalidDriverResponse" , "Неверный ответ от драйвера устройства");
            this ._wiaExceptionList .Add(error);

            error = new WiaException(0x80210016 , "coverOpen" , "Открыта крышка устрйства");
            this ._wiaExceptionList .Add(error);

            error = new WiaException(0x80210017 , "lampOff" , "Лампа устройства оключена");
            this ._wiaExceptionList .Add(error);

        }

        public class OperationResult {
            public string message { get; private set; }
            public bool hasError { get; private set; }

            public OperationResult(string message , bool hasError) {
                this .message = message;
                this .hasError = hasError;
            }
        }

        [Serializable()]
        public class ScanSettings : Model.BinaryStorageAbstract {           
            
            public string deviceId { get; set; }
            public int dpiResolution { get; set; }
            public int resolution { get; set; }
            public int contrast { get; set; }
            public int threshold { get; set; }
            public int pixelsVExtents { get; set; }
            public int pixelsHExtents { get; set; }
            public int verticalExtent {
                get {
                    return Convert .ToInt32(pixelsVExtents * 25.4 / resolution);
                }
                set {
                    int v = value;
                    pixelsVExtents = Convert .ToInt32(value / 25.4 * resolution);
                }
            }

            public int horisontalExtent {
                get{
                    return Convert.ToInt32(pixelsHExtents * 25.4/resolution);
                }
                set {
                    pixelsHExtents = Convert .ToInt32(value / 25.4 * resolution);
                }
            }
            public ColorMode currentIntent { get; set; }
            public bool useDuplex { get; set; }
            /// <summary>
            /// Конструктор класса
            /// </summary>
            /// <param name="dpiResolution">Разарешенеи в точка на дюйм</param>
            /// <param name="resolution">Разарешенив точка на дюйм</param>
            /// <param name="contrast">Контрастность</param>
            /// <param name="horisontalExtent">Горизонтальная протяженность сканируемого обектка, задается в милиметрах</param>
            /// <param name="verticalExtent">Вертикальная протяженность сканируемого обектка, задается в милиметрах</param>
            /// <param name="currentIntent">Цветовой режим</param>
            /// <param name="threshold">Порог для сканирования в серых тонах</param>
            /// <param name="useDuplex">Флаг использования дуплекса при сканировании</param>
            public ScanSettings(int dpiResolution  = 300,
                                int resolution = 300,
                                int contrast = 0,
                                int horisontalExtent = 210,
                                int verticalExtent = 297,
                                ColorMode currentIntent = ColorMode.greyscale,
                                int threshold = 128,
                                bool useDuplex = false) {
                this .resolution = resolution;
                this .dpiResolution = dpiResolution;
                this .contrast = contrast;
                this .verticalExtent = verticalExtent;
                this .horisontalExtent = horisontalExtent;
                this .currentIntent = currentIntent;
                this .threshold = threshold;
                this .useDuplex = useDuplex;
            
            }            
        }

        public Device getDevice() {
            return this .device;
        }

        public void setDevice(string deviceId) {
            DeviceManager deviceMng = new DeviceManager();
            foreach (DeviceInfo info in deviceMng .DeviceInfos) {
                if (info .DeviceID == deviceId) {
                    device = info .Connect();
                    break;
                }
            }
        }

        public string getDeviceName() {
            if (device == null) {
                return "Устройство не выбрано";
            }
            return  device .Properties[WIA_PROPERTIES .NAME.ToString()] .get_Value() .ToString();
        }

        public Image simpleScan() {            
            WIA .ImageFile wiaImage = null;
            try {
                wiaImage = wiaDiag .ShowAcquireImage(WiaDeviceType .ScannerDeviceType , WiaImageIntent .GrayscaleIntent , WiaImageBias .MaximizeQuality , wiaFormatJPEG , true , true , false);
            }
            catch (Exception exc) {
                
            }
            WIA .Vector vector = wiaImage .FileData;
            Image i = Image .FromStream(new MemoryStream((byte[])vector .get_BinaryData()));
            return i;
        }

        public OperationResult scaningMulti(ref List<Image> imageList , ScanSettings setting) {
            bool hasMorePages = true;
            OperationResult result = null;
            if (device == null) {
                this .selectDevice();
            }
            try {
                while (hasMorePages) {
                    DeviceManager deviceMng = new DeviceManager();
                    foreach (DeviceInfo info in deviceMng .DeviceInfos) {
                        if (info .DeviceID == device .DeviceID) {
                            device = info .Connect();
                            break;
                        }
                    }

                    this. applySettings(setting);

                    WIA .Item itemWIA = device .Items[1];                  
                    WIA .ImageFile imgFile = null;
                    WIA .ImageFile imgFaileBeyond = null;
                    imgFile = (WIA .ImageFile)wiaDiag .ShowTransfer(itemWIA , wiaFormatJPEG , false);
                    if (setting .useDuplex) {
                        imgFaileBeyond = (WIA .ImageFile)wiaDiag .ShowTransfer(itemWIA , wiaFormatJPEG , false);
                    }
                    WIA .Vector vector = imgFile .FileData;
                    Image i = Image .FromStream(new MemoryStream((byte[])vector .get_BinaryData()));
                    imageList .Add(i);
                    if (setting .useDuplex) {
                        vector = imgFaileBeyond .FileData;
                        i = Image .FromStream(new MemoryStream((byte[])vector .get_BinaryData()));
                        imageList .Add(i);
                    }
                    hasMorePages = this .hasMorePages(device);
                }
            }
            catch (Exception exc) {
                if (this .isWiaException(exc , ref result)) {
                    return result;
                }

                result = new OperationResult(exc .Message , true);
                return result;
            }

            result = new OperationResult("Сканирование завершено" , false);
            return result;
        }


        public OperationResult scaningOne(ref List<Image> imageList , ScanSettings setting) {           
            OperationResult result = null;
            if (device == null) {
                this .selectDevice();
            }
            try {               
                    DeviceManager deviceMng = new DeviceManager();
                    foreach (DeviceInfo info in deviceMng .DeviceInfos) {
                        if (info .DeviceID == device .DeviceID) {
                            device = info .Connect();
                            break;
                        }
                    }

                    this .applySettings(setting);

                    WIA .Item itemWIA = device .Items[1];
                    WIA .ImageFile imgFile = null;
                    WIA .ImageFile imgFaileBeyond = null;
                    imgFile = (WIA .ImageFile)wiaDiag .ShowTransfer(itemWIA , wiaFormatJPEG , false);
                    if (setting .useDuplex) {
                        imgFaileBeyond = (WIA .ImageFile)wiaDiag .ShowTransfer(itemWIA , wiaFormatJPEG , false);
                    }
                    WIA .Vector vector = imgFile .FileData;
                    Image i = Image .FromStream(new MemoryStream((byte[])vector .get_BinaryData()));
                    imageList .Add(i);
                    if (setting .useDuplex) {
                        vector = imgFaileBeyond .FileData;
                        i = Image .FromStream(new MemoryStream((byte[])vector .get_BinaryData()));
                        imageList .Add(i);
                    }                   
                
            }
            catch (Exception exc) {
                if (this .isWiaException(exc , ref result)) {
                    return result;
                }

                result = new OperationResult(exc .Message , true);
                return result;
            }

            result = new OperationResult("Сканирование завершено" , false);
            return result;
        }

        public OperationResult selectDevice() {
            OperationResult result = null;
            try {
                device = wiaDiag .ShowSelectDevice(WiaDeviceType .ScannerDeviceType , true , false);
            }
            catch (Exception exc) {
                if (this .isWiaException(exc , ref result)) {
                    return result;
                }

                result = new OperationResult(exc .Message , true);
                return result;
            }
            result = new OperationResult("Success" , false);
            return result;
        }

        public OperationResult showProperties() {
            OperationResult result = null;
            try {
                wiaDiag .ShowDeviceProperties(device , false);
            }
            catch (Exception exc) {
                if (this .isWiaException(exc , ref result)) {
                    return result;
                }

                result = new OperationResult(exc .Message , true);                
                return result;
            }
            result = new OperationResult("Success" , false);
            return result;
        }

        private bool hasMorePages(Device WiaDev) {
            try {
                bool hasMorePages = false;
                //determine if there are any more pages waiting
                Property documentHandlingSelect = null;
                Property documentHandlingStatus = null;
                foreach (Property prop in WiaDev .Properties) {
                    if (prop .PropertyID == WIA_PROPERTIES .WIA_DPS_DOCUMENT_HANDLING_SELECT)
                        documentHandlingSelect = prop;
                    if (prop .PropertyID == WIA_PROPERTIES .WIA_DPS_DOCUMENT_HANDLING_STATUS)
                        documentHandlingStatus = prop;                                        
                }

                hasMorePages = false; //assume there are no more pages
                if (documentHandlingSelect != null)
                //may not exist on flatbed scanner but required for feeder
					{
                    //check for document feeder
                    if ((Convert .ToUInt32(documentHandlingSelect .get_Value()) & WIA_DPS_DOCUMENT_HANDLING_SELECT .FEEDER) != 0) {
                        UInt32 value1 = Convert .ToUInt32(documentHandlingStatus .get_Value());
                        hasMorePages = ((Convert .ToUInt32(documentHandlingStatus .get_Value()) & WIA_DPS_DOCUMENT_HANDLING_STATUS .FEED_READY) != 0);
                    }
                }
                return hasMorePages;
            }
            catch (Exception ex) {                
                throw ex;
            }
        }

        private bool isWiaException(Exception exc, ref OperationResult result) {
            int hR = System .Runtime .InteropServices .Marshal .GetHRForException(exc);            
            foreach (WiaException item in this ._wiaExceptionList) {
                if (exc .Message .IndexOf(item .hResultString.ToString()) > -1) {
                    result = new OperationResult(item .message , true);
                    return true;
                }
            }
            
            return false;
        }

        private void applySettings(ScanSettings setting) {
            WIA .Item itemWIA = device .Items[1];
            foreach (WIA .Property prop in itemWIA .Properties) {
                if (prop .PropertyID == WIA_PROPERTIES .HORIZONTAL_RESOLUTION) {
                    prop .set_Value((object)setting.resolution);
                }
                if (prop .PropertyID == WIA_PROPERTIES .VERTICAL_RESOLUTION) {
                    prop .set_Value((object)setting.resolution);
                }
                if (prop .PropertyID == WIA_PROPERTIES .HORIZONTAL_EXTENT) {
                    prop .set_Value((object)setting.pixelsHExtents);
                }
                if (prop .PropertyID == WIA_PROPERTIES .VERTICAL_EXTENT) {
                    prop .set_Value((object)setting.pixelsVExtents);
                }
                if (prop .PropertyID == WIA_PROPERTIES .CONTRAST) {
                    prop .set_Value((object)setting.contrast);
                }
                if (prop .PropertyID == WIA_PROPERTIES .CURRENT_INTENT) {
                    prop .set_Value((object)setting .currentIntent);
                }
                if (prop .PropertyID == WIA_PROPERTIES .THRESHOLD) {
                    int Val = (int)prop .get_Value();
                    prop .set_Value((object)setting .threshold);
                }

            }
            if (setting.useDuplex) {
                foreach (WIA .Property prop in device .Properties) {
                    if (prop .PropertyID == WIA_PROPERTIES .WIA_IPS_DOCUMENT_HANDLING_SELECT) {
                        prop .set_Value((object)0x005);
                    }
                   /* if (prop .PropertyID == WIA_PROPERTIES .HORIZONTAL_OPTICAL_RESOLUTION) {
                        prop .set_Value((object)setting.dpiResolution);
                    }
                    if (prop .PropertyID == WIA_PROPERTIES .VERTICAL_OPTICAL_RESOLUTION) {                        
                         prop .set_Value((object)setting .dpiResolution);
                    }*/
                }
            }
        }
    }
}

public class EZTwain {
    [DllImport("eztw32.dll" , CharSet = CharSet .Ansi , ExactSpelling = true , EntryPoint = "TWAIN_AcquireNative")]
    public static extern System .IntPtr AcquireNative(System .IntPtr hwndApp , int wPixTypes);


    [DllImport("eztw32.dll" , CharSet = CharSet .Ansi , ExactSpelling = true , EntryPoint = "TWAIN_SetHideUI")]
    public static extern void SetHideUI(int fHide);

    [DllImport("eztw32.dll" , CharSet = CharSet .Ansi , ExactSpelling = true , EntryPoint = "TWAIN_OpenDefaultSource")]
    public static extern int OpenDefaultSource();

    [DllImport("eztw32.dll" , CharSet = CharSet .Ansi , ExactSpelling = true , EntryPoint = "TWAIN_SetBitDepth")]
    public static extern int SetBitDepth(int nBits);

    [DllImport("eztw32.dll" , CharSet = CharSet .Ansi , ExactSpelling = true , EntryPoint = "TWAIN_SetCurrentResolution")]
    public static extern int SetCurrentResolution(double dRes);


}
