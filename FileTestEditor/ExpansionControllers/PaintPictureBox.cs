using System;
using System .Collections .Generic;
using System .Drawing;
using System .Linq;
using System .Text;
using System .Windows .Forms;

namespace FileTestEditor .ExpansionControllers {
    class PaintPictureBox : PictureBox {
        private bool _lmPress = false;        
        private Point _ptOriginal = new Point();
        private Point _ptLast = new Point();
        private Rectangle _frame = new Rectangle();
        public Image cutingImage {get; private set;}

        public delegate void changecutingImageDelegate(bool e);
        public event changecutingImageDelegate changeCutingImage;

        private void DrawFrame(Graphics gr) {
            
            gr .DrawRectangle(Pens .Red , this ._frame);            
        }
        protected override void OnMouseDown(MouseEventArgs e) {
           
            if (e .Button == MouseButtons .Left && this.Image!=null) {
                this ._lmPress = true;                
            }
            _ptOriginal .X = e .X;
            _ptOriginal .Y = e .Y;          
            _ptLast .X = -1;
            _ptLast .Y = -1;
        }
        protected override void OnMouseMove(MouseEventArgs e) {
           
            Point ptCurrent = new Point(e .X , e .Y);
            if (this ._lmPress) {                
                if (_ptLast .X != -1) {
                    DrawDraggingShape(_ptOriginal , _ptLast);
                }                
                _ptLast = ptCurrent;                
                DrawDraggingShape(_ptOriginal , ptCurrent);                
            }
        }
        protected override void OnMouseUp(MouseEventArgs e) {
           
            this ._lmPress = false;          
            if (_ptLast .X != -1) {
                Point ptCurrent = new Point(e .X , e .Y);              
                Invalidate();
            }            
            _ptLast .X = -1;
            _ptLast .Y = -1;
            _ptOriginal .X = -1;
            _ptOriginal .Y = -1;
        }
        protected override void OnPaint(PaintEventArgs pe) {
            base .OnPaint(pe);
            DrawFrame(pe .Graphics);
        }
        protected override void OnMouseClick(MouseEventArgs e) {
                     
                if(!this.hasInFrame(e.Location)) {
                    this .clearFrame();
                }
            
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e) {
          
            if (hasInFrame(e .Location)) {
                this .cutSelectedImage(); 
            }
        }

        protected override void OnResize(EventArgs e) {
            base .OnResize(e);
            
        }

        private bool hasInFrame(Point e) { 
            int x1 = _frame .X;
            int x2 = _frame .X + _frame .Width;
            int y1 = _frame .Y;
            int y2 = _frame .Y + _frame .Height;
            if ((e .X < x1 || e .X > x2) || (e .Y < y1 || e .Y > y2)) {
                return false;
            }
            return true;
        }

        private void clearFrame() {
            this ._frame .Width = 0;
            this ._frame .Height = 0;
            Invalidate();
        }

        private void cutSelectedImage() {
            if (this ._frame .Width == 0 ||
                this ._frame .Height == 0) {
                    return;
            }
            
            Rectangle frame = this ._frame;
            this .setScalingK(ref frame);
            Bitmap bmp = new Bitmap(frame .Width, frame .Height);            
            bmp .SetResolution(this.Image.HorizontalResolution , this.Image.VerticalResolution);
            Graphics g = Graphics .FromImage(bmp);
            g .InterpolationMode = System .Drawing .Drawing2D .InterpolationMode .HighQualityBicubic;
            g .DrawImage(this.Image , 0 , 0 , frame , GraphicsUnit .Pixel);
            g .Dispose();                                    
            this .cutingImage = (Image)bmp;
            this .clearFrame();

            if (this .changeCutingImage != null) {
                this .changeCutingImage(true);
            }          
            
        }

        private void setScalingK(ref Rectangle frame) {
            double k = 1.0;
            bool isReduction = false;
            if (this .SizeMode == PictureBoxSizeMode .Zoom) {
                    if (this .Image .Height > this .Height) {
                        k = (double)this .Image .Height / (double)this .Height;
                    }
                    else {
                        if (this .Image .Width > this .Width) {
                            k = (double)this .Image .Width / (double)this .Width;
                        }
                    }

                    if (this .Image .Height < this .Height) {
                        k = (double)this .Height / (double)this .Image .Height;
                        isReduction = true;
                    }
                    else {
                        if (this .Image .Width < this .Width) {
                            k = (double)this .Width / (double)this .Image .Width;
                            isReduction = true;
                        }
                    }
            }
            
            if (k != 1.0) {
                if (!isReduction) {
                    frame .X = Convert .ToInt32((double)(frame .X - Convert .ToInt32(((double)this .Width / (double)2 - (double)this .Image .Width / ((double)2 * k)))) * k);
                    frame .Y = Convert .ToInt32((double)(frame .Y - Convert .ToInt32((double)this .Height / (double)2 - (double)this .Image .Height / ((double)2 * k))) * k);
                    frame .Height = Convert .ToInt32((double)frame .Height * k);
                    frame .Width = Convert .ToInt32((double)frame .Width * k);  
                }
                else {
                    frame .X = Convert .ToInt32((double)(frame .X - Convert .ToInt32(((double)this .Width / (double)2 - (double)this .Image .Width / ((double)2) * k))) / k);
                    frame .Y = Convert .ToInt32((double)(frame .Y - Convert .ToInt32((double)this .Height / (double)2 - (double)this .Image .Height / ((double)2) * k)) / k);
                    frame .Height = Convert .ToInt32((double)frame .Height / k);
                    frame .Width = Convert .ToInt32((double)frame .Width / k);  
                }                
            }
                                             
        }

        protected override void OnSizeModeChanged(EventArgs e) {                       
            base .OnSizeModeChanged(e);
        }

        private void DrawDraggingShape(Point p1 , Point p2) {

            Rectangle rc = new Rectangle();
            this ._frame = new Rectangle();
            
            p1 = PointToScreen(p1);
            p2 = PointToScreen(p2);
            
            if (p1 .X < p2 .X) {
                rc .X = p1 .X;
                rc .Width = p2 .X - p1 .X;
            }
            else {
                rc .X = p2 .X;
                rc .Width = p1 .X - p2 .X;
            }
            if (p1 .Y < p2 .Y) {
                rc .Y = p1 .Y;
                rc .Height = p2 .Y - p1 .Y;
            }
            else {
                rc .Y = p2 .Y;
                rc .Height = p1 .Y - p2 .Y;
            }
          
            this ._frame.Location = PointToClient(rc .Location);
            this ._frame .Width = rc .Width;
            this ._frame .Height = rc .Height;
            
            ControlPaint .DrawReversibleFrame(rc ,
                            Color .Black , FrameStyle .Dashed);            
        }            

    }
}
