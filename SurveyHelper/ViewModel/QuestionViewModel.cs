using DevExpress.Mvvm;
using SurveyHelper.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SurveyHelper.ViewModel {
    public class QuestionViewModel {
        public Patient Patient { get; set; }
        public ICommand NextCommand { protected set; get; }
        public ICommand SubmitCommand { protected set; get; }
        public QuestionViewModel() {
            Patient = new Patient("0");
            NextCommand = new DelegateCommand(Next, IsRequiredFieldsSubmitted);
            SubmitCommand = new DelegateCommand(Submit, IsRequiredFieldsSubmitted);
        }

        public void Next() {
            //MessageBox.Show("Next");
        }
        public void Submit() {
            string fileName = "Patient1.json";
            string jsonString = JsonSerializer.Serialize(Patient);
            File.WriteAllText(fileName, jsonString);
            
            MessageBox.Show("Thank you for your answers. You can find the results of the survey in the Patient1.json file next to the application");
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
