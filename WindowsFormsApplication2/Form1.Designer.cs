namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ksiazkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsApplication2.Database1DataSet();
            this.ksiazkaTableAdapter = new WindowsFormsApplication2.Database1DataSetTableAdapters.ksiazkaTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication2.Database1DataSetTableAdapters.TableAdapterManager();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.contextMenuStrip5 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip5 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.biodataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.użytkownicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajUsuńProduktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sprzedazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raportSprzedażyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raportDobowyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uzytkownicyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKategorięToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dostawcyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajUsunDostawceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.narzedziaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Dostawcy = new System.Windows.Forms.Button();
            this.contextMenuStrip6 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Produkty = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.eventLog2 = new System.Diagnostics.EventLog();
            this.eventLog3 = new System.Diagnostics.EventLog();
            this.ksiazkaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new WindowsFormsApplication2.Database1DataSet1();
            this.ksiazkaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ksiazkaTableAdapter1 = new WindowsFormsApplication2.Database1DataSet1TableAdapters.ksiazkaTableAdapter();
            this.Szukaj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labSzukaj = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip4.SuspendLayout();
            this.menuStrip5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ksiazkaBindingSource
            // 
            this.ksiazkaBindingSource.DataMember = "ksiazka";
            this.ksiazkaBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ksiazkaTableAdapter
            // 
            this.ksiazkaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ksiazkaTableAdapter = this.ksiazkaTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication2.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.database1DataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CausesValidation = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataGridView1.Location = new System.Drawing.Point(53, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(773, 279);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 205);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(274, 20);
            this.textBox2.TabIndex = 17;
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(182, 31);
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 23);
            // 
            // contextMenuStrip5
            // 
            this.contextMenuStrip5.Name = "contextMenuStrip5";
            this.contextMenuStrip5.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip5
            // 
            this.menuStrip5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.użytkownicyToolStripMenuItem,
            this.uzytkownicyToolStripMenuItem,
            this.dostawcyToolStripMenuItem,
            this.narzedziaToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip5.Location = new System.Drawing.Point(0, 0);
            this.menuStrip5.Name = "menuStrip5";
            this.menuStrip5.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip5.Size = new System.Drawing.Size(905, 24);
            this.menuStrip5.TabIndex = 23;
            this.menuStrip5.Text = "menuStrip5";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biodataToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(92, 20);
            this.toolStripMenuItem1.Text = "Administrator";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // biodataToolStripMenuItem
            // 
            this.biodataToolStripMenuItem.Name = "biodataToolStripMenuItem";
            this.biodataToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.biodataToolStripMenuItem.Text = "Użytkownicy";
            this.biodataToolStripMenuItem.Click += new System.EventHandler(this.biodataToolStripMenuItem_Click);
            // 
            // użytkownicyToolStripMenuItem
            // 
            this.użytkownicyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajUsuńProduktToolStripMenuItem,
            this.sprzedazToolStripMenuItem,
            this.raportSprzedażyToolStripMenuItem});
            this.użytkownicyToolStripMenuItem.Name = "użytkownicyToolStripMenuItem";
            this.użytkownicyToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.użytkownicyToolStripMenuItem.Text = "Pracownik";
            this.użytkownicyToolStripMenuItem.Click += new System.EventHandler(this.użytkownicyToolStripMenuItem_Click);
            // 
            // dodajUsuńProduktToolStripMenuItem
            // 
            this.dodajUsuńProduktToolStripMenuItem.Name = "dodajUsuńProduktToolStripMenuItem";
            this.dodajUsuńProduktToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.dodajUsuńProduktToolStripMenuItem.Text = "Magazyn";
            this.dodajUsuńProduktToolStripMenuItem.Click += new System.EventHandler(this.dodajUsuńProduktToolStripMenuItem_Click);
            // 
            // sprzedazToolStripMenuItem
            // 
            this.sprzedazToolStripMenuItem.Name = "sprzedazToolStripMenuItem";
            this.sprzedazToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.sprzedazToolStripMenuItem.Text = "Historia Sprzedaży";
            this.sprzedazToolStripMenuItem.Click += new System.EventHandler(this.sprzedazToolStripMenuItem_Click);
            // 
            // raportSprzedażyToolStripMenuItem
            // 
            this.raportSprzedażyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raportDobowyToolStripMenuItem});
            this.raportSprzedażyToolStripMenuItem.Name = "raportSprzedażyToolStripMenuItem";
            this.raportSprzedażyToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.raportSprzedażyToolStripMenuItem.Text = "Raport Sprzedaży";
            // 
            // raportDobowyToolStripMenuItem
            // 
            this.raportDobowyToolStripMenuItem.Name = "raportDobowyToolStripMenuItem";
            this.raportDobowyToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.raportDobowyToolStripMenuItem.Text = "Wydrukuj raport";
            this.raportDobowyToolStripMenuItem.Click += new System.EventHandler(this.raportDobowyToolStripMenuItem_Click);
            // 
            // uzytkownicyToolStripMenuItem
            // 
            this.uzytkownicyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajKategorięToolStripMenuItem});
            this.uzytkownicyToolStripMenuItem.Name = "uzytkownicyToolStripMenuItem";
            this.uzytkownicyToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.uzytkownicyToolStripMenuItem.Text = "Produkty";
            // 
            // dodajKategorięToolStripMenuItem
            // 
            this.dodajKategorięToolStripMenuItem.Name = "dodajKategorięToolStripMenuItem";
            this.dodajKategorięToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.dodajKategorięToolStripMenuItem.Text = "Dodaj Kategorię";
            this.dodajKategorięToolStripMenuItem.Click += new System.EventHandler(this.dodajKategorięToolStripMenuItem_Click);
            // 
            // dostawcyToolStripMenuItem
            // 
            this.dostawcyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajUsunDostawceToolStripMenuItem});
            this.dostawcyToolStripMenuItem.Name = "dostawcyToolStripMenuItem";
            this.dostawcyToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.dostawcyToolStripMenuItem.Text = "Dostawcy";
            // 
            // dodajUsunDostawceToolStripMenuItem
            // 
            this.dodajUsunDostawceToolStripMenuItem.Name = "dodajUsunDostawceToolStripMenuItem";
            this.dodajUsunDostawceToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.dodajUsunDostawceToolStripMenuItem.Text = "Dodaj/Usun Dostawce";
            this.dodajUsunDostawceToolStripMenuItem.Click += new System.EventHandler(this.dodajUsunDostawceToolStripMenuItem_Click);
            // 
            // narzedziaToolStripMenuItem
            // 
            this.narzedziaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcjeToolStripMenuItem});
            this.narzedziaToolStripMenuItem.Name = "narzedziaToolStripMenuItem";
            this.narzedziaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.narzedziaToolStripMenuItem.Text = "Narzędzia";
            // 
            // opcjeToolStripMenuItem
            // 
            this.opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            this.opcjeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.opcjeToolStripMenuItem.Text = "Opcje";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 565);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(905, 22);
            this.statusStrip1.TabIndex = 24;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(231, 170);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 21);
            this.comboBox1.TabIndex = 25;
            // 
            // Dostawcy
            // 
            this.Dostawcy.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Dostawcy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Dostawcy.BackgroundImage")));
            this.Dostawcy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Dostawcy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dostawcy.FlatAppearance.BorderSize = 0;
            this.Dostawcy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dostawcy.Location = new System.Drawing.Point(39, 27);
            this.Dostawcy.Name = "Dostawcy";
            this.Dostawcy.Size = new System.Drawing.Size(76, 88);
            this.Dostawcy.TabIndex = 26;
            this.Dostawcy.Text = "Dostawcy";
            this.Dostawcy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Dostawcy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Dostawcy.UseVisualStyleBackColor = false;
            this.Dostawcy.Click += new System.EventHandler(this.button7_Click);
            // 
            // contextMenuStrip6
            // 
            this.contextMenuStrip6.Name = "contextMenuStrip6";
            this.contextMenuStrip6.Size = new System.Drawing.Size(61, 4);
            // 
            // Produkty
            // 
            this.Produkty.AutoSize = true;
            this.Produkty.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Produkty.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Produkty.BackgroundImage")));
            this.Produkty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Produkty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Produkty.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.Produkty.FlatAppearance.BorderSize = 0;
            this.Produkty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.Produkty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Produkty.Location = new System.Drawing.Point(146, 27);
            this.Produkty.Name = "Produkty";
            this.Produkty.Size = new System.Drawing.Size(76, 88);
            this.Produkty.TabIndex = 29;
            this.Produkty.Text = "Produkty";
            this.Produkty.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Produkty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Produkty.UseVisualStyleBackColor = false;
            this.Produkty.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // eventLog2
            // 
            this.eventLog2.SynchronizingObject = this;
            // 
            // eventLog3
            // 
            this.eventLog3.SynchronizingObject = this;
            // 
            // ksiazkaBindingSource1
            // 
            this.ksiazkaBindingSource1.DataMember = "ksiazka";
            this.ksiazkaBindingSource1.DataSource = this.database1DataSet;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ksiazkaBindingSource2
            // 
            this.ksiazkaBindingSource2.DataMember = "ksiazka";
            this.ksiazkaBindingSource2.DataSource = this.database1DataSet1;
            // 
            // ksiazkaTableAdapter1
            // 
            this.ksiazkaTableAdapter1.ClearBeforeFill = true;
            // 
            // Szukaj
            // 
            this.Szukaj.Location = new System.Drawing.Point(312, 205);
            this.Szukaj.Name = "Szukaj";
            this.Szukaj.Size = new System.Drawing.Size(65, 23);
            this.Szukaj.TabIndex = 33;
            this.Szukaj.Text = "Szukaj";
            this.Szukaj.UseVisualStyleBackColor = true;
            this.Szukaj.Click += new System.EventHandler(this.Szukaj_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(253, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 88);
            this.button1.TabIndex = 34;
            this.button1.Text = "Sprzedaż";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // labSzukaj
            // 
            this.labSzukaj.AutoSize = true;
            this.labSzukaj.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labSzukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labSzukaj.Location = new System.Drawing.Point(141, 162);
            this.labSzukaj.Name = "labSzukaj";
            this.labSzukaj.Size = new System.Drawing.Size(84, 29);
            this.labSzukaj.TabIndex = 35;
            this.labSzukaj.Text = "Szukaj";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 565);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 565);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 565);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Nazwa użytkownika";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(906, 462);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(905, 587);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labSzukaj);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Szukaj);
            this.Controls.Add(this.Produkty);
            this.Controls.Add(this.Dostawcy);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip5);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Księgarnia";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip4.ResumeLayout(false);
            this.menuStrip5.ResumeLayout(false);
            this.menuStrip5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource ksiazkaBindingSource;
        private Database1DataSetTableAdapters.ksiazkaTableAdapter ksiazkaTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip5;
        private System.Windows.Forms.MenuStrip menuStrip5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Dostawcy;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem użytkownicyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uzytkownicyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dostawcyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem narzedziaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip6;
        private System.Windows.Forms.Button Produkty;
        private System.Diagnostics.EventLog eventLog1;
        private System.Diagnostics.EventLog eventLog2;
        private System.Diagnostics.EventLog eventLog3;
        private System.Windows.Forms.BindingSource ksiazkaBindingSource1;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource ksiazkaBindingSource2;
        private Database1DataSet1TableAdapters.ksiazkaTableAdapter ksiazkaTableAdapter1;
        private System.Windows.Forms.ToolStripMenuItem biodataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajUsuńProduktToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sprzedazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajUsunDostawceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajKategorięToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
        private System.Windows.Forms.Button Szukaj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labSzukaj;
        private System.Windows.Forms.ToolStripMenuItem raportSprzedażyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raportDobowyToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

