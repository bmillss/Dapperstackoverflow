using DapperStackOverflow.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DapperStackOverflow.Controllers
{
    public class StackController : Controller
    {
        public IActionResult Index()
        {
            List<questions> quest = DAL.GetAllCategories();
            return View(quest);
        }
        
        public IActionResult Answers()
        {
            return View();
        }
        public IActionResult DeleteQuestion(int questID)
        {
            DAL.DeleteQuestion(questID);
            List<questions> quest = DAL.GetAllCategories();
            return View("Index", quest);
        }
        public IActionResult EditQuestion(questions questID)
        {
            DAL.EditQuestion(questID);
            List<questions> quest = DAL.GetAllCategories();
            return View("Index", quest);
        }
        public IActionResult NewQuestion(questions quest) //add function will not work
        {
            DAL.InsertQuestion(quest);
            return Redirect("");
        }
        public IActionResult Search(string str)
        {
            List<questions> allquestions = DAL.SearchQuestions(str);
            return View(allquestions);
        }


    }
}
