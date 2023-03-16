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
        txtName.Text.ToLower().Trim();
        if (txtName.Text.Trim() == "" ||  pas.Text.Trim() == "")
        {
            DisplayAlert(" ‰»ÌÂ ", "«·—Ã«¡ ≈„·ƒ «·ÕﬁÊ· «·”«»ﬁ… ", "„Ê«›ﬁ");
            txtName.Focus();
        }
        else 
        {
           string strChek = " „ Õ›Ÿ ﬂ·„… «·„—Ê—";
            if (!check.IsChecked) 
            {
                strChek = $"·„ Ì{strChek.Trim()}";
                    }
            DisplayAlert("„»—Êﬂ",$"·ﬁœ  „  ”ÃÌ· «·œŒÊ· »‰Ã«Õ, {strChek}","„Ê«›ﬁ");
        }
    }
    int count = 0;  
    private void oup_Clicked(object sender, EventArgs e)
    {
        pas.Focus();

        count++;
        
        if(count == 1)

       oup.Text = "≈Õ›Ÿ ﬂ·„… «·„—Ê— «·ÃœÌœ…";
else            
        
        
            oup.Text = "≈–« ‰”Ì  ﬂ·„… «·„—Ê— ≈÷€ÿ Â‰« ";                

    }
}