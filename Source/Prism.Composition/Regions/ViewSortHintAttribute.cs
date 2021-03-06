// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Microsoft.Practices.Prism.Regions
{
    /// <summary>
    /// Provides a hint from a view to a region on how to sort the view.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed class ViewSortHintAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewSortHintAttribute"/> class.
        /// </summary>
        /// <param name="hint">The hint to use for sorting.</param>
        public ViewSortHintAttribute(string hint)
        {            
            this.Hint = hint;
        }

        /// <summary>
        /// Gets  the hint.
        /// </summary>
        /// <value>The hint to use for sorting.</value>
        public string Hint { get; private set; }
    }
}
