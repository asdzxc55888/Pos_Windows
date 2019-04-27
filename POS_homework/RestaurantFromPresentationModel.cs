using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace POS_homework
{
    public class RestaurantFromPresentationModel
    {
        const string PROGRAM_NAME = "\\POS_homework";
        const string ADD = "Add";
        const string SAVE = "Save";
        const string SLASH = "/";
        string _saveMealButtonText = SAVE;
        string _saveCategoryButtonText = SAVE;
        int _selectMealListIndex = 0;
        int _selectCategoryListIndex = 0;
        List<Meal> _categoryMealList; 
        PosCustomerSideModel _model;
        public RestaurantFromPresentationModel (PosCustomerSideModel model)
        {
            _model = model;
        }

        //取得meal
        public Meal GetMeal(int listIndex)
        {
            if (listIndex < 0)
            {
                return new Meal("", 0, "", "", null);
            }
            return _model.GetMealListMeal(listIndex);
        }

        //取得mealList的Name
        public List<string> GetMealNameList()
        {
            List<Meal> mealList = _model.GetMealList();
            List<string> mealNameList = new List<string>();
            foreach (Meal meal in mealList)
            {
                mealNameList.Add(meal.Name);
            }
            return mealNameList;
        }

        //取得相對路徑
        public string GetMealImageRelativePath(string imagePath)
        {
            if (imagePath == Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) || imagePath == "")
            {
                return "";
            }
            string projectPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + PROGRAM_NAME;
            Uri baseUri = new Uri(projectPath);
            Uri targetUri = new Uri(imagePath);
            return SLASH + baseUri.MakeRelativeUri(targetUri).ToString();
        }

        //取得所有類別的名稱
        public string[] GetCategoryNames()
        {
            string[] result = new string[_model.GetCategoryList().Count];
            int count = 0;
            foreach (Category category in _model.GetCategoryList())
            {
                result[count++] = category.Name;
            }
            return result;
        }

        //取得categoty在categoryList的index
        public int GetCategoryIndex(string mealCategory)
        {
            int index = 0;
            foreach (Category category in _model.GetCategoryList())
            {
                if (mealCategory == category.Name)
                {
                    return index;
                }
                index ++;
            }
            return -1;
        }

        //取得該類別餐點清單的所有名稱
        public string[] GetCategoryMealListName()
        {
            string[] result = new string[_categoryMealList.Count];
            int count = 0;
            foreach (Meal meal in _categoryMealList)
            {
                result[count++] = meal.Name;
            }
            return result;
        }

        //取得SaveButton文字
        public string GetSaveButtonText(int tabPageIndex)
        {
            if (tabPageIndex == 0)
            {
                return _saveMealButtonText;
            }
            else
            {
                return _saveCategoryButtonText;
            }
        }

        //取得類別名稱的文字
        public string GetCategoryNameText(int categoryListIndex)
        {
            if (categoryListIndex == -1)
            {
                return "";
            }
            return _model.GetCategoryList()[categoryListIndex].Name;
        }

        //轉換餐點價錢成字串
        public string ConvertMealPriceToString(int price)
        {
            if (price == 0)
            {
                return "";
            }
            return price.ToString();
        }

        //設定SaveMealButton文字
        public void SetSaveButtonText(int state, int tabPageIndex)
        {
            string stateString;
            if (state == 0)
            {
                stateString = SAVE;
            } else
            {
                stateString = ADD;
            }
            if (tabPageIndex == 0)
            {
                _saveMealButtonText = stateString;
                
            } else if (tabPageIndex == 1)
            {
                _saveCategoryButtonText = stateString;
            }
        }

        //設定所選擇的類別所包含的餐點
        public void SetSelectCategoryMealList(int categoryIndex)
        {
            _categoryMealList = new List<Meal>();
            if (categoryIndex == -1)
            {
                return;
            }
            List<Category> categoryList = _model.GetCategoryList();
            foreach (Meal meal in _model.GetMealList())
            {
                if (meal.Category == categoryList[categoryIndex].Name)
                {
                    _categoryMealList.Add(meal);
                }
            }
        }

        //設定選擇的餐點索引
        public void SetSelectMealListIndex(int mealListIndex)
        {
            _selectMealListIndex = mealListIndex;
        }

        //設定選擇的餐點索引
        public void SetSelectCategoryListIndex(int categoryListIndex)
        {
            _selectCategoryListIndex = categoryListIndex;
        }

        //saveMealButton是否啟用
        public bool IsSaveMealButtonEnabled(string nameString, string priceString, string imagePathString)
        {
            if (nameString != "" && priceString != "" && imagePathString != "" && !(_selectMealListIndex == -1 && _saveMealButtonText == SAVE))
            {
                if (!IsNumeric(priceString))
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        //saveCategoryButton是否啟用
        public bool IsSaveCategoryButtonEnabled(string nameString)
        {
            if (nameString != "" && !(_selectCategoryListIndex == -1 && _saveCategoryButtonText == SAVE))
            {
                return true;
            }
            return false;
        }

        //deleteButton是否啟用
        public bool IsDeleteCategoryButtonEnabled()
        {
            if (_selectCategoryListIndex == -1 || _model.IsOrderMealListHaveCategory(_selectCategoryListIndex))
            {
                return false;
            }
            return true;
        }

        //deleteButton是否啟用
        public bool IsDeleteMealButtonEnabled()
        {
            if (_selectMealListIndex == -1 || _model.IsOrderMealListHaveMeal(_selectMealListIndex))
            {
                return false;
            }
            return true;
        }

        //判斷傳入字串是否為數字
        public bool IsNumeric(String strNumber)
        {
            Regex NumberPattern = new Regex("[^0-9.-]");
            return !NumberPattern.IsMatch(strNumber);
        }
    }
}
