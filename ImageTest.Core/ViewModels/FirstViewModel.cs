using Cirrious.MvvmCross.ViewModels;
using System.Collections.Generic;

namespace ImageTest.Core.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
        public IList<ListItem> Data { get; set; }

        public FirstViewModel()
        {
            Data = new List<ListItem>()
                {
                    new ListItem() { Title = "Test01", Type = "1" },
                    new ListItem() { Title = "Test02", Type = "2" },
                    new ListItem() { Title = "Test03", Type = "1" },
                    new ListItem() { Title = "Test04", Type = "2" },
                    new ListItem() { Title = "Test05", Type = "1" },
                    new ListItem() { Title = "Test06", Type = "2" },
                    new ListItem() { Title = "Test07", Type = "1" },
                    new ListItem() { Title = "Test08", Type = "2" },
                    new ListItem() { Title = "Test09", Type = "1" },
                    new ListItem() { Title = "Test10", Type = "2" },
                    new ListItem() { Title = "Test11", Type = "1" },
                    new ListItem() { Title = "Test12", Type = "2" },
                    new ListItem() { Title = "Test13", Type = "1" },
                    new ListItem() { Title = "Test14", Type = "2" },
                    new ListItem() { Title = "Test15", Type = "1" },
                    new ListItem() { Title = "Test16", Type = "2" },
                    new ListItem() { Title = "Test17", Type = "1" },
                };
        }
    }
}
