using ToDoList.ViewModels;

namespace ToDoList.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        taskList.BindingContext = new ToDoViewModel();
	}

    private void taskSearchBar_SearchButtonPressed(object sender, EventArgs e)
    {

    }

    private void taskSearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {

    }
}