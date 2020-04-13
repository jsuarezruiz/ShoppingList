using System.Collections.ObjectModel;
using ShoppingList.Models;
using ShoppingList.Services;
using Xamarin.Forms;

namespace ShoppingList.ViewModels
{
    public class ShoppingListViewModel : BindableObject
    {
        ObservableCollection<ShoppingItem> _items;

        public ShoppingListViewModel()
        {
            LoadShoppingList();
        }

        public ObservableCollection<ShoppingItem> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                OnPropertyChanged();
            }
        }

        void LoadShoppingList()
        {
            var items = ShoppingService.Instance.GetShoppingList();
            Items = new ObservableCollection<ShoppingItem>(items);
        }
    }
}