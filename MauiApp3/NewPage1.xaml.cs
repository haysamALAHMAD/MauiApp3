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
            DisplayAlert("����� ", "������ ���� ������ ������� ", "�����");
            txtName.Focus();
        }
        else 
        {
           string strChek = "�� ��� ���� ������";
            if (!check.IsChecked) 
            {
                strChek = $"�� �{strChek.Trim()}";
                    }
            DisplayAlert("�����",$"��� �� ����� ������ �����, {strChek}","�����");
        }
    }
    int count = 0;  
    private void oup_Clicked(object sender, EventArgs e)
    {
        pas.Focus();

        count++;
        
        if(count == 1)

       oup.Text = "���� ���� ������ �������";
else            
        
        
            oup.Text = "��� ���� ���� ������ ���� ��� ";                

    }
}