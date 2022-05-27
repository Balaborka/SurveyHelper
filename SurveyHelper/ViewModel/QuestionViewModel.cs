using DevExpress.Mvvm;
using SurveyHelper.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SurveyHelper.ViewModel {
    public class QuestionViewModel {
        public Patient Patient { get; set; }
        public ICommand NextCommand { protected set; get; }
        public QuestionViewModel() {
            Patient = new Patient("0");
            NextCommand = new DelegateCommand(Next, IsRequiredFieldsSubmitted);
        }

        public void Next() {
            MessageBox.Show("Next");
        }
        bool IsRequiredFieldsSubmitted() {
            if (!String.IsNullOrEmpty(Patient.ID) &&
                !String.IsNullOrEmpty(Patient.Name) &&
                !String.IsNullOrEmpty(Patient.Surname) &&
                !String.IsNullOrEmpty(Patient.Phone) &&
                !String.IsNullOrEmpty(Patient.Address) &&
                !String.IsNullOrEmpty(Patient.Mail))
                return true;
            return false;
        }
    }
}
