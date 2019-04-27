using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_homework
{
    class Order
    {
        private Meal _selectedMeal;
        private List<Meal> _orderMealList = new List<Meal>();
        private List<int> _orderMealQuantity = new List<int>();
        private List<int> _orderMealSubtotal = new List<int>();
        private int _totalPrice;

        //設定當前選擇的餐點
        public void SetSelectedMeal(Meal selectedMeal)
        {
            _selectedMeal = selectedMeal;
        }

        //添加餐點
        public void AddSelectedMeal()
        {
            int count = 0;
            for (count = 0; count < _orderMealList.Count; count++)
            {
                if (_selectedMeal == _orderMealList[count])
                {
                    _orderMealQuantity[count] += 1;
                    break;
                }
            }
            if (count == _orderMealList.Count)
            {
                _orderMealList.Add(_selectedMeal);
                _orderMealQuantity.Add(1);
                _orderMealSubtotal.Add(0);
            }
        }

        //移除餐點
        public void RemoveMeal(int index)
        {
            _orderMealList.RemoveAt(index);
            _orderMealSubtotal.RemoveAt(index);
            _orderMealQuantity.RemoveAt(index);
        }

        //重設餐點
        public void ResetOrderMealsMeal(Meal changeMeal, Meal newMeal)
        {
            for (int i = 0; i < _orderMealList.Count; i++)
            {
                if (orderMealList[i].Equals(changeMeal))
                {
                    orderMealList[i] = newMeal;
                }
            }
        }

        //計算總價
        public void CalculateTotalPrice()
        {
            _totalPrice = 0;
            CalculateSubtotalPrice();
            for (int i = 0; i < _orderMealList.Count; i++)
            {
                _totalPrice += _orderMealSubtotal[i];
            }
        }

        //計算單品餐點的總價
        public void CalculateSubtotalPrice()
        {
            for (int i = 0; i < _orderMealList.Count; i++)
            {
                _orderMealSubtotal[i] = _orderMealList[i].UnitPrice * _orderMealQuantity[i];
            }
        }

        //設定餐點數量
        public void SetOrderMealListQuantity(int orderListIndex, int quantity)
        {
            _orderMealQuantity[orderListIndex] = quantity;
            CalculateSubtotalPrice();
        }

        //取得餐點數量
        public int GetOrderMealQuantity(int index)
        {
            return _orderMealQuantity[index];
        }

        //取得餐點總價
        public int GetOrderMealSubtotal(int index)
        {
            return _orderMealSubtotal[index];
        }

        //是否以選取餐點
        public bool IsSelected()
        {
            if (_selectedMeal != null)
            {
                return true;
            }
            return false;
        }

        //判斷餐點是否出現在已點餐點
        public bool IsOrderMealListHaveMeal(Meal meal)
        {
            for (int i = 0; i < _orderMealList.Count; i++)
            {
                if (_orderMealList[i].Equals(meal))
                {
                    return true;
                }
            }
            return false;
        }

        //判斷類別是否出現在已點餐點
        public bool IsOrderMealListHaveCategory(Category category)
        {
            for (int i = 0; i < _orderMealList.Count; i++)
            {
                if (_orderMealList[i].Category == category.Name)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Meal> orderMealList
        {
            get
            {
                return _orderMealList;
            }
        }

        public int totalPrice
        {
            get
            {
                CalculateTotalPrice();
                return _totalPrice;
            }
        }
    }
}
