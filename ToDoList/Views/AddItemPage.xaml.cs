using ToDoList.Models;

namespace ToDoList.Views;

public partial class AddItemPage : ContentPage
{
    public AddItemPage()
	{
		InitializeComponent();
	}

    private async void SaveBtn_Clicked(object sender, EventArgs e)
    {
        ListRepository.AddItem(new List()
        {
            id = ListRepository.GetMaxId(),
            title = titleEntry.Text,
            description = descriptionEntry.Text
        });

        await Shell.Current.GoToAsync("..");
    }

    private void CancelBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}