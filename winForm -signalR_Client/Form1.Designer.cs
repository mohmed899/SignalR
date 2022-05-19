namespace winForm__signalR_Client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtJob = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DGV_Emp = new System.Windows.Forms.DataGridView();
            this.AddBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Emp)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(114, 144);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(149, 23);
            this.TxtName.TabIndex = 0;
            // 
            // TxtJob
            // 
            this.TxtJob.Location = new System.Drawing.Point(114, 185);
            this.TxtJob.Name = "TxtJob";
            this.TxtJob.Size = new System.Drawing.Size(149, 23);
            this.TxtJob.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(511, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employess Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(51, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Create Employee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(27, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Job";
            // 
            // DGV_Emp
            // 
            this.DGV_Emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Emp.Location = new System.Drawing.Point(397, 122);
            this.DGV_Emp.Name = "DGV_Emp";
            this.DGV_Emp.RowTemplate.Height = 25;
            this.DGV_Emp.Size = new System.Drawing.Size(391, 169);
            this.DGV_Emp.TabIndex = 6;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(141, 258);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DGV_Emp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtJob);
            this.Controls.Add(this.TxtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Emp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtName;
        private TextBox TxtJob;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView DGV_Emp;
        private Button AddBtn;
    }
}