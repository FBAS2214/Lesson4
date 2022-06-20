using Bogus;
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
using WpfApp1.Models;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public List<Human> People { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;

            People = new Faker<Human>()
                .RuleFor(h=>h.Firstname, f=>f.Person.FirstName)
                .RuleFor(h=>h.Lastname, f=>f.Person.LastName)
                .RuleFor(h=>h.Gender, f=>f.Person.Gender.ToString())
                .RuleFor(h=>h.Phone, f=>f.Person.Phone)
                .RuleFor(h=>h.ImageUrl, f=>f.Person.Avatar)
                .RuleFor(h=>h.Email, f=>f.Person.Email)
                .RuleFor(h=>h.Address, f=>f.Person.Address.City)
                .RuleFor(h=>h.DateOfBirth, f=>f.Person.DateOfBirth)
                .Generate(10);

            // listView.ItemsSource = People;
        }
    }
}
