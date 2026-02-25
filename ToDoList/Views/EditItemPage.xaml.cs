using ToDoList.Models;
using List = ToDoList.Models.List;

namespace ToDoList.Views;

[QueryProperty(nameof(itemId), "Id")]
public partial class EditItemPage : ContentPage
{
	private List item;
	public EditItemPage()
	{
		InitializeComponent();
	}
    public string itemId
    {
        set
        {
            item = ListRepository.GetItemById(int.Parse(value));
            titleEntry.Text = item.title;
            descriptionEntry.Text = item.description;
        }
    }

    private void SaveBtn_Clicked(object sender, EventArgs e)
    {
		item.title = titleEntry.Text;
		item.description = descriptionEntry.Text;

		ListRepository.UpdateItem(item);

        Shell.Current.GoToAsync("..");
    }

    private void CancelBtn_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("..");
    }
}