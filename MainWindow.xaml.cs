using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;

namespace system_programming
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            List<Process> processList = new List<Process>(Process.GetProcesses());
            processListView.Items.Clear();
            foreach (var process in processList)
            {
                processListView.Items.Add(new { Name = process.ProcessName, Id = process.Id });
            }
        }
    }
}
