using System;
using System .Collections .Generic;
using System .Linq;
using System .Text;
using System .Text .RegularExpressions;
using System .Windows .Forms;

namespace FileTestEditor .ExpansionControllers {
    class RegMaskTetxBox:TextBox {
        public string regMask { get; set; }     

        protected override void OnKeyPress(KeyPressEventArgs e) {
            if (this .regMask .Length == 0 || e.KeyChar == 8) {
                return;
            }            
            string value = e .KeyChar .ToString();
            if (!Regex .IsMatch(value , this .regMask)) {
                e .Handled = true;
            }                        
        }
    }
}
