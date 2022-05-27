using SurveyHelper.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SurveyHelper.Model {
    public class Patient : INotifyPropertyChanged {
        string id;
        public string ID { 
            get => id;
            set {
                id = value; 
                NotifyPropertyChanged(); 
            } 
        }
        string name;
        public string Name {
            get => name;
            set {
                name = value;
                NotifyPropertyChanged();
            }
        }
        string surname;
        public string Surname {
            get => surname;
            set {
                surname = value;
                NotifyPropertyChanged();
            }
        }
        string phone;
        public string Phone {
            get => phone;
            set {
                phone = value;
                NotifyPropertyChanged();
            }
        }
        string address;
        public string Address {
            get => address;
            set {
                address = value;
                NotifyPropertyChanged();
            }
        }
        string mail;
        public string Mail {
            get => mail;
            set {
                mail = value;
                NotifyPropertyChanged();
            }
        }
        DateTime birthday;
        public DateTime Birthday {
            get => birthday;
            set {
                birthday = value;
                NotifyPropertyChanged();
            }
        }
        GenderEnum gender;
        public GenderEnum Gender {
            get => gender;
            set {
                gender = value;
                NotifyPropertyChanged();
            }
        }
        bool isRequiredFieldsSubmitted;
        public bool IsRequiredFieldsSubmitted {
            get => isRequiredFieldsSubmitted;
            set {
                isRequiredFieldsSubmitted = value;
                NotifyPropertyChanged();
            }
        }
        public ObservableCollection<Disease> ListOfDiseases { get; set; }

        public Patient(string id) {
            this.ID = id;
            ListOfDiseases = new ObservableCollection<Disease>();
            ListOfDiseases.Add(new Disease() { Name = "Break", HasDisease = null });
            ListOfDiseases.Add(new Disease() { Name = "COVID-19", HasDisease = null });
            ListOfDiseases.Add(new Disease() { Name = "Monkey Ospa", HasDisease = null });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
