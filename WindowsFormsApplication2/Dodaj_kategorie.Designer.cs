namespace WindowsFormsApplication2
{
    partial class Dodaj_kategorie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dodaj_kategorie));
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butdodaj = new System.Windows.Forms.Button();
            this.GridGatunek = new System.Windows.Forms.DataGridView();
            this.butUsun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridGatunek)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(43, 89);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(234, 20);
            this.txtCategory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(39, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podaj Gatunek książki:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butdodaj
            // 
            this.butdodaj.Location = new System.Drawing.Point(54, 132);
            this.butdodaj.Name = "butdodaj";
            this.butdodaj.Size = new System.Drawing.Size(75, 23);
            this.butdodaj.TabIndex = 2;
            this.butdodaj.Text = "Dodaj";
            this.butdodaj.UseVisualStyleBackColor = true;
            this.butdodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // GridGatunek
            // 
            this.GridGatunek.AllowUserToOrderColumns = true;
            this.GridGatunek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridGatunek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridGatunek.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GridGatunek.GridColor = System.Drawing.SystemColors.Control;
            this.GridGatunek.Location = new System.Drawing.Point(312, 12);
            this.GridGatunek.MultiSelect = false;
            this.GridGatunek.Name = "GridGatunek";
            this.GridGatunek.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.GridGatunek.ShowCellErrors = false;
            this.GridGatunek.ShowCellToolTips = false;
            this.GridGatunek.ShowEditingIcon = false;
            this.GridGatunek.ShowRowErrors = false;
            this.GridGatunek.Size = new System.Drawing.Size(190, 355);
            this.GridGatunek.StandardTab = true;
            this.GridGatunek.TabIndex = 4;
            // 
            // butUsun
            // 
            this.butUsun.Location = new System.Drawing.Point(181, 132);
            this.butUsun.Name = "butUsun";
            this.butUsun.Size = new System.Drawing.Size(75, 23);
            this.butUsun.TabIndex = 5;
            this.butUsun.Text = "Usun";
            this.butUsun.UseVisualStyleBackColor = true;
            this.butUsun.Click += new System.EventHandler(this.butUsun_Click);
            // 
            // Dodaj_kategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(514, 411);
            this.Controls.Add(this.butUsun);
            this.Controls.Add(this.GridGatunek);
            this.Controls.Add(this.butdodaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCategory);
            this.Name = "Dodaj_kategorie";
            this.Text = "Dodaj_kategorie";
            this.Load += new System.EventHandler(this.Dodaj_kategorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridGatunek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butdodaj;
        private System.Windows.Forms.DataGridView GridGatunek;
        private System.Windows.Forms.Button butUsun;
    }
}