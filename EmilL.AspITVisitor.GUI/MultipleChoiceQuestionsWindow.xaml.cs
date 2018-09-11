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
    /// Interaction logic for MultipleChoiceQuestionsWindow.xaml
    /// </summary>
    public partial class MultipleChoiceQuestionsWindow : Window
    {
        private int currentGuestId;
        private HandlerCollection handlerCollection;
        Questionnaire activeQ;
        IList<MultipleChoiseQuestion> mcQuestions;
        MultipleChoiseAnswer mcAnswer;
        PossibleAnswer chosenAnswer;
        int amountOfQuestions;
        int amountOfAnsweredQuestions;
        public MultipleChoiceQuestionsWindow(int currentGuestId, Questionnaire activeQ)
        {
            InitializeComponent();
            this.activeQ = activeQ;
            this.currentGuestId = currentGuestId;
            handlerCollection = new HandlerCollection();
            mcQuestions = activeQ.MultipleChoiseQuestions.ToList();
            amountOfAnsweredQuestions = 0;
            amountOfQuestions = mcQuestions.Count;
            cboMultiQuestion.ItemsSource = mcQuestions[0].PossibleAnswers;
            lblMultiQuestion.Content = mcQuestions[0].Question;
        }

        private void btnNextMultiQuestion_Click(object sender, RoutedEventArgs e)
        {
            chosenAnswer = cboMultiQuestion.SelectedItem as PossibleAnswer;
            mcAnswer = new MultipleChoiseAnswer()
            {
                Answer = chosenAnswer.Answer,
                PossibleAnswerId = chosenAnswer.Id,
                GuestId = currentGuestId,
                Question = chosenAnswer.MultipleChoiseQuestion.Question
            };
            handlerCollection.AHandler.AddMultiAnswer(mcAnswer);
            amountOfAnsweredQuestions++;
            if (amountOfQuestions == amountOfAnsweredQuestions)
            {
                this.Close();
            }
            else
            {
                lblMultiQuestion.Content = mcQuestions[amountOfAnsweredQuestions].Question;
                cboMultiQuestion.ItemsSource = mcQuestions[amountOfAnsweredQuestions].PossibleAnswers;
            }
        }

        private void btnCancelMultiQuestion_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("ÅH NEJ", "Annuller oprettelse af bruger og besvarelse af spørgsmål?", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {

            }
            else
            {
                handlerCollection.GHandler.RemoveGuest(currentGuestId);
                this.Close();
            }
        }
    }
}
