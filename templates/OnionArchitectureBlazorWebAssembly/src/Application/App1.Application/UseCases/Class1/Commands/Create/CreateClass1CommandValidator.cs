﻿namespace App1.Application.UseCases.Class1.Commands.Create;

using FluentValidation;
using Interfaces.Repositories;

public class CreateClass1CommandValidator : AbstractValidator<CreateClass1Command>
{
	private readonly IClass1Repository class1Repository;

	public CreateClass1CommandValidator(IClass1Repository class1Repository)
	{
		this.class1Repository = class1Repository;

		ConfigureValidation();
	}

	private void ConfigureValidation()
	{
		RuleFor(x => x.Title)
			.NotEmpty()
			.MustAsync(async (command, name, ctx, cancellationToken) =>
			{
				var isExist = await class1Repository.IsExist(name, cancellationToken);

				if (!isExist)
				{
					return true;
				}

				ctx.AddFailure(nameof(command.Title), $"Class1 with Title:'{command.Title}' already exist");
				return false;
			});
	}
}