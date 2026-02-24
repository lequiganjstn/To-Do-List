using System.Collections.ObjectModel;

namespace ToDoList.Models
{
    public class ListRepository
    {
        public static ObservableCollection<List> _items = new ObservableCollection<List>()
            {
                new List { title = "Learn .NET MAUI", description = "learn more about the MVVM architecture and how to implement it" },
                new List { title = "Learn UX Design", description = "continue the UX Design professional certificate course in Coursera" },
                new List { title = "Workout"},
                new List { title = "Learn Statistics"},
                new List { title = "Check emails"},
                new List { title = "Learn Excel"}
            };

        public static ObservableCollection<List> GetItems() => _items;


    }
}
