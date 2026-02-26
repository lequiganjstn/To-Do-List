using System.Collections.ObjectModel;

namespace ToDoList.Models
{
    public static class ListRepository
    {
        public static ObservableCollection<List> _items = new ObservableCollection<List>()
            {
                new List { id = 1, title = "Learn .NET MAUI", description = "learn more about the MVVM architecture and how to implement it" },
                new List { id = 2, title = "Learn UX Design", description = "continue the UX Design professional certificate course in Coursera" },
                new List { id = 3, title = "Workout", description = "Lower day" },
                new List { id = 4, title = "Learn Statistics", description = "practice formulas such as percentile, quartile, IQR" },
                new List { id = 5, title = "Check Gmail", description = "check for emails for any activities/announcements" },
                new List { id = 6, title = "Learn Excel", description = "practice Excel formulas for Statistics"}
            };

        public static ObservableCollection<List> GetItems() => _items;
        
        public static List GetItemById(int itemId)
        {
            return _items.FirstOrDefault(x => x.id == itemId);
        }

        public static void UpdateItem(List item)
        {
            List itemToUpdate = GetItemById(item.id);

            //itemToUpdate.title = item.title;
            //itemToUpdate.description = item.description;

            int index = _items.IndexOf(itemToUpdate);

            _items[index] = item;
        }

        public static int GetMaxId()
        {
           return _items.Max(x => x.id) + 1;
        }

        public static void AddItem(List item)
        {
            int maxId = GetMaxId();

            List newItem = new List()
            {
                id = maxId,
                title = item.title,
                description = item.description
            };

            _items.Add(newItem);
        }

        public static List<List> GetSearchResults(String query)
        {
            return _items.Where(x => x.title.Contains(query, StringComparison.OrdinalIgnoreCase))?.ToList();
        }
    }
}
