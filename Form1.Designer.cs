namespace oop_6115261002_project
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butPAdd = new System.Windows.Forms.Button();
            this.butPEdit = new System.Windows.Forms.Button();
            this.butPDelete = new System.Windows.Forms.Button();
            this.butPDisplay = new System.Windows.Forms.Button();
            this.butPNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "รสไอศกรีม";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ราคา";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(118, 30);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(118, 87);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(118, 145);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(276, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(492, 259);
            this.dataGridView1.TabIndex = 11;
            // 
            // butPAdd
            // 
            this.butPAdd.Location = new System.Drawing.Point(276, 345);
            this.butPAdd.Name = "butPAdd";
            this.butPAdd.Size = new System.Drawing.Size(75, 23);
            this.butPAdd.TabIndex = 12;
            this.butPAdd.Text = "add";
            this.butPAdd.UseVisualStyleBackColor = true;
            this.butPAdd.Click += new System.EventHandler(this.butPAdd_Click);
            // 
            // butPEdit
            // 
            this.butPEdit.Location = new System.Drawing.Point(380, 345);
            this.butPEdit.Name = "butPEdit";
            this.butPEdit.Size = new System.Drawing.Size(75, 23);
            this.butPEdit.TabIndex = 13;
            this.butPEdit.Text = "edit";
            this.butPEdit.UseVisualStyleBackColor = true;
            this.butPEdit.Click += new System.EventHandler(this.button2_Click);
            // 
            // butPDelete
            // 
            this.butPDelete.Location = new System.Drawing.Point(486, 345);
            this.butPDelete.Name = "butPDelete";
            this.butPDelete.Size = new System.Drawing.Size(75, 23);
            this.butPDelete.TabIndex = 14;
            this.butPDelete.Text = "delete";
            this.butPDelete.UseVisualStyleBackColor = true;
            this.butPDelete.Click += new System.EventHandler(this.butPDelete_Click);
            // 
            // butPDisplay
            // 
            this.butPDisplay.Location = new System.Drawing.Point(588, 345);
            this.butPDisplay.Name = "butPDisplay";
            this.butPDisplay.Size = new System.Drawing.Size(75, 23);
            this.butPDisplay.TabIndex = 15;
            this.butPDisplay.Text = "display";
            this.butPDisplay.UseVisualStyleBackColor = true;
            this.butPDisplay.Click += new System.EventHandler(this.butPDisplay_Click);
            // 
            // butPNext
            // 
            this.butPNext.Location = new System.Drawing.Point(693, 345);
            this.butPNext.Name = "butPNext";
            this.butPNext.Size = new System.Drawing.Size(75, 23);
            this.butPNext.TabIndex = 16;
            this.butPNext.Text = "next";
            this.butPNext.UseVisualStyleBackColor = true;
            this.butPNext.Click += new System.EventHandler(this.butPNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butPNext);
            this.Controls.Add(this.butPDisplay);
            this.Controls.Add(this.butPDelete);
            this.Controls.Add(this.butPEdit);
            this.Controls.Add(this.butPAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ice Cream";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butPAdd;
        private System.Windows.Forms.Button butPEdit;
        private System.Windows.Forms.Button butPDelete;
        private System.Windows.Forms.Button butPDisplay;
        private System.Windows.Forms.Button butPNext;
    }
}

