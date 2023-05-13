using System.Collections.ObjectModel;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.Logging;
using MC = Microsoft.Maui.Controls;
using PassXYZ.Vault.Models;
using PassXYZ.Vault.Services;
using BlazorBindings.Maui;

namespace PassXYZ.Vault.Pages
{
    public partial class ItemsPage : ComponentBase
    {
        [Inject]
        IDataStore<Item> dataStore { get; set; }
        [Inject]
        ILogger<ItemsPage> logger { get; set; }
        public List<Item> Items { get; set; }

        void OnAppearing()
        {
            logger.LogDebug("OnAppearing");
        }

        protected override async Task OnInitializedAsync()
        {
            Items = await dataStore.GetItemsAsync(true);
            StateHasChanged();
        }

    }
}