namespace WindowsFormsApplication2
{
    partial class frmBookInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookInfo));
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPublisher = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ISPN = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbRodzajOkladki = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.database1DataSet1 = new WindowsFormsApplication2.Database1DataSet1();
            this.ksiazkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ksiazkaTableAdapter = new WindowsFormsApplication2.Database1DataSet1TableAdapters.ksiazkaTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.database1DataSet = new WindowsFormsApplication2.Database1DataSet();
            this.ksiazkaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ksiazkaTableAdapter1 = new WindowsFormsApplication2.Database1DataSetTableAdapters.ksiazkaTableAdapter();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.database1DataSet2 = new WindowsFormsApplication2.Database1DataSet();
            this.txtISPN = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Ilosc = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(148, 52);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(352, 20);
            this.txtTitle.TabIndex = 5;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(148, 318);
            this.nudQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(127, 20);
            this.nudQuantity.TabIndex = 8;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tytul:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Autor:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(148, 178);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(352, 21);
            this.cmbCategory.TabIndex = 11;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Wydawca:";
            // 
            // cmbPublisher
            // 
            this.cmbPublisher.FormattingEnabled = true;
            this.cmbPublisher.Location = new System.Drawing.Point(148, 220);
            this.cmbPublisher.Name = "cmbPublisher";
            this.cmbPublisher.Size = new System.Drawing.Size(352, 21);
            this.cmbPublisher.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Gatunek:";
            // 
            // ISPN
            // 
            this.ISPN.AutoSize = true;
            this.ISPN.Location = new System.Drawing.Point(107, 137);
            this.ISPN.Name = "ISPN";
            this.ISPN.Size = new System.Drawing.Size(35, 13);
            this.ISPN.TabIndex = 15;
            this.ISPN.Text = "ISPN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ilosc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Rodzaj Okładki:";
            // 
            // cmbRodzajOkladki
            // 
            this.cmbRodzajOkladki.FormattingEnabled = true;
            this.cmbRodzajOkladki.Items.AddRange(new object[] {
            "Twarda",
            "Miękka"});
            this.cmbRodzajOkladki.Location = new System.Drawing.Point(385, 274);
            this.cmbRodzajOkladki.Name = "cmbRodzajOkladki";
            this.cmbRodzajOkladki.Size = new System.Drawing.Size(115, 21);
            this.cmbRodzajOkladki.TabIndex = 19;
            this.cmbRodzajOkladki.SelectedIndexChanged += new System.EventHandler(this.cmbRodzajOkladki_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(67, 366);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 56);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Dodaj";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(168, 366);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 56);
            this.btnNew.TabIndex = 21;
            this.btnNew.Text = "Nowe";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(271, 366);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 56);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Aktualizuj";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(375, 366);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 56);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Usuń podaną ilość z magazynu";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ksiazkaBindingSource
            // 
            this.ksiazkaBindingSource.DataMember = "ksiazka";
            this.ksiazkaBindingSource.DataSource = this.database1DataSet1;
            this.ksiazkaBindingSource.CurrentChanged += new System.EventHandler(this.ksiazkaBindingSource_CurrentChanged);
            // 
            // ksiazkaTableAdapter
            // 
            this.ksiazkaTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "ID:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(148, 96);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(352, 20);
            this.txtAuthor.TabIndex = 25;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ksiazkaBindingSource1
            // 
            this.ksiazkaBindingSource1.DataMember = "ksiazka";
            this.ksiazkaBindingSource1.DataSource = this.database1DataSet;
            // 
            // ksiazkaTableAdapter1
            // 
            this.ksiazkaTableAdapter1.ClearBeforeFill = true;
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(148, 15);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(352, 20);
            this.txtBookId.TabIndex = 28;
            this.txtBookId.TextChanged += new System.EventHandler(this.txtkod_TextChanged);
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtISPN
            // 
            this.txtISPN.Location = new System.Drawing.Point(149, 137);
            this.txtISPN.Name = "txtISPN";
            this.txtISPN.Size = new System.Drawing.Size(351, 20);
            this.txtISPN.TabIndex = 29;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(149, 270);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(140, 20);
            this.txtCena.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(110, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Cena:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 56);
            this.button1.TabIndex = 32;
            this.button1.Text = "Usuń z bazy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Ilość podanego produktu w magazynie:";
            // 
            // Ilosc
            // 
            this.Ilosc.AutoSize = true;
            this.Ilosc.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ilosc.Location = new System.Drawing.Point(493, 318);
            this.Ilosc.Name = "Ilosc";
            this.Ilosc.Size = new System.Drawing.Size(22, 25);
            this.Ilosc.TabIndex = 34;
            this.Ilosc.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(674, 509);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // frmBookInfo
            // 
            this.ClientSize = new System.Drawing.Size(675, 511);
            this.Controls.Add(this.Ilosc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtISPN);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbRodzajOkladki);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ISPN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbPublisher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmBookInfo";
            this.Load += new System.EventHandler(this.frmBookInfo_Load_2);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPublisher;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label ISPN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbRodzajOkladki;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource ksiazkaBindingSource;
        private Database1DataSet1TableAdapters.ksiazkaTableAdapter ksiazkaTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAuthor;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource ksiazkaBindingSource1;
        private Database1DataSetTableAdapters.ksiazkaTableAdapter ksiazkaTableAdapter1;
        private System.Windows.Forms.TextBox txtBookId;
        private Database1DataSet database1DataSet2;
        private System.Windows.Forms.TextBox txtISPN;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Ilosc;
        private System.Windows.Forms.PictureBox pictureBox1;
    }

}