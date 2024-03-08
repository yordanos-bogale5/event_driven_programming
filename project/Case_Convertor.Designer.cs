namespace SE_Mekele
{
    partial class Case_Convertor
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
            this.rdoLower = new System.Windows.Forms.RadioButton();
            this.rdoUpper = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdoLower
            // 
            this.rdoLower.AutoSize = true;
            this.rdoLower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLower.Location = new System.Drawing.Point(130, 45);
            this.rdoLower.Name = "rdoLower";
            this.rdoLower.Size = new System.Drawing.Size(88, 24);
            this.rdoLower.TabIndex = 11;
            this.rdoLower.TabStop = true;
            this.rdoLower.Text = "ToLower";
            this.rdoLower.UseVisualStyleBackColor = true;
            this.rdoLower.CheckedChanged += new System.EventHandler(this.rdoLower_CheckedChanged);
            // 
            // rdoUpper
            // 
            this.rdoUpper.AutoSize = true;
            this.rdoUpper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoUpper.Location = new System.Drawing.Point(35, 45);
            this.rdoUpper.Name = "rdoUpper";
            this.rdoUpper.Size = new System.Drawing.Size(89, 24);
            this.rdoUpper.TabIndex = 10;
            this.rdoUpper.TabStop = true;
            this.rdoUpper.Text = "ToUpper";
            this.rdoUpper.UseVisualStyleBackColor = true;
            this.rdoUpper.CheckedChanged += new System.EventHandler(this.rdoUpper_CheckedChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(105, 100);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(51, 20);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "label2";
            // 
            // txtString
            // 
            this.txtString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtString.Location = new System.Drawing.Point(12, 12);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(215, 26);
            this.txtString.TabIndex = 8;
            this.txtString.TextChanged += new System.EventHandler(this.txtString_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Result:";
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(237, 12);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(76, 26);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Enter...";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // Case_Convertor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 129);
            this.Controls.Add(this.rdoLower);
            this.Controls.Add(this.rdoUpper);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvert);
            this.Name = "Case_Convertor";
            this.Text = "Case_Convertor";
            this.Load += new System.EventHandler(this.Case_Convertor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoLower;
        private System.Windows.Forms.RadioButton rdoUpper;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConvert;
    }
}