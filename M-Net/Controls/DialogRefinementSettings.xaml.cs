using System;
using System.Windows;
using System.Windows.Controls;

namespace M.Controls
{
    /// <summary>
    /// Interaction logic for DialogRefinementSettings.xaml
    /// </summary>
    public partial class DialogRefinementSettings : UserControl
    {
        public event Action StartRefinement;
        public event Action Close;

        public DialogRefinementSettings()
        {
            InitializeComponent();
        }

        private void ButtonCancel_OnClick(object sender, RoutedEventArgs e)
        {
            Close?.Invoke();
        }

        private void ButtonRefine_Click(object sender, RoutedEventArgs e)
        {
            StartRefinement?.Invoke();
        }
    }
}
