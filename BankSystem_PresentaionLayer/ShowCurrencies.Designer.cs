namespace BankSystem_PresentaionLayer
{
    partial class frmShowCurrencies
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
            this.dgvCurrencyList = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.updateRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currencyCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rbSearchByCountry = new System.Windows.Forms.RadioButton();
            this.rbSearchByCode = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.showAllCurrenciesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrencyList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCurrencyList
            // 
            this.dgvCurrencyList.AllowUserToAddRows = false;
            this.dgvCurrencyList.AllowUserToDeleteRows = false;
            this.dgvCurrencyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrencyList.Location = new System.Drawing.Point(88, 107);
            this.dgvCurrencyList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvCurrencyList.Name = "dgvCurrencyList";
            this.dgvCurrencyList.ReadOnly = true;
            this.dgvCurrencyList.Size = new System.Drawing.Size(615, 331);
            this.dgvCurrencyList.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateRateToolStripMenuItem,
            this.currencyCalculatorToolStripMenuItem,
            this.showAllCurrenciesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(801, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // updateRateToolStripMenuItem
            // 
            this.updateRateToolStripMenuItem.Name = "updateRateToolStripMenuItem";
            this.updateRateToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.updateRateToolStripMenuItem.Text = "Update Rate";
            this.updateRateToolStripMenuItem.Click += new System.EventHandler(this.updateRateToolStripMenuItem_Click);
            // 
            // currencyCalculatorToolStripMenuItem
            // 
            this.currencyCalculatorToolStripMenuItem.Name = "currencyCalculatorToolStripMenuItem";
            this.currencyCalculatorToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.currencyCalculatorToolStripMenuItem.Text = "Currency Calculator";
            this.currencyCalculatorToolStripMenuItem.Click += new System.EventHandler(this.currencyCalculatorToolStripMenuItem_Click);
            // 
            // rbSearchByCountry
            // 
            this.rbSearchByCountry.AutoSize = true;
            this.rbSearchByCountry.BackColor = System.Drawing.Color.Transparent;
            this.rbSearchByCountry.Location = new System.Drawing.Point(384, 73);
            this.rbSearchByCountry.Name = "rbSearchByCountry";
            this.rbSearchByCountry.Size = new System.Drawing.Size(129, 17);
            this.rbSearchByCountry.TabIndex = 14;
            this.rbSearchByCountry.TabStop = true;
            this.rbSearchByCountry.Text = "Search by Country";
            this.rbSearchByCountry.UseVisualStyleBackColor = false;
            // 
            // rbSearchByCode
            // 
            this.rbSearchByCode.AutoSize = true;
            this.rbSearchByCode.BackColor = System.Drawing.Color.Transparent;
            this.rbSearchByCode.Location = new System.Drawing.Point(534, 73);
            this.rbSearchByCode.Name = "rbSearchByCode";
            this.rbSearchByCode.Size = new System.Drawing.Size(112, 17);
            this.rbSearchByCode.TabIndex = 15;
            this.rbSearchByCode.TabStop = true;
            this.rbSearchByCode.Text = "Search by Code";
            this.rbSearchByCode.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSearch.Location = new System.Drawing.Point(88, 73);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(263, 21);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // showAllCurrenciesToolStripMenuItem
            // 
            this.showAllCurrenciesToolStripMenuItem.Name = "showAllCurrenciesToolStripMenuItem";
            this.showAllCurrenciesToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.showAllCurrenciesToolStripMenuItem.Text = "Show All Currencies";
            // 
            // frmShowCurrencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BankSystem_PresentaionLayer.Properties.Resources._31f76f699c7dbeb57a3be117d32f93a1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.rbSearchByCode);
            this.Controls.Add(this.rbSearchByCountry);
            this.Controls.Add(this.dgvCurrencyList);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmShowCurrencies";
            this.Text = "ShowCurrencies";
            this.Load += new System.EventHandler(this.frmShowCurrencies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrencyList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCurrencyList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currencyCalculatorToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbSearchByCountry;
        private System.Windows.Forms.RadioButton rbSearchByCode;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ToolStripMenuItem showAllCurrenciesToolStripMenuItem;
    }
}