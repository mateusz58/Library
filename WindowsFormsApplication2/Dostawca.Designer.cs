namespace WindowsFormsApplication2
{
    partial class Dostawca
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
            this.Griddostawca = new System.Windows.Forms.DataGridView();
            this.txtdostawca = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtkodpocztowy = new System.Windows.Forms.TextBox();
            this.txtmiasto = new System.Windows.Forms.TextBox();
            this.txtulica = new System.Windows.Forms.TextBox();
            this.txtkraj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnrlokalu = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txttelefon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Griddostawca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Griddostawca
            // 
            this.Griddostawca.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Griddostawca.AllowUserToAddRows = false;
            this.Griddostawca.AllowUserToDeleteRows = false;
            this.Griddostawca.AllowUserToResizeColumns = false;
            this.Griddostawca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Griddostawca.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Griddostawca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Griddostawca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Griddostawca.Location = new System.Drawing.Point(361, 12);
            this.Griddostawca.Name = "Griddostawca";
            this.Griddostawca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Griddostawca.RowHeadersVisible = false;
            this.Griddostawca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Griddostawca.ShowEditingIcon = false;
            this.Griddostawca.ShowRowErrors = false;
            this.Griddostawca.Size = new System.Drawing.Size(509, 537);
            this.Griddostawca.TabIndex = 2;
            // 
            // txtdostawca
            // 
            this.txtdostawca.Location = new System.Drawing.Point(111, 135);
            this.txtdostawca.Name = "txtdostawca";
            this.txtdostawca.Size = new System.Drawing.Size(231, 20);
            this.txtdostawca.TabIndex = 3;
            this.txtdostawca.TextChanged += new System.EventHandler(this.txtdostawca_TextChanged);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(29, 492);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(102, 23);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "Dodaj Wydawcę";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(29, 586);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(102, 23);
            this.btndel.TabIndex = 5;
            this.btndel.Text = "Usuń Wydawcę";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(111, 393);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(90, 20);
            this.txtemail.TabIndex = 6;
            // 
            // txtkodpocztowy
            // 
            this.txtkodpocztowy.Location = new System.Drawing.Point(112, 181);
            this.txtkodpocztowy.Name = "txtkodpocztowy";
            this.txtkodpocztowy.Size = new System.Drawing.Size(117, 20);
            this.txtkodpocztowy.TabIndex = 7;
            // 
            // txtmiasto
            // 
            this.txtmiasto.Location = new System.Drawing.Point(112, 226);
            this.txtmiasto.Name = "txtmiasto";
            this.txtmiasto.Size = new System.Drawing.Size(135, 20);
            this.txtmiasto.TabIndex = 8;
            // 
            // txtulica
            // 
            this.txtulica.Location = new System.Drawing.Point(111, 272);
            this.txtulica.Name = "txtulica";
            this.txtulica.Size = new System.Drawing.Size(197, 20);
            this.txtulica.TabIndex = 9;
            // 
            // txtkraj
            // 
            this.txtkraj.Location = new System.Drawing.Point(112, 352);
            this.txtkraj.Name = "txtkraj";
            this.txtkraj.Size = new System.Drawing.Size(197, 20);
            this.txtkraj.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nazwa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kod pocztowy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Miasto:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ulica:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kraj:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nr lokalu:";
            // 
            // txtnrlokalu
            // 
            this.txtnrlokalu.Location = new System.Drawing.Point(111, 312);
            this.txtnrlokalu.Name = "txtnrlokalu";
            this.txtnrlokalu.Size = new System.Drawing.Size(197, 20);
            this.txtnrlokalu.TabIndex = 18;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(29, 536);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 23);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Zmień dane";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txttelefon
            // 
            this.txttelefon.Location = new System.Drawing.Point(111, 436);
            this.txttelefon.Name = "txttelefon";
            this.txttelefon.Size = new System.Drawing.Size(197, 20);
            this.txttelefon.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Telefon:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(33, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 26);
            this.label9.TabIndex = 22;
            this.label9.Text = "Szczegóły dostawcy:";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(16, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 69);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Dostawca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 673);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txttelefon);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtnrlokalu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtkraj);
            this.Controls.Add(this.txtulica);
            this.Controls.Add(this.txtmiasto);
            this.Controls.Add(this.txtkodpocztowy);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtdostawca);
            this.Controls.Add(this.Griddostawca);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Dostawca";
            this.Text = "Dostawca";
            this.Load += new System.EventHandler(this.Dostawca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Griddostawca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Griddostawca;
        private System.Windows.Forms.TextBox txtdostawca;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtkodpocztowy;
        private System.Windows.Forms.TextBox txtmiasto;
        private System.Windows.Forms.TextBox txtulica;
        private System.Windows.Forms.TextBox txtkraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnrlokalu;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txttelefon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}