using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatMovieToday.AnswerBase
{
    public static class Answers
    {
        static public Dictionary<string, Dictionary<string, List<string>>> ABCAnswer = new Dictionary<string, Dictionary<string, List<string>>>(StringComparer.OrdinalIgnoreCase);
        static Random rnd = new Random();
        static private List<string> Commands = new List<string> { "!Отвечай " };

        static public string GenerateAnswer(string Question)
        {
            if (ABCAnswer.ContainsKey(Question[0].ToString()))
            {
                if (ABCAnswer[Question[0].ToString()].ContainsKey(Question))
                {
                    int rand = rnd.Next(0, ABCAnswer[Question[0].ToString()][Question].Count);
                    string Answer = ABCAnswer[Question[0].ToString()][Question][rand];
                    return Answer;
                }
                else
                {
                    return "Я не знаю как тебе ответить. Если хочешь чтобы я как-то отвечал на твой вопрос напиши !Отвечай \"текст\"";
                }
            }
            else
            {
                return "Я не знаю как тебе ответить. Если хочешь чтобы я как-то отвечал на твой вопрос напиши !Отвечай \"текст\"";
            }
        }

        static public string ExecuteCommand(string Question, string Command)
        {
            string[] CommandAnswer = Command.Split('"'); 
            if (Commands.Contains(CommandAnswer[0]))
            {
                AnswerBase.WorkerForTxt.Write("\n" + Question + "\\" + CommandAnswer[1] );
                AnswerBase.WorkerForTxt.AddToDictionary(ABCAnswer, Question, CommandAnswer)     
                return "Хорошо, я запомнил";
            }
            else
            {
                return "Я не знаю такой команды";
            }
        }
    }
}
