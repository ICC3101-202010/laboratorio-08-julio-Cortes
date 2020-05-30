namespace Lab8
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Selector = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StoresData = new System.Windows.Forms.DataGridView();
            this.LocalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocalSchedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecreationalData = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RestaurantsData = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CinemaData = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StoresData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecreationalData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestaurantsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CinemaData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Selector);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 476);
            this.panel1.TabIndex = 2;
            // 
            // Selector
            // 
            this.Selector.Dock = System.Windows.Forms.DockStyle.Top;
            this.Selector.FormattingEnabled = true;
            this.Selector.Items.AddRange(new object[] {
            "Stores",
            "Restaurants",
            "Cinemas",
            "Recreationals"});
            this.Selector.Location = new System.Drawing.Point(0, 0);
            this.Selector.Name = "Selector";
            this.Selector.Size = new System.Drawing.Size(897, 21);
            this.Selector.TabIndex = 0;
            this.Selector.SelectedIndexChanged += new System.EventHandler(this.Selector_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Lab8.Properties.Resources.mall3;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.StoresData);
            this.panel2.Controls.Add(this.RecreationalData);
            this.panel2.Controls.Add(this.RestaurantsData);
            this.panel2.Controls.Add(this.CinemaData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 455);
            this.panel2.TabIndex = 1;
            // 
            // StoresData
            // 
            this.StoresData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StoresData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LocalName,
            this.LocalId,
            this.LocalSchedule,
            this.StoreCategory});
            this.StoresData.Location = new System.Drawing.Point(392, 0);
            this.StoresData.Name = "StoresData";
            this.StoresData.Size = new System.Drawing.Size(245, 143);
            this.StoresData.TabIndex = 0;
            this.StoresData.Visible = false;
            // 
            // LocalName
            // 
            this.LocalName.HeaderText = "Store Name";
            this.LocalName.Name = "LocalName";
            this.LocalName.ReadOnly = true;
            // 
            // LocalId
            // 
            this.LocalId.HeaderText = "Store Id";
            this.LocalId.Name = "LocalId";
            this.LocalId.ReadOnly = true;
            // 
            // LocalSchedule
            // 
            this.LocalSchedule.HeaderText = "Store Schedule";
            this.LocalSchedule.Name = "LocalSchedule";
            this.LocalSchedule.ReadOnly = true;
            // 
            // StoreCategory
            // 
            this.StoreCategory.HeaderText = "Store Category";
            this.StoreCategory.Name = "StoreCategory";
            this.StoreCategory.ReadOnly = true;
            // 
            // RecreationalData
            // 
            this.RecreationalData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecreationalData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.RecreationalData.Location = new System.Drawing.Point(643, 0);
            this.RecreationalData.Name = "RecreationalData";
            this.RecreationalData.Size = new System.Drawing.Size(251, 143);
            this.RecreationalData.TabIndex = 3;
            this.RecreationalData.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Recreational Name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Recreational Id";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Recreational Schedule";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // RestaurantsData
            // 
            this.RestaurantsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RestaurantsData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.RestaurantsData.Location = new System.Drawing.Point(207, 3);
            this.RestaurantsData.Name = "RestaurantsData";
            this.RestaurantsData.Size = new System.Drawing.Size(169, 143);
            this.RestaurantsData.TabIndex = 1;
            this.RestaurantsData.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Restaurant Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Restaurant Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Restaurant Schedule";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Restaurant private tables";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // CinemaData
            // 
            this.CinemaData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CinemaData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.CinemaData.Location = new System.Drawing.Point(0, 0);
            this.CinemaData.Name = "CinemaData";
            this.CinemaData.Size = new System.Drawing.Size(190, 146);
            this.CinemaData.TabIndex = 2;
            this.CinemaData.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Cinema Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Cinema Id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Cinema Schedule";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Cinema N of Rooms";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 476);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StoresData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecreationalData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RestaurantsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CinemaData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StoresData;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreCategory;
        private System.Windows.Forms.DataGridView RecreationalData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridView CinemaData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView RestaurantsData;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Selector;
        private System.Windows.Forms.Panel panel2;
    }
}