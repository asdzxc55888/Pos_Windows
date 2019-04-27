using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_homework
{
    public class Meal
    {
        private string _name;
        private int _price;
        private string _introduction;
        private string _imagePath;
        private Category _category;

        public Meal(String mealName , int mealPrice , string mealIntroduction , string imagePath , Category category)
        {
            _name = mealName;
            _price = mealPrice;
            _introduction = mealIntroduction;
            _imagePath = imagePath;
            _category = category;
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string Category
        {
            get
            {
                if (_category != null)
                {
                    return _category.Name;
                }
                return "";
            }
            set
            {
                Category category = new Category(value);
                _category = category;
            }
        }

        public int UnitPrice
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }

        //取得餐點介紹
        public string GetIntroduction()
        {  
            return _introduction;
        }

        //取得餐點路徑
        public string GetImagePath()
        {
            string projectPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            return projectPath + _imagePath;
        }
    }
}
