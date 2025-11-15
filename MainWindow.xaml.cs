using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pr_8
{
    public partial class MainWindow : Window
    {
        private List<Warrior> warriors = new List<Warrior>();

        public MainWindow()
        {
            InitializeComponent();
            CreateWarriors();
            DisplayWarriors();
        }

        private void CreateWarriors()
        {
            warriors.Add(new Warrior("Простой воин", 100));
            warriors.Add(new LightArmorWarrior("Лучник", 80));
            warriors.Add(new HeavyArmorWarrior("Рыцарь", 120));
            warriors[0].TakeDamage(30); 
            warriors[1].TakeDamage(30); 
            warriors[2].TakeDamage(30); 
        }

        private void DisplayWarriors()
        {
            foreach (var warrior in warriors)
            {
                warriorsPanel.Children.Add(new Elements.UserControl1(warrior));
            }
        }
    }
}