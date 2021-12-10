using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace UnderstandingTemplatedControls.Views
{
    public partial class UserControlExample : UserControl
    {
        public UserControlExample()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
