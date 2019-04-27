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
    public class RestaurantFromPresentationModelTests
    {
        static PosCustomerSideModel _model = new PosCustomerSideModel();
        RestaurantFromPresentationModel _presentationModel = new RestaurantFromPresentationModel(_model);

        //測試 GetMeal
        [TestMethod()]
        public void GetMealTest()
        {
            Meal selectMeal = _presentationModel.GetMeal(1);
            Meal testMeal = _model.GetMealListMeal(1);
            Assert.AreEqual(testMeal, selectMeal);
            selectMeal = _presentationModel.GetMeal(-1);
        }

        //測試 GetMealNameList
        [TestMethod()]
        public void GetMealNameListTest()
        {
            List<string> testMealNames = new List<string>();
            List<Meal> mealList = _model.GetMealList();
            foreach (Meal meal in mealList)
            {
                testMealNames.Add(meal.Name);
            }
            CollectionAssert.AreEqual(testMealNames, _presentationModel.GetMealNameList());
        }

        //測試 GetMealImageRelativePath
        [TestMethod()]
        public void GetMealImageRelativePathTest()
        {
            Assert.AreEqual("/Resources/MainMeals/Angus_thumb.png", _presentationModel.GetMealImageRelativePath("D:\\CSIE資工\\C#\\POS_homework\\POS_homeworkTests/Resources/MainMeals/Angus_thumb.png"));
            Assert.AreEqual("", _presentationModel.GetMealImageRelativePath(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))));
            Assert.AreEqual("", _presentationModel.GetMealImageRelativePath(""));
        }

        //測試 GetCategoryNames
        [TestMethod()]
        public void GetCategoryNamesTest()
        {
            string[] result = { "主餐", "甜點", "飲料" };
            CollectionAssert.AreEqual(result, _presentationModel.GetCategoryNames());
        }

        //測試 GetCategoryIndex
        [TestMethod()]
        public void GetCategoryIndexTest()
        {
            Assert.AreEqual(0, _presentationModel.GetCategoryIndex("主餐"));
            Assert.AreEqual(2, _presentationModel.GetCategoryIndex("飲料"));
            Assert.AreEqual(-1, _presentationModel.GetCategoryIndex("大BANG"));
        }

        //測試 ConvertMealPriceToString
        [TestMethod()]
        public void ConvertMealPriceToStringTest()
        {
            Assert.AreEqual("878", _presentationModel.ConvertMealPriceToString(878));
            Assert.AreEqual("", _presentationModel.ConvertMealPriceToString(0));
        }

        //測試 SaveButtonText
        [TestMethod()]
        public void SaveButtonTextTest()
        {
            _presentationModel.SetSaveButtonText(0, 0);
            Assert.AreEqual("Save", _presentationModel.GetSaveButtonText(0));
            _presentationModel.SetSaveButtonText(0, 1);
            Assert.AreEqual("Save", _presentationModel.GetSaveButtonText(1));
            _presentationModel.SetSaveButtonText(1, 0);
            Assert.AreEqual("Add", _presentationModel.GetSaveButtonText(0));
            _presentationModel.SetSaveButtonText(1, 1);
            Assert.AreEqual("Add", _presentationModel.GetSaveButtonText(1));
        }

        //測試 SelectCategoryMealList
        [TestMethod()]
        public void SelectCategoryMealListTest()
        {
            string[] testResult = { "蘋果派", "蘋果", "蛋捲冰淇淋", "冰炫風", "沙拉", "聖代" };
            _presentationModel.SetSelectCategoryMealList(-1);
            _presentationModel.SetSelectCategoryMealList(1);
            CollectionAssert.AreEqual(testResult, _presentationModel.GetCategoryMealListName());
        }

        //測試 選擇清單時 控制向的狀態
        [TestMethod()]
        public void SelectMealAndCategoryListIndexTest()
        {
            _presentationModel.SetSelectMealListIndex(0);
            Assert.IsTrue(_presentationModel.IsDeleteMealButtonEnabled());
            Assert.IsTrue(_presentationModel.IsSaveMealButtonEnabled("蛋捲冰", "18", "testPath"));
            Assert.IsFalse(_presentationModel.IsSaveMealButtonEnabled("蛋捲冰", "18h", "testPath"));
            Assert.IsFalse(_presentationModel.IsSaveMealButtonEnabled("", "", ""));
            _presentationModel.SetSelectMealListIndex(-1);
            Assert.IsFalse(_presentationModel.IsDeleteMealButtonEnabled());
            Assert.IsFalse(_presentationModel.IsSaveMealButtonEnabled("蛋捲冰", "18", "testPath"));
            Category newCategory = new Category("狗食");
            _presentationModel.SetSelectCategoryListIndex(3);
            _model.SetCategoryList(-1, newCategory);
            Assert.AreEqual(newCategory, _model.GetCategoryList()[3]);
            Assert.IsTrue(_presentationModel.IsDeleteCategoryButtonEnabled());
            Assert.IsTrue(_presentationModel.IsSaveCategoryButtonEnabled("狗食"));
            newCategory = new Category("下午茶");
            _model.SetCategoryList(1, newCategory);
            Assert.AreEqual(newCategory, _model.GetCategoryList()[1]);
            _presentationModel.SetSelectCategoryListIndex(-1);
            Assert.IsFalse(_presentationModel.IsDeleteCategoryButtonEnabled());
            Assert.IsFalse(_presentationModel.IsSaveCategoryButtonEnabled("主餐"));
            Assert.IsFalse(_presentationModel.IsSaveCategoryButtonEnabled(""));
            _model.SetCategoryMealList(1);
            _model.ClickOrderButton(0);
            _model.ClickAddButton();
            _model.SetCategoryMealList(0);
            _model.ClickOrderButton(1);
            _model.ClickAddButton();
            _presentationModel.SetSelectMealListIndex(1);
            Assert.IsFalse(_presentationModel.IsDeleteMealButtonEnabled());
            _presentationModel.SetSelectCategoryListIndex(0);
            Assert.IsFalse(_presentationModel.IsDeleteCategoryButtonEnabled());

        }

        //測試 GetCategoryNameText
        [TestMethod()]
        public void GetCategoryNameTextTest()
        {
            Assert.AreEqual("主餐", _presentationModel.GetCategoryNameText(0));
            Assert.AreEqual("飲料", _presentationModel.GetCategoryNameText(2));
            Assert.AreEqual("", _presentationModel.GetCategoryNameText(-1));
        }
    }
}