using SurveyHelper.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SurveyHelper {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        QuestionViewModel vm;
        public MainWindow() {
            InitializeComponent();
            vm = new QuestionViewModel();
            this.DataContext = vm;
        }

        private void nextButton_Click(object sender, RoutedEventArgs e) {
            this.Width = 1100;
            diseasesPanel.Visibility = Visibility.Visible;
            nextButton.Visibility = Visibility.Collapsed;
        }
    }
}
