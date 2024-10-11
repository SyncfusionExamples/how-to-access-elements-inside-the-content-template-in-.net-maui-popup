
namespace MAUIPopup;

public partial class Suggetion2 : ContentPage
{
    private Entry? entry;
    private Entry? entry1;
    public Suggetion2()
    {
        InitializeComponent();
    }

    private void ClickToShowPopup_Clicked(object sender, EventArgs e)
    {
        popup.Show();
    }

    private void StackLayout_ChildAdded(object sender, ElementEventArgs e)
    {
        if (e.Element is Entry)
        {
            var child = (Entry)e.Element;
            if (child != null && child.StyleId == "Entry")
            {
                entry = child;
            }
            else if (child != null && child.StyleId == "Entry1")
            {
                entry1 = child;
            }
        }
    }  

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (entry1!.Text == entry!.Text)
        {
            DisplayAlert("Status", "Login Successfully", "Ok");            
        }
        else
        {
            DisplayAlert("Status", "Login Failed", "Ok");
        }
        entry.Text = string.Empty;
        entry1.Text = string.Empty;
    }
}