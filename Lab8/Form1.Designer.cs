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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AddPanel = new System.Windows.Forms.Panel();
            this.AddHolder = new System.Windows.Forms.Panel();
            this.StorePanel = new System.Windows.Forms.TableLayoutPanel();
            this.OwnerLableStore = new System.Windows.Forms.Label();
            this.IdLabelStore = new System.Windows.Forms.Label();
            this.ScheduleLabelStore = new System.Windows.Forms.Label();
            this.CategoryLabelStore = new System.Windows.Forms.Label();
            this.StoreNameTextBox = new System.Windows.Forms.TextBox();
            this.StoreIDLabel = new System.Windows.Forms.TextBox();
            this.StoreSheduleLabel = new System.Windows.Forms.TextBox();
            this.StoreCategoryLabel = new System.Windows.Forms.TextBox();
            this.FinalAddStore = new System.Windows.Forms.Button();
            this.UsedIdStore = new System.Windows.Forms.Label();
            this.RecreationalPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RecreationalNameLabel = new System.Windows.Forms.Label();
            this.RecreationalIDLabel = new System.Windows.Forms.Label();
            this.RecreationalScheduleLabel = new System.Windows.Forms.Label();
            this.RecreationalNameTextBox = new System.Windows.Forms.TextBox();
            this.RecreationalIDTextBox = new System.Windows.Forms.TextBox();
            this.RecreationalScheduleTextBox = new System.Windows.Forms.TextBox();
            this.FinalAddRecreational = new System.Windows.Forms.Button();
            this.UsedIdRecreationalLabel = new System.Windows.Forms.Label();
            this.RestaurantPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RestaurantNameLabel = new System.Windows.Forms.Label();
            this.RestaurantIdLabel = new System.Windows.Forms.Label();
            this.RestaurantScheduleLabel = new System.Windows.Forms.Label();
            this.RestaurantPrivateLabel = new System.Windows.Forms.Label();
            this.RestaurantNameTextBox = new System.Windows.Forms.TextBox();
            this.RestaurantIDTextBox = new System.Windows.Forms.TextBox();
            this.RestaurantScheduleTextBox = new System.Windows.Forms.TextBox();
            this.RestaurantPrivateTextBox = new System.Windows.Forms.TextBox();
            this.FinalAddRestaurant = new System.Windows.Forms.Button();
            this.UsedIdRestaurantLabel = new System.Windows.Forms.Label();
            this.CinemaPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CinemaOwnerLabel = new System.Windows.Forms.Label();
            this.CinemaIDLabel = new System.Windows.Forms.Label();
            this.CinemaScheduleLabel = new System.Windows.Forms.Label();
            this.CinemaRoomsLabel = new System.Windows.Forms.Label();
            this.CinemaNameTextBox = new System.Windows.Forms.TextBox();
            this.CinemaIDTextBox = new System.Windows.Forms.TextBox();
            this.CinemaScheduleTextBox = new System.Windows.Forms.TextBox();
            this.CinemaNofRoomsLabel = new System.Windows.Forms.TextBox();
            this.FinalAddCinema = new System.Windows.Forms.Button();
            this.UsedIdCinemaLabel = new System.Windows.Forms.Label();
            this.TopBottonHolder = new System.Windows.Forms.TableLayoutPanel();
            this.BackButtomAdding = new System.Windows.Forms.Button();
            this.AddRecreationalButton = new System.Windows.Forms.Button();
            this.AddRestaurantButton = new System.Windows.Forms.Button();
            this.AddCinemaButton = new System.Windows.Forms.Button();
            this.AddStoreButton = new System.Windows.Forms.Button();
            this.BasePanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddLocal = new System.Windows.Forms.Button();
            this.ViewLocals = new System.Windows.Forms.Button();
            this.AddPanel.SuspendLayout();
            this.AddHolder.SuspendLayout();
            this.StorePanel.SuspendLayout();
            this.RecreationalPanel.SuspendLayout();
            this.RestaurantPanel.SuspendLayout();
            this.CinemaPanel.SuspendLayout();
            this.TopBottonHolder.SuspendLayout();
            this.BasePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddPanel
            // 
            this.AddPanel.BackColor = System.Drawing.Color.DimGray;
            this.AddPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddPanel.BackgroundImage")));
            this.AddPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddPanel.Controls.Add(this.AddHolder);
            this.AddPanel.Controls.Add(this.TopBottonHolder);
            this.AddPanel.Location = new System.Drawing.Point(276, 15);
            this.AddPanel.Name = "AddPanel";
            this.AddPanel.Size = new System.Drawing.Size(171, 97);
            this.AddPanel.TabIndex = 1;
            this.AddPanel.Visible = false;
            // 
            // AddHolder
            // 
            this.AddHolder.Controls.Add(this.StorePanel);
            this.AddHolder.Controls.Add(this.RecreationalPanel);
            this.AddHolder.Controls.Add(this.RestaurantPanel);
            this.AddHolder.Controls.Add(this.CinemaPanel);
            this.AddHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddHolder.Location = new System.Drawing.Point(0, 100);
            this.AddHolder.Name = "AddHolder";
            this.AddHolder.Size = new System.Drawing.Size(171, 0);
            this.AddHolder.TabIndex = 3;
            // 
            // StorePanel
            // 
            this.StorePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StorePanel.ColumnCount = 4;
            this.StorePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.StorePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.StorePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StorePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.StorePanel.Controls.Add(this.OwnerLableStore, 1, 1);
            this.StorePanel.Controls.Add(this.IdLabelStore, 1, 2);
            this.StorePanel.Controls.Add(this.ScheduleLabelStore, 1, 3);
            this.StorePanel.Controls.Add(this.CategoryLabelStore, 1, 4);
            this.StorePanel.Controls.Add(this.StoreNameTextBox, 2, 1);
            this.StorePanel.Controls.Add(this.StoreIDLabel, 2, 2);
            this.StorePanel.Controls.Add(this.StoreSheduleLabel, 2, 3);
            this.StorePanel.Controls.Add(this.StoreCategoryLabel, 2, 4);
            this.StorePanel.Controls.Add(this.FinalAddStore, 2, 5);
            this.StorePanel.Controls.Add(this.UsedIdStore, 3, 2);
            this.StorePanel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.StorePanel.Location = new System.Drawing.Point(12, 6);
            this.StorePanel.Name = "StorePanel";
            this.StorePanel.RowCount = 6;
            this.StorePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.15384F));
            this.StorePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.42308F));
            this.StorePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.42308F));
            this.StorePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.42308F));
            this.StorePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.42308F));
            this.StorePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.15384F));
            this.StorePanel.Size = new System.Drawing.Size(200, 100);
            this.StorePanel.TabIndex = 0;
            // 
            // OwnerLableStore
            // 
            this.OwnerLableStore.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OwnerLableStore.AutoSize = true;
            this.OwnerLableStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.OwnerLableStore.Location = new System.Drawing.Point(24, 21);
            this.OwnerLableStore.Name = "OwnerLableStore";
            this.OwnerLableStore.Size = new System.Drawing.Size(53, 14);
            this.OwnerLableStore.TabIndex = 0;
            this.OwnerLableStore.Text = "Owner\'s name";
            this.OwnerLableStore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IdLabelStore
            // 
            this.IdLabelStore.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.IdLabelStore.AutoSize = true;
            this.IdLabelStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.IdLabelStore.Location = new System.Drawing.Point(30, 35);
            this.IdLabelStore.Name = "IdLabelStore";
            this.IdLabelStore.Size = new System.Drawing.Size(47, 14);
            this.IdLabelStore.TabIndex = 1;
            this.IdLabelStore.Text = "Store\'s ID";
            this.IdLabelStore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScheduleLabelStore
            // 
            this.ScheduleLabelStore.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ScheduleLabelStore.AutoSize = true;
            this.ScheduleLabelStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.ScheduleLabelStore.Location = new System.Drawing.Point(26, 49);
            this.ScheduleLabelStore.Name = "ScheduleLabelStore";
            this.ScheduleLabelStore.Size = new System.Drawing.Size(51, 14);
            this.ScheduleLabelStore.TabIndex = 2;
            this.ScheduleLabelStore.Text = "Store\'s Schedule";
            this.ScheduleLabelStore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CategoryLabelStore
            // 
            this.CategoryLabelStore.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CategoryLabelStore.AutoSize = true;
            this.CategoryLabelStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.CategoryLabelStore.Location = new System.Drawing.Point(25, 63);
            this.CategoryLabelStore.Name = "CategoryLabelStore";
            this.CategoryLabelStore.Size = new System.Drawing.Size(52, 14);
            this.CategoryLabelStore.TabIndex = 3;
            this.CategoryLabelStore.Text = "Store\'s Category";
            this.CategoryLabelStore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StoreNameTextBox
            // 
            this.StoreNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StoreNameTextBox.Location = new System.Drawing.Point(83, 24);
            this.StoreNameTextBox.Name = "StoreNameTextBox";
            this.StoreNameTextBox.Size = new System.Drawing.Size(94, 20);
            this.StoreNameTextBox.TabIndex = 4;
            // 
            // StoreIDLabel
            // 
            this.StoreIDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StoreIDLabel.Location = new System.Drawing.Point(83, 38);
            this.StoreIDLabel.Name = "StoreIDLabel";
            this.StoreIDLabel.Size = new System.Drawing.Size(94, 20);
            this.StoreIDLabel.TabIndex = 5;
            // 
            // StoreSheduleLabel
            // 
            this.StoreSheduleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StoreSheduleLabel.Location = new System.Drawing.Point(83, 52);
            this.StoreSheduleLabel.Name = "StoreSheduleLabel";
            this.StoreSheduleLabel.Size = new System.Drawing.Size(94, 20);
            this.StoreSheduleLabel.TabIndex = 6;
            // 
            // StoreCategoryLabel
            // 
            this.StoreCategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StoreCategoryLabel.Location = new System.Drawing.Point(83, 66);
            this.StoreCategoryLabel.Name = "StoreCategoryLabel";
            this.StoreCategoryLabel.Size = new System.Drawing.Size(94, 20);
            this.StoreCategoryLabel.TabIndex = 7;
            // 
            // FinalAddStore
            // 
            this.FinalAddStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FinalAddStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FinalAddStore.FlatAppearance.BorderSize = 0;
            this.FinalAddStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinalAddStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalAddStore.Location = new System.Drawing.Point(83, 80);
            this.FinalAddStore.Name = "FinalAddStore";
            this.FinalAddStore.Size = new System.Drawing.Size(94, 17);
            this.FinalAddStore.TabIndex = 9;
            this.FinalAddStore.Text = "Add To DataBase";
            this.FinalAddStore.UseVisualStyleBackColor = false;
            this.FinalAddStore.Click += new System.EventHandler(this.FinalAddStore_Click);
            // 
            // UsedIdStore
            // 
            this.UsedIdStore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UsedIdStore.AutoSize = true;
            this.UsedIdStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsedIdStore.ForeColor = System.Drawing.Color.Maroon;
            this.UsedIdStore.Location = new System.Drawing.Point(183, 35);
            this.UsedIdStore.Name = "UsedIdStore";
            this.UsedIdStore.Size = new System.Drawing.Size(14, 14);
            this.UsedIdStore.TabIndex = 10;
            this.UsedIdStore.Text = "Id alredy in DataBase";
            this.UsedIdStore.Visible = false;
            // 
            // RecreationalPanel
            // 
            this.RecreationalPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RecreationalPanel.ColumnCount = 4;
            this.RecreationalPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.RecreationalPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.RecreationalPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RecreationalPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.RecreationalPanel.Controls.Add(this.RecreationalNameLabel, 1, 1);
            this.RecreationalPanel.Controls.Add(this.RecreationalIDLabel, 1, 2);
            this.RecreationalPanel.Controls.Add(this.RecreationalScheduleLabel, 1, 3);
            this.RecreationalPanel.Controls.Add(this.RecreationalNameTextBox, 2, 1);
            this.RecreationalPanel.Controls.Add(this.RecreationalIDTextBox, 2, 2);
            this.RecreationalPanel.Controls.Add(this.RecreationalScheduleTextBox, 2, 3);
            this.RecreationalPanel.Controls.Add(this.FinalAddRecreational, 2, 5);
            this.RecreationalPanel.Controls.Add(this.UsedIdRecreationalLabel, 3, 2);
            this.RecreationalPanel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.RecreationalPanel.Location = new System.Drawing.Point(235, 126);
            this.RecreationalPanel.Name = "RecreationalPanel";
            this.RecreationalPanel.RowCount = 6;
            this.RecreationalPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.15384F));
            this.RecreationalPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.42308F));
            this.RecreationalPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.42308F));
            this.RecreationalPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.42308F));
            this.RecreationalPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.42308F));
            this.RecreationalPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.15384F));
            this.RecreationalPanel.Size = new System.Drawing.Size(200, 100);
            this.RecreationalPanel.TabIndex = 5;
            this.RecreationalPanel.Visible = false;
            // 
            // RecreationalNameLabel
            // 
            this.RecreationalNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RecreationalNameLabel.AutoSize = true;
            this.RecreationalNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.RecreationalNameLabel.Location = new System.Drawing.Point(24, 21);
            this.RecreationalNameLabel.Name = "RecreationalNameLabel";
            this.RecreationalNameLabel.Size = new System.Drawing.Size(53, 14);
            this.RecreationalNameLabel.TabIndex = 0;
            this.RecreationalNameLabel.Text = "Owner\'s name";
            this.RecreationalNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecreationalIDLabel
            // 
            this.RecreationalIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RecreationalIDLabel.AutoSize = true;
            this.RecreationalIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.RecreationalIDLabel.Location = new System.Drawing.Point(23, 35);
            this.RecreationalIDLabel.Name = "RecreationalIDLabel";
            this.RecreationalIDLabel.Size = new System.Drawing.Size(54, 14);
            this.RecreationalIDLabel.TabIndex = 1;
            this.RecreationalIDLabel.Text = "Recreational\'s ID";
            this.RecreationalIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecreationalScheduleLabel
            // 
            this.RecreationalScheduleLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RecreationalScheduleLabel.AutoSize = true;
            this.RecreationalScheduleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.RecreationalScheduleLabel.Location = new System.Drawing.Point(23, 49);
            this.RecreationalScheduleLabel.Name = "RecreationalScheduleLabel";
            this.RecreationalScheduleLabel.Size = new System.Drawing.Size(54, 14);
            this.RecreationalScheduleLabel.TabIndex = 2;
            this.RecreationalScheduleLabel.Text = "Recreational\'s Schedule";
            this.RecreationalScheduleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecreationalNameTextBox
            // 
            this.RecreationalNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RecreationalNameTextBox.Location = new System.Drawing.Point(83, 24);
            this.RecreationalNameTextBox.Name = "RecreationalNameTextBox";
            this.RecreationalNameTextBox.Size = new System.Drawing.Size(94, 20);
            this.RecreationalNameTextBox.TabIndex = 4;
            // 
            // RecreationalIDTextBox
            // 
            this.RecreationalIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RecreationalIDTextBox.Location = new System.Drawing.Point(83, 38);
            this.RecreationalIDTextBox.Name = "RecreationalIDTextBox";
            this.RecreationalIDTextBox.Size = new System.Drawing.Size(94, 20);
            this.RecreationalIDTextBox.TabIndex = 5;
            // 
            // RecreationalScheduleTextBox
            // 
            this.RecreationalScheduleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RecreationalScheduleTextBox.Location = new System.Drawing.Point(83, 52);
            this.RecreationalScheduleTextBox.Name = "RecreationalScheduleTextBox";
            this.RecreationalScheduleTextBox.Size = new System.Drawing.Size(94, 20);
            this.RecreationalScheduleTextBox.TabIndex = 6;
            // 
            // FinalAddRecreational
            // 
            this.FinalAddRecreational.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FinalAddRecreational.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FinalAddRecreational.FlatAppearance.BorderSize = 0;
            this.FinalAddRecreational.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinalAddRecreational.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalAddRecreational.Location = new System.Drawing.Point(83, 80);
            this.FinalAddRecreational.Name = "FinalAddRecreational";
            this.FinalAddRecreational.Size = new System.Drawing.Size(94, 17);
            this.FinalAddRecreational.TabIndex = 8;
            this.FinalAddRecreational.Text = "Add To DataBase";
            this.FinalAddRecreational.UseVisualStyleBackColor = false;
            this.FinalAddRecreational.Click += new System.EventHandler(this.FinalAddRecreational_Click);
            // 
            // UsedIdRecreationalLabel
            // 
            this.UsedIdRecreationalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UsedIdRecreationalLabel.AutoSize = true;
            this.UsedIdRecreationalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsedIdRecreationalLabel.ForeColor = System.Drawing.Color.Maroon;
            this.UsedIdRecreationalLabel.Location = new System.Drawing.Point(183, 35);
            this.UsedIdRecreationalLabel.Name = "UsedIdRecreationalLabel";
            this.UsedIdRecreationalLabel.Size = new System.Drawing.Size(14, 14);
            this.UsedIdRecreationalLabel.TabIndex = 11;
            this.UsedIdRecreationalLabel.Text = "Id alredy in DataBase";
            this.UsedIdRecreationalLabel.Visible = false;
            // 
            // RestaurantPanel
            // 
            this.RestaurantPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RestaurantPanel.ColumnCount = 4;
            this.RestaurantPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.RestaurantPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.RestaurantPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RestaurantPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.RestaurantPanel.Controls.Add(this.RestaurantNameLabel, 1, 1);
            this.RestaurantPanel.Controls.Add(this.RestaurantIdLabel, 1, 2);
            this.RestaurantPanel.Controls.Add(this.RestaurantScheduleLabel, 1, 3);
            this.RestaurantPanel.Controls.Add(this.RestaurantPrivateLabel, 1, 4);
            this.RestaurantPanel.Controls.Add(this.RestaurantNameTextBox, 2, 1);
            this.RestaurantPanel.Controls.Add(this.RestaurantIDTextBox, 2, 2);
            this.RestaurantPanel.Controls.Add(this.RestaurantScheduleTextBox, 2, 3);
            this.RestaurantPanel.Controls.Add(this.RestaurantPrivateTextBox, 2, 4);
            this.RestaurantPanel.Controls.Add(this.FinalAddRestaurant, 2, 5);
            this.RestaurantPanel.Controls.Add(this.UsedIdRestaurantLabel, 3, 2);
            this.RestaurantPanel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.RestaurantPanel.Location = new System.Drawing.Point(235, 6);
            this.RestaurantPanel.Name = "RestaurantPanel";
            this.RestaurantPanel.RowCount = 6;
            this.RestaurantPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.15384F));
            this.RestaurantPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.42308F));
            this.RestaurantPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.42308F));
            this.RestaurantPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.42308F));
            this.RestaurantPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.42308F));
            this.RestaurantPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.15384F));
            this.RestaurantPanel.Size = new System.Drawing.Size(200, 100);
            this.RestaurantPanel.TabIndex = 4;
            this.RestaurantPanel.Visible = false;
            // 
            // RestaurantNameLabel
            // 
            this.RestaurantNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RestaurantNameLabel.AutoSize = true;
            this.RestaurantNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.RestaurantNameLabel.Location = new System.Drawing.Point(24, 21);
            this.RestaurantNameLabel.Name = "RestaurantNameLabel";
            this.RestaurantNameLabel.Size = new System.Drawing.Size(53, 14);
            this.RestaurantNameLabel.TabIndex = 0;
            this.RestaurantNameLabel.Text = "Owner\'s name";
            this.RestaurantNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RestaurantIdLabel
            // 
            this.RestaurantIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RestaurantIdLabel.AutoSize = true;
            this.RestaurantIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.RestaurantIdLabel.Location = new System.Drawing.Point(26, 35);
            this.RestaurantIdLabel.Name = "RestaurantIdLabel";
            this.RestaurantIdLabel.Size = new System.Drawing.Size(51, 14);
            this.RestaurantIdLabel.TabIndex = 1;
            this.RestaurantIdLabel.Text = "Restaurant\'s ID";
            this.RestaurantIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RestaurantScheduleLabel
            // 
            this.RestaurantScheduleLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RestaurantScheduleLabel.AutoSize = true;
            this.RestaurantScheduleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.RestaurantScheduleLabel.Location = new System.Drawing.Point(26, 49);
            this.RestaurantScheduleLabel.Name = "RestaurantScheduleLabel";
            this.RestaurantScheduleLabel.Size = new System.Drawing.Size(51, 14);
            this.RestaurantScheduleLabel.TabIndex = 2;
            this.RestaurantScheduleLabel.Text = "Restaurant\'s Schedule";
            this.RestaurantScheduleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RestaurantPrivateLabel
            // 
            this.RestaurantPrivateLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RestaurantPrivateLabel.AutoSize = true;
            this.RestaurantPrivateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.RestaurantPrivateLabel.Location = new System.Drawing.Point(25, 63);
            this.RestaurantPrivateLabel.Name = "RestaurantPrivateLabel";
            this.RestaurantPrivateLabel.Size = new System.Drawing.Size(52, 14);
            this.RestaurantPrivateLabel.TabIndex = 3;
            this.RestaurantPrivateLabel.Text = "Restaurant has exclusive tables (True/False) ";
            this.RestaurantPrivateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RestaurantNameTextBox
            // 
            this.RestaurantNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RestaurantNameTextBox.Location = new System.Drawing.Point(83, 24);
            this.RestaurantNameTextBox.Name = "RestaurantNameTextBox";
            this.RestaurantNameTextBox.Size = new System.Drawing.Size(94, 20);
            this.RestaurantNameTextBox.TabIndex = 4;
            // 
            // RestaurantIDTextBox
            // 
            this.RestaurantIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RestaurantIDTextBox.Location = new System.Drawing.Point(83, 38);
            this.RestaurantIDTextBox.Name = "RestaurantIDTextBox";
            this.RestaurantIDTextBox.Size = new System.Drawing.Size(94, 20);
            this.RestaurantIDTextBox.TabIndex = 5;
            // 
            // RestaurantScheduleTextBox
            // 
            this.RestaurantScheduleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RestaurantScheduleTextBox.Location = new System.Drawing.Point(83, 52);
            this.RestaurantScheduleTextBox.Name = "RestaurantScheduleTextBox";
            this.RestaurantScheduleTextBox.Size = new System.Drawing.Size(94, 20);
            this.RestaurantScheduleTextBox.TabIndex = 6;
            // 
            // RestaurantPrivateTextBox
            // 
            this.RestaurantPrivateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RestaurantPrivateTextBox.Location = new System.Drawing.Point(83, 66);
            this.RestaurantPrivateTextBox.Name = "RestaurantPrivateTextBox";
            this.RestaurantPrivateTextBox.Size = new System.Drawing.Size(94, 20);
            this.RestaurantPrivateTextBox.TabIndex = 7;
            // 
            // FinalAddRestaurant
            // 
            this.FinalAddRestaurant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FinalAddRestaurant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FinalAddRestaurant.FlatAppearance.BorderSize = 0;
            this.FinalAddRestaurant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinalAddRestaurant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalAddRestaurant.Location = new System.Drawing.Point(83, 80);
            this.FinalAddRestaurant.Name = "FinalAddRestaurant";
            this.FinalAddRestaurant.Size = new System.Drawing.Size(94, 17);
            this.FinalAddRestaurant.TabIndex = 8;
            this.FinalAddRestaurant.Text = "Add To DataBase";
            this.FinalAddRestaurant.UseVisualStyleBackColor = false;
            this.FinalAddRestaurant.Click += new System.EventHandler(this.FinalAddRestaurant_Click);
            // 
            // UsedIdRestaurantLabel
            // 
            this.UsedIdRestaurantLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UsedIdRestaurantLabel.AutoSize = true;
            this.UsedIdRestaurantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsedIdRestaurantLabel.ForeColor = System.Drawing.Color.Maroon;
            this.UsedIdRestaurantLabel.Location = new System.Drawing.Point(183, 35);
            this.UsedIdRestaurantLabel.Name = "UsedIdRestaurantLabel";
            this.UsedIdRestaurantLabel.Size = new System.Drawing.Size(14, 14);
            this.UsedIdRestaurantLabel.TabIndex = 11;
            this.UsedIdRestaurantLabel.Text = "Id alredy in DataBase";
            this.UsedIdRestaurantLabel.Visible = false;
            // 
            // CinemaPanel
            // 
            this.CinemaPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CinemaPanel.ColumnCount = 4;
            this.CinemaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.CinemaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.CinemaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CinemaPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.CinemaPanel.Controls.Add(this.CinemaOwnerLabel, 1, 1);
            this.CinemaPanel.Controls.Add(this.CinemaIDLabel, 1, 2);
            this.CinemaPanel.Controls.Add(this.CinemaScheduleLabel, 1, 3);
            this.CinemaPanel.Controls.Add(this.CinemaRoomsLabel, 1, 4);
            this.CinemaPanel.Controls.Add(this.CinemaNameTextBox, 2, 1);
            this.CinemaPanel.Controls.Add(this.CinemaIDTextBox, 2, 2);
            this.CinemaPanel.Controls.Add(this.CinemaScheduleTextBox, 2, 3);
            this.CinemaPanel.Controls.Add(this.CinemaNofRoomsLabel, 2, 4);
            this.CinemaPanel.Controls.Add(this.FinalAddCinema, 2, 5);
            this.CinemaPanel.Controls.Add(this.UsedIdCinemaLabel, 3, 2);
            this.CinemaPanel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.CinemaPanel.Location = new System.Drawing.Point(12, 126);
            this.CinemaPanel.Name = "CinemaPanel";
            this.CinemaPanel.RowCount = 6;
            this.CinemaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.15384F));
            this.CinemaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.42308F));
            this.CinemaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.42308F));
            this.CinemaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.42308F));
            this.CinemaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.42308F));
            this.CinemaPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.15384F));
            this.CinemaPanel.Size = new System.Drawing.Size(200, 100);
            this.CinemaPanel.TabIndex = 3;
            this.CinemaPanel.Visible = false;
            // 
            // CinemaOwnerLabel
            // 
            this.CinemaOwnerLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CinemaOwnerLabel.AutoSize = true;
            this.CinemaOwnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.CinemaOwnerLabel.Location = new System.Drawing.Point(24, 21);
            this.CinemaOwnerLabel.Name = "CinemaOwnerLabel";
            this.CinemaOwnerLabel.Size = new System.Drawing.Size(53, 14);
            this.CinemaOwnerLabel.TabIndex = 0;
            this.CinemaOwnerLabel.Text = "Owner\'s name";
            this.CinemaOwnerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CinemaIDLabel
            // 
            this.CinemaIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CinemaIDLabel.AutoSize = true;
            this.CinemaIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.CinemaIDLabel.Location = new System.Drawing.Point(24, 35);
            this.CinemaIDLabel.Name = "CinemaIDLabel";
            this.CinemaIDLabel.Size = new System.Drawing.Size(53, 14);
            this.CinemaIDLabel.TabIndex = 1;
            this.CinemaIDLabel.Text = "Cinema\'s ID";
            this.CinemaIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CinemaScheduleLabel
            // 
            this.CinemaScheduleLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CinemaScheduleLabel.AutoSize = true;
            this.CinemaScheduleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.CinemaScheduleLabel.Location = new System.Drawing.Point(24, 49);
            this.CinemaScheduleLabel.Name = "CinemaScheduleLabel";
            this.CinemaScheduleLabel.Size = new System.Drawing.Size(53, 14);
            this.CinemaScheduleLabel.TabIndex = 2;
            this.CinemaScheduleLabel.Text = "Cinema\'s Schedule";
            this.CinemaScheduleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CinemaRoomsLabel
            // 
            this.CinemaRoomsLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CinemaRoomsLabel.AutoSize = true;
            this.CinemaRoomsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.CinemaRoomsLabel.Location = new System.Drawing.Point(24, 63);
            this.CinemaRoomsLabel.Name = "CinemaRoomsLabel";
            this.CinemaRoomsLabel.Size = new System.Drawing.Size(53, 14);
            this.CinemaRoomsLabel.TabIndex = 3;
            this.CinemaRoomsLabel.Text = "Cinema\'s N of rooms";
            this.CinemaRoomsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CinemaNameTextBox
            // 
            this.CinemaNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CinemaNameTextBox.Location = new System.Drawing.Point(83, 24);
            this.CinemaNameTextBox.Name = "CinemaNameTextBox";
            this.CinemaNameTextBox.Size = new System.Drawing.Size(94, 20);
            this.CinemaNameTextBox.TabIndex = 4;
            // 
            // CinemaIDTextBox
            // 
            this.CinemaIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CinemaIDTextBox.Location = new System.Drawing.Point(83, 38);
            this.CinemaIDTextBox.Name = "CinemaIDTextBox";
            this.CinemaIDTextBox.Size = new System.Drawing.Size(94, 20);
            this.CinemaIDTextBox.TabIndex = 5;
            // 
            // CinemaScheduleTextBox
            // 
            this.CinemaScheduleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CinemaScheduleTextBox.Location = new System.Drawing.Point(83, 52);
            this.CinemaScheduleTextBox.Name = "CinemaScheduleTextBox";
            this.CinemaScheduleTextBox.Size = new System.Drawing.Size(94, 20);
            this.CinemaScheduleTextBox.TabIndex = 6;
            // 
            // CinemaNofRoomsLabel
            // 
            this.CinemaNofRoomsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CinemaNofRoomsLabel.Location = new System.Drawing.Point(83, 66);
            this.CinemaNofRoomsLabel.Name = "CinemaNofRoomsLabel";
            this.CinemaNofRoomsLabel.Size = new System.Drawing.Size(94, 20);
            this.CinemaNofRoomsLabel.TabIndex = 7;
            // 
            // FinalAddCinema
            // 
            this.FinalAddCinema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FinalAddCinema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FinalAddCinema.FlatAppearance.BorderSize = 0;
            this.FinalAddCinema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinalAddCinema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalAddCinema.Location = new System.Drawing.Point(83, 80);
            this.FinalAddCinema.Name = "FinalAddCinema";
            this.FinalAddCinema.Size = new System.Drawing.Size(94, 17);
            this.FinalAddCinema.TabIndex = 8;
            this.FinalAddCinema.Text = "Add To DataBase";
            this.FinalAddCinema.UseVisualStyleBackColor = false;
            this.FinalAddCinema.Click += new System.EventHandler(this.FinalAddCinema_Click);
            // 
            // UsedIdCinemaLabel
            // 
            this.UsedIdCinemaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UsedIdCinemaLabel.AutoSize = true;
            this.UsedIdCinemaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsedIdCinemaLabel.ForeColor = System.Drawing.Color.Maroon;
            this.UsedIdCinemaLabel.Location = new System.Drawing.Point(183, 35);
            this.UsedIdCinemaLabel.Name = "UsedIdCinemaLabel";
            this.UsedIdCinemaLabel.Size = new System.Drawing.Size(14, 14);
            this.UsedIdCinemaLabel.TabIndex = 11;
            this.UsedIdCinemaLabel.Text = "Id alredy in DataBase";
            this.UsedIdCinemaLabel.Visible = false;
            // 
            // TopBottonHolder
            // 
            this.TopBottonHolder.ColumnCount = 5;
            this.TopBottonHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TopBottonHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TopBottonHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TopBottonHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TopBottonHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TopBottonHolder.Controls.Add(this.BackButtomAdding, 0, 0);
            this.TopBottonHolder.Controls.Add(this.AddRecreationalButton, 4, 0);
            this.TopBottonHolder.Controls.Add(this.AddRestaurantButton, 3, 0);
            this.TopBottonHolder.Controls.Add(this.AddCinemaButton, 2, 0);
            this.TopBottonHolder.Controls.Add(this.AddStoreButton, 1, 0);
            this.TopBottonHolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBottonHolder.Location = new System.Drawing.Point(0, 0);
            this.TopBottonHolder.Name = "TopBottonHolder";
            this.TopBottonHolder.RowCount = 1;
            this.TopBottonHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopBottonHolder.Size = new System.Drawing.Size(171, 100);
            this.TopBottonHolder.TabIndex = 2;
            // 
            // BackButtomAdding
            // 
            this.BackButtomAdding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackButtomAdding.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BackButtomAdding.FlatAppearance.BorderSize = 0;
            this.BackButtomAdding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButtomAdding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButtomAdding.Location = new System.Drawing.Point(3, 47);
            this.BackButtomAdding.Name = "BackButtomAdding";
            this.BackButtomAdding.Size = new System.Drawing.Size(28, 50);
            this.BackButtomAdding.TabIndex = 4;
            this.BackButtomAdding.Text = "Back";
            this.BackButtomAdding.UseVisualStyleBackColor = false;
            this.BackButtomAdding.Click += new System.EventHandler(this.BackButtomAdding_Click);
            // 
            // AddRecreationalButton
            // 
            this.AddRecreationalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddRecreationalButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddRecreationalButton.FlatAppearance.BorderSize = 0;
            this.AddRecreationalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRecreationalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRecreationalButton.Location = new System.Drawing.Point(139, 47);
            this.AddRecreationalButton.Name = "AddRecreationalButton";
            this.AddRecreationalButton.Size = new System.Drawing.Size(29, 50);
            this.AddRecreationalButton.TabIndex = 3;
            this.AddRecreationalButton.Text = "Add Recreational";
            this.AddRecreationalButton.UseVisualStyleBackColor = false;
            this.AddRecreationalButton.Click += new System.EventHandler(this.AddRecreationalButton_Click);
            // 
            // AddRestaurantButton
            // 
            this.AddRestaurantButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddRestaurantButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddRestaurantButton.FlatAppearance.BorderSize = 0;
            this.AddRestaurantButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRestaurantButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddRestaurantButton.Location = new System.Drawing.Point(105, 47);
            this.AddRestaurantButton.Name = "AddRestaurantButton";
            this.AddRestaurantButton.Size = new System.Drawing.Size(28, 50);
            this.AddRestaurantButton.TabIndex = 2;
            this.AddRestaurantButton.Text = "Add Restaurant";
            this.AddRestaurantButton.UseVisualStyleBackColor = false;
            this.AddRestaurantButton.Click += new System.EventHandler(this.AddRestaurantButton_Click);
            // 
            // AddCinemaButton
            // 
            this.AddCinemaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddCinemaButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddCinemaButton.FlatAppearance.BorderSize = 0;
            this.AddCinemaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCinemaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCinemaButton.Location = new System.Drawing.Point(71, 47);
            this.AddCinemaButton.Name = "AddCinemaButton";
            this.AddCinemaButton.Size = new System.Drawing.Size(28, 50);
            this.AddCinemaButton.TabIndex = 1;
            this.AddCinemaButton.Text = "Add Cinema";
            this.AddCinemaButton.UseVisualStyleBackColor = false;
            this.AddCinemaButton.Click += new System.EventHandler(this.AddCinemaButton_Click);
            // 
            // AddStoreButton
            // 
            this.AddStoreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddStoreButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddStoreButton.FlatAppearance.BorderSize = 0;
            this.AddStoreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStoreButton.Location = new System.Drawing.Point(37, 47);
            this.AddStoreButton.Name = "AddStoreButton";
            this.AddStoreButton.Size = new System.Drawing.Size(28, 50);
            this.AddStoreButton.TabIndex = 0;
            this.AddStoreButton.Text = "Add Store";
            this.AddStoreButton.UseVisualStyleBackColor = false;
            this.AddStoreButton.Click += new System.EventHandler(this.AddStoreButton_Click);
            // 
            // BasePanel
            // 
            this.BasePanel.BackColor = System.Drawing.Color.DimGray;
            this.BasePanel.BackgroundImage = global::Lab8.Properties.Resources.mall;
            this.BasePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BasePanel.ColumnCount = 1;
            this.BasePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BasePanel.Controls.Add(this.AddLocal, 0, 1);
            this.BasePanel.Controls.Add(this.ViewLocals, 0, 2);
            this.BasePanel.Location = new System.Drawing.Point(43, 15);
            this.BasePanel.Name = "BasePanel";
            this.BasePanel.RowCount = 4;
            this.BasePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BasePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BasePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.BasePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.BasePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BasePanel.Size = new System.Drawing.Size(177, 100);
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
            this.AddLocal.Location = new System.Drawing.Point(3, 53);
            this.AddLocal.Name = "AddLocal";
            this.AddLocal.Size = new System.Drawing.Size(171, 14);
            this.AddLocal.TabIndex = 0;
            this.AddLocal.Text = "Add new premise";
            this.AddLocal.UseVisualStyleBackColor = false;
            this.AddLocal.Click += new System.EventHandler(this.AddLocal_ButtonClick);
            // 
            // ViewLocals
            // 
            this.ViewLocals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ViewLocals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewLocals.FlatAppearance.BorderSize = 0;
            this.ViewLocals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewLocals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.ViewLocals.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ViewLocals.Location = new System.Drawing.Point(3, 73);
            this.ViewLocals.Name = "ViewLocals";
            this.ViewLocals.Size = new System.Drawing.Size(171, 14);
            this.ViewLocals.TabIndex = 2;
            this.ViewLocals.Text = "View current premises";
            this.ViewLocals.UseVisualStyleBackColor = false;
            this.ViewLocals.Click += new System.EventHandler(this.ViewLocals_Click);
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
            this.AddPanel.ResumeLayout(false);
            this.AddHolder.ResumeLayout(false);
            this.StorePanel.ResumeLayout(false);
            this.StorePanel.PerformLayout();
            this.RecreationalPanel.ResumeLayout(false);
            this.RecreationalPanel.PerformLayout();
            this.RestaurantPanel.ResumeLayout(false);
            this.RestaurantPanel.PerformLayout();
            this.CinemaPanel.ResumeLayout(false);
            this.CinemaPanel.PerformLayout();
            this.TopBottonHolder.ResumeLayout(false);
            this.BasePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BasePanel;
        private System.Windows.Forms.Button AddLocal;
        private System.Windows.Forms.Button ViewLocals;
        private System.Windows.Forms.Panel AddPanel;
        private System.Windows.Forms.Panel AddHolder;
        private System.Windows.Forms.TableLayoutPanel TopBottonHolder;
        private System.Windows.Forms.Button AddRecreationalButton;
        private System.Windows.Forms.Button AddRestaurantButton;
        private System.Windows.Forms.Button AddCinemaButton;
        private System.Windows.Forms.Button AddStoreButton;
        private System.Windows.Forms.TableLayoutPanel StorePanel;
        private System.Windows.Forms.Label OwnerLableStore;
        private System.Windows.Forms.Label IdLabelStore;
        private System.Windows.Forms.Label ScheduleLabelStore;
        private System.Windows.Forms.Label CategoryLabelStore;
        private System.Windows.Forms.TextBox StoreNameTextBox;
        private System.Windows.Forms.TextBox StoreIDLabel;
        private System.Windows.Forms.TextBox StoreSheduleLabel;
        private System.Windows.Forms.TextBox StoreCategoryLabel;
        private System.Windows.Forms.Button BackButtomAdding;
        private System.Windows.Forms.TableLayoutPanel CinemaPanel;
        private System.Windows.Forms.Label CinemaOwnerLabel;
        private System.Windows.Forms.Label CinemaIDLabel;
        private System.Windows.Forms.Label CinemaScheduleLabel;
        private System.Windows.Forms.Label CinemaRoomsLabel;
        private System.Windows.Forms.TextBox CinemaNameTextBox;
        private System.Windows.Forms.TextBox CinemaIDTextBox;
        private System.Windows.Forms.TextBox CinemaScheduleTextBox;
        private System.Windows.Forms.TextBox CinemaNofRoomsLabel;
        private System.Windows.Forms.TableLayoutPanel RestaurantPanel;
        private System.Windows.Forms.Label RestaurantNameLabel;
        private System.Windows.Forms.Label RestaurantIdLabel;
        private System.Windows.Forms.Label RestaurantScheduleLabel;
        private System.Windows.Forms.Label RestaurantPrivateLabel;
        private System.Windows.Forms.TextBox RestaurantNameTextBox;
        private System.Windows.Forms.TextBox RestaurantIDTextBox;
        private System.Windows.Forms.TextBox RestaurantScheduleTextBox;
        private System.Windows.Forms.TextBox RestaurantPrivateTextBox;
        private System.Windows.Forms.Button FinalAddRestaurant;
        private System.Windows.Forms.TableLayoutPanel RecreationalPanel;
        private System.Windows.Forms.Label RecreationalNameLabel;
        private System.Windows.Forms.Label RecreationalIDLabel;
        private System.Windows.Forms.Label RecreationalScheduleLabel;
        private System.Windows.Forms.TextBox RecreationalNameTextBox;
        private System.Windows.Forms.TextBox RecreationalIDTextBox;
        private System.Windows.Forms.TextBox RecreationalScheduleTextBox;
        private System.Windows.Forms.Button FinalAddRecreational;
        private System.Windows.Forms.Button FinalAddCinema;
        private System.Windows.Forms.Button FinalAddStore;
        private System.Windows.Forms.Label UsedIdStore;
        private System.Windows.Forms.Label UsedIdRecreationalLabel;
        private System.Windows.Forms.Label UsedIdRestaurantLabel;
        private System.Windows.Forms.Label UsedIdCinemaLabel;
    }
}

