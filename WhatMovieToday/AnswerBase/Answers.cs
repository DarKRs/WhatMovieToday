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

        static List<string> BotAnswers = new List<string>();
        static List<string> UserQuestions = new List<string>();


        static public string GenerateAnswer(string Question)
        {
            UserQuestions.Add(Question);
            if (ABCAnswer.ContainsKey(Question[0].ToString()))
            {
                if (ABCAnswer[Question[0].ToString()].ContainsKey(Question))
                {
                    int rand = rnd.Next(0, ABCAnswer[Question[0].ToString()][Question].Count);
                    string Answer = ABCAnswer[Question[0].ToString()][Question][rand];
                    BotAnswers.Add(Answer);
                    return "Бот:" + Answer;
                }
                else
                {
                    return "Бот:" + "Я не знаю как тебе ответить. Если хочешь чтобы я как-то отвечал на твой вопрос напиши !Отвечай \"текст\"";
                }
            }
            else
            {
                return "Бот:" +  "Я не знаю как тебе ответить. Если хочешь чтобы я как-то отвечал на твой вопрос напиши !Отвечай \"текст\"";
            }
        }

        static public string ExecuteCommand(string Command)
        {
            string[] CommandAnswer = Command.Split('"');
            switch (CommandAnswer[0])
            {
                case "!Отвечай ":
                    AddAnswer(UserQuestions.Last(), CommandAnswer);
                    return "Бот:" + "Хорошо, я запомнил \n";
                case "!Забудь":
                    DeleteAnswer(UserQuestions.Last(), BotAnswers.Last());
                    return "Бот:" + "Больше не повторится \n";
                default: return "Бот:" + "Я не знаю такой команды \n";
            }
        }

        static private void AddAnswer(string Question, string[] CommandAnswer)
        {
            AnswerBase.WorkerForTxt.Write("\n" + Question + "\\" + CommandAnswer[1]);
            AnswerBase.WorkerForTxt.AddToDictionary(ABCAnswer, Question, CommandAnswer);
        }

        static private void DeleteAnswer(string Question, string BotAnswer)
        {
            AnswerBase.WorkerForTxt.Delete(Question + "\\" + BotAnswer);
        }
    }
}
