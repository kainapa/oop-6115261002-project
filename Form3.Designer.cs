namespace oop_6115261002_project
{
    partial class Form3
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
            this.txtCID = new System.Windows.Forms.TextBox();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.txtCTel = new System.Windows.Forms.TextBox();
            this.butCAdd = new System.Windows.Forms.Button();
            this.butCEdit = new System.Windows.Forms.Button();
            this.butCDelete = new System.Windows.Forms.Button();
            this.butCDisplay = new System.Windows.Forms.Button();
            this.butCNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ชื่อ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "เบอร์โทร";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(267, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(466, 278);
            this.dataGridView1.TabIndex = 3;
            // 
            // txtCID
            // 
            this.txtCID.Location = new System.Drawing.Point(128, 37);
            this.txtCID.Name = "txtCID";
            this.txtCID.Size = new System.Drawing.Size(100, 22);
            this.txtCID.TabIndex = 4;
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(128, 96);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(100, 22);
            this.txtCName.TabIndex = 5;
            // 
            // txtCTel
            // 
            this.txtCTel.Location = new System.Drawing.Point(128, 153);
            this.txtCTel.Name = "txtCTel";
            this.txtCTel.Size = new System.Drawing.Size(100, 22);
            this.txtCTel.TabIndex = 6;
            // 
            // butCAdd
            // 
            this.butCAdd.Location = new System.Drawing.Point(267, 345);
            this.butCAdd.Name = "butCAdd";
            this.butCAdd.Size = new System.Drawing.Size(75, 23);
            this.butCAdd.TabIndex = 7;
            this.butCAdd.Text = "add";
            this.butCAdd.UseVisualStyleBackColor = true;
            this.butCAdd.Click += new System.EventHandler(this.butCAdd_Click);
            // 
            // butCEdit
            // 
            this.butCEdit.Location = new System.Drawing.Point(365, 345);
            this.butCEdit.Name = "butCEdit";
            this.butCEdit.Size = new System.Drawing.Size(75, 23);
            this.butCEdit.TabIndex = 8;
            this.butCEdit.Text = "edit";
            this.butCEdit.UseVisualStyleBackColor = true;
            this.butCEdit.Click += new System.EventHandler(this.butCEdit_Click);
            // 
            // butCDelete
            // 
            this.butCDelete.Location = new System.Drawing.Point(463, 345);
            this.butCDelete.Name = "butCDelete";
            this.butCDelete.Size = new System.Drawing.Size(75, 23);
            this.butCDelete.TabIndex = 9;
            this.butCDelete.Text = "delete";
            this.butCDelete.UseVisualStyleBackColor = true;
            this.butCDelete.Click += new System.EventHandler(this.butCDelete_Click);
            // 
            // butCDisplay
            // 
            this.butCDisplay.Location = new System.Drawing.Point(561, 345);
            this.butCDisplay.Name = "butCDisplay";
            this.butCDisplay.Size = new System.Drawing.Size(75, 23);
            this.butCDisplay.TabIndex = 10;
            this.butCDisplay.Text = "display";
            this.butCDisplay.UseVisualStyleBackColor = true;
            this.butCDisplay.Click += new System.EventHandler(this.butCDisplay_Click);
            // 
            // butCNext
            // 
            this.butCNext.Location = new System.Drawing.Point(658, 345);
            this.butCNext.Name = "butCNext";
            this.butCNext.Size = new System.Drawing.Size(75, 23);
            this.butCNext.TabIndex = 11;
            this.butCNext.Text = "next";
            this.butCNext.UseVisualStyleBackColor = true;
            this.butCNext.Click += new System.EventHandler(this.butCNext_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butCNext);
            this.Controls.Add(this.butCDisplay);
            this.Controls.Add(this.butCDelete);
            this.Controls.Add(this.butCEdit);
            this.Controls.Add(this.butCAdd);
            this.Controls.Add(this.txtCTel);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.txtCID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.TextBox txtCTel;
        private System.Windows.Forms.Button butCAdd;
        private System.Windows.Forms.Button butCEdit;
        private System.Windows.Forms.Button butCDelete;
        private System.Windows.Forms.Button butCDisplay;
        private System.Windows.Forms.Button butCNext;
    }
}