namespace SE_Mekele
{
    partial class FileHadle
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDirDelete = new System.Windows.Forms.Button();
            this.btnDirMove = new System.Windows.Forms.Button();
            this.btnDirectoryInfo = new System.Windows.Forms.Button();
            this.btnDirLists = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.txtBrowsefile = new System.Windows.Forms.TextBox();
            this.btnAppend = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtString = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnFile_Info = new System.Windows.Forms.Button();
            this.richtxtDisplay = new System.Windows.Forms.RichTextBox();
            this.btnDirCreate = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDirCreate);
            this.groupBox2.Controls.Add(this.btnDirDelete);
            this.groupBox2.Controls.Add(this.btnDirMove);
            this.groupBox2.Controls.Add(this.btnDirectoryInfo);
            this.groupBox2.Controls.Add(this.btnDirLists);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Font = new System.Drawing.Font("Meaza", 12F);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(508, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 216);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Directory Handling";
            // 
            // btnDirDelete
            // 
            this.btnDirDelete.Location = new System.Drawing.Point(146, 126);
            this.btnDirDelete.Name = "btnDirDelete";
            this.btnDirDelete.Size = new System.Drawing.Size(96, 31);
            this.btnDirDelete.TabIndex = 30;
            this.btnDirDelete.Text = "Delete";
            this.btnDirDelete.UseVisualStyleBackColor = true;
            this.btnDirDelete.Click += new System.EventHandler(this.btnDirDelete_Click);
            // 
            // btnDirMove
            // 
            this.btnDirMove.Location = new System.Drawing.Point(256, 126);
            this.btnDirMove.Name = "btnDirMove";
            this.btnDirMove.Size = new System.Drawing.Size(96, 31);
            this.btnDirMove.TabIndex = 30;
            this.btnDirMove.Text = "Move";
            this.btnDirMove.UseVisualStyleBackColor = true;
            this.btnDirMove.Click += new System.EventHandler(this.btnDirMove_Click);
            // 
            // btnDirectoryInfo
            // 
            this.btnDirectoryInfo.Location = new System.Drawing.Point(211, 176);
            this.btnDirectoryInfo.Name = "btnDirectoryInfo";
            this.btnDirectoryInfo.Size = new System.Drawing.Size(120, 31);
            this.btnDirectoryInfo.TabIndex = 30;
            this.btnDirectoryInfo.Text = "Info";
            this.btnDirectoryInfo.UseVisualStyleBackColor = true;
            this.btnDirectoryInfo.Click += new System.EventHandler(this.btnDirectoryInfo_Click);
            // 
            // btnDirLists
            // 
            this.btnDirLists.Location = new System.Drawing.Point(82, 176);
            this.btnDirLists.Name = "btnDirLists";
            this.btnDirLists.Size = new System.Drawing.Size(120, 31);
            this.btnDirLists.TabIndex = 30;
            this.btnDirLists.Text = "Lists";
            this.btnDirLists.UseVisualStyleBackColor = true;
            this.btnDirLists.Click += new System.EventHandler(this.btnDirLists_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "String:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(88, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(278, 29);
            this.textBox2.TabIndex = 22;
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold);
            this.btnCopy.ForeColor = System.Drawing.Color.Blue;
            this.btnCopy.Location = new System.Drawing.Point(296, 128);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(86, 31);
            this.btnCopy.TabIndex = 24;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold);
            this.btnWrite.ForeColor = System.Drawing.Color.Blue;
            this.btnWrite.Location = new System.Drawing.Point(109, 178);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(86, 31);
            this.btnWrite.TabIndex = 25;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // txtBrowsefile
            // 
            this.txtBrowsefile.Location = new System.Drawing.Point(148, 35);
            this.txtBrowsefile.Name = "txtBrowsefile";
            this.txtBrowsefile.Size = new System.Drawing.Size(278, 29);
            this.txtBrowsefile.TabIndex = 21;
            // 
            // btnAppend
            // 
            this.btnAppend.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold);
            this.btnAppend.ForeColor = System.Drawing.Color.Blue;
            this.btnAppend.Location = new System.Drawing.Point(201, 178);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(86, 31);
            this.btnAppend.TabIndex = 26;
            this.btnAppend.Text = "Append";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold);
            this.btnRead.ForeColor = System.Drawing.Color.Blue;
            this.btnRead.Location = new System.Drawing.Point(16, 178);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(84, 31);
            this.btnRead.TabIndex = 23;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(148, 75);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(278, 29);
            this.txtString.TabIndex = 22;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.Red;
            this.btnBrowse.Location = new System.Drawing.Point(432, 33);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(44, 31);
            this.btnBrowse.TabIndex = 27;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 30);
            this.label2.TabIndex = 20;
            this.label2.Text = "String:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "Browse file:";
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreate.ForeColor = System.Drawing.Color.Blue;
            this.btnCreate.Location = new System.Drawing.Point(16, 128);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(84, 31);
            this.btnCreate.TabIndex = 28;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.Blue;
            this.btnDelete.Location = new System.Drawing.Point(109, 128);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 31);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMove
            // 
            this.btnMove.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold);
            this.btnMove.ForeColor = System.Drawing.Color.Blue;
            this.btnMove.Location = new System.Drawing.Point(201, 128);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(86, 31);
            this.btnMove.TabIndex = 28;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRename);
            this.groupBox1.Controls.Add(this.btnFile_Info);
            this.groupBox1.Controls.Add(this.btnMove);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.txtString);
            this.groupBox1.Controls.Add(this.btnRead);
            this.groupBox1.Controls.Add(this.btnAppend);
            this.groupBox1.Controls.Add(this.txtBrowsefile);
            this.groupBox1.Controls.Add(this.btnWrite);
            this.groupBox1.Controls.Add(this.btnCopy);
            this.groupBox1.Font = new System.Drawing.Font("Meaza", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 217);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Handling";
            // 
            // btnRename
            // 
            this.btnRename.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold);
            this.btnRename.ForeColor = System.Drawing.Color.Blue;
            this.btnRename.Location = new System.Drawing.Point(388, 128);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(91, 31);
            this.btnRename.TabIndex = 29;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnFile_Info
            // 
            this.btnFile_Info.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold);
            this.btnFile_Info.ForeColor = System.Drawing.Color.Blue;
            this.btnFile_Info.Location = new System.Drawing.Point(296, 178);
            this.btnFile_Info.Name = "btnFile_Info";
            this.btnFile_Info.Size = new System.Drawing.Size(86, 31);
            this.btnFile_Info.TabIndex = 28;
            this.btnFile_Info.Text = "Info";
            this.btnFile_Info.UseVisualStyleBackColor = true;
            this.btnFile_Info.Click += new System.EventHandler(this.btnFile_Info_Click);
            // 
            // richtxtDisplay
            // 
            this.richtxtDisplay.Font = new System.Drawing.Font("Meaza", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtxtDisplay.Location = new System.Drawing.Point(19, 235);
            this.richtxtDisplay.Name = "richtxtDisplay";
            this.richtxtDisplay.Size = new System.Drawing.Size(469, 185);
            this.richtxtDisplay.TabIndex = 29;
            this.richtxtDisplay.Text = "";
            this.richtxtDisplay.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnDirCreate
            // 
            this.btnDirCreate.Location = new System.Drawing.Point(37, 126);
            this.btnDirCreate.Name = "btnDirCreate";
            this.btnDirCreate.Size = new System.Drawing.Size(96, 31);
            this.btnDirCreate.TabIndex = 30;
            this.btnDirCreate.Text = "Create";
            this.btnDirCreate.UseVisualStyleBackColor = true;
            this.btnDirCreate.Click += new System.EventHandler(this.btnDirCreate_Click);
            // 
            // FileHadle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 422);
            this.Controls.Add(this.richtxtDisplay);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FileHadle";
            this.Text = "FileHadle";
            this.Load += new System.EventHandler(this.FileHadle_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TextBox txtBrowsefile;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFile_Info;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.RichTextBox richtxtDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnDirectoryInfo;
        private System.Windows.Forms.Button btnDirLists;
        private System.Windows.Forms.Button btnDirDelete;
        private System.Windows.Forms.Button btnDirMove;
        private System.Windows.Forms.Button btnDirCreate;
    }
}