using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WhatMovieToday
{
    public partial class Main : Form
    {
        Random rnd = new Random();
        public Main()
        {
            InitializeComponent();
            AnswerBase.WorkerForTxt.Parse(AnswerBase.Answers.ABCAnswer);

            ChatBox.Text += "Доброго времени суток. Я бот который поможет вам подобрать фильм. Чтобы начать общение напишите что-либо. \n";
        }


        private void Send_Click(object sender, EventArgs e)
        {
            Answer();
        }

        private void SendBox_KeyPress(object sender, KeyEventArgs e)
        {
            if (SendBox.Text == "") { return; }
            if (e.KeyCode == Keys.Enter)
            {
                Answer();
                SendBox.Text = "";
            }
        }


        private void Answer()
        {
            ChatBox.Text += "\n Вы:" + SendBox.Text + "\n";
            if (SendBox.Text[0] == '!')
            {
                ChatBox.Text += "\n" + AnswerBase.Answers.ExecuteCommand(SendBox.Text);
                ChatBox.SelectionStart = ChatBox.Text.Length;
                return;
            }
            Thread.Sleep(rnd.Next(100, 500));
            ChatBox.Text += "\n" + AnswerBase.Answers.GenerateAnswer(SendBox.Text) + "\n";
            ChatBox.SelectionStart = ChatBox.Text.Length;
        }
    }
}
