using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace WanganGarageManager
{
    class ApplicationEvents
    {
        public ApplicationEvents()
        {
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(WanganGarageManager_UnhandledException);
        }

        private void WanganGarageManager_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (!Debugger.IsAttached)
            {
                if (MessageBox.Show("エラーが発生したため、アプリケーションを終了する必要があります。ログファイルを保存しますか？", "Wangan Garage Managerがクラッシュしました。", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    File.WriteAllText("errorlog_" + DateTime.UtcNow.ToString("ddMMyyyy-HHmmss") + ".log", e.ExceptionObject.ToString());
                }
                Environment.Exit(0xFF);
            }
        }
    }
}
