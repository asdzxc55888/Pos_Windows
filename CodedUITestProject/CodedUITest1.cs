using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace CodedUITestProject
{
    /// <summary>
    /// CodedUITest1 的摘要說明
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        const string FILE_PATH = @"D:\CSIE資工\C#\POS_homework\POS_homework\bin\Debug\POS_homework.exe";

        /// <summary>
        /// Launches the Calculator
        /// </summary>
        [TestInitialize()]
        public void Initialize()
        {
            Robot.Initialize(FILE_PATH, "StartUp");
        }

        /// <summary>
        /// Closes the launched program
        /// </summary>
        [TestCleanup()]
        public void Cleanup()
        {
            Robot.CleanUp();
        }

        //測試addButton
        [TestMethod]
        public void TestAddButton()
        {
            Robot.SetForm("StartUp");
            Robot.ClickButton("client");
            Robot.SetForm("POS-Customer Side");
            Robot.AssertButtonEnable("addMeal", false);
            Robot.ClickButton("orderButton1");
            Robot.AssertButtonEnable("addMeal", true);
        }

        //測試NextPageButton
        [TestMethod]
        public void TestNextPageButton()
        {
            Robot.SetForm("StartUp");
            Robot.ClickButton("client");
            Robot.SetForm("POS-Customer Side");
            Robot.AssertButtonEnable("nextPage", true);
            Robot.ClickButton("nextPage");
            Robot.AssertButtonEnable("nextPage", false);
        }

        //測試PreviousPageButton
        [TestMethod]
        public void TestPreviousPageButton()
        {
            Robot.SetForm("StartUp");
            Robot.ClickButton("client");
            Robot.SetForm("POS-Customer Side");
            Robot.AssertButtonEnable("previousPage", false);
            Robot.ClickButton("nextPage");
            Robot.AssertButtonEnable("previousPage", true);
        }

        //測試點餐功能
        [TestMethod]
        public void TestAddMeal()
        {
            Robot.SetForm("StartUp");
            Robot.ClickButton("client");
            Robot.SetForm("POS-Customer Side");
            Robot.ClickButton("orderButton1");
            Robot.ClickButton("addMeal");
            Robot.ClickButton("addMeal");
            Robot.AssertText("totalPriceLabel", "Total：178元");
            Robot.ClickButton("nextPage");
            Robot.ClickButton("orderButton2");
            Robot.ClickButton("addMeal");
            Robot.AssertText("totalPriceLabel", "Total：237元");
            Robot.ClickTabControl("甜點");
            Robot.ClickButton("orderButton1");
            Robot.ClickButton("addMeal");
            Robot.AssertText("totalPriceLabel", "Total：286元");
            Robot.DeleteDataGridViewRowByIndex("mealsListDataGridView", "1");
            Robot.AssertText("totalPriceLabel", "Total：108元");
        }

        //測試餐點資訊
        [TestMethod]
        public void TestMealInfotmation()
        {
            Robot.SetForm("StartUp");
            Robot.ClickButton("restaurant");
            Robot.SetForm("PosRestaurantSideForm");
            Robot.ClickListViewByValue("mealListBox", "熱咖啡");
            Robot.AssertButtonEnable("deleteMealButton", true);
            Robot.AssertEdit("mealNameTextBox", "熱咖啡");
        }

        //測試儲存餐點資訊
        [TestMethod]
        public void TestSaveMeal()
        {
            string[] openFileString = { "Resources", "dessert", "Apple-Pie_thumb5.png" };
            Robot.SetForm("StartUp");
            Robot.ClickButton("restaurant");
            Robot.SetForm("PosRestaurantSideForm");
            Robot.ClickListViewByValue("mealListBox", "安格斯黑牛堡");
            Robot.SetEdit("mealNameTextBox", "");
            Robot.AssertButtonEnable("saveMealButton", false);
            Robot.SetEdit("mealNameTextBox", "安格斯黑牛鮑\n");
            Robot.AssertButtonEnable("saveMealButton", true);
            Robot.ClickButton("mealImageBrowseButton");
            Robot.SelectFileByOpenFileDialog("開啟", openFileString);
            Robot.ClickButton("saveMealButton");
        }

        //測試添加餐點
        [TestMethod]
        public void TestMeal()
        {
            string[] openFileString = { "Resources", "dessert", "Apple-Pie_thumb5.png" };
            Robot.SetForm("StartUp");
            Robot.ClickButton("restaurant");
            Robot.SetForm("PosRestaurantSideForm");
            Robot.ClickButton("addMealButton");
            Robot.SetEdit("mealNameTextBox", "蛋餅\n");
            Robot.SetEdit("mealPriceTextBox", "20\n");
            Robot.SetComboBox("mealCategoryComboBox", "甜點");
            Robot.SetEdit("mealDescriptionTextBox", "好吃的蛋餅\n");
            Robot.ClickButton("mealImageBrowseButton");
            Robot.SelectFileByOpenFileDialog("開啟", openFileString);
            Robot.AssertButtonEnable("saveMealButton", true);
            Robot.ClickButton("saveMealButton");
            Robot.ClickListViewByValue("mealListBox", "蛋餅");
            Robot.ClickButton("deleteMealButton");
        }

        //測試添加類別
        [TestMethod]
        public void TestCategory()
        {
            string[] openFileString = { "Resources", "dessert", "Apple-Pie_thumb5.png" };
            Robot.SetForm("StartUp");
            Robot.ClickButton("restaurant");
            Robot.SetForm("PosRestaurantSideForm");
            Robot.ClickTabControl("Category Manager");
            Robot.ClickButton("addCategoryButton");
            Robot.AssertButtonEnable("saveCategoryButton", false);
            Robot.SetEdit("categoryNameTextBox", "玩具\n");
            Robot.AssertButtonEnable("saveCategoryButton", true);
            Robot.ClickButton("saveCategoryButton");
        }

        //測試Save類別
        [TestMethod]
        public void TestSaveCategory()
        {
            string[] openFileString = { "Resources", "dessert", "Apple-Pie_thumb5.png" };
            Robot.SetForm("StartUp");
            Robot.ClickButton("restaurant");
            Robot.SetForm("PosRestaurantSideForm");
            Robot.ClickTabControl("Category Manager");
            Robot.ClickListViewByValue("categoryListBox", "主餐");
            Robot.SetEdit("categoryNameTextBox", "玩具\n");
            Robot.AssertButtonEnable("saveCategoryButton", true);
            Robot.ClickButton("saveCategoryButton");
            Robot.ClickListViewByValue("categoryListBox", "玩具");
            Robot.ClickButton("deleteCategoryButton");
        }

        //測試珊除以點餐點
        [TestMethod]
        public void TestDeleteOrderMeal()
        {
            Robot.SetForm("StartUp");
            Robot.ClickButton("client");
            Robot.SetForm("POS-Customer Side");
            Robot.ClickButton("orderButton1");
            Robot.ClickButton("addMeal");
            Robot.SetForm("StartUp");
            Robot.ClickButton("restaurant");
            Robot.SetForm("PosRestaurantSideForm");
            Robot.ClickListViewByValue("mealListBox", "安格斯黑牛堡");
            Robot.AssertButtonEnable("deleteMealButton", false);
        }
    }
}
