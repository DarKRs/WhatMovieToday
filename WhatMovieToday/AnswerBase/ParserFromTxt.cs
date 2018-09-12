﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatMovieToday.AnswerBase
{
    class ParserFromTxt
    {
        const string path = "..\\..\\AnswerBase\\answer_databse.txt";
        static public Dictionary<string, Dictionary<string, List<string>>> ABCAnswer = new Dictionary<string, Dictionary<string, List<string>>>();

        static public  void Parse()
        {
        //    try
          //  {
                FileStream fs = new FileStream(path, FileMode.Open);
                StreamReader reader = new StreamReader(fs, System.Text.Encoding.UTF8);

                string file = reader.ReadToEnd();
                string[] All = file.Split('\n');
                for (int i = 0; i < All.Length; i++)
                {
                    string[] QuestionAnswer = All[i].Split('\\');
                    if(ABCAnswer.ContainsKey(QuestionAnswer[0][0].ToString())) //В словаре уже есть такая буква?
                    {
                        if (ABCAnswer[QuestionAnswer[0][0].ToString()].ContainsKey(QuestionAnswer[0].ToString())){
                            ABCAnswer[QuestionAnswer[0][0].ToString()][QuestionAnswer[0]].Add(QuestionAnswer[1]);
                         }
                        else
                        {
                            ABCAnswer[QuestionAnswer[0][0].ToString()].Add(QuestionAnswer[0], new List<string>() { QuestionAnswer[1] });
                        }
                    }
                    else
                    {
                        ABCAnswer.Add(QuestionAnswer[0][0].ToString(), new Dictionary<string, List<string>> {
                                {QuestionAnswer[0], new List<string>(){ QuestionAnswer[1] }
                            } });
                    }

                }
            int a = 0;
        //    }
      /*      catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                "Все очень плохо", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }*/
        }
    }
}