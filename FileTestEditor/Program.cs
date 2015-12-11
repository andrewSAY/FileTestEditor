using System;
using System .Collections .Generic;
using System .Linq;
using System .Windows .Forms;

namespace FileTestEditor {
    static class Program {
        public static Data .ApplicationManager AppManager = new Data .ApplicationManager();
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main() {
            Application .EnableVisualStyles();
            Application .SetCompatibleTextRenderingDefault(false);
            Application .Run(new FormMain());
        }
    }
}
