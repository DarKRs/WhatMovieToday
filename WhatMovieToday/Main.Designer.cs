﻿namespace WhatMovieToday
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.UpperMenu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GenreList = new System.Windows.Forms.RichTextBox();
            this.FilmList = new System.Windows.Forms.RichTextBox();
            this.ChatBox = new System.Windows.Forms.RichTextBox();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стандартныеКомандыБотаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpperMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpperMenu
            // 
            this.UpperMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.UpperMenu.Location = new System.Drawing.Point(0, 0);
            this.UpperMenu.Name = "UpperMenu";
            this.UpperMenu.Size = new System.Drawing.Size(996, 24);
            this.UpperMenu.TabIndex = 0;
            this.UpperMenu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.авторToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // авторToolStripMenuItem
            // 
            this.авторToolStripMenuItem.Name = "авторToolStripMenuItem";
            this.авторToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.авторToolStripMenuItem.Text = "Автор";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChatBox);
            this.panel1.Controls.Add(this.GenreList);
            this.panel1.Controls.Add(this.FilmList);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 331);
            this.panel1.TabIndex = 1;
            // 
            // GenreList
            // 
            this.GenreList.Location = new System.Drawing.Point(3, 3);
            this.GenreList.Name = "GenreList";
            this.GenreList.ReadOnly = true;
            this.GenreList.Size = new System.Drawing.Size(389, 199);
            this.GenreList.TabIndex = 1;
            this.GenreList.Text = "";
            // 
            // FilmList
            // 
            this.FilmList.Location = new System.Drawing.Point(398, 3);
            this.FilmList.Name = "FilmList";
            this.FilmList.ReadOnly = true;
            this.FilmList.Size = new System.Drawing.Size(571, 199);
            this.FilmList.TabIndex = 0;
            this.FilmList.Text = "";
            // 
            // ChatBox
            // 
            this.ChatBox.Location = new System.Drawing.Point(3, 208);
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.Size = new System.Drawing.Size(966, 120);
            this.ChatBox.TabIndex = 2;
            this.ChatBox.Text = "";
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стандартныеКомандыБотаToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // стандартныеКомандыБотаToolStripMenuItem
            // 
            this.стандартныеКомандыБотаToolStripMenuItem.Name = "стандартныеКомандыБотаToolStripMenuItem";
            this.стандартныеКомандыБотаToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.стандартныеКомандыБотаToolStripMenuItem.Text = "Стандартные команды бота";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 370);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UpperMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.UpperMenu;
            this.Name = "Main";
            this.Text = "WhatMovieToday?";
            this.UpperMenu.ResumeLayout(false);
            this.UpperMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip UpperMenu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox GenreList;
        private System.Windows.Forms.RichTextBox FilmList;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стандартныеКомандыБотаToolStripMenuItem;
        private System.Windows.Forms.RichTextBox ChatBox;
    }
}

