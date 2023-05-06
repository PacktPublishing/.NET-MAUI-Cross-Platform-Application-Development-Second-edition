using BlazorBindings.Maui;
using System.Reflection;

namespace PassXYZ.Vault
{
	public class App : BlazorBindingsApplication<AppShell>
	{
		public App(IServiceProvider services) : base(services)
		{
			AddStyles("Resources/Styles/Colors.xaml");
			AddStyles("Resources/Styles/Styles.xaml");
		}

		private void AddStyles(string path)
		{
			var stylesType = typeof(App).Assembly.GetCustomAttributes<XamlResourceIdAttribute>()
				.First(a => a.Path == path)
				.Type;

			var stylesResources = (ResourceDictionary)Activator.CreateInstance(stylesType);

			Resources.Add(stylesResources);
		}
	}
}
