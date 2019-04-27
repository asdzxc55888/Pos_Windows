using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_homework
{
    public class PosCustomerSideModel
    {
        public event MealChangedEventHandler _mealChanged;
        public delegate void MealChangedEventHandler();
        private Order _orderObject = new Order();
        private List<Meal> _mealsList = new List<Meal>();
        private List<Meal> _categoryMealList = new List<Meal>();
        private List<Category> _categoryList = new List<Category>();
        const char COMMA = ',';
        const string DOLLAR = "元";
        const char NEXT_LINE = '\n';
        const string MONEY = "$";
        const int MEAL_INFORMATION_NAME = 0;
        const int MEAL_INFORMATION_PRICE = 1;
        const int MEAL_INFORMATION_IMAGE_PATH = 2;
        const int MEAL_INFORMATION_CATEGORY = 3;

        public PosCustomerSideModel()
        {
            InitializeCategoryList();
            InitializeMealList();
            SetCategoryMealList(0);
        }

        //初始化餐點清單
        private void InitializeMealList()
        {
            string projectPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            const string MEAL_INTRODUCTION_PATH = "/Resources/MealIntroduction.txt";
            const string MEAL_INFORMATION_PATH = "/Resources/MealInitial.txt";
            const string RESOURCES_PATH = "/Resources/";
            StreamReader mealInitialText = new StreamReader(projectPath + MEAL_INFORMATION_PATH);
            StreamReader mealIntroductionText = new StreamReader(projectPath + MEAL_INTRODUCTION_PATH);
            string[] informationLine = mealInitialText.ReadToEnd().Split(NEXT_LINE);
            for (int i = 0; i < informationLine.Length; i++)
            {
                string[] mealInformation = informationLine[i].Split(COMMA);
                string mealName = mealInformation[MEAL_INFORMATION_NAME];
                int mealPrice = Int32.Parse(mealInformation[MEAL_INFORMATION_PRICE]);
                string mealImagePath = RESOURCES_PATH + mealInformation[MEAL_INFORMATION_IMAGE_PATH];
                Category mealCategory = _categoryList[Int32.Parse(mealInformation[MEAL_INFORMATION_CATEGORY])];
                _mealsList.Add(new Meal(mealName, mealPrice, mealIntroductionText.ReadLine(), mealImagePath, mealCategory));
            }
        }

        //初始化categoryList
        private void InitializeCategoryList()
        {
            const string CATEGORY_NAME = "主餐,甜點,飲料";
            string[] categoryNames = CATEGORY_NAME.Split(COMMA);
            foreach (string categoryName in categoryNames)
            {
                _categoryList.Add(new Category(categoryName));
            }
        }

        //選擇餐點時的動作
        public void ClickOrderButton(int mealIndex)
        {
            _orderObject.SetSelectedMeal(_categoryMealList[mealIndex]);
        }

        //添加餐點
        public void ClickAddButton()
        {
            _orderObject.AddSelectedMeal();
        }

        //刪除已點餐點
        public void DeleteOrderMeal(int rowIndex, int columnIndex)
        {
            if (rowIndex >= 0 && columnIndex == 0)
            {
                _orderObject.RemoveMeal(rowIndex);
            }
        }

        //刪除餐點選單的餐點
        public void DeleteMealListMeal(int mealListIndex)
        {
            _mealsList.RemoveAt(mealListIndex);
            NotifyObserver();
        }

        //刪除類別清單的類別
        public void DeleteCategoryListCategory(int categoryListIndex)
        {
            for (int i = 0; i < _mealsList.Count; i++)
            {
                if (_mealsList[i].Category == _categoryList[categoryListIndex].Name)
                {
                    _mealsList.RemoveAt(i);
                    i = -1;
                }
            }
            _categoryList.RemoveAt(categoryListIndex);
            NotifyObserver();
        }

        //設定要顯示的餐點種類清單
        public void SetCategoryMealList(int categoryIndex)
        {
            Category nowCategory = _categoryList[categoryIndex];
            _categoryMealList.Clear();
            foreach (Meal meal in _mealsList)
            {
                if (meal.Category == nowCategory.Name)
                {
                    _categoryMealList.Add(meal);
                }
            }
        }

        //設定餐點資訊
        public void SetMealInformation(int listIndex, Meal newMeal, int categoryIndex)
        {
            newMeal.Category = _categoryList[categoryIndex].Name;
            if (listIndex == -1)
            {
                _mealsList.Add(newMeal);
            }
            else
            {
                _orderObject.ResetOrderMealsMeal(_mealsList[listIndex], newMeal);
                _mealsList[listIndex] = newMeal;
            }
            NotifyObserver();
        }

        //設定類別清單 -1代表新增
        public void SetCategoryList(int categoryListIndex, Category newCategory)
        {
            if (categoryListIndex == -1)
            {
                _categoryList.Add(newCategory);
            }
            else
            {
                for (int i = 0; i < _mealsList.Count; i++)
                {
                    if (_mealsList[i].Category == _categoryList[categoryListIndex].Name)
                    {
                        _mealsList[i].Category = newCategory.Name;
                    }
                }
                _categoryList[categoryListIndex] = newCategory;
            }
            NotifyObserver();
        }

        //設定餐點數量
        public void SetOrderMealListQuantity(int orderListIndex, int columnIndex, int quantity)
        {
            if (columnIndex == 1)
            {
                _orderObject.SetOrderMealListQuantity(orderListIndex, quantity);
            }
        }

        //取得餐點清單
        public List<Meal> GetMealList()
        {
            return _mealsList;
        }

        //取得以點餐項目
        public List<Meal> GetOrderMealList()
        {
            return _orderObject.orderMealList;
        }

        //取得OrderButton的文字
        public string GetOrderButtonText(int listIndex)
        {
            return _categoryMealList[listIndex].Name + NEXT_LINE + MONEY + _categoryMealList[listIndex].UnitPrice + DOLLAR;
        }

        //取得總價
        public int GetTotalPrice()
        {
            return _orderObject.totalPrice;
        }

        //取得幾種餐點
        public int GetCategoryMealListNumber()
        {
            return _categoryMealList.Count;
        }

        //取得餐點介紹文字
        public string GetCategoryMealIntroductionText(int listIndex)
        {
            return _categoryMealList[listIndex].GetIntroduction();
        }

        //取得圖片路徑
        public string GetCategoryMealImagePath(int listIndex)
        {
            return _categoryMealList[listIndex].GetImagePath();
        }

        //取得該類別的餐點
        public List<Meal> GetCategoryMealList()
        {
            return _categoryMealList;
        }

        //取得類別清單
        public List<Category> GetCategoryList()
        {
            return _categoryList;
        }

        //回傳餐點清單的餐點
        public Meal GetMealListMeal(int listIndex)
        {
            return _mealsList[listIndex];
        }

        //取得餐點數量
        public int GetOrderMealQuantity(int index)
        {
            return _orderObject.GetOrderMealQuantity(index);
        }

        //取得餐點總價
        public int GetOrderMealSubtotal(int index)
        {
            return _orderObject.GetOrderMealSubtotal(index);
        }

        //取得是否有選取餐點
        public bool IsSelectedMeal()
        {
            return _orderObject.IsSelected();
        }

        //判斷餐點是否出現在已點餐點
        public bool IsOrderMealListHaveMeal(int listIndex)
        {
            return _orderObject.IsOrderMealListHaveMeal(_mealsList[listIndex]);
        }

        //判斷類別是否出現在已點餐點
        public bool IsOrderMealListHaveCategory(int listIndex)
        {
            return _orderObject.IsOrderMealListHaveCategory(_categoryList[listIndex]);
        }

        //通知
        void NotifyObserver()
        {
            if (_mealChanged != null)
                _mealChanged();
        }
    }

}
