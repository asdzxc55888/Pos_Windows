using Microsoft.VisualStudio.TestTools.UnitTesting;
using POS_homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_homework.Tests
{
    [TestClass()]
    public class PosCustomerSideModelTests
    {
        PosCustomerSideModel _model;
        bool isNotify = false;

        //初始化測試
        [TestInitialize()]
        public void Initialize()
        {
            _model = new PosCustomerSideModel();
            _model._mealChanged += UpdateMealInformationTest;
        }

        //通知測試
        public void UpdateMealInformationTest()
        {
            isNotify = true;
        }

        //加入刪除餐點測試
        [TestMethod()]
        public void AddDeleteMealTest()
        {
            List<Meal> testMeals = new List<Meal>();
            testMeals.Add(_model.GetCategoryMealList()[0]);
            _model.ClickOrderButton(0);
            _model.ClickAddButton();
            CollectionAssert.AreEqual(_model.GetOrderMealList(), testMeals);
            Assert.AreEqual(89, _model.GetTotalPrice());

            _model.ClickOrderButton(0);
            _model.ClickAddButton();
            _model.SetOrderMealListQuantity(0, 0, 5);
            Assert.AreEqual(_model.GetOrderMealQuantity(0), 2);
            _model.SetOrderMealListQuantity(0, 1, 5);
            Assert.AreEqual(_model.GetOrderMealQuantity(0), 5);
            Assert.AreEqual(445, _model.GetOrderMealSubtotal(0));

            _model.ClickOrderButton(5);
            _model.ClickAddButton();
            testMeals.Add(_model.GetCategoryMealList()[5]);
            CollectionAssert.AreEqual(_model.GetOrderMealList(), testMeals);
            Meal newMeal = new Meal("蛋糕", 39, "好吃", "path", _model.GetCategoryList()[1]);
            _model.SetMealInformation(0, newMeal, 1);
            Assert.AreEqual(newMeal, _model.GetMealList()[0]);
            testMeals.RemoveAt(0);
            _model.DeleteOrderMeal(0, 0);
            CollectionAssert.AreEqual(_model.GetOrderMealList(), testMeals);
            _model.DeleteOrderMeal(-1, 2);
            CollectionAssert.AreEqual(_model.GetOrderMealList(), testMeals);
        }

        [TestMethod()]
        public void DeleteMealListMealTest()
        {
            List<Meal> testMeals = new List<Meal>();
            testMeals = _model.GetMealList();
            testMeals.RemoveAt(0);
            _model.DeleteMealListMeal(0);
            CollectionAssert.AreEqual(_model.GetMealList(), testMeals);
        }

        [TestMethod()]
        public void DeleteCategoryListCategoryTest()
        {
            List<Category> categories = new List<Category>();
            PosCustomerSideModel testModel = new PosCustomerSideModel();
            bool isDeleteCategoryInList = false;
            categories = testModel.GetCategoryList();
            categories.RemoveAt(2);
            _model.DeleteCategoryListCategory(2);
            for (int i = 0; i < categories.Count; i++)
            {
                Assert.AreEqual(categories[i].Name, _model.GetCategoryList()[i].Name);
            }
            foreach (Meal meal in _model.GetMealList())
            {
                if (meal.Category == "飲料")
                {
                    isDeleteCategoryInList = true;
                }
            }
            Assert.IsFalse(isDeleteCategoryInList);
        }

        //測試 SetMealInformation
        [TestMethod()]
        public void SetMealInformationTest()
        {
            Meal newMeal = new Meal("蛋糕", 39, "好吃", "path", _model.GetCategoryList()[1]);
            _model.SetMealInformation(0, newMeal, 1);
            Assert.AreEqual(newMeal, _model.GetMealList()[0]);
            _model.SetMealInformation(-1, newMeal, 1);
            Assert.AreEqual(newMeal, _model.GetMealList()[27]);
        }
    }
}