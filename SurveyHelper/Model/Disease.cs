using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SurveyHelper.Model {
    public class Disease : INotifyPropertyChanged {
        string name;
        public string Name {
            get => name;
            set {
                name = value;
                NotifyPropertyChanged();
            }
        }
        bool? hasDisease;
        public bool? HasDisease {
            get => hasDisease;
            set {
                hasDisease = value;
                NotifyPropertyChanged();
            }
        }
        string comment;
        public string Comment {
            get => comment;
            set {
                comment = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
