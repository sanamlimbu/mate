﻿using System.Reflection;
using Mate.Application.Common.Behaviors;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Mate.Application;

public static class ServiceExtensions
{
	public static void ConfigureApplication(this IServiceCollection services)
    {
		services.AddAutoMapper(Assembly.GetExecutingAssembly());
		services.AddMediatR(Assembly.GetExecutingAssembly());
		services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
    }
}

