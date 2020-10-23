namespace oop_6115261002_project
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butDAdd = new System.Windows.Forms.Button();
            this.butDEdit = new System.Windows.Forms.Button();
            this.butDDelete = new System.Windows.Forms.Button();
            this.butDDisplay = new System.Windows.Forms.Button();
            this.butDNext = new System.Windows.Forms.Button();
            this.txtDID = new System.Windows.Forms.TextBox();
            this.txtDCup = new System.Windows.Forms.TextBox();
            this.radioDS = new System.Windows.Forms.RadioButton();
            this.radioDM = new System.Windows.Forms.RadioButton();
            this.radioDL = new System.Windows.Forms.RadioButton();
            this.radioDXL = new System.Windows.Forms.RadioButton();
            this.radioXXL = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ถ้วย";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "size";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(216, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(470, 243);
            this.dataGridView1.TabIndex = 3;
            // 
            // butDAdd
            // 
            this.butDAdd.Location = new System.Drawing.Point(216, 324);
            this.butDAdd.Name = "butDAdd";
            this.butDAdd.Size = new System.Drawing.Size(75, 23);
            this.butDAdd.TabIndex = 4;
            this.butDAdd.Text = "add";
            this.butDAdd.UseVisualStyleBackColor = true;
            this.butDAdd.Click += new System.EventHandler(this.butDAdd_Click);
            // 
            // butDEdit
            // 
            this.butDEdit.Location = new System.Drawing.Point(316, 324);
            this.butDEdit.Name = "butDEdit";
            this.butDEdit.Size = new System.Drawing.Size(75, 23);
            this.butDEdit.TabIndex = 5;
            this.butDEdit.Text = "edit";
            this.butDEdit.UseVisualStyleBackColor = true;
            this.butDEdit.Click += new System.EventHandler(this.butDEdit_Click);
            // 
            // butDDelete
            // 
            this.butDDelete.Location = new System.Drawing.Point(414, 324);
            this.butDDelete.Name = "butDDelete";
            this.butDDelete.Size = new System.Drawing.Size(75, 23);
            this.butDDelete.TabIndex = 6;
            this.butDDelete.Text = "delete";
            this.butDDelete.UseVisualStyleBackColor = true;
            this.butDDelete.Click += new System.EventHandler(this.butDDelete_Click);
            // 
            // butDDisplay
            // 
            this.butDDisplay.Location = new System.Drawing.Point(513, 324);
            this.butDDisplay.Name = "butDDisplay";
            this.butDDisplay.Size = new System.Drawing.Size(75, 23);
            this.butDDisplay.TabIndex = 7;
            this.butDDisplay.Text = "display";
            this.butDDisplay.UseVisualStyleBackColor = true;
            this.butDDisplay.Click += new System.EventHandler(this.butDDisplay_Click);
            // 
            // butDNext
            // 
            this.butDNext.Location = new System.Drawing.Point(611, 324);
            this.butDNext.Name = "butDNext";
            this.butDNext.Size = new System.Drawing.Size(75, 23);
            this.butDNext.TabIndex = 8;
            this.butDNext.Text = "next";
            this.butDNext.UseVisualStyleBackColor = true;
            this.butDNext.Click += new System.EventHandler(this.butDNext_Click);
            // 
            // txtDID
            // 
            this.txtDID.Location = new System.Drawing.Point(84, 30);
            this.txtDID.Name = "txtDID";
            this.txtDID.Size = new System.Drawing.Size(100, 22);
            this.txtDID.TabIndex = 9;
            // 
            // txtDCup
            // 
            this.txtDCup.Location = new System.Drawing.Point(84, 89);
            this.txtDCup.Name = "txtDCup";
            this.txtDCup.Size = new System.Drawing.Size(100, 22);
            this.txtDCup.TabIndex = 10;
            // 
            // radioDS
            // 
            this.radioDS.AutoSize = true;
            this.radioDS.Location = new System.Drawing.Point(84, 149);
            this.radioDS.Name = "radioDS";
            this.radioDS.Size = new System.Drawing.Size(38, 21);
            this.radioDS.TabIndex = 11;
            this.radioDS.TabStop = true;
            this.radioDS.Text = "S";
            this.radioDS.UseVisualStyleBackColor = true;
            // 
            // radioDM
            // 
            this.radioDM.AutoSize = true;
            this.radioDM.Location = new System.Drawing.Point(84, 195);
            this.radioDM.Name = "radioDM";
            this.radioDM.Size = new System.Drawing.Size(40, 21);
            this.radioDM.TabIndex = 12;
            this.radioDM.TabStop = true;
            this.radioDM.Text = "M";
            this.radioDM.UseVisualStyleBackColor = true;
            // 
            // radioDL
            // 
            this.radioDL.AutoSize = true;
            this.radioDL.Location = new System.Drawing.Point(84, 240);
            this.radioDL.Name = "radioDL";
            this.radioDL.Size = new System.Drawing.Size(37, 21);
            this.radioDL.TabIndex = 13;
            this.radioDL.TabStop = true;
            this.radioDL.Text = "L";
            this.radioDL.UseVisualStyleBackColor = true;
            // 
            // radioDXL
            // 
            this.radioDXL.AutoSize = true;
            this.radioDXL.Location = new System.Drawing.Point(84, 283);
            this.radioDXL.Name = "radioDXL";
            this.radioDXL.Size = new System.Drawing.Size(46, 21);
            this.radioDXL.TabIndex = 14;
            this.radioDXL.TabStop = true;
            this.radioDXL.Text = "XL";
            this.radioDXL.UseVisualStyleBackColor = true;
            this.radioDXL.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioXXL
            // 
            this.radioXXL.AutoSize = true;
            this.radioXXL.Location = new System.Drawing.Point(84, 326);
            this.radioXXL.Name = "radioXXL";
            this.radioXXL.Size = new System.Drawing.Size(55, 21);
            this.radioXXL.TabIndex = 15;
            this.radioXXL.TabStop = true;
            this.radioXXL.Text = "XXL";
            this.radioXXL.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioXXL);
            this.Controls.Add(this.radioDXL);
            this.Controls.Add(this.radioDL);
            this.Controls.Add(this.radioDM);
            this.Controls.Add(this.radioDS);
            this.Controls.Add(this.txtDCup);
            this.Controls.Add(this.txtDID);
            this.Controls.Add(this.butDNext);
            this.Controls.Add(this.butDDisplay);
            this.Controls.Add(this.butDDelete);
            this.Controls.Add(this.butDEdit);
            this.Controls.Add(this.butDAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Detail";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butDAdd;
        private System.Windows.Forms.Button butDEdit;
        private System.Windows.Forms.Button butDDelete;
        private System.Windows.Forms.Button butDDisplay;
        private System.Windows.Forms.Button butDNext;
        private System.Windows.Forms.TextBox txtDID;
        private System.Windows.Forms.TextBox txtDCup;
        private System.Windows.Forms.RadioButton radioDS;
        private System.Windows.Forms.RadioButton radioDM;
        private System.Windows.Forms.RadioButton radioDL;
        private System.Windows.Forms.RadioButton radioDXL;
        private System.Windows.Forms.RadioButton radioXXL;
    }
}