using System;
using System .Collections .Generic;
using System .Linq;
using System .Text;
using System.Windows.Forms;

namespace FileTestEditor .Helper {
    public static class MessageManager {
        public static DialogResult showInfoMessage(string message) {
          return  MessageBox .Show( message , "" , MessageBoxButtons .OK , MessageBoxIcon .Information , MessageBoxDefaultButton .Button1);
        }

        public static DialogResult showErrorMessage(string message) {
            return MessageBox .Show(message , "" , MessageBoxButtons .OK , MessageBoxIcon .Error , MessageBoxDefaultButton .Button1);
        }

        public static DialogResult showOKCancelMessage(string message) {
            return MessageBox .Show(message , "" , MessageBoxButtons .OKCancel , MessageBoxIcon .Question , MessageBoxDefaultButton .Button2);
        }

        public static DialogResult showYesNoCancelMessage(string message) {
            return MessageBox .Show(message , "" , MessageBoxButtons .YesNoCancel , MessageBoxIcon .Question , MessageBoxDefaultButton .Button3);
        }
    }
}
