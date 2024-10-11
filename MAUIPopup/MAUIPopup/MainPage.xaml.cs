using Syncfusion.Maui.Popup;
using System.ComponentModel;

namespace MAUIPopup
{
    public partial class MainPage : ContentPage
    {      
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Suggestion1());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new Suggetion2());
        }
    }
}
