public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
{
	

	loggerFactory.AddConsole(Configuration.GetSection());
	loggerFactory.AddDebug();
	
	if(env.is Development)
	{
		app.UseBrowserLink();
		app.UseDeveloperExceptionPage();
		app.UseDatabaseErrorPage();
	}
	else
	{
		app.UseExceptionHandler("/Home/Error");
	}

	app.UseIISPlatformHandler(options=>options.AuthenticationOptions.Clear());

	app.UseStaticFiles();

	app.UseIdentity();

	// To Configure external authentication 

	app.UseMvc
	(
		routes=>
		{
			routes.MapRoute
			(
				name: 		"default",
				template :  "{controller=Home}/{action=Index}/{id?}"
			);
		}
	);
}