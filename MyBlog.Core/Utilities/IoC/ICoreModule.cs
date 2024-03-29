﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace MyBlog.Core.Utilities.IoC
{
	public interface ICoreModule
	{
		void Load(IServiceCollection services);
	}
}
