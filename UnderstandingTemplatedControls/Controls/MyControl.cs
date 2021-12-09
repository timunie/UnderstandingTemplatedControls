using Avalonia;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingTemplatedControls.Controls
{
    public class MyControl : TemplatedControl
    {


        /// <summary>
        /// Defines the <see cref="FileName"/> property.
        /// </summary>
        public static readonly StyledProperty<string?> FileNameProperty =
            AvaloniaProperty.Register<MyControl, string?>(nameof(FileName), null, defaultBindingMode: BindingMode.TwoWay);

        /// <summary>
        ///    This is a sample StyledProperty
        /// </summary>
        public string? FileName
        {
            get { return GetValue(FileNameProperty); }
            set { SetValue(FileNameProperty, value); }
        }

    }
}
