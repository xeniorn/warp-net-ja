using System;
using System.Windows;
using System.Windows.Controls;

namespace Warp.Controls.Sociology.Dialogs
{
    /// <summary>
    /// Interaction logic for DialogCreateSourceFromSettings.xaml
    /// </summary>
    public partial class DialogCreateSourceFromSettings : UserControl
    {
        public event Action Create;
        public event Action Close;

        public DialogCreateSourceFromSettings()
        {
            InitializeComponent();
        }

        private void ButtonCancel_OnClick(object sender, RoutedEventArgs e)
        {
            Close?.Invoke();
        }

        private void ButtonCreate_OnClick(object sender, RoutedEventArgs e)
        {
            Create?.Invoke();
        }
    }
}
