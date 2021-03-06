﻿namespace Boilerplate.AspNetCore.Razor
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc.Razor;

    /// <summary>
    /// Specifies the contracts for a view location expander that is used by <see cref="RazorViewEngine"/> instances to
    /// determine search paths for a view using the .min.cshtml file extension.
    /// </summary>
    /// <seealso cref="IViewLocationExpander" />
    public class MinifiedViewLocationExpander : IViewLocationExpander
    {
        private const string MinifiedViewExtension = ".min.cshtml";

        private static readonly IEnumerable<string> ViewLocationFormats = new[]
        {
            "/Views/{1}/{0}" + MinifiedViewExtension,
            "/Views/Shared/{0}" + MinifiedViewExtension,
        };

        /// <inheritdoc/>
        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (viewLocations == null)
            {
                throw new ArgumentNullException(nameof(viewLocations));
            }

            return ViewLocationFormats;
        }

        /// <inheritdoc/>
        public void PopulateValues(ViewLocationExpanderContext context)
        {
        }
    }
}
