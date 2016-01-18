using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Diagnostics;
using Guest_Booker_Studio.Presentation.Controls;
using Guest_Booker_Studio.Presentation;


namespace Guest_Booker_Studio
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static MainWindow mainWindowInstance;
        public static bool IsInDevelopment = false;
        public App()
        {
          
            Thread.CurrentThread.Priority = ThreadPriority.Highest;
            IsInDevelopment = Convert.ToBoolean(ConfigurationManager.AppSettings["IsInDevelopment"]);
            ShutdownMode = System.Windows.ShutdownMode.OnMainWindowClose;
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            System.Windows.SplashScreen splash = new SplashScreen("/Presentation/Resources/Images/final start draft.png");
            splash.Show(false, true);
            Thread.Sleep(4000);
            splash.Close(new TimeSpan(0, 0, 2));
            bool AllowMultipleInstance = Convert.ToBoolean(ConfigurationManager.AppSettings["AllowMultipleInstance"]);
            if (!AllowMultipleInstance)
            {
                Process currentProcess = Process.GetCurrentProcess();
                if (Process.GetProcessesByName(currentProcess.ProcessName).Length > 1)
                {
                    MessageBox.Show("Application is already running.");
                    Application.Current.Shutdown();
                    return;
                }

            Application.Current.DispatcherUnhandledException += new System.Windows.Threading.DispatcherUnhandledExceptionEventHandler(Current_DispatcherUnhandledException);
            base.OnStartup(e);
            }
        }
        void Current_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            if (e.Exception != null)
            {
                if (IsInDevelopment)
                {
                    string msg = e.Exception.Message + "\n\r";
                    msg += (e.Exception.InnerException == null) ? "" : e.Exception.InnerException.Message;

                    new BookerStudioMessageBox("Runtime Exception", msg, GuestBookerMessageBoxButtons.Ok, IconType.Info).ShowDialog();

                }
            }
            e.Handled = true;
        }


        }
    
}
