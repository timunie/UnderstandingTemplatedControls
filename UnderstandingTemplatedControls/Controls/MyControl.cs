using Avalonia;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Controls;

namespace UnderstandingTemplatedControls.Controls
{
    public class MyControl : TemplatedControl
    {
        string? _FileName;

        /// <summary>
        /// Defines the <see cref="FileName"/> property.
        /// </summary>
        public static readonly DirectProperty<MyControl, string?> FileNameProperty =
            AvaloniaProperty.RegisterDirect<MyControl, string?>(
                nameof(FileName),
                o => o.FileName, 
                (o, v) => o.FileName = v,
                defaultBindingMode: BindingMode.TwoWay,
                enableDataValidation: true);

        /// <summary>
        ///    This is a sample StyledProperty
        /// </summary>
        public string? FileName
        {
            get { return _FileName; }
            set { SetAndRaise(FileNameProperty, ref _FileName, value); }
        }

        protected override void UpdateDataValidation<T>(AvaloniaProperty<T> property, BindingValue<T> value)
        {
            if (property == FileNameProperty)
            {
                DataValidationErrors.SetError(this, value.Error);
            }
        }


    }
}
