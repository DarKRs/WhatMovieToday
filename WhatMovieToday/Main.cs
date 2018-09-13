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
            AnswerBase.ParserFromTxt.Parse();

            ChatBox.Text += "Доброго времени суток. Я бот который поможет вам подобрать фильм. Чтобы начать общение напишите что-либо. \n\n";
        }

        private void ChatBox_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ChatBox.Lines[ChatBox.Lines.Length - 1] == "") { return; }
                //MessageBox.Show("Нажали <ENTER>");
                
                Thread.Sleep(rnd.Next(100,500));
                ChatBox.Text += "\n" + AnswerBase.ParserFromTxt.GenerateAnswer(ChatBox.Lines[ChatBox.Lines.Length-1]) + "\n";
                ChatBox.SelectionStart = ChatBox.Text.Length;
            }
        }
    }
}
