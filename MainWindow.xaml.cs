using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CinemaGridApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CreateSeatingPlan();
        }

        private void CreateSeatingPlan()
        {
            for (int i = 0; i < 100; i++)
            {
                Button button = new Button
                {
                    Background = Brushes.Red,
                    Width = 30,
                    Height = 15
                };

                button.Click += (sender, e) =>
                {
                    Button clickedButton = (Button)sender;
                    if (clickedButton.Background == Brushes.Red)
                    {
                        clickedButton.Background = Brushes.Green;
                    }
                    else
                    {
                        clickedButton.Background = Brushes.Red;
                    }
                };

                SeatingPlanGrid.Children.Add(button);
            }
        }
    }
}
