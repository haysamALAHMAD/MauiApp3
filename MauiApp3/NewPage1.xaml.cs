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
            DisplayAlert("����� ", "������ ���� ������ ������� ", "�����");
        }
        else 
        {
            DisplayAlert("�����","��� �� ����� ������ �����","�����");
        }
    }

    private void close_Clicked(object sender, EventArgs e)
    {
        
    }
}