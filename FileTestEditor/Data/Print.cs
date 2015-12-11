using System;
using System .Collections .Generic;
using System .Linq;
using System .Text;
using System .Drawing;
using System .Drawing .Printing;
using System.IO;


namespace FileTestEditor .Data {
    class Print {

        private int _pageH{get;set;}
        private int _pageW { get; set; }
        private double k = 0.3904;

        private List<object[]> _printObjects { get; set; }
        
        public double pageHmm { get; private set; }
        public double pageWmm { get; private set; }

        public Print(double pageW, double pageH) {
            this .pageHmm = pageH;
            this .pageWmm = pageW;
        }

        public List<string> getPrintDeviceList() {
            List<string> list = new List<string>();
            foreach (string printer in PrinterSettings .InstalledPrinters) {
                list .Add(printer);                
            }

            list .Insert(0 , "");

            return list;
        }

        public void printBatch(List<object[]> printObjects, string printerName) {
            _printObjects = printObjects;
            _pageH = Convert.ToInt32(Math .Round(pageHmm * k));
            _pageW = Convert .ToInt32(Math .Round(pageWmm * k));

            PrintDocument prDoc = new PrintDocument();

            prDoc .PrinterSettings .PrinterName = printerName;
            prDoc .DefaultPageSettings .PaperSize = new PaperSize("default" , _pageW , _pageH);
            if (_printObjects .Count >= 1) {
                prDoc .DefaultPageSettings .Landscape = useLandscape((byte[])_printObjects[0][0]);
            }

            prDoc .PrintPage += new PrintPageEventHandler(printPage);
            prDoc .Print();
        }

        private void printPage(object sender , PrintPageEventArgs e) { 
            Font font = new Font("Arial", 60, FontStyle.Bold, GraphicsUnit.Document);
            MemoryStream ms =new MemoryStream();
            ms.Write((byte[])_printObjects[0][0], 0, ((byte[])_printObjects[0][0]).Count());                        
            Bitmap bmap = null;
            bmap = new Bitmap(ms);
            ms .Close();         
            bool currentLandscape = e .PageSettings .Landscape;
            if (_printObjects .Count > 1) {
                e.PageSettings.Landscape = useLandscape(bmap);
            }

           
            Rectangle pictArea = new Rectangle();
            if (!currentLandscape) {
                pictArea .Height = e .PageSettings .PaperSize .Height - 150;
                pictArea .Width = e .PageSettings .PaperSize .Width - 150;
            }
            else {
                pictArea .Height = e .PageSettings .PaperSize .Width - 150;
                pictArea .Width = e .PageSettings .PaperSize .Height - 150;
            }

            bmap = this .zoomBitmap(bmap, pictArea);

            Point imgPoint =new Point(50,70);
            e .Graphics .DrawImage((Image)bmap , imgPoint);
            string caption = "{0} Вариант {1} {2}{3}";
            caption=string.Format(caption,_printObjects[0][4],_printObjects[0][5],_printObjects[0][1],_printObjects[0][2]);
            e .Graphics .DrawString(caption, font , Brushes .Black , new PointF(50 , 50));

            _printObjects .Remove(_printObjects[0]);
            e .HasMorePages = (_printObjects .Count == 0) ? false : true;               
        }

        private Bitmap zoomBitmap(Bitmap source, Rectangle pictArea) {
           
            double kX = 1.0;
            double kY = 1.0;
            
            if (source .Height >= pictArea.Height) {
                kX = (double)source .Height / (double)pictArea .Height;
            }
            if (kY == 1.0) {
                if (source .Width >= pictArea .Width) {
                    kY = (double)source .Width / (double)pictArea .Width;
                }
            }
            Size newSize = new Size();
            newSize.Height = Convert .ToInt32(source.Height/kX);
            newSize.Width = Convert .ToInt32(source.Width/kY);
            Bitmap complete = new Bitmap((Image)source , newSize);
            
            return complete;
        }

        private bool useLandscape(byte[] byts) {
            MemoryStream ms = new MemoryStream();
            ms .Write(byts , 0 , byts .Count());
            Bitmap bmap = new Bitmap(ms);
            ms .Close();
            if (bmap .Width > bmap .Height) {
                return true;
            }

            return false;
        }

        private bool useLandscape(Bitmap bmap) {            
            if (bmap .Width > bmap .Height) {
                return true;
            }

            return false;
        }
    }
}
