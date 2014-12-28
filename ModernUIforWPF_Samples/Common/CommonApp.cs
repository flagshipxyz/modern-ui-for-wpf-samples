using System;
using System.Windows;

namespace ModernUIforWPF_Samples
{
    public class CommonApp
    {
        public static void ExceptionLog(Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
    }
}
