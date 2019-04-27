using System;
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
    public partial class StartUpForm : Form
    {
        private PosCustomerSideModel _model;
        private PosCustomerSideForm _customerSideForm;
        private PosRestaurantSideForm _restaurantSideForm;
        public StartUpForm(PosCustomerSideModel model)
        {
            InitializeComponent();
            _model = model;
            _customerSideForm = new PosCustomerSideForm(_model);
        }
     
        //點擊顯示客戶端畫面
        public void ClickCustomerButton(object sender, EventArgs e)
        {
            _customerSideForm = new PosCustomerSideForm(_model);
            _customerSideForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseCustomerSideForm);
            _startCustomerFormButton.Enabled = false;
            _customerSideForm.Show();
        }

        //點擊顯示餐廳端畫面
        public void ClickRestaurantButton(object sender, EventArgs e)
        {
            _restaurantSideForm = new PosRestaurantSideForm(_model);
            _restaurantSideForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseRestaurantSideForm);
            _startRestaurantFormButton.Enabled = false;
            _restaurantSideForm.Show();
        }

        //點擊離開按鈕
        public void ClickExitButton(object sender, EventArgs e)
        {
            Close();
        }

        //關閉CustomerSideForm
        public void CloseCustomerSideForm(object sender, EventArgs e)
        {
            _startCustomerFormButton.Enabled = true;
        }

        //關閉RestaurantSideForm
        public void CloseRestaurantSideForm(object sender, EventArgs e)
        {
            _startRestaurantFormButton.Enabled = true;
        }
    }
}
