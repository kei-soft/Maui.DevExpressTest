﻿using Maui.DevExpressTest.ViewModels;

namespace Maui.DevExpressTest;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		this.BindingContext = new MainViewModel();
	}
}

