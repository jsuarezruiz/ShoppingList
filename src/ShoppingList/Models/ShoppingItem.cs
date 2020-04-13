using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ShoppingList.Models
{
    public class ShoppingItem : BindableObject
    {
        bool _isDetailVisible;

        public string Name { get; set; }
        public string Icon { get; set; }
        public Color Color { get; set; }

        public bool IsDetailVisible
        {
            get { return _isDetailVisible; }
            set
            {
                Task.Run(async () =>
                {
                    await Task.Delay(value ? 0 : 250);
                    _isDetailVisible = value;
                    OnPropertyChanged();
                });
            }
        }

        public List<ShoppingDetailItem> Items { get; set; }
    }

    public class ShoppingDetailItem
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public bool Done { get; set; }
        public bool IsLatest { get; set; }
    }
}