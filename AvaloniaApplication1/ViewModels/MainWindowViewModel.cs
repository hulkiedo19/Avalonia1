using Avalonia.Controls;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaloniaApplication1.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        /*
        some ideas for solution:
        1 - make public list in viewmodelbase, maybe it can be accessible from this and other classes
        2 - maybe get full list from db, and put it through view model and command classes
        3 - fuck this avalonia and start using default xaml
        */

        //public string Greeting => "Welcome to Avalonia!";

        public List<string> LB_Items = new List<string>()
        {
            "Hello1",
            "Hello2",
            "Hello3",
            "Hello4",
            "Hello5",
            "Hello6",
            "Hello7",
            "Hello8",
            "Hello9",
        };

        public List<string> CB_sort = new List<string>()
        {
            "Less cost",
            "Biggest cost",
            "More materials",
            "Less materials"
        };
        public List<string> CB_filter = new List<string>()
        {
            "With materials",
            "Without materials"
        };


        public List<string> ListBoxItems => LB_Items;
        public List<string> ComboBoxSortItems => CB_sort;
        public List<string> ComboBoxFilterItems => CB_filter;
    }
}
