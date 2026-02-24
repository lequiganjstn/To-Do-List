using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using List = ToDoList.Models.List;

namespace ToDoList.ViewModels
{
    public class ToDoViewModel
    {
        public ObservableCollection<List> Items { get; set; }

        public ToDoViewModel()
        {
            Items = new ObservableCollection<List>
            {
                new List { title = "Learn .NET MAUI", description = "learn more about the MVVM architecture and how to implement it" },
                new List { title = "Learn UX Design", description = "continue the UX Design professional certificate course in Coursera" }
            };
        }
    }
}
