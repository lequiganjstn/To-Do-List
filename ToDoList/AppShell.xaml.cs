using ToDoList.Views;

namespace ToDoList
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(AddItemPage), typeof(AddItemPage));
            Routing.RegisterRoute(nameof(EditItemPage), typeof(EditItemPage));
        }
    }
}
