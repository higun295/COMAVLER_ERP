namespace Maui.DataGrid.Sample;

using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

class Program : MauiApplication
{
    /// <inheritdoc/>
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	static void Main(string[] args)
	{
		var app = new Program();
		app.Run(args);
	}
}
