using Syncfusion.Maui.Popup;

namespace MAUIPopup;

public partial class Suggestion1 : ContentPage
{
    internal Label? PopupLabel { get; set; }
    private SfPopup? Popup;
    public Suggestion1()
    {
        InitializeComponent();
        InitializePopup();
    }

    private void InitializePopup()
    {
        Popup = new SfPopup() { ShowFooter = true };
        PopupLabel = new Label() { Text = "Custom Popup Content" };
        Popup.ContentTemplate = new DataTemplate(() =>
        {
            return PopupLabel;
        });
        Popup.FooterTemplate = new DataTemplate(() =>
        {
            var button = new Button() { Text = "Change Text" };
            button.Clicked += Button_Clicked;
            return button;
        });
    }

    private void Button_Clicked(object? sender, EventArgs e)
    {
        PopupLabel!.Text = "Text Changed";
    }

    private void Show_Popup(object sender, EventArgs e)
    {
        Popup!.Show();
    }
}