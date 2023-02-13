
namespace Cars_request
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
            this.listShow = new System.Windows.Forms.ListBox();
            this.btnShowFile = new System.Windows.Forms.Button();
            this.btnShowList = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLinkOfFile = new System.Windows.Forms.Label();
            this.btnSelecttFile = new System.Windows.Forms.Button();
            this.txtCarKind = new System.Windows.Forms.TextBox();
            this.txtCarColor = new System.Windows.Forms.TextBox();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.lblRandom = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listShow
            // 
            this.listShow.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listShow.FormattingEnabled = true;
            this.listShow.Location = new System.Drawing.Point(445, 9);
            this.listShow.Name = "listShow";
            this.listShow.Size = new System.Drawing.Size(246, 290);
            this.listShow.TabIndex = 0;
            // 
            // btnShowFile
            // 
            this.btnShowFile.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFile.Location = new System.Drawing.Point(577, 305);
            this.btnShowFile.Name = "btnShowFile";
            this.btnShowFile.Size = new System.Drawing.Size(99, 41);
            this.btnShowFile.TabIndex = 1;
            this.btnShowFile.Text = "Show from file";
            this.btnShowFile.UseVisualStyleBackColor = true;
            this.btnShowFile.Click += new System.EventHandler(this.btnShowFile_Click);
            // 
            // btnShowList
            // 
            this.btnShowList.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowList.Location = new System.Drawing.Point(451, 305);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(109, 41);
            this.btnShowList.TabIndex = 2;
            this.btnShowList.Text = "Show from list";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.lblLinkOfFile);
            this.groupBox1.Controls.Add(this.btnSelecttFile);
            this.groupBox1.Controls.Add(this.txtCarKind);
            this.groupBox1.Controls.Add(this.txtCarColor);
            this.groupBox1.Controls.Add(this.txtCarName);
            this.groupBox1.Controls.Add(this.lblRandom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.btnEnter);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 287);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add request";
            // 
            // lblLinkOfFile
            // 
            this.lblLinkOfFile.AutoSize = true;
            this.lblLinkOfFile.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkOfFile.Location = new System.Drawing.Point(146, 233);
            this.lblLinkOfFile.Name = "lblLinkOfFile";
            this.lblLinkOfFile.Size = new System.Drawing.Size(31, 14);
            this.lblLinkOfFile.TabIndex = 8;
            this.lblLinkOfFile.Text = "Non";
            // 
            // btnSelecttFile
            // 
            this.btnSelecttFile.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecttFile.Location = new System.Drawing.Point(149, 189);
            this.btnSelecttFile.Name = "btnSelecttFile";
            this.btnSelecttFile.Size = new System.Drawing.Size(101, 29);
            this.btnSelecttFile.TabIndex = 7;
            this.btnSelecttFile.Text = "Browse file";
            this.btnSelecttFile.UseVisualStyleBackColor = true;
            this.btnSelecttFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtCarKind
            // 
            this.txtCarKind.Location = new System.Drawing.Point(200, 127);
            this.txtCarKind.Name = "txtCarKind";
            this.txtCarKind.Size = new System.Drawing.Size(124, 20);
            this.txtCarKind.TabIndex = 6;
            // 
            // txtCarColor
            // 
            this.txtCarColor.Location = new System.Drawing.Point(200, 90);
            this.txtCarColor.Name = "txtCarColor";
            this.txtCarColor.Size = new System.Drawing.Size(124, 20);
            this.txtCarColor.TabIndex = 6;
            // 
            // txtCarName
            // 
            this.txtCarName.Location = new System.Drawing.Point(200, 50);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.Size = new System.Drawing.Size(124, 20);
            this.txtCarName.TabIndex = 6;
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandom.Location = new System.Drawing.Point(197, 16);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(16, 16);
            this.lblRandom.TabIndex = 5;
            this.lblRandom.Text = "0";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(77, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter kind of car : ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter car color : ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter car name :";
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(77, 16);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(85, 16);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "ID of car : ";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(149, 253);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(101, 28);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Enter to file";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(528, 352);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(178, 345);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(716, 387);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.btnShowFile);
            this.Controls.Add(this.listShow);
            this.Name = "Form1";
            this.Text = "Sami Bakkar Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listShow;
        private System.Windows.Forms.Button btnShowFile;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblLinkOfFile;
        private System.Windows.Forms.TextBox txtCarKind;
        private System.Windows.Forms.TextBox txtCarColor;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        protected System.Windows.Forms.Button btnSelecttFile;
    }
}

