
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;



namespace LABWPF11_12V6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            
            
            // Подписываемся на событие изменения текста в текстовых полях
            TextBox1.TextChanged += TextBox_TextChanged;
            TextBox2.TextChanged += TextBox_TextChanged;
        }
        
         // Обработчик события для кнопки "Открыть"
        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Функция 'Открыть' пока не реализована.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Обработчик события для кнопки "Очистить"
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Clear();
            TextBox2.Clear();
        }

        // Обработчик события для кнопки "Закрыть"
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // Обработчик события для изменения текста в текстовых полях
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Кнопка "Закрыть" доступна только если оба текстовых поля пусты
            CloseButton.IsEnabled = string.IsNullOrWhiteSpace(TextBox1.Text) && string.IsNullOrWhiteSpace(TextBox2.Text);
        }

        // Обработчик события для выпадающего списка
        private void StyleComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (StyleComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                switch (selectedItem.Content.ToString())
                {
                    case "Обычный стиль":
                        ApplyTextStyle(FontWeights.Normal, FontStyles.Normal, Brushes.Black);
                        break;
                    case "Жирный стиль":
                        ApplyTextStyle(FontWeights.Bold, FontStyles.Normal, Brushes.Blue);
                        break;
                    case "Курсив":
                        ApplyTextStyle(FontWeights.Normal, FontStyles.Italic, Brushes.Green);
                        break;
                }
            }
        }

        // Метод для применения стиля к текстовым полям
        private void ApplyTextStyle(FontWeight fontWeight, FontStyle fontStyle, Brush foreground)
        {
            TextBox1.FontWeight = fontWeight;
            TextBox1.FontStyle = fontStyle;
            TextBox1.Foreground = foreground;

            TextBox2.FontWeight = fontWeight;
            TextBox2.FontStyle = fontStyle;
            TextBox2.Foreground = foreground;
        }
    }
}

