using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatMovieToday.AnswerBase
{
    class WorkerForTxt
    {
        const string path = "..\\..\\AnswerBase\\answer_databse.txt";
        

        static public void Parse(Dictionary<string, Dictionary<string, List<string>>> ABCAnswer)
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
                AddToDictionary(ABCAnswer, QuestionAnswer);

            }
            fs.Close();
            reader.Close();
            //    }
            /*      catch (Exception ex)
                  {
                      MessageBox.Show(ex.Message,
                      "Все очень плохо", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
                  }*/
        }

        static public void AddToDictionary(Dictionary<string, Dictionary<string, List<string>>> ABCAnswer, string[] QuestionAnswer)
        {
            if (ABCAnswer.ContainsKey(QuestionAnswer[0][0].ToString())) //В словаре уже есть такая буква?
            {
                if (ABCAnswer[QuestionAnswer[0][0].ToString()].ContainsKey(QuestionAnswer[0].ToString()))
                {
                    ABCAnswer[QuestionAnswer[0][0].ToString()][QuestionAnswer[0]].Add(QuestionAnswer[1]);
                }
                else
                {
                    ABCAnswer[QuestionAnswer[0][0].ToString()].Add(QuestionAnswer[0], new List<string>() { QuestionAnswer[1] });
                }
            }
            else
            {
                ABCAnswer.Add(QuestionAnswer[0][0].ToString(), new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase) {
                                {QuestionAnswer[0], new List<string>(){ QuestionAnswer[1] }
                            } });
            }
        }

        static public void AddToDictionary(Dictionary<string, Dictionary<string, List<string>>> ABCAnswer, string Question, string[] CommandAnswer)
        {
            if (ABCAnswer.ContainsKey(Question[0].ToString())) //В словаре уже есть такая буква?
            {
                if (ABCAnswer[Question[0].ToString()].ContainsKey(Question))
                {
                    ABCAnswer[Question[0].ToString()][Question].Add(CommandAnswer[1]);
                }
                else
                {
                    ABCAnswer[Question[0].ToString()].Add(Question, new List<string>() { CommandAnswer[1] });
                }
            }
            else
            {
                ABCAnswer.Add(Question[0].ToString(), new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase) {
                                {Question, new List<string>(){ CommandAnswer[1] }
                            } });
            }
        }

        static public void Write(string QuestionAnswer)
        {
           

            using (FileStream fs = new FileStream(path, FileMode.Append))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.UTF8.GetBytes(QuestionAnswer);
                // запись массива байтов в файл
                fs.Write(array, 0, array.Length);
            }

        }


    }
}
