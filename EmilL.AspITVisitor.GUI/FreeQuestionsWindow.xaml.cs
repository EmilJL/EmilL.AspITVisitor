﻿using System;
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
    /// Interaction logic for FreeQuestionsWindow.xaml
    /// </summary>
    public partial class FreeQuestionsWindow : Window
    {
        HandlerCollection handlerCollection;
        Questionnaire activeQ;
        IList<FreeAnswerQuestion> fQuestions;
        FreeAnswer freeAnswer;
        int currentGuestId;
        int amountOfQuestions;
        int amountOfAnsweredQuestions;
        public FreeQuestionsWindow(int currentGuestId, Questionnaire activeQ)
        {
            InitializeComponent();
            this.activeQ = activeQ;
            this.currentGuestId = currentGuestId;
            handlerCollection = new HandlerCollection();

            fQuestions = activeQ.FreeAnswerQuestions.ToList();
            amountOfQuestions = fQuestions.Count;
            amountOfAnsweredQuestions = 0;
            lblFreeQuestion.Content = fQuestions[amountOfAnsweredQuestions].Question;
        }

        private void btnNextFreeQuestion_Click(object sender, RoutedEventArgs e)
        {

            freeAnswer = new FreeAnswer()
            {
                Answer = txtFreeQuestionAnswer.Text,
                FreeAnswerQuestionId = fQuestions[amountOfAnsweredQuestions].Id,
                GuestId = currentGuestId,
                Question = fQuestions[amountOfAnsweredQuestions].Question
            };
            handlerCollection.AHandler.AddFreeAnswer(freeAnswer);
            amountOfAnsweredQuestions++;
            if (amountOfQuestions == amountOfAnsweredQuestions)
            {
                txtFreeQuestionAnswer.Text = "";
                this.Close();
            }
            else
            {
                lblFreeQuestion.Content = fQuestions[amountOfAnsweredQuestions].Question;
                txtFreeQuestionAnswer.Text = "";
            }
        }

        private void btnCancelFreeQuestion_Click(object sender, RoutedEventArgs e)
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
