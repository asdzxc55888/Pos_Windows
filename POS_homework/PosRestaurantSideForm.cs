using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_homework
{
    public partial class PosRestaurantSideForm : Form
    {
        PosCustomerSideModel _model;
        RestaurantFromPresentationModel _presentationModel;
        OpenFileDialog _openImageDialog;
        public PosRestaurantSideForm(PosCustomerSideModel model)
        {
            InitializeComponent();
            _model = model;
            _model._mealChanged += UpdateViewInformation;
            _presentationModel = new RestaurantFromPresentationModel(_model);
            InitialComponent();
        }
        
        //初始化元件
        public void InitialComponent()
        {
            UpdateViewInformation();

            this._openImageDialog = new System.Windows.Forms.OpenFileDialog();
            string projectPath =
            Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
            _openImageDialog.InitialDirectory = projectPath;
            _openImageDialog.Multiselect = false;
            _openImageDialog.Filter = "Image|*.png;*.jpg;*.jpeg";
        }

        //刷新餐點資訊
        public void RefreshMealInformation(int mealListIndex)
        {
            Meal selectMeal = _presentationModel.GetMeal(mealListIndex);
            _mealNameTextBox.Text = selectMeal.Name;
            _mealPriceTextBox.Text = _presentationModel.ConvertMealPriceToString(selectMeal.UnitPrice);
            _mealImageTextBox.Text = _presentationModel.GetMealImageRelativePath(selectMeal.GetImagePath());
            _mealDescriptionTextBox.Text = selectMeal.GetIntroduction();
            _mealCategoryComboBox.SelectedIndex = _presentationModel.GetCategoryIndex(selectMeal.Category);
            _saveMealButton.Text = _presentationModel.GetSaveButtonText(_tabControl1.SelectedIndex);
        }

        //刷新類別資訊
        public void RefreshCategoryInformation(int categoryListIndex)
        {
            _categoryNameTextBox.Text = _presentationModel.GetCategoryNameText(categoryListIndex);
            _usingCategoryMealListBox.DataSource = _presentationModel.GetCategoryMealListName();
            _saveCategoryButton.Text = _presentationModel.GetSaveButtonText(_tabControl1.SelectedIndex);
        }

        //選擇餐點清單事件
        private void SelectMealListMealEvent(object sender, EventArgs e)
        {
            _presentationModel.SetSaveButtonText(0, _tabControl1.SelectedIndex);
            _presentationModel.SetSelectMealListIndex(_mealListBox.SelectedIndex);
            RefreshMealInformation(_mealListBox.SelectedIndex);
            _deleteMealButton.Enabled = _presentationModel.IsDeleteMealButtonEnabled();
        }

        //選擇類別清單事件
        private void SelectCategoryListMealEvent(object sender, EventArgs e)
        {
            _presentationModel.SetSaveButtonText(0, _tabControl1.SelectedIndex);
            _presentationModel.SetSelectCategoryMealList(_categoryListBox.SelectedIndex);
            _presentationModel.SetSelectCategoryListIndex(_categoryListBox.SelectedIndex);
            RefreshCategoryInformation(_categoryListBox.SelectedIndex);
            _deleteCategoryButton.Enabled = _presentationModel.IsDeleteCategoryButtonEnabled();
        }

        //儲存事件
        private void ClickSaveMealButtonEvent(object sender, EventArgs e)
        {
            Meal newMeal = new Meal(_mealNameTextBox.Text, Int32.Parse(_mealPriceTextBox.Text), _mealDescriptionTextBox.Text, _mealImageTextBox.Text, null);
            _model.SetMealInformation(_mealListBox.SelectedIndex, newMeal, _mealCategoryComboBox.SelectedIndex);
            _mealListBox.DataSource = _presentationModel.GetMealNameList();
        }

        //儲存事件
        private void ClickSaveCategoryButtonEvent(object sender, EventArgs e)
        {
            Category category = new Category(_categoryNameTextBox.Text);
            _model.SetCategoryList(_categoryListBox.SelectedIndex, category);
            _categoryListBox.DataSource = _presentationModel.GetCategoryNames();
        }

        //增加餐點事件
        private void ClickAddMealButtonEvent(object sender, EventArgs e)
        {
            _mealListBox.SelectedIndex = -1;
            _presentationModel.SetSaveButtonText(1, _tabControl1.SelectedIndex);
            RefreshMealInformation(_mealListBox.SelectedIndex);
            _mealCategoryComboBox.SelectedIndex = 0;
        }

        //增加餐點事件
        private void ClickAddCategoryButtonEvent(object sender, EventArgs e)
        {
            _categoryListBox.SelectedIndex = -1;
            _presentationModel.SetSaveButtonText(1, _tabControl1.SelectedIndex);
            RefreshCategoryInformation(_categoryListBox.SelectedIndex);
        }

        //點擊瀏覽按鈕事件
        private void ClickBrowseEvent(object sender, EventArgs e)
        {
            DialogResult result = _openImageDialog.ShowDialog();
            _mealImageTextBox.Text = _presentationModel.GetMealImageRelativePath(_openImageDialog.FileName);
        }

        //點擊刪除餐點事件
        private void ClickDeleteMealButton(object sender, EventArgs e)
        {
            _model.DeleteMealListMeal(_mealListBox.SelectedIndex);
        }

        //點擊刪除類別事件
        private void ClickDeleteCategoryButton(object sender, EventArgs e)
        {
            _model.DeleteCategoryListCategory(_categoryListBox.SelectedIndex);
        }

        //餐點資訊有變動時做的事件
        private void ChangeMealInformationEvent(object sender, EventArgs e)
        {
            _saveMealButton.Enabled = _presentationModel.IsSaveMealButtonEnabled(_mealNameTextBox.Text, _mealPriceTextBox.Text, _mealImageTextBox.Text);
        }

        //餐點資訊有變動時做的事件
        private void ChangeCategoryInformationEvent(object sender, EventArgs e)
        {
            _saveCategoryButton.Enabled = _presentationModel.IsSaveCategoryButtonEnabled(_categoryNameTextBox.Text);
        }

        //更新Meal事件
        private void UpdateViewInformation()
        {
            _mealCategoryComboBox.Items.Clear();
            _mealCategoryComboBox.Items.AddRange(_presentationModel.GetCategoryNames());
            _mealListBox.DataSource = _presentationModel.GetMealNameList();
            _mealListBox.ClearSelected();
            _categoryListBox.DataSource = _presentationModel.GetCategoryNames();
            _categoryListBox.ClearSelected();
        }
    }
}
