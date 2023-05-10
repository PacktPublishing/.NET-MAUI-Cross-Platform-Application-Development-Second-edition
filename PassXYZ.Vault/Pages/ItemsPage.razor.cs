using System.Collections.ObjectModel;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using PassXYZ.Vault.Models;
using PassXYZ.Vault.Services;

namespace PassXYZ.Vault.Pages
{
    public partial class ItemsPage : ComponentBase
    {
        public List<Item> Items { get; set; }
        [Inject]
        IDataStore<Item> dataStore { get; set; }
        [Inject]
        ILogger<ItemsPage> logger { get; set; }

        void OnAppearing()
        {
            logger.LogDebug("OnAppearing");
        }

        protected override async Task OnInitializedAsync()
        {
            //await Task.Delay(5000);
            Items = await dataStore.GetItemsAsync(true);
            StateHasChanged();
        }
    }

}