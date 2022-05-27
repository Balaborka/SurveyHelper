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
    /// Interaction logic for PropertyDiseaseControl.xaml
    /// </summary>
    public partial class PropertyDiseaseControl : UserControl {
        public PropertyDiseaseControl() {
            InitializeComponent();
        }
        public string NameProperty {
            get { return (string)GetValue(NamePropertyProperty); }
            set { SetValue(NamePropertyProperty, value); }
        }

        public static readonly DependencyProperty NamePropertyProperty =
            DependencyProperty.Register("NameProperty", typeof(string), typeof(PropertyDiseaseControl), new PropertyMetadata(""));

        public string CommentProperty {
            get { return (string)GetValue(CommentPropertyProperty); }
            set { SetValue(CommentPropertyProperty, value); }
        }

        public static readonly DependencyProperty CommentPropertyProperty =
            DependencyProperty.Register("CommentProperty", typeof(string), typeof(PropertyDiseaseControl), new PropertyMetadata(""));

        public bool HasDiseaseProperty {
            get { return (bool)GetValue(HasDiseasePropertyProperty); }
            set { SetValue(HasDiseasePropertyProperty, value); }
        }

        public static readonly DependencyProperty HasDiseasePropertyProperty =
            DependencyProperty.Register("HasDiseaseProperty", typeof(bool), typeof(PropertyDiseaseControl), new PropertyMetadata(false));

    }
}
