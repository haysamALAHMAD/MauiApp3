namespace MauiApp3;

public partial class NewPage1 : ContentPage
{
    public NewPage1()
    {
        InitializeComponent();
    }

    private void check_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {

    }

    private void valider_Clicked(object sender, EventArgs e)
    {
        if (txtName.Text == null && pas.Text == null)
        {
            DisplayAlert(" ‰»ÌÂ ", "«·—Ã«¡ ≈„·ƒ «·ÕﬁÊ· «·”«»ﬁ… ", "„Ê«›ﬁ");
        }
        else 
        {
            DisplayAlert("„»—Êﬂ","·ﬁœ  „  ”ÃÌ· «·œŒÊ· »‰Ã«Õ","„Ê«›ﬁ");
        }
    }

    private void close_Clicked(object sender, EventArgs e)
    {
        
    }
}