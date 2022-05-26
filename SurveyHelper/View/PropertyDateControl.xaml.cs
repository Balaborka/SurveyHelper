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

namespace SurveyHelper.View {
    /// <summary>
    /// Interaction logic for PropertyDateControl.xaml
    /// </summary>
    public partial class PropertyDateControl : UserControl {
        public PropertyDateControl() {
            InitializeComponent();
        }
        public string NameProperty {
            get { return (string)GetValue(NamePropertyProperty); }
            set { SetValue(NamePropertyProperty, value); }
        }

        public static readonly DependencyProperty NamePropertyProperty =
            DependencyProperty.Register("NameProperty", typeof(string), typeof(PropertyDateControl), new PropertyMetadata(""));

        public DateTime ValueProperty {
            get { return (DateTime)GetValue(ValuePropertyProperty); }
            set { SetValue(ValuePropertyProperty, value); }
        }

        public static readonly DependencyProperty ValuePropertyProperty =
            DependencyProperty.Register("ValueProperty", typeof(DateTime), typeof(PropertyDateControl), new PropertyMetadata(DateTime.Now));
    }
}
