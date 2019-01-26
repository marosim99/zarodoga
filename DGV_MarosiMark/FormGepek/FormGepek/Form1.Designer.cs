namespace FormGepek
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
            this.dataGridViewGepek = new System.Windows.Forms.DataGridView();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.textBoxGyarto = new System.Windows.Forms.TextBox();
            this.textBoxSorozat = new System.Windows.Forms.TextBox();
            this.textBoxTipus = new System.Windows.Forms.TextBox();
            this.textBoxPixel = new System.Windows.Forms.TextBox();
            this.textBoxAr = new System.Windows.Forms.TextBox();
            this.textBoxObjektiv = new System.Windows.Forms.TextBox();
            this.textBoxSzenzor = new System.Windows.Forms.TextBox();
            this.buttonNewGep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTipusId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGepek)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGepek
            // 
            this.dataGridViewGepek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGepek.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewGepek.Name = "dataGridViewGepek";
            this.dataGridViewGepek.Size = new System.Drawing.Size(597, 425);
            this.dataGridViewGepek.TabIndex = 0;
            this.dataGridViewGepek.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewGepek.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGepek_CellContentDoubleClick);
            this.dataGridViewGepek.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGepek_CellDoubleClick);
            this.dataGridViewGepek.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGepek_CellValueChanged);
            this.dataGridViewGepek.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewGepek_DefaultValuesNeeded);
            this.dataGridViewGepek.DoubleClick += new System.EventHandler(this.dataGridViewGepek_DoubleClick);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(667, 13);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 1;
            this.buttonLoad.Text = "Betöltés";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(667, 54);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 2;
            this.buttonNew.Text = "Új Adat";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(667, 99);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Módosítás";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(667, 145);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Törlés";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(667, 196);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Mentés";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(667, 257);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Mégse";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(667, 406);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(75, 23);
            this.buttonQuit.TabIndex = 7;
            this.buttonQuit.Text = "Kilépés";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // textBoxGyarto
            // 
            this.textBoxGyarto.Location = new System.Drawing.Point(84, 463);
            this.textBoxGyarto.Name = "textBoxGyarto";
            this.textBoxGyarto.Size = new System.Drawing.Size(100, 20);
            this.textBoxGyarto.TabIndex = 8;
            // 
            // textBoxSorozat
            // 
            this.textBoxSorozat.Location = new System.Drawing.Point(84, 498);
            this.textBoxSorozat.Name = "textBoxSorozat";
            this.textBoxSorozat.Size = new System.Drawing.Size(100, 20);
            this.textBoxSorozat.TabIndex = 9;
            // 
            // textBoxTipus
            // 
            this.textBoxTipus.Location = new System.Drawing.Point(84, 536);
            this.textBoxTipus.Name = "textBoxTipus";
            this.textBoxTipus.Size = new System.Drawing.Size(100, 20);
            this.textBoxTipus.TabIndex = 10;
            // 
            // textBoxPixel
            // 
            this.textBoxPixel.Location = new System.Drawing.Point(277, 459);
            this.textBoxPixel.Name = "textBoxPixel";
            this.textBoxPixel.Size = new System.Drawing.Size(100, 20);
            this.textBoxPixel.TabIndex = 11;
            // 
            // textBoxAr
            // 
            this.textBoxAr.Location = new System.Drawing.Point(277, 570);
            this.textBoxAr.Name = "textBoxAr";
            this.textBoxAr.Size = new System.Drawing.Size(100, 20);
            this.textBoxAr.TabIndex = 14;
            // 
            // textBoxObjektiv
            // 
            this.textBoxObjektiv.Location = new System.Drawing.Point(277, 532);
            this.textBoxObjektiv.Name = "textBoxObjektiv";
            this.textBoxObjektiv.Size = new System.Drawing.Size(100, 20);
            this.textBoxObjektiv.TabIndex = 13;
            // 
            // textBoxSzenzor
            // 
            this.textBoxSzenzor.Location = new System.Drawing.Point(277, 497);
            this.textBoxSzenzor.Name = "textBoxSzenzor";
            this.textBoxSzenzor.Size = new System.Drawing.Size(100, 20);
            this.textBoxSzenzor.TabIndex = 12;
            // 
            // buttonNewGep
            // 
            this.buttonNewGep.Location = new System.Drawing.Point(416, 574);
            this.buttonNewGep.Name = "buttonNewGep";
            this.buttonNewGep.Size = new System.Drawing.Size(100, 23);
            this.buttonNewGep.TabIndex = 15;
            this.buttonNewGep.Text = "Új Gép felvétele";
            this.buttonNewGep.UseVisualStyleBackColor = true;
            this.buttonNewGep.Click += new System.EventHandler(this.buttonNewGep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Gyarto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Sorozat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 539);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tipus";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Pixel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 500);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Szenzor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 535);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Objektiv";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 573);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Ár";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 573);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "TipusId";
            // 
            // textBoxTipusId
            // 
            this.textBoxTipusId.Location = new System.Drawing.Point(84, 570);
            this.textBoxTipusId.Name = "textBoxTipusId";
            this.textBoxTipusId.Size = new System.Drawing.Size(100, 20);
            this.textBoxTipusId.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxTipusId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNewGep);
            this.Controls.Add(this.textBoxAr);
            this.Controls.Add(this.textBoxObjektiv);
            this.Controls.Add(this.textBoxSzenzor);
            this.Controls.Add(this.textBoxPixel);
            this.Controls.Add(this.textBoxTipus);
            this.Controls.Add(this.textBoxSorozat);
            this.Controls.Add(this.textBoxGyarto);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.dataGridViewGepek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGepek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGepek;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.TextBox textBoxGyarto;
        private System.Windows.Forms.TextBox textBoxSorozat;
        private System.Windows.Forms.TextBox textBoxTipus;
        private System.Windows.Forms.TextBox textBoxPixel;
        private System.Windows.Forms.TextBox textBoxAr;
        private System.Windows.Forms.TextBox textBoxObjektiv;
        private System.Windows.Forms.TextBox textBoxSzenzor;
        private System.Windows.Forms.Button buttonNewGep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxTipusId;
    }
}

