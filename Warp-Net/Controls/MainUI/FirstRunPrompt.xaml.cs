using System;
using System.Windows;
using System.Windows.Controls;

namespace Warp.Controls
{
    /// <summary>
    /// Interaction logic for AnalyticsPrompt.xaml
    /// </summary>
    public partial class FirstRunPrompt : UserControl
    {
        public event Action Close;

        public FirstRunPrompt()
        {
            InitializeComponent();
        }

        private void ButtonClose_OnClick(object sender, RoutedEventArgs e)
        {
            Close?.Invoke();
        }

        private void Hyperlink_OnClick(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.warpem.com/warp/?page_id=51");
        }
    }
}
