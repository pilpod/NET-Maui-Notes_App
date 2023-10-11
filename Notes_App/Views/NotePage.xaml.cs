namespace Notes_App.Views;
[QueryProperty(nameof(ItemId), nameof(ItemId))]
public partial class NotePage : ContentPage
{
    public string ItemId { set { LoadNote(value); } }

    public NotePage()
    {
        InitializeComponent();
    }
}