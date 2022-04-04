using System;
using System.Windows;
using System.Windows.Controls;
using Warp.Tools;

namespace Warp.Controls
{
    /// <summary>
    /// Interaction logic for LogMessage.xaml
    /// </summary>
    public partial class LogMessageDisplay : UserControl
    {
        private LogMessage Message;

        private void Message_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (Message == null)
            {
                PanelContent.Children.Clear();
                return;
            }

            if (e.PropertyName == "Timestamp")
            {
                UpdateTimestamp(Message.Timestamp);
            }
            else if (e.PropertyName == "Content")
            {
                UpdateContent(Message.Content);
            }
        }

        public LogMessageDisplay()
        {
            InitializeComponent();

            DataContextChanged += LogMessageDisplay_DataContextChanged;
        }

        void UpdateTimestamp(DateTime timestamp)
        {
            TextTimestamp.Text = timestamp.ToString("HH:mm:ss");
        }

        void UpdateContent(object content)
        {
            PanelContent.Children.Clear();

            if (content is string)
            {
                TextBlock Text = new TextBlock
                {
                    Text = (string)content
                };

                PanelContent.Children.Add(Text);
            }
        }

        private void LogMessageDisplay_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (e.OldValue != null)
                ((LogMessage)e.OldValue).PropertyChanged -= Message_PropertyChanged;
            if (e.NewValue != null)
            {
                ((LogMessage)e.NewValue).PropertyChanged += Message_PropertyChanged;
                UpdateTimestamp(((LogMessage)e.NewValue).Timestamp);
                UpdateContent(((LogMessage)e.NewValue).Content);
            }
        }
    }
}
