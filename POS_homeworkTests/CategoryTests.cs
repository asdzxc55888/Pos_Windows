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
    public class CategoryTests
    {
        const string INITIAL_NAME = "主餐";
        Category _category;
        //初始化測試
        [TestInitialize()]
        public void Initialize()
        {
            _category = new Category(INITIAL_NAME);
        }

        //測試所有屬性
        [TestMethod()]
        public void TestPorperty()
        {
            const string TEST_NAME = "TEST";
            _category.Name = TEST_NAME;
            Assert.AreEqual(_category.Name, TEST_NAME);
        }
    }
}