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
        private HandlerCollection handlerCollection;
        private Questionnaire activeQ;
        public GuestWindow()
        {
            InitializeComponent();
            handlerCollection = new HandlerCollection();
            activeQ = handlerCollection.QHandler.GetAllQuestionnaires().FirstOrDefault(f => f.Active == true);
        }

        private void btnSaveGuest_Click(object sender, RoutedEventArgs e)
        {
            //QuestionnaireHandler qHandler = new QuestionnaireHandler();
            //GuestHandler guestHandler = new GuestHandler();
            Guest guest = new Guest()
            {
                Age = int.Parse(txtAge.Text),
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Commune = txtCommune.Text,
                WishesToBeStudent = cBoxPotentialStudent.IsChecked.Value
                /// I am missing the date of the Inquiry being filled out. My DB is the issue.
            };
            /// Måske får guest et ID her?
            handlerCollection.GHandler.AddGuest(guest);
            var activeQ = handlerCollection.QHandler.GetAllQuestionnaires().FirstOrDefault(f => f.Active == true);
            var fQuestions = activeQ.FreeAnswerQuestions;
            var mQuestions = activeQ.MultipleChoiseQuestions;

            MessageBox.Show($"Du vil nu få præsenteret {fQuestions.Count} spørgsmål, der besvares med et tekstsvar. Derefter vil du få præsenteret {mQuestions.Count} multiple-choice spørgsmål.");
            FreeQuestionsWindow fQWindow = new FreeQuestionsWindow(guest.Id, activeQ);
            fQWindow.ShowDialog();
            MultipleChoiceQuestionsWindow mcQWindow = new MultipleChoiceQuestionsWindow(guest.Id, activeQ);
            mcQWindow.ShowDialog();
            MessageBox.Show("Det lykkedes dig at svare på alle spørgsmålene. Wow.");
        }

        private void btnCancelSavingGuest_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
