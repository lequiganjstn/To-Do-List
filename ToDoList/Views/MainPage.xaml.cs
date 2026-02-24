using System.Collections.ObjectModel;
using ToDoList.Models;

namespace ToDoList.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

        ObservableCollection<List> items = ListRepository.GetItems();
        taskList.ItemsSource = items;
	}

    private void taskSearchBar_SearchButtonPressed(object sender, EventArgs e)
    {

    }

    private void taskSearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {

    }

    private async void taskList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(EditItemPage)}?Id={((List) taskList.SelectedItem).id}");
    }
}