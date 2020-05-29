namespace Lab8
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BasePanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddLocal = new System.Windows.Forms.Button();
            this.LocalInfo = new System.Windows.Forms.Button();
            this.ViewLocals = new System.Windows.Forms.Button();
            this.PhotoPanel = new System.Windows.Forms.Panel();
            this.AddPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddStoreButton = new System.Windows.Forms.Button();
            this.AddCinemaButton = new System.Windows.Forms.Button();
            this.AddRestaurantButton = new System.Windows.Forms.Button();
            this.AddRecreationalButton = new System.Windows.Forms.Button();
            this.BasePanel.SuspendLayout();
            this.AddPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BasePanel
            // 
            this.BasePanel.BackColor = System.Drawing.Color.DimGray;
            this.BasePanel.ColumnCount = 1;
            this.BasePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BasePanel.Controls.Add(this.AddLocal, 0, 1);
            this.BasePanel.Controls.Add(this.LocalInfo, 0, 2);
            this.BasePanel.Controls.Add(this.ViewLocals, 0, 3);
            this.BasePanel.Controls.Add(this.PhotoPanel, 0, 0);
            this.BasePanel.Location = new System.Drawing.Point(38, 12);
            this.BasePanel.Name = "BasePanel";
            this.BasePanel.RowCount = 5;
            this.BasePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.BasePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BasePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BasePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BasePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BasePanel.Size = new System.Drawing.Size(200, 100);
            this.BasePanel.TabIndex = 0;
            // 
            // AddLocal
            // 
            this.AddLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddLocal.FlatAppearance.BorderSize = 0;
            this.AddLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLocal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddLocal.Location = new System.Drawing.Point(3, 35);
            this.AddLocal.Name = "AddLocal";
            this.AddLocal.Size = new System.Drawing.Size(194, 10);
            this.AddLocal.TabIndex = 0;
            this.AddLocal.Text = "Add new premise";
            this.AddLocal.UseVisualStyleBackColor = false;
            // 
            // LocalInfo
            // 
            this.LocalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LocalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LocalInfo.FlatAppearance.BorderSize = 0;
            this.LocalInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LocalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.LocalInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LocalInfo.Location = new System.Drawing.Point(3, 51);
            this.LocalInfo.Name = "LocalInfo";
            this.LocalInfo.Size = new System.Drawing.Size(194, 10);
            this.LocalInfo.TabIndex = 1;
            this.LocalInfo.Text = "View current premises information";
            this.LocalInfo.UseVisualStyleBackColor = false;
            // 
            // ViewLocals
            // 
            this.ViewLocals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ViewLocals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewLocals.FlatAppearance.BorderSize = 0;
            this.ViewLocals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewLocals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.ViewLocals.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ViewLocals.Location = new System.Drawing.Point(3, 67);
            this.ViewLocals.Name = "ViewLocals";
            this.ViewLocals.Size = new System.Drawing.Size(194, 10);
            this.ViewLocals.TabIndex = 2;
            this.ViewLocals.Text = "View current premises";
            this.ViewLocals.UseVisualStyleBackColor = false;
            // 
            // PhotoPanel
            // 
            this.PhotoPanel.BackColor = System.Drawing.Color.DimGray;
            this.PhotoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhotoPanel.Location = new System.Drawing.Point(3, 3);
            this.PhotoPanel.Name = "PhotoPanel";
            this.PhotoPanel.Size = new System.Drawing.Size(194, 26);
            this.PhotoPanel.TabIndex = 3;
            // 
            // AddPanel
            // 
            this.AddPanel.BackColor = System.Drawing.Color.DimGray;
            this.AddPanel.Controls.Add(this.panel2);
            this.AddPanel.Controls.Add(this.tableLayoutPanel1);
            this.AddPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddPanel.Location = new System.Drawing.Point(0, 0);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(800, 450);
            this.AddPanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.AddRecreationalButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.AddRestaurantButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.AddCinemaButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.AddStoreButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 100);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 350);
            this.panel2.TabIndex = 3;
            // 
            // AddStoreButton
            // 
            this.AddStoreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddStoreButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddStoreButton.FlatAppearance.BorderSize = 0;
            this.AddStoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStoreButton.Location = new System.Drawing.Point(3, 74);
            this.AddStoreButton.Name = "AddStoreButton";
            this.AddStoreButton.Size = new System.Drawing.Size(194, 23);
            this.AddStoreButton.TabIndex = 0;
            this.AddStoreButton.Text = "button1";
            this.AddStoreButton.UseVisualStyleBackColor = false;
            // 
            // AddCinemaButton
            // 
            this.AddCinemaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddCinemaButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddCinemaButton.FlatAppearance.BorderSize = 0;
            this.AddCinemaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCinemaButton.Location = new System.Drawing.Point(203, 74);
            this.AddCinemaButton.Name = "AddCinemaButton";
            this.AddCinemaButton.Size = new System.Drawing.Size(194, 23);
            this.AddCinemaButton.TabIndex = 1;
            this.AddCinemaButton.Text = "button2";
            this.AddCinemaButton.UseVisualStyleBackColor = false;
            // 
            // AddRestaurantButton
            // 
            this.AddRestaurantButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddRestaurantButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddRestaurantButton.FlatAppearance.BorderSize = 0;
            this.AddRestaurantButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRestaurantButton.Location = new System.Drawing.Point(403, 74);
            this.AddRestaurantButton.Name = "AddRestaurantButton";
            this.AddRestaurantButton.Size = new System.Drawing.Size(194, 23);
            this.AddRestaurantButton.TabIndex = 2;
            this.AddRestaurantButton.Text = "button3";
            this.AddRestaurantButton.UseVisualStyleBackColor = false;
            // 
            // AddRecreationalButton
            // 
            this.AddRecreationalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddRecreationalButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddRecreationalButton.FlatAppearance.BorderSize = 0;
            this.AddRecreationalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRecreationalButton.Location = new System.Drawing.Point(603, 74);
            this.AddRecreationalButton.Name = "AddRecreationalButton";
            this.AddRecreationalButton.Size = new System.Drawing.Size(194, 23);
            this.AddRecreationalButton.TabIndex = 3;
            this.AddRecreationalButton.Text = "button4";
            this.AddRecreationalButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddPanel);
            this.Controls.Add(this.BasePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.BasePanel.ResumeLayout(false);
            this.AddPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BasePanel;
        private System.Windows.Forms.Button AddLocal;
        private System.Windows.Forms.Button LocalInfo;
        private System.Windows.Forms.Button ViewLocals;
        private System.Windows.Forms.Panel PhotoPanel;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button AddRecreationalButton;
        private System.Windows.Forms.Button AddRestaurantButton;
        private System.Windows.Forms.Button AddCinemaButton;
        private System.Windows.Forms.Button AddStoreButton;
    }
}

