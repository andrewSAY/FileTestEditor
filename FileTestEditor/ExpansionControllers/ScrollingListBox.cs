using System;
using System .Collections .Generic;
using System .Linq;
using System .Text;
using System.Windows.Forms;

namespace FileTestEditor .ExpansionControllers {
    class ScrollingListBox:ListBox {

        private int _numberOfDivisions = 0;

        protected override void OnMouseWheel(MouseEventArgs e) {                       
            if (this ._numberOfDivisions == 0) {
                this ._numberOfDivisions = Math.Abs(e .Delta);
            }
            if (this .Items .Count == 0) { 
                return;
            }
            int currentIndex = this .SelectedIndex;
            int offsetPoints = Convert.ToInt32(e .Delta / this ._numberOfDivisions) * -1;
            currentIndex += offsetPoints;
            if (offsetPoints > 0) {                
                if (currentIndex >= this .Items .Count) {
                    currentIndex = this .Items .Count - 1;
                }                
            }
            if (offsetPoints < 0) {                
                if (currentIndex <= 0) {
                    currentIndex = 0;
                }   
            }
            this .SelectedIndex = currentIndex;
        }

        protected override void OnMouseHover(EventArgs e) {
            base .OnMouseHover(e);
            this .Focus();
        }
    }
}
