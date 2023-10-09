﻿namespace App1.Infrastructure.Business;

using App1.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
	public static void AddInfrastructureBusiness(this IServiceCollection services)
	{
		services.AddScoped<IServiceInterface1, ServiceClass1>();
	}
}