using DataGridViewNumericUpDownElements;
namespace POS_homework
{
    partial class PosCustomerSideForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
            this._mealInformationTextBox = new System.Windows.Forms.RichTextBox();
            this._tabControl = new System.Windows.Forms.TabControl();
            this._tabPage = new System.Windows.Forms.TabPage();
            this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._orderButton9 = new System.Windows.Forms.Button();
            this._orderButton8 = new System.Windows.Forms.Button();
            this._orderButton7 = new System.Windows.Forms.Button();
            this._orderButton6 = new System.Windows.Forms.Button();
            this._orderButton5 = new System.Windows.Forms.Button();
            this._orderButton4 = new System.Windows.Forms.Button();
            this._orderButton3 = new System.Windows.Forms.Button();
            this._orderButton2 = new System.Windows.Forms.Button();
            this._orderButton1 = new System.Windows.Forms.Button();
            this._tabPage2 = new System.Windows.Forms.TabPage();
            this._tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._mealsGroupBox = new System.Windows.Forms.GroupBox();
            this._totalPriceLabel = new System.Windows.Forms.Label();
            this._mealsListDataGridView = new System.Windows.Forms.DataGridView();
            this._tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._pageLabel = new System.Windows.Forms.Label();
            this._nextPageButton = new System.Windows.Forms.Button();
            this._previousPageButton = new System.Windows.Forms.Button();
            this._addButton = new System.Windows.Forms.Button();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel3.SuspendLayout();
            this._tabControl.SuspendLayout();
            this._tabPage.SuspendLayout();
            this._tableLayoutPanel.SuspendLayout();
            this._tableLayoutPanel1.SuspendLayout();
            this._mealsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._mealsListDataGridView)).BeginInit();
            this._tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel3.Controls.Add(this._mealInformationTextBox, 0, 1);
            tableLayoutPanel3.Controls.Add(this._tabControl, 0, 0);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(2, 17);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.81818F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.18182F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            tableLayoutPanel3.Size = new System.Drawing.Size(364, 440);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // _mealInformationTextBox
            // 
            this._mealInformationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mealInformationTextBox.Location = new System.Drawing.Point(2, 344);
            this._mealInformationTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._mealInformationTextBox.Name = "_mealInformationTextBox";
            this._mealInformationTextBox.ReadOnly = true;
            this._mealInformationTextBox.Size = new System.Drawing.Size(360, 94);
            this._mealInformationTextBox.TabIndex = 9;
            this._mealInformationTextBox.Text = "";
            // 
            // _tabControl
            // 
            this._tabControl.Controls.Add(this._tabPage);
            this._tabControl.Controls.Add(this._tabPage2);
            this._tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tabControl.Location = new System.Drawing.Point(2, 2);
            this._tabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(360, 338);
            this._tabControl.TabIndex = 10;
            // 
            // _tabPage
            // 
            this._tabPage.Controls.Add(this._tableLayoutPanel);
            this._tabPage.Location = new System.Drawing.Point(4, 22);
            this._tabPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._tabPage.Name = "_tabPage";
            this._tabPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._tabPage.Size = new System.Drawing.Size(352, 312);
            this._tabPage.TabIndex = 0;
            this._tabPage.Text = "tabPage1";
            this._tabPage.UseVisualStyleBackColor = true;
            // 
            // _tableLayoutPanel
            // 
            this._tableLayoutPanel.ColumnCount = 3;
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanel.Controls.Add(this._orderButton9, 2, 2);
            this._tableLayoutPanel.Controls.Add(this._orderButton8, 1, 2);
            this._tableLayoutPanel.Controls.Add(this._orderButton7, 0, 2);
            this._tableLayoutPanel.Controls.Add(this._orderButton6, 2, 1);
            this._tableLayoutPanel.Controls.Add(this._orderButton5, 1, 1);
            this._tableLayoutPanel.Controls.Add(this._orderButton4, 0, 1);
            this._tableLayoutPanel.Controls.Add(this._orderButton3, 2, 0);
            this._tableLayoutPanel.Controls.Add(this._orderButton2, 1, 0);
            this._tableLayoutPanel.Controls.Add(this._orderButton1, 0, 0);
            this._tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel.Location = new System.Drawing.Point(2, 2);
            this._tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._tableLayoutPanel.Name = "_tableLayoutPanel";
            this._tableLayoutPanel.RowCount = 3;
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanel.Size = new System.Drawing.Size(348, 308);
            this._tableLayoutPanel.TabIndex = 0;
            // 
            // _orderButton9
            // 
            this._orderButton9.AccessibleName = "orderButton9";
            this._orderButton9.Dock = System.Windows.Forms.DockStyle.Fill;
            this._orderButton9.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._orderButton9.Location = new System.Drawing.Point(234, 206);
            this._orderButton9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._orderButton9.Name = "_orderButton9";
            this._orderButton9.Size = new System.Drawing.Size(112, 100);
            this._orderButton9.TabIndex = 8;
            this._orderButton9.Text = "button9";
            this._orderButton9.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this._orderButton9.UseVisualStyleBackColor = true;
            this._orderButton9.Click += new System.EventHandler(this.OrderButtonClick);
            // 
            // _orderButton8
            // 
            this._orderButton8.AccessibleName = "orderButton8";
            this._orderButton8.Dock = System.Windows.Forms.DockStyle.Fill;
            this._orderButton8.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._orderButton8.Location = new System.Drawing.Point(118, 206);
            this._orderButton8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._orderButton8.Name = "_orderButton8";
            this._orderButton8.Size = new System.Drawing.Size(112, 100);
            this._orderButton8.TabIndex = 7;
            this._orderButton8.Text = "button8";
            this._orderButton8.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this._orderButton8.UseVisualStyleBackColor = true;
            this._orderButton8.Click += new System.EventHandler(this.OrderButtonClick);
            // 
            // _orderButton7
            // 
            this._orderButton7.AccessibleName = "orderButton7";
            this._orderButton7.Dock = System.Windows.Forms.DockStyle.Fill;
            this._orderButton7.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._orderButton7.Location = new System.Drawing.Point(2, 206);
            this._orderButton7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._orderButton7.Name = "_orderButton7";
            this._orderButton7.Size = new System.Drawing.Size(112, 100);
            this._orderButton7.TabIndex = 6;
            this._orderButton7.Text = "button7";
            this._orderButton7.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this._orderButton7.UseVisualStyleBackColor = true;
            this._orderButton7.Click += new System.EventHandler(this.OrderButtonClick);
            // 
            // _orderButton6
            // 
            this._orderButton6.AccessibleName = "orderButton6";
            this._orderButton6.Dock = System.Windows.Forms.DockStyle.Fill;
            this._orderButton6.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._orderButton6.Location = new System.Drawing.Point(234, 104);
            this._orderButton6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._orderButton6.Name = "_orderButton6";
            this._orderButton6.Size = new System.Drawing.Size(112, 98);
            this._orderButton6.TabIndex = 5;
            this._orderButton6.Text = "button6";
            this._orderButton6.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this._orderButton6.UseVisualStyleBackColor = true;
            this._orderButton6.Click += new System.EventHandler(this.OrderButtonClick);
            // 
            // _orderButton5
            // 
            this._orderButton5.AccessibleName = "orderButton5";
            this._orderButton5.Dock = System.Windows.Forms.DockStyle.Fill;
            this._orderButton5.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._orderButton5.Location = new System.Drawing.Point(118, 104);
            this._orderButton5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._orderButton5.Name = "_orderButton5";
            this._orderButton5.Size = new System.Drawing.Size(112, 98);
            this._orderButton5.TabIndex = 4;
            this._orderButton5.Text = "button5";
            this._orderButton5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this._orderButton5.UseVisualStyleBackColor = true;
            this._orderButton5.Click += new System.EventHandler(this.OrderButtonClick);
            // 
            // _orderButton4
            // 
            this._orderButton4.AccessibleName = "orderButton4";
            this._orderButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this._orderButton4.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._orderButton4.Location = new System.Drawing.Point(2, 104);
            this._orderButton4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._orderButton4.Name = "_orderButton4";
            this._orderButton4.Size = new System.Drawing.Size(112, 98);
            this._orderButton4.TabIndex = 3;
            this._orderButton4.Text = "button4";
            this._orderButton4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this._orderButton4.UseVisualStyleBackColor = true;
            this._orderButton4.Click += new System.EventHandler(this.OrderButtonClick);
            // 
            // _orderButton3
            // 
            this._orderButton3.AccessibleName = "orderButton3";
            this._orderButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this._orderButton3.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._orderButton3.Location = new System.Drawing.Point(234, 2);
            this._orderButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._orderButton3.Name = "_orderButton3";
            this._orderButton3.Size = new System.Drawing.Size(112, 98);
            this._orderButton3.TabIndex = 2;
            this._orderButton3.Text = "button3";
            this._orderButton3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this._orderButton3.UseVisualStyleBackColor = true;
            this._orderButton3.Click += new System.EventHandler(this.OrderButtonClick);
            // 
            // _orderButton2
            // 
            this._orderButton2.AccessibleName = "orderButton2";
            this._orderButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this._orderButton2.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._orderButton2.Location = new System.Drawing.Point(118, 2);
            this._orderButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._orderButton2.Name = "_orderButton2";
            this._orderButton2.Size = new System.Drawing.Size(112, 98);
            this._orderButton2.TabIndex = 1;
            this._orderButton2.Text = "button2";
            this._orderButton2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this._orderButton2.UseVisualStyleBackColor = true;
            this._orderButton2.Click += new System.EventHandler(this.OrderButtonClick);
            // 
            // _orderButton1
            // 
            this._orderButton1.AccessibleName = "orderButton1";
            this._orderButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._orderButton1.Font = new System.Drawing.Font("新細明體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._orderButton1.Location = new System.Drawing.Point(2, 2);
            this._orderButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._orderButton1.Name = "_orderButton1";
            this._orderButton1.Size = new System.Drawing.Size(112, 98);
            this._orderButton1.TabIndex = 0;
            this._orderButton1.Text = "button1";
            this._orderButton1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this._orderButton1.UseVisualStyleBackColor = true;
            this._orderButton1.Click += new System.EventHandler(this.OrderButtonClick);
            // 
            // _tabPage2
            // 
            this._tabPage2.Location = new System.Drawing.Point(4, 22);
            this._tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._tabPage2.Name = "_tabPage2";
            this._tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._tabPage2.Size = new System.Drawing.Size(350, 313);
            this._tabPage2.TabIndex = 1;
            this._tabPage2.Text = "tabPage2";
            this._tabPage2.UseVisualStyleBackColor = true;
            // 
            // _tableLayoutPanel1
            // 
            this._tableLayoutPanel1.ColumnCount = 2;
            this._tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.54104F));
            this._tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.45896F));
            this._tableLayoutPanel1.Controls.Add(this._mealsGroupBox, 0, 0);
            this._tableLayoutPanel1.Controls.Add(this._totalPriceLabel, 1, 1);
            this._tableLayoutPanel1.Controls.Add(this._mealsListDataGridView, 1, 0);
            this._tableLayoutPanel1.Controls.Add(this._tableLayoutPanel2, 0, 1);
            this._tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._tableLayoutPanel1.Name = "_tableLayoutPanel1";
            this._tableLayoutPanel1.RowCount = 2;
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.82635F));
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.17365F));
            this._tableLayoutPanel1.Size = new System.Drawing.Size(896, 534);
            this._tableLayoutPanel1.TabIndex = 0;
            // 
            // _mealsGroupBox
            // 
            this._mealsGroupBox.Controls.Add(tableLayoutPanel3);
            this._mealsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mealsGroupBox.Location = new System.Drawing.Point(2, 2);
            this._mealsGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._mealsGroupBox.Name = "_mealsGroupBox";
            this._mealsGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._mealsGroupBox.Size = new System.Drawing.Size(368, 459);
            this._mealsGroupBox.TabIndex = 0;
            this._mealsGroupBox.TabStop = false;
            this._mealsGroupBox.Text = "Meals";
            // 
            // _totalPriceLabel
            // 
            this._totalPriceLabel.AccessibleName = "totalPriceLabel";
            this._totalPriceLabel.AutoSize = true;
            this._totalPriceLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this._totalPriceLabel.Font = new System.Drawing.Font("微軟正黑體", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._totalPriceLabel.Location = new System.Drawing.Point(721, 463);
            this._totalPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._totalPriceLabel.Name = "_totalPriceLabel";
            this._totalPriceLabel.Size = new System.Drawing.Size(173, 71);
            this._totalPriceLabel.TabIndex = 2;
            this._totalPriceLabel.Text = "Total：0";
            // 
            // _mealsListDataGridView
            // 
            this._mealsListDataGridView.AccessibleName = "mealsListDataGridView";
            this._mealsListDataGridView.AllowUserToResizeColumns = false;
            this._mealsListDataGridView.AllowUserToResizeRows = false;
            this._mealsListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._mealsListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._mealsListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mealsListDataGridView.Location = new System.Drawing.Point(374, 2);
            this._mealsListDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._mealsListDataGridView.Name = "_mealsListDataGridView";
            this._mealsListDataGridView.RowHeadersVisible = false;
            this._mealsListDataGridView.RowTemplate.Height = 27;
            this._mealsListDataGridView.Size = new System.Drawing.Size(520, 459);
            this._mealsListDataGridView.TabIndex = 1;
            this._mealsListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickMealListCellContent);
            this._mealsListDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChangeDataGridViewCellValue);
            // 
            // _tableLayoutPanel2
            // 
            this._tableLayoutPanel2.ColumnCount = 3;
            this._tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanel2.Controls.Add(this._pageLabel, 0, 1);
            this._tableLayoutPanel2.Controls.Add(this._nextPageButton, 2, 1);
            this._tableLayoutPanel2.Controls.Add(this._previousPageButton, 1, 1);
            this._tableLayoutPanel2.Controls.Add(this._addButton, 2, 0);
            this._tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel2.Location = new System.Drawing.Point(2, 465);
            this._tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._tableLayoutPanel2.Name = "_tableLayoutPanel2";
            this._tableLayoutPanel2.RowCount = 2;
            this._tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tableLayoutPanel2.Size = new System.Drawing.Size(368, 67);
            this._tableLayoutPanel2.TabIndex = 3;
            // 
            // _pageLabel
            // 
            this._pageLabel.AutoSize = true;
            this._pageLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this._pageLabel.Location = new System.Drawing.Point(2, 33);
            this._pageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this._pageLabel.Name = "_pageLabel";
            this._pageLabel.Size = new System.Drawing.Size(60, 34);
            this._pageLabel.TabIndex = 0;
            this._pageLabel.Text = "Page：1 / 2";
            // 
            // _nextPageButton
            // 
            this._nextPageButton.AccessibleName = "nextPage";
            this._nextPageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._nextPageButton.Location = new System.Drawing.Point(246, 35);
            this._nextPageButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._nextPageButton.Name = "_nextPageButton";
            this._nextPageButton.Size = new System.Drawing.Size(120, 30);
            this._nextPageButton.TabIndex = 1;
            this._nextPageButton.Text = "Next Page";
            this._nextPageButton.UseVisualStyleBackColor = true;
            this._nextPageButton.Click += new System.EventHandler(this.ChangePageButton);
            // 
            // _previousPageButton
            // 
            this._previousPageButton.AccessibleName = "previousPage";
            this._previousPageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._previousPageButton.Enabled = false;
            this._previousPageButton.Location = new System.Drawing.Point(124, 35);
            this._previousPageButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._previousPageButton.Name = "_previousPageButton";
            this._previousPageButton.Size = new System.Drawing.Size(118, 30);
            this._previousPageButton.TabIndex = 2;
            this._previousPageButton.Text = "Previous Page";
            this._previousPageButton.UseVisualStyleBackColor = true;
            this._previousPageButton.Click += new System.EventHandler(this.ChangePageButton);
            // 
            // _addButton
            // 
            this._addButton.AccessibleName = "addMeal";
            this._addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addButton.Location = new System.Drawing.Point(246, 2);
            this._addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(120, 29);
            this._addButton.TabIndex = 3;
            this._addButton.Text = "Add";
            this._addButton.UseVisualStyleBackColor = true;
            this._addButton.Click += new System.EventHandler(this.ClickAddButton);
            // 
            // PosCustomerSideForm
            // 
            this.AccessibleName = "POS-Customer Side";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 534);
            this.Controls.Add(this._tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PosCustomerSideForm";
            this.Text = "POS-Customer Side";
            tableLayoutPanel3.ResumeLayout(false);
            this._tabControl.ResumeLayout(false);
            this._tabPage.ResumeLayout(false);
            this._tableLayoutPanel.ResumeLayout(false);
            this._tableLayoutPanel1.ResumeLayout(false);
            this._tableLayoutPanel1.PerformLayout();
            this._mealsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._mealsListDataGridView)).EndInit();
            this._tableLayoutPanel2.ResumeLayout(false);
            this._tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel1;
        private System.Windows.Forms.GroupBox _mealsGroupBox;
        private System.Windows.Forms.DataGridView _mealsListDataGridView;
        private System.Windows.Forms.Label _totalPriceLabel;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel2;
        private System.Windows.Forms.Label _pageLabel;
        private System.Windows.Forms.Button _nextPageButton;
        private System.Windows.Forms.Button _previousPageButton;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.RichTextBox _mealInformationTextBox;
        private System.Windows.Forms.TabControl _tabControl;
        private System.Windows.Forms.TabPage _tabPage;
        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel;
        private System.Windows.Forms.Button _orderButton9;
        private System.Windows.Forms.Button _orderButton8;
        private System.Windows.Forms.Button _orderButton7;
        private System.Windows.Forms.Button _orderButton6;
        private System.Windows.Forms.Button _orderButton5;
        private System.Windows.Forms.Button _orderButton4;
        private System.Windows.Forms.Button _orderButton3;
        private System.Windows.Forms.Button _orderButton2;
        private System.Windows.Forms.Button _orderButton1;
        private System.Windows.Forms.TabPage _tabPage2;
    }
}

