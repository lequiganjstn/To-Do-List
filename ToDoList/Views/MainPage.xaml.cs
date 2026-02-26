using System.Collections.ObjectModel;
using System.Threading.Tasks;
using ToDoList.Models;

namespace ToDoList.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        taskSearchBar.Text = String.Empty;

        LoadContacts();
    }

    private async void AddBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AddItemPage));
    }

    private void delete_Clicked(object sender, EventArgs e)
    {
        var menuItem = sender as MenuItem;
        var item = menuItem.CommandParameter as List;

        ListRepository.DeleteItem(item);

        LoadContacts();
    }

    private void taskSearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
        SearchBar searchBar = (SearchBar)sender;
        taskList.ItemsSource = new ObservableCollection<List>(ListRepository.GetSearchResults(searchBar.Text));
    }

    private async void taskList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (taskList.SelectedItem != null)
        {
            await Shell.Current.GoToAsync($"{nameof(EditItemPage)}?Id={((List)taskList.SelectedItem).id}");
        }
    }

    private void taskList_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        taskList.SelectedItem = null;
    }

    private void LoadContacts()
    {
        ObservableCollection<List> items = new ObservableCollection<List>(ListRepository.GetItems());
        taskList.ItemsSource = items;
    }
}