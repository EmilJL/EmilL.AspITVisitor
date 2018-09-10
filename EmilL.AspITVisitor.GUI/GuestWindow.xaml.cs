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
using EmilL.AspITVisitor.Business;
using EmilL.AspITVisitor.DAL.EF;

namespace EmilL.AspITVisitor.GUI
{
    /// <summary>
    /// Interaction logic for GuestWindow.xaml
    /// </summary>
    public partial class GuestWindow : Window
    {
        public GuestWindow()
        {
            InitializeComponent();
        }

        private void btnSaveGuest_Click(object sender, RoutedEventArgs e)
        {
            QuestionnaireHandler qHandler = new QuestionnaireHandler();
            GuestHandler guestHandler = new GuestHandler();
            Guest guest = new Guest()
            {
                Age = int.Parse(txtAge.Text),
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Commune = txtCommune.Text,
                WishesToBeStudent = cBoxPotentialStudent.IsChecked.Value
                /// I am missing the date of the Inquiry being filled out. My DB is the issue.
            };
            guestHandler.AddGuest(guest);
            var activeQ = qHandler.GetAllQuestionnaires().FirstOrDefault(f => f.Active == true);
            var fQuestions = activeQ.FreeAnswerQuestions;
            //MessageBox.Show($"Du vil nu få præsenteret {}")
        }

        private void btnCancelSavingGuest_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
