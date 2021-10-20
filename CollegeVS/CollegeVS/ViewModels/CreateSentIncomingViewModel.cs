using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;
using CollegeVS.Models;
namespace CollegeVS.ViewModels
{
    public class CreateSentIncomingViewModel : BindableObject
    {

        private ObservableCollection<CreateSentIncomingModel> info;
        public ObservableCollection<CreateSentIncomingModel> Info
        {
            get { return info; }
            set
            {

                info = value;
                OnPropertyChanged();
            }

        }



        public CreateSentIncomingViewModel()
        {
            Info = new ObservableCollection<CreateSentIncomingModel>
            {
                new CreateSentIncomingModel()
                {
                    Nothing ="Nothing",
              

                },
                new CreateSentIncomingModel()
                {
                    Nothing ="Empty",
                   
                },
                
                new CreateSentIncomingModel()
                {
                    Nothing ="None",
                  
                }

            };
        }
    }
}
