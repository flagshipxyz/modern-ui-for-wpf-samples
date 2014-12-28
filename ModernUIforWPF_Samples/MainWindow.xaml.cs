using FirstFloor.ModernUI.Presentation;
using FirstFloor.ModernUI.Windows.Controls;
using System;
using System.IO;

namespace ModernUIforWPF_Samples
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ModernWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            string dir = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            _appearanceSettingsPath = Path.Combine(dir, "AppearanceSettings.xml");

            AppearanceSettings.Load(_appearanceSettingsPath);

            AppearanceManager.Current.ThemeSource = new Uri(AppearanceSettings.Instance.ThemeSource, UriKind.Relative);
            AppearanceManager.Current.FontSize = AppearanceSettings.Instance.FontSize;
            AppearanceManager.Current.AccentColor = AppearanceSettings.Instance.AccentColor;

            this.Closed += MainWindow_Closed;

        }

        string _appearanceSettingsPath = string.Empty;

        void MainWindow_Closed(object sender, EventArgs e)
        {
            AppearanceSettings.Save(_appearanceSettingsPath);
        }
    }
}
