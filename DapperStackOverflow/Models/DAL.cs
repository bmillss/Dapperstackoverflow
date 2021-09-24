using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Dapper;

namespace DapperStackOverflow.Models
{
    public class DAL
    {
        public static string CurrentUser = null;
        public static MySqlConnection DB;

        public static List<questions> GetAllCategories()
        {
            return DB.GetAll<questions>().ToList();
        }

        public static questions GetQuestion(string id)
        {
            return DB.Get<questions>(id);
        }

        public static void InsertQuestion(questions quest)
        {
            quest.Posted = DateTime.Now;
            quest.Username = DAL.CurrentUser;
            quest.QuestionsID = quest.ID;
            quest.status = 1;
            DB.Insert(quest);
        }

        public static void EditQuestion(questions quest)
        {

            quest.Username = DAL.CurrentUser;
            quest.QuestionsID = quest.ID;
            DB.Update(quest);
        }

        public static void DeleteQuestion(int questID)
        {
            questions quest = new questions() { ID = questID };
            DB.Delete(quest);
        }

        public static List<questions> SearchQuestions(string str)
        {
            var keyvaluepair = new { search = $"%{str}%" };
            string sql = "select * from questions where detail like @search or Username like @search";
            return DB.Query<questions>(sql, keyvaluepair).ToList();
        }
    }
}
