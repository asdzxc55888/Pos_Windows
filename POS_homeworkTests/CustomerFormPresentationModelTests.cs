using Microsoft.VisualStudio.TestTools.UnitTesting;
using POS_homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace POS_homework.Tests
{
    [TestClass()]
    public class CustomerFormPresentationModelTests
    {
        static PosCustomerSideModel _model = new PosCustomerSideModel();
        CustomerFormPresentationModel _presentationModel = new CustomerFormPresentationModel(_model);
        //測試換業時的動作
        [TestMethod()]
        public void PageChangeTest()
        {
            _presentationModel.ResetPage();
            Assert.AreEqual("Total：0元", _presentationModel.GetTotalPriceLabelText());
            Assert.IsTrue(_presentationModel.IsNextPageButtonEnabled());
            Assert.IsFalse(_presentationModel.IsPreviousPageButtonEnabled());
            Assert.AreEqual("Page：1 / 2", _presentationModel.GetPageLabelText());
            Assert.AreEqual("麥香魚\n$49元", _presentationModel.GetOrderButtonText(8));
            Assert.AreEqual("安格斯黑牛堡，大家都愛吃。", _presentationModel.GetMealIntroductionText(0));
            Assert.IsTrue(_presentationModel.IsOrderButtonVisible(8));
            _presentationModel.ChangePage(1);
            Assert.IsFalse(_presentationModel.IsNextPageButtonEnabled());
            Assert.IsTrue(_presentationModel.IsPreviousPageButtonEnabled());
            Assert.AreEqual("Page：2 / 2", _presentationModel.GetPageLabelText());
            Assert.AreEqual(null, _presentationModel.GetOrderButtonText(8));
            Assert.IsFalse(_presentationModel.IsOrderButtonVisible(8));
            _presentationModel.GetMealButtonImagePath(0);
            _presentationModel.GetMealButtonImagePath(8);
            _presentationModel.ChangePage(2);
            Assert.AreEqual("Page：1 / 2", _presentationModel.GetPageLabelText());
        }

        //測試 ClickOrderButtonHandler
        [TestMethod()]
        public void ClickOrderButtonHandlerTest()
        {
            Assert.IsFalse(_presentationModel.IsAddButtonEnabled());
            _presentationModel.ClickOrderButtonHandler(2);
            Assert.IsTrue(_presentationModel.IsAddButtonEnabled());
        }

        //測試 GetCategoryNames
        [TestMethod()]
        public void GetCategoryNamesTest()
        {
            string[] testResult = { "主餐", "甜點", "飲料" };
            CollectionAssert.AreEqual(testResult, _presentationModel.GetCategoryNames());
        }
    }
}