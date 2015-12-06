using System.Windows;
using System.Windows.Input;

namespace WpfApplication1 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e) {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e) {
            new MainWindow().Show();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e) {
            Close();
        }
    }
}
