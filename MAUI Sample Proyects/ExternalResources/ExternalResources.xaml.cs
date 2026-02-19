using System.Text.Json;

namespace MAUI_Sample_Proyects.ExternalResources;

public partial class ExternalResources : ContentPage
{
	public ExternalResources()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await LoadMauiAsset();
    }

    async Task LoadMauiAsset()
    {
        using var stream = await FileSystem.OpenAppPackageFileAsync("data.json");
        using var reader = new StreamReader(stream);

        var contents = reader.ReadToEnd();

        var p = JsonSerializer.Deserialize<Person>(contents);
    }
}

public class Person
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
}