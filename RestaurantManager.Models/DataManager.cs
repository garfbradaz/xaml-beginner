using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Models
{
    public class DataManager 
    {
        public DataManager()
        {
            this.OrderItems = new ObservableCollection<string>(
                new List<string>
                {
                    "Steak, Chicken, Peas",
                    "Rice, Chicken",
                    "Hummus, Pita"
                }
            );

            this.MenuItems = new ObservableCollection<string>
            {
                "Steak",
                "Chicken",
                "Peas",
                "Rice",
                "Hummus",
                "Pita",
                "Mushy Peas"
            };

            this.CurrentlySelectedMenuItems = new ObservableCollection<string>
            {
                "Rice",
                "Pita"
            };

        }

        public ObservableCollection<string> OrderItems { get; set; }
        public ObservableCollection<string> MenuItems { get; set; }
        public ObservableCollection<string> CurrentlySelectedMenuItems { get; set; }


    }

}

