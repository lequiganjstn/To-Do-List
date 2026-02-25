using ToDoList.Models;

namespace ToDoList.Views;

public partial class AddItemPage : ContentPage
{
	public AddItemPage()
	{
		InitializeComponent();
	}

    private List item;

    private void SaveBtn_Clicked(object sender, EventArgs e)
    {
        item.title = titleEntry.Text;
        item.description = descriptionEntry.Text;

        ListRepository.AddItem(item);

        Shell.Current.GoToAsync("..");
    }

    private void CancelBtn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}