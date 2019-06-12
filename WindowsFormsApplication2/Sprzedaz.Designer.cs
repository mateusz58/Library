namespace WindowsFormsApplication2
{
    partial class Sprzedaz
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Gridprodukty = new System.Windows.Forms.DataGridView();
            this.Gridzamowienia = new System.Windows.Forms.DataGridView();
            this.Suma = new System.Windows.Forms.Label();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtkod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btndodaj = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.btnDrukuj = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Gridprodukty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gridzamowienia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Gridprodukty
            // 
            this.Gridprodukty.AllowUserToAddRows = false;
            this.Gridprodukty.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.NullValue = "0";
            this.Gridprodukty.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.Gridprodukty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridprodukty.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Gridprodukty.Location = new System.Drawing.Point(34, 105);
            this.Gridprodukty.Name = "Gridprodukty";
            this.Gridprodukty.RowHeadersVisible = false;
            this.Gridprodukty.Size = new System.Drawing.Size(574, 223);
            this.Gridprodukty.TabIndex = 0;
            // 
            // Gridzamowienia
            // 
            this.Gridzamowienia.AllowUserToAddRows = false;
            this.Gridzamowienia.AllowUserToOrderColumns = true;
            this.Gridzamowienia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Gridzamowienia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridzamowienia.Location = new System.Drawing.Point(658, 356);
            this.Gridzamowienia.Name = "Gridzamowienia";
            this.Gridzamowienia.Size = new System.Drawing.Size(476, 293);
            this.Gridzamowienia.TabIndex = 1;
            this.Gridzamowienia.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gridzamowienia_CellValueChanged);
            this.Gridzamowienia.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Gridzamowienia_RowHeaderMouseClick);
            this.Gridzamowienia.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.Gridzamowienia_UserDeletedRow);
            // 
            // Suma
            // 
            this.Suma.AutoSize = true;
            this.Suma.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Suma.Location = new System.Drawing.Point(398, 468);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(80, 27);
            this.Suma.TabIndex = 2;
            this.Suma.Text = "Suma:";
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(484, 468);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(148, 20);
            this.txtSuma.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(306, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kod kreskowy:";
            // 
            // txtkod
            // 
            this.txtkod.Location = new System.Drawing.Point(484, 382);
            this.txtkod.Name = "txtkod";
            this.txtkod.Size = new System.Drawing.Size(148, 20);
            this.txtkod.TabIndex = 9;
            this.txtkod.TextChanged += new System.EventHandler(this.txtkod_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(29, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Szukaj:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(342, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Według:";
            // 
            // btndodaj
            // 
            this.btndodaj.Location = new System.Drawing.Point(638, 295);
            this.btndodaj.Name = "btndodaj";
            this.btndodaj.Size = new System.Drawing.Size(142, 23);
            this.btndodaj.TabIndex = 12;
            this.btndodaj.Text = "Dodaj do karty produktów";
            this.btndodaj.UseVisualStyleBackColor = true;
            this.btndodaj.Click += new System.EventHandler(this.btndodaj_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(196, 20);
            this.textBox2.TabIndex = 13;
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(753, 683);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(111, 23);
            this.btnZapisz.TabIndex = 14;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // btnDrukuj
            // 
            this.btnDrukuj.Location = new System.Drawing.Point(925, 683);
            this.btnDrukuj.Name = "btnDrukuj";
            this.btnDrukuj.Size = new System.Drawing.Size(111, 23);
            this.btnDrukuj.TabIndex = 15;
            this.btnDrukuj.Text = "Drukuj";
            this.btnDrukuj.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(65, 677);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 29);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(446, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Szukaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numBox
            // 
            this.numBox.Location = new System.Drawing.Point(860, 302);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(176, 20);
            this.numBox.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(631, 468);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "zł";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(796, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ilość";
            // 
            // Sprzedaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1158, 790);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDrukuj);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btndodaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtkod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.Gridzamowienia);
            this.Controls.Add(this.Gridprodukty);
            this.Name = "Sprzedaz";
            this.Text = "Sprzedaz";
            this.Load += new System.EventHandler(this.Sprzedaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gridprodukty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gridzamowienia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Gridprodukty;
        private System.Windows.Forms.DataGridView Gridzamowienia;
        private System.Windows.Forms.Label Suma;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btndodaj;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnZapisz;
        private System.Windows.Forms.Button btnDrukuj;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}