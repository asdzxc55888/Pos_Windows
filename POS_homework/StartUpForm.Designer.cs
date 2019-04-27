namespace POS_homework
{
    partial class StartUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._startCustomerFormButton = new System.Windows.Forms.Button();
            this._startRestaurantFormButton = new System.Windows.Forms.Button();
            this._exitButton = new System.Windows.Forms.Button();
            this._tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tableLayoutPanel1
            // 
            this._tableLayoutPanel1.ColumnCount = 3;
            this._tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this._tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this._tableLayoutPanel1.Controls.Add(this._startCustomerFormButton, 0, 0);
            this._tableLayoutPanel1.Controls.Add(this._startRestaurantFormButton, 0, 1);
            this._tableLayoutPanel1.Controls.Add(this._exitButton, 2, 2);
            this._tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this._tableLayoutPanel1.Name = "_tableLayoutPanel1";
            this._tableLayoutPanel1.RowCount = 3;
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._tableLayoutPanel1.Size = new System.Drawing.Size(800, 266);
            this._tableLayoutPanel1.TabIndex = 0;
            // 
            // _startCustomerFormButton
            // 
            this._startCustomerFormButton.AccessibleName = "client";
            this._tableLayoutPanel1.SetColumnSpan(this._startCustomerFormButton, 3);
            this._startCustomerFormButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._startCustomerFormButton.Location = new System.Drawing.Point(3, 3);
            this._startCustomerFormButton.Name = "_startCustomerFormButton";
            this._startCustomerFormButton.Size = new System.Drawing.Size(794, 82);
            this._startCustomerFormButton.TabIndex = 0;
            this._startCustomerFormButton.Text = "Start the Customer Program(Frontend)";
            this._startCustomerFormButton.UseVisualStyleBackColor = true;
            this._startCustomerFormButton.Click += new System.EventHandler(this.ClickCustomerButton);
            // 
            // _startRestaurantFormButton
            // 
            this._startRestaurantFormButton.AccessibleName = "restaurant";
            this._tableLayoutPanel1.SetColumnSpan(this._startRestaurantFormButton, 3);
            this._startRestaurantFormButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._startRestaurantFormButton.Location = new System.Drawing.Point(3, 91);
            this._startRestaurantFormButton.Name = "_startRestaurantFormButton";
            this._startRestaurantFormButton.Size = new System.Drawing.Size(794, 82);
            this._startRestaurantFormButton.TabIndex = 1;
            this._startRestaurantFormButton.Text = "Start the Restaurant Program(Backend)";
            this._startRestaurantFormButton.UseVisualStyleBackColor = true;
            this._startRestaurantFormButton.Click += new System.EventHandler(this.ClickRestaurantButton);
            // 
            // _exitButton
            // 
            this._exitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._exitButton.Location = new System.Drawing.Point(535, 179);
            this._exitButton.Name = "_exitButton";
            this._exitButton.Size = new System.Drawing.Size(262, 84);
            this._exitButton.TabIndex = 2;
            this._exitButton.Text = "Exit";
            this._exitButton.UseVisualStyleBackColor = true;
            this._exitButton.Click += new System.EventHandler(this.ClickExitButton);
            // 
            // StartUpForm
            // 
            this.AccessibleName = "StartUp";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 266);
            this.Controls.Add(this._tableLayoutPanel1);
            this.Name = "StartUpForm";
            this.Text = "StartUp";
            this._tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel1;
        private System.Windows.Forms.Button _startCustomerFormButton;
        private System.Windows.Forms.Button _startRestaurantFormButton;
        private System.Windows.Forms.Button _exitButton;
    }
}