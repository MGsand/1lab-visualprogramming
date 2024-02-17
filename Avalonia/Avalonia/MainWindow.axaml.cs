using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using System.Drawing;

namespace ColorfulRectangle
{
    public class MainWindow : Window
    {
        private Rectangle _colorRectangle;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);

            _colorRectangle = this.FindControl<Rectangle>("ColorRectangle");
        }

        private void ChangeColor(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string colorName = button.Content.ToString();

            Color color;
            if (Color.TryParse(colorName, out color))
            {
                _colorRectangle.Fill = new SolidColorBrush(color);
            }
        }
    }
}
