using Microsoft.VisualStudio.TestTools.UnitTesting;
using POS_homework;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_homework.Tests
{
    [TestClass()]
    public class MealTests
    {
        const string INITIAL_NAME = "麥克雞";
        const string INITIAL_INTRODUCTION = "";
        const int INITIAL_PRICE = 59;
        const string INITIAL_IMAGE_PATH = "testPath";
        const string INITIAL_CATEGORY_NAME = "主餐";
        Category _category = new Category(INITIAL_CATEGORY_NAME);
        Meal _meal;
        
        //初始化測試
        [TestInitialize()]
        public void Initialize()
        {
            _meal = new Meal(INITIAL_NAME, INITIAL_PRICE, INITIAL_INTRODUCTION, INITIAL_IMAGE_PATH, null);
        }

        //測試 GetIntroduction
        [TestMethod()]
        public void GetIntroductionTest()
        {
            Assert.AreEqual(_meal.GetIntroduction(), INITIAL_INTRODUCTION);
        }

        //測試GetImagePath
        [TestMethod()]
        public void GetImagePathTest()
        {
            string projectPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            Assert.AreEqual(_meal.GetImagePath(), projectPath + INITIAL_IMAGE_PATH);
        }

        //測試所有屬性
        [TestMethod()]
        public void TestPorperty()
        {
            Assert.AreEqual(_meal.Category, "");
            _meal.Category = _category.Name;
            Assert.AreEqual(_meal.Category, _category.Name);
            _meal.Name = INITIAL_NAME;
            Assert.AreEqual(_meal.Name, INITIAL_NAME);
            _meal.UnitPrice = INITIAL_PRICE;
            Assert.AreEqual(_meal.UnitPrice, INITIAL_PRICE);
        }
    }
}