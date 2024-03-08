namespace SE_Mekele
{
    partial class Fibonacci
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
            this.lstView = new System.Windows.Forms.ListBox();
            this.txtFibNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstView
            // 
            this.lstView.FormattingEnabled = true;
            this.lstView.Location = new System.Drawing.Point(63, 34);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(120, 199);
            this.lstView.TabIndex = 5;
            // 
            // txtFibNo
            // 
            this.txtFibNo.Location = new System.Drawing.Point(123, 8);
            this.txtFibNo.Name = "txtFibNo";
            this.txtFibNo.Size = new System.Drawing.Size(138, 20);
            this.txtFibNo.TabIndex = 4;
            this.txtFibNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFibNo.TextChanged += new System.EventHandler(this.txtFibNo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fibonacci Series";
            // 
            // Fibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 241);
            this.Controls.Add(this.lstView);
            this.Controls.Add(this.txtFibNo);
            this.Controls.Add(this.label1);
            this.Name = "Fibonacci";
            this.Text = "Fibonacci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstView;
        private System.Windows.Forms.TextBox txtFibNo;
        private System.Windows.Forms.Label label1;
    }
}