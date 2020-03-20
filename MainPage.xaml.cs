using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sign
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btn1.Clicked += Btn1_Clicked;
            btn2.Clicked += Btn2_Clicked;
            
        }

        async private void Btn2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Get());
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
