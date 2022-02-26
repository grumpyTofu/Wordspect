using Microsoft.AspNetCore.Components.WebView.Maui;

using MudBlazor.Services;
using Wordspect.Data;

namespace Wordspect;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.RegisterBlazorMauiWebView()
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddBlazorWebView();
		builder.Services.AddMudServices();

		builder.Services.AddSingleton<WeatherForecastService>();

		return builder.Build();
	}
}
