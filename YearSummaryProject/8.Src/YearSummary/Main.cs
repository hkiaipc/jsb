using System;
using NLog;
using System.Windows.Forms;
namespace YearSummary
{
	/// <summary>
	/// Main ��ժҪ˵����
	/// </summary>
	public class MainClass
	{
        static NLog.Logger logger = LogManager.GetCurrentClassLogger ();

		/// <summary>
		/// Ӧ�ó��������ڵ㡣
		/// </summary>
		[STAThread]
		static void Main() 
		{
            System.AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
			Application.Run(new frmYearSummary());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            HandleException (e.Exception );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            HandleException (e.ExceptionObject as Exception);
        }

        /// <summary>
        /// 
        /// </summary>
        static private void HandleException ( Exception ex)
        {
            MessageBox.Show (ex.Message , "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error );
            logger.Fatal(ex);
            Environment.Exit (1);
        }
    }
}
