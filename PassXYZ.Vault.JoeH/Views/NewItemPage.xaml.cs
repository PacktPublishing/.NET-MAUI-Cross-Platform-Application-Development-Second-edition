using PassXYZ.Vault.JoeH.Models;
using PassXYZ.Vault.ViewModels;

namespace PassXYZ.Vault.JoeH.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}