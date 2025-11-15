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

namespace pr_8.Elements
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1(Warrior warrior)
        {
            InitializeComponent();

            tbName.Text = warrior.Name;
            tbHealth.Text = $"Здоровье: {warrior.Health}";

            if (warrior is LightArmorWarrior)
                tbArmor.Text = "Тип доспехов: Легкие";
            else if (warrior is HeavyArmorWarrior)
                tbArmor.Text = "Тип доспехов: Тяжелые";
            else
                tbArmor.Text = "Тип доспехов: Нет";
        }
    }
}