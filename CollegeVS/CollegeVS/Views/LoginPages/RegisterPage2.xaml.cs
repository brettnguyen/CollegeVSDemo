using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollegeVS.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollegeVS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage2 : ContentPage
    {
        
        public RegisterPage2()
        {
            InitializeComponent();
            Month.Items.Add("January");
            Month.Items.Add("February");
            Month.Items.Add("March");
            Month.Items.Add("April");
            Month.Items.Add("June");
            Month.Items.Add("July");
            Month.Items.Add("August");
            Month.Items.Add("September");
            Month.Items.Add("October");
            Month.Items.Add("November");
            Month.Items.Add("December");

            Day.Items.Add("01");
            Day.Items.Add("02");
            Day.Items.Add("03");
            Day.Items.Add("04");
            Day.Items.Add("05");
            Day.Items.Add("06");
            Day.Items.Add("07");
            Day.Items.Add("08");
            Day.Items.Add("09");
            Day.Items.Add("10");
            Day.Items.Add("11");
            Day.Items.Add("12");
            Day.Items.Add("13");
            Day.Items.Add("14");
            Day.Items.Add("15");
            Day.Items.Add("16");
            Day.Items.Add("17");
            Day.Items.Add("18");
            Day.Items.Add("19");
            Day.Items.Add("20");
            Day.Items.Add("21");
            Day.Items.Add("22");
            Day.Items.Add("23");
            Day.Items.Add("24");
            Day.Items.Add("25");
            Day.Items.Add("26");
            Day.Items.Add("27");
            Day.Items.Add("28");
            Day.Items.Add("29");
            Day.Items.Add("30");
            Day.Items.Add("31");

            Year.Items.Add("2021");
            Year.Items.Add("2020");
            Year.Items.Add("2019");
            Year.Items.Add("2018");
            Year.Items.Add("2017");
            Year.Items.Add("2016");
            Year.Items.Add("2015");
            Year.Items.Add("2014");
            Year.Items.Add("2013");
            Year.Items.Add("2012");
            Year.Items.Add("2011");
            Year.Items.Add("2010");
            Year.Items.Add("2009");
            Year.Items.Add("2008");
            Year.Items.Add("2007");
            Year.Items.Add("2006");
            Year.Items.Add("2005");
            Year.Items.Add("2004");
            Year.Items.Add("2003");
            Year.Items.Add("2002");
            Year.Items.Add("2001");
            Year.Items.Add("2000");
            Year.Items.Add("1999");
            Year.Items.Add("1998");
            Year.Items.Add("1997");
            Year.Items.Add("1996");
            Year.Items.Add("1995");
            Year.Items.Add("1994");
            Year.Items.Add("1993");
            Year.Items.Add("1992");
            Year.Items.Add("1991");
            Year.Items.Add("1990");
            Year.Items.Add("1989");
            Year.Items.Add("1988");
            Year.Items.Add("1987");
            Year.Items.Add("1986");
            Year.Items.Add("1985");
            Year.Items.Add("1984");
            Year.Items.Add("1983");
            Year.Items.Add("1982");
            Year.Items.Add("1981");
            Year.Items.Add("1980");
            Year.Items.Add("1979");
            Year.Items.Add("1978");
            Year.Items.Add("1977");
            Year.Items.Add("1976");
            Year.Items.Add("1975");
            Year.Items.Add("1974");
            Year.Items.Add("1973");
            Year.Items.Add("1972");
            Year.Items.Add("1971");
            Year.Items.Add("1970");
            Year.Items.Add("1969");
            Year.Items.Add("1968");
            Year.Items.Add("1967");
            Year.Items.Add("1966");
            Year.Items.Add("1965");
            Year.Items.Add("1964");
            Year.Items.Add("1963");
            Year.Items.Add("1962");
            Year.Items.Add("1961");
            Year.Items.Add("1960");
            Year.Items.Add("1959");
            Year.Items.Add("1958");
            Year.Items.Add("1957");
            Year.Items.Add("1956");
            Year.Items.Add("1955");
            Year.Items.Add("1954");
            Year.Items.Add("1953");
            Year.Items.Add("1952");
            Year.Items.Add("1951");
            Year.Items.Add("1950");






        }
       async void BackArrow_Tapped(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}