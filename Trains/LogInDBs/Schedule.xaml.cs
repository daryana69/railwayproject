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
using System.Windows.Shapes;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace LogInDBs
{
    /// <summary>
    /// Interaction logic for Schedule.xaml
    /// </summary>
    public partial class Schedule : Window
    {
        public static class ConfigurationManager { }



        public Schedule()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            LogInDBs.TrainsDataSet trainsDataSet = ((LogInDBs.TrainsDataSet)(this.FindResource("trainsDataSet")));
            // Load data into the table Schedule. You can modify this code as needed.
            LogInDBs.TrainsDataSetTableAdapters.ScheduleTableAdapter trainsDataSetScheduleTableAdapter = new LogInDBs.TrainsDataSetTableAdapters.ScheduleTableAdapter();
            trainsDataSetScheduleTableAdapter.Fill(trainsDataSet.Schedule);
            System.Windows.Data.CollectionViewSource scheduleViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("scheduleViewSource")));
            scheduleViewSource.View.MoveCurrentToFirst();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            SignUpPage su = new SignUpPage();
            su.Show();
            this.Close();
        }

        private void TicketClerk_Click(object sender, RoutedEventArgs e)
        {
            Window1 su = new Window1();
            su.Show();
            this.Close();
        }
    }
}
