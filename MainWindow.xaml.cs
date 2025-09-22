using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfIndecisionApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string input = OptionInput.Text.Trim();

            if (!string.IsNullOrEmpty(input))
            {
                ChoicesList.Items.Add(input);
                OptionInput.Clear();
            }
            else
            {
                MessageBox.Show("You need to enter a value before adding.");
            }
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (ChoicesList.SelectedItem != null)
            {
                ChoicesList.Items.Remove(ChoicesList.SelectedItem);
            }
            else
            {
                MessageBox.Show("You need to select an item to remove.");
            }
        }

        private void DecideButton_Click(object sender, RoutedEventArgs e)
        {
            if (ChoicesList.Items.Count > 0)
            {
                int index = random.Next(ChoicesList.Items.Count);
                string choice = (string)ChoicesList.Items[index];

                MessageBox.Show($"The chosen option is: {choice}", "Decision");
            }
            else
            {
                MessageBox.Show("No choices available to decide from.");
            }
        }
    }
}