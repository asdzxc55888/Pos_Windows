using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace POS_homework
{
    public class CustomerFormPresentationModel
    {
        PosCustomerSideModel _model;
        const int VISIBLE_ORDER_BUTTON = 9;
        const int TOTAL_MEALS = 15;
        const string PAGE_TEXT = "Page：";
        const string DIVIDE = " / ";
        const string TOTAL_TEXT = "Total：";
        const string DOLLAR = "元";
        private int _page;
        private int _maxPage;
        public CustomerFormPresentationModel(PosCustomerSideModel model)
        {
            _model = model;
            ResetPage();
        }

        //從設頁面
        public void ResetPage()
        {
            _maxPage = _model.GetCategoryMealListNumber() / VISIBLE_ORDER_BUTTON;
            if (_model.GetCategoryMealListNumber() % VISIBLE_ORDER_BUTTON != 0)
                _maxPage += 1;
            _page = 1;
        }

        //選擇餐點時的動作
        public void ClickOrderButtonHandler(int orderButtonIndex)
        {
            int mealIndex = orderButtonIndex + VISIBLE_ORDER_BUTTON * (_page - 1);
            _model.ClickOrderButton(mealIndex);
        }

        //換頁
        public void ChangePage(int changePageTableIndex)
        {
            const int NEXT_INDEX = 1;
            const int BACK_INDEX = 2;
            if (changePageTableIndex == NEXT_INDEX)
            {
                _page++;
            }
            else if (changePageTableIndex == BACK_INDEX)
            {
                _page--;
            }
        }

        //傳入按鈕的index，回傳mealList的index
        private int GetListIndex(int buttonIndex)
        {
            return buttonIndex + VISIBLE_ORDER_BUTTON * (_page - 1);
        }

        //取得pageLabel的text
        public string GetPageLabelText()
        {
            return PAGE_TEXT + _page + DIVIDE + _maxPage;
        }

        //取得OrderButton的文字
        public string GetOrderButtonText(int buttonIndex)
        {
            int listIndex = GetListIndex(buttonIndex);
            if (IsOrderButtonVisible(buttonIndex))
            {
                return _model.GetOrderButtonText(listIndex);
            }
            else
            {
                return null;
            }
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

        //取得介紹文字
        public string GetMealIntroductionText(int buttonIndex)
        {
            int listIndex = GetListIndex(buttonIndex);
            return _model.GetCategoryMealIntroductionText(listIndex);
        }

        //取得圖片路徑
        public Image GetMealButtonImagePath(int buttonIndex)
        {
            int listIndex = GetListIndex(buttonIndex);
            if (IsOrderButtonVisible(buttonIndex))
            {
                return Image.FromFile(_model.GetCategoryMealImagePath(listIndex));
            }
            else
            {
                return null;
            }
        }

        //取得總價的文字
        public string GetTotalPriceLabelText()
        {
            return TOTAL_TEXT + _model.GetTotalPrice().ToString() + DOLLAR;
        }

        //PreviousPageButton是否可使用
        public bool IsPreviousPageButtonEnabled()
        {
            if (_page == 1)
                return false;
            return true;
        }

        //NextPageButton是否可使用
        public bool IsNextPageButtonEnabled()
        {
            if (_page == _maxPage)
                return false;
            return true;
        }

        //AddButton是否可以使用
        public bool IsAddButtonEnabled()
        {
            return _model.IsSelectedMeal();
        }

        //判斷orderButton是否出現
        public bool IsOrderButtonVisible(int buttonIndex)
        {
            if (GetListIndex(buttonIndex) > _model.GetCategoryMealListNumber() - 1)
                return false;
            else
                return true;
        }
    }
}
