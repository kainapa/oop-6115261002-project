namespace oop_6115261002_project
{
    partial class Form4
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
            this.radioS = new System.Windows.Forms.RadioButton();
            this.radioM = new System.Windows.Forms.RadioButton();
            this.radioL = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.butSAdd = new System.Windows.Forms.Button();
            this.butSEdit = new System.Windows.Forms.Button();
            this.butSDelete = new System.Windows.Forms.Button();
            this.butSDisplay = new System.Windows.Forms.Button();
            this.radioXL = new System.Windows.Forms.RadioButton();
            this.radioXXL = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioS
            // 
            this.radioS.AutoSize = true;
            this.radioS.Location = new System.Drawing.Point(45, 88);
            this.radioS.Name = "radioS";
            this.radioS.Size = new System.Drawing.Size(38, 21);
            this.radioS.TabIndex = 1;
            this.radioS.TabStop = true;
            this.radioS.Text = "S";
            this.radioS.UseVisualStyleBackColor = true;
            this.radioS.CheckedChanged += new System.EventHandler(this.radioS_CheckedChanged);
            // 
            // radioM
            // 
            this.radioM.AutoSize = true;
            this.radioM.Location = new System.Drawing.Point(45, 126);
            this.radioM.Name = "radioM";
            this.radioM.Size = new System.Drawing.Size(40, 21);
            this.radioM.TabIndex = 2;
            this.radioM.TabStop = true;
            this.radioM.Text = "M";
            this.radioM.UseVisualStyleBackColor = true;
            // 
            // radioL
            // 
            this.radioL.AutoSize = true;
            this.radioL.Location = new System.Drawing.Point(45, 163);
            this.radioL.Name = "radioL";
            this.radioL.Size = new System.Drawing.Size(37, 21);
            this.radioL.TabIndex = 3;
            this.radioL.TabStop = true;
            this.radioL.Text = "L";
            this.radioL.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(253, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(509, 287);
            this.dataGridView1.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(119, 37);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 5;
            // 
            // butSAdd
            // 
            this.butSAdd.Location = new System.Drawing.Point(253, 338);
            this.butSAdd.Name = "butSAdd";
            this.butSAdd.Size = new System.Drawing.Size(75, 23);
            this.butSAdd.TabIndex = 6;
            this.butSAdd.Text = "add";
            this.butSAdd.UseVisualStyleBackColor = true;
            this.butSAdd.Click += new System.EventHandler(this.butSAdd_Click);
            // 
            // butSEdit
            // 
            this.butSEdit.Location = new System.Drawing.Point(366, 338);
            this.butSEdit.Name = "butSEdit";
            this.butSEdit.Size = new System.Drawing.Size(75, 23);
            this.butSEdit.TabIndex = 7;
            this.butSEdit.Text = "edit";
            this.butSEdit.UseVisualStyleBackColor = true;
            this.butSEdit.Click += new System.EventHandler(this.butSEdit_Click);
            // 
            // butSDelete
            // 
            this.butSDelete.Location = new System.Drawing.Point(479, 338);
            this.butSDelete.Name = "butSDelete";
            this.butSDelete.Size = new System.Drawing.Size(75, 23);
            this.butSDelete.TabIndex = 8;
            this.butSDelete.Text = "delete";
            this.butSDelete.UseVisualStyleBackColor = true;
            this.butSDelete.Click += new System.EventHandler(this.butSDelete_Click);
            // 
            // butSDisplay
            // 
            this.butSDisplay.Location = new System.Drawing.Point(588, 338);
            this.butSDisplay.Name = "butSDisplay";
            this.butSDisplay.Size = new System.Drawing.Size(75, 23);
            this.butSDisplay.TabIndex = 9;
            this.butSDisplay.Text = "display";
            this.butSDisplay.UseVisualStyleBackColor = true;
            this.butSDisplay.Click += new System.EventHandler(this.butSDisplay_Click);
            // 
            // radioXL
            // 
            this.radioXL.AutoSize = true;
            this.radioXL.Location = new System.Drawing.Point(45, 201);
            this.radioXL.Name = "radioXL";
            this.radioXL.Size = new System.Drawing.Size(46, 21);
            this.radioXL.TabIndex = 10;
            this.radioXL.TabStop = true;
            this.radioXL.Text = "XL";
            this.radioXL.UseVisualStyleBackColor = true;
            this.radioXL.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioXXL
            // 
            this.radioXXL.AutoSize = true;
            this.radioXXL.Location = new System.Drawing.Point(45, 237);
            this.radioXXL.Name = "radioXXL";
            this.radioXXL.Size = new System.Drawing.Size(55, 21);
            this.radioXXL.TabIndex = 11;
            this.radioXXL.TabStop = true;
            this.radioXXL.Text = "XXL";
            this.radioXXL.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioXXL);
            this.Controls.Add(this.radioXL);
            this.Controls.Add(this.butSDisplay);
            this.Controls.Add(this.butSDelete);
            this.Controls.Add(this.butSEdit);
            this.Controls.Add(this.butSAdd);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioL);
            this.Controls.Add(this.radioM);
            this.Controls.Add(this.radioS);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Size";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioS;
        private System.Windows.Forms.RadioButton radioM;
        private System.Windows.Forms.RadioButton radioL;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button butSAdd;
        private System.Windows.Forms.Button butSEdit;
        private System.Windows.Forms.Button butSDelete;
        private System.Windows.Forms.Button butSDisplay;
        private System.Windows.Forms.RadioButton radioXL;
        private System.Windows.Forms.RadioButton radioXXL;
    }
}