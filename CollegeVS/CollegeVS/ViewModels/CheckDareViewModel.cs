using CollegeVS.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Xamarin.Forms;
using FFImageLoading;

namespace CollegeVS.ViewModels
{
    public class CheckDareViewModel: BindableObject
    {


		private ObservableCollection<CheckDareModel> _dareInfo;
		public ObservableCollection<CheckDareModel> DareInfo
		{
			get { return _dareInfo; }
			set
			{

				_dareInfo = value;

			}

		}
		public CheckDareViewModel()
        {
            DareInfo = new ObservableCollection<CheckDareModel>
            {
                new CheckDareModel()
                {

                    BackgroundColor = "Red",
                    Category ="TransparentParties.png"


                    }

                   };
        }
    }
}
