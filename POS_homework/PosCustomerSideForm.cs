using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataGridViewNumericUpDownElements;

namespace POS_homework
{
    public partial class PosCustomerSideForm : Form
    {
        const string ORDER_BUTTON_NAME = "orderButton";
        const string TOTAL_PRICE_COLUMN_NAME = "mealTotalPriceColumn";
        private PosCustomerSideModel _model;
        private CustomerFormPresentationModel _presentationModel;
        DataGridViewButtonColumn _deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
        DataGridViewNumericUpDownColumn _quantityNumericUpDownColumn = new DataGridViewNumericUpDownColumn();
        DataGridViewTextBoxColumn _mealTotalPriceColumn = new DataGridViewTextBoxColumn();
        private BindingSource _bindingSource = new BindingSource();

        public PosCustomerSideForm(PosCustomerSideModel model)
        {
            _model = model;
            _model._mealChanged += UpdateMealInformation;
            _bindingSource.DataSource = _model.GetOrderMealList();
            _presentationModel = new CustomerFormPresentationModel(_model);
            Load += new System.EventHandler(this.LoadPosCustomerSideForm);
            InitializeComponent();
        }

        //formLoad時做的初始化動作
        private void LoadPosCustomerSideForm(object sender, EventArgs e)
        {
            InitialComponent();
            RefreshTabPage();
            RefreshMealGroupBox();
            _tabControl.SelectedIndexChanged += new EventHandler(SelectTabPage);
            _addButton.Enabled = _presentationModel.IsAddButtonEnabled();
        }

        //初始化元件
        private void InitialComponent()
        {
            _deleteColumn.HeaderText = "Delete";
            _deleteColumn.Name = "deleteColumn";
            _deleteColumn.Text = "X";
            _deleteColumn.UseColumnTextForButtonValue = true;
            _mealTotalPriceColumn.HeaderText = "Subtotal";
            _mealTotalPriceColumn.Name = TOTAL_PRICE_COLUMN_NAME;
            _mealsListDataGridView.Columns.Add(_deleteColumn);
            _mealsListDataGridView.DataSource = _bindingSource;
            _mealsListDataGridView.Columns["Name"].ReadOnly = true;
            _mealsListDataGridView.Columns["Category"].ReadOnly = true;
            _mealsListDataGridView.Columns["UnitPrice"].ReadOnly = true;
            _quantityNumericUpDownColumn.HeaderText = "Qty";
            _quantityNumericUpDownColumn.Minimum = 1;
            _quantityNumericUpDownColumn.Name = "_quantityNumericUpDownColumn";
            _mealsListDataGridView.Columns.Add(_quantityNumericUpDownColumn);
            _mealsListDataGridView.Columns.Add(_mealTotalPriceColumn);
            _mealsListDataGridView.Columns[TOTAL_PRICE_COLUMN_NAME].ReadOnly = true;
        }

        //刷新tabPage
        private void RefreshTabPage()
        {
            string[] categorysName = _presentationModel.GetCategoryNames();
            _tabControl.TabPages.Clear();
            foreach (string categotyName in categorysName)
            {
                _tabControl.TabPages.Add(GenerateTabPage(categotyName));
            }
        }

        //刷新餐點數量
        public void RefreshDataGridView()
        {
            for (int i = 0; i < _mealsListDataGridView.Rows.Count; i++)
            {
                _mealsListDataGridView[1, i].Value = _model.GetOrderMealQuantity(i);
            }
            for (int i = 0; i < _mealsListDataGridView.Rows.Count; i++)
            {
                _mealsListDataGridView[2, i].Value = _model.GetOrderMealSubtotal(i);
            }
            _totalPriceLabel.Text = _presentationModel.GetTotalPriceLabelText();
        }

        //刷新選單按鈕
        private void RefreshMealGroupBox()
        {
            TabPage tabPage = _tabControl.SelectedTab;
            tabPage.Controls.Add(_tableLayoutPanel);
            _model.SetCategoryMealList(_tabControl.SelectedIndex);
            TableLayoutPanel layoutPanel = (TableLayoutPanel)tabPage.Controls[0];
            for (int i = layoutPanel.Controls.Count - 1; i >= 0; i--)
            {
                Button orderButton = (Button)layoutPanel.Controls[layoutPanel.Controls.Count - i - 1];
                orderButton.Visible = _presentationModel.IsOrderButtonVisible(i);
                orderButton.Text = _presentationModel.GetOrderButtonText(i);
                orderButton.BackgroundImage = _presentationModel.GetMealButtonImagePath(i);
            }
            _pageLabel.Text = _presentationModel.GetPageLabelText();
            _previousPageButton.Enabled = _presentationModel.IsPreviousPageButtonEnabled();
            _nextPageButton.Enabled = _presentationModel.IsNextPageButtonEnabled();

            RefreshDataGridView();
        }

        //產生tabPage
        private TabPage GenerateTabPage(string tabPageName)
        {
            TabPage tabPage = new TabPage(tabPageName);
            tabPage.Click += new EventHandler(SelectTabPage);
            return tabPage;
        }

        //orderbuttom的點擊事件
        private void OrderButtonClick(object sender, EventArgs e)
        {
            int orderButtonIndex = ((Button)sender).TabIndex;
            _presentationModel.ClickOrderButtonHandler(orderButtonIndex);
            _mealInformationTextBox.Text = _presentationModel.GetMealIntroductionText(orderButtonIndex);
            _addButton.Enabled = _presentationModel.IsAddButtonEnabled();

        }

        //選擇餐點種類時的事件
        private void SelectTabPage(object sender, EventArgs e)
        {
            if (_tabControl.SelectedIndex != -1)
            {
                RefreshMealGroupBox();
                _presentationModel.ResetPage();
                _pageLabel.Text = _presentationModel.GetPageLabelText();
                _previousPageButton.Enabled = _presentationModel.IsPreviousPageButtonEnabled();
                _nextPageButton.Enabled = _presentationModel.IsNextPageButtonEnabled();
                RefreshMealGroupBox();
            }
        }

        //下一頁按鈕點擊事件
        private void ChangePageButton(object sender, EventArgs e)
        {
            _presentationModel.ChangePage(((Button)sender).TabIndex);
            RefreshMealGroupBox(); 
        }
        
        //Add按鈕點擊事件，將餐點加到gridView
        private void ClickAddButton(object sender, EventArgs e)
        {
            _model.ClickAddButton();
            _bindingSource.ResetBindings(true);
            _totalPriceLabel.Text = _presentationModel.GetTotalPriceLabelText();
            RefreshDataGridView();
        }

        //刪除菜單事件
        private void ClickMealListCellContent(object sender, DataGridViewCellEventArgs e)
        {
            _model.DeleteOrderMeal(e.RowIndex, e.ColumnIndex);
            _bindingSource.ResetBindings(true);
            _totalPriceLabel.Text = _presentationModel.GetTotalPriceLabelText();
        }

        //更改數量事件
        private void ChangeDataGridViewCellValue(object sender, DataGridViewCellEventArgs e)
        {
            string data = _mealsListDataGridView[e.ColumnIndex, e.RowIndex].Value.ToString();
            _model.SetOrderMealListQuantity(e.RowIndex, e.ColumnIndex, Int32.Parse(data));
            RefreshDataGridView();
        }

        //更新Meal事件
        private void UpdateMealInformation()
        {
            _bindingSource.ResetBindings(true);
            RefreshTabPage();
            RefreshMealGroupBox();
            RefreshDataGridView();
        }
    }
}
