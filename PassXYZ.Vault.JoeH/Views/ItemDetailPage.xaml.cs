using PassXYZ.Vault.ViewModels;

namespace PassXYZ.Vault.JoeH.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}