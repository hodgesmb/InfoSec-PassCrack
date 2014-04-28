namespace PassCrack
{
    partial class PassCrackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassCrackForm));
            this.dictionaryLbl = new System.Windows.Forms.Label();
            this.hashValLbl = new System.Windows.Forms.Label();
            this.fileSelLbl = new System.Windows.Forms.Label();
            this.hashInputField = new System.Windows.Forms.TextBox();
            this.crackBtn = new System.Windows.Forms.Button();
            this.selectFileBtn = new System.Windows.Forms.Button();
            this.currentHashLbl = new System.Windows.Forms.Label();
            this.hashLbl = new System.Windows.Forms.Label();
            this.currentWordLbl = new System.Windows.Forms.Label();
            this.passwdLbl = new System.Windows.Forms.Label();
            this.passwdResLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wordCountLbl = new System.Windows.Forms.Label();
            this.wordCountNumLbl = new System.Windows.Forms.Label();
            this.TimeCtrLbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dictionaryLbl
            // 
            this.dictionaryLbl.AutoSize = true;
            this.dictionaryLbl.Location = new System.Drawing.Point(13, 13);
            this.dictionaryLbl.Name = "dictionaryLbl";
            this.dictionaryLbl.Size = new System.Drawing.Size(79, 13);
            this.dictionaryLbl.TabIndex = 0;
            this.dictionaryLbl.Text = "Dictionary File: ";
            // 
            // hashValLbl
            // 
            this.hashValLbl.AutoSize = true;
            this.hashValLbl.Location = new System.Drawing.Point(13, 80);
            this.hashValLbl.Name = "hashValLbl";
            this.hashValLbl.Size = new System.Drawing.Size(107, 13);
            this.hashValLbl.TabIndex = 1;
            this.hashValLbl.Text = "Hash Value Desired: ";
            // 
            // fileSelLbl
            // 
            this.fileSelLbl.AutoSize = true;
            this.fileSelLbl.Location = new System.Drawing.Point(98, 13);
            this.fileSelLbl.Name = "fileSelLbl";
            this.fileSelLbl.Size = new System.Drawing.Size(85, 13);
            this.fileSelLbl.TabIndex = 5;
            this.fileSelLbl.Text = "No File Selected";
            // 
            // hashInputField
            // 
            this.hashInputField.Location = new System.Drawing.Point(145, 77);
            this.hashInputField.Name = "hashInputField";
            this.hashInputField.Size = new System.Drawing.Size(321, 20);
            this.hashInputField.TabIndex = 8;
            this.hashInputField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hashInputField_KeyPress);
            // 
            // crackBtn
            // 
            this.crackBtn.Location = new System.Drawing.Point(483, 74);
            this.crackBtn.Name = "crackBtn";
            this.crackBtn.Size = new System.Drawing.Size(75, 23);
            this.crackBtn.TabIndex = 9;
            this.crackBtn.Text = "Crack!";
            this.crackBtn.UseVisualStyleBackColor = true;
            this.crackBtn.Click += new System.EventHandler(this.crackBtn_Click);
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.Location = new System.Drawing.Point(16, 40);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(75, 23);
            this.selectFileBtn.TabIndex = 10;
            this.selectFileBtn.Text = "Select File";
            this.selectFileBtn.UseVisualStyleBackColor = true;
            this.selectFileBtn.Click += new System.EventHandler(this.selectFileBtn_Click);
            // 
            // currentHashLbl
            // 
            this.currentHashLbl.AutoSize = true;
            this.currentHashLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentHashLbl.Location = new System.Drawing.Point(186, 147);
            this.currentHashLbl.Name = "currentHashLbl";
            this.currentHashLbl.Size = new System.Drawing.Size(42, 24);
            this.currentHashLbl.TabIndex = 11;
            this.currentHashLbl.Text = "N/A";
            // 
            // hashLbl
            // 
            this.hashLbl.AutoSize = true;
            this.hashLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hashLbl.Location = new System.Drawing.Point(21, 147);
            this.hashLbl.Name = "hashLbl";
            this.hashLbl.Size = new System.Drawing.Size(131, 24);
            this.hashLbl.TabIndex = 12;
            this.hashLbl.Text = "Current Hash: ";
            // 
            // currentWordLbl
            // 
            this.currentWordLbl.AutoSize = true;
            this.currentWordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentWordLbl.Location = new System.Drawing.Point(186, 114);
            this.currentWordLbl.Name = "currentWordLbl";
            this.currentWordLbl.Size = new System.Drawing.Size(42, 24);
            this.currentWordLbl.TabIndex = 14;
            this.currentWordLbl.Text = "N/A";
            // 
            // passwdLbl
            // 
            this.passwdLbl.AutoSize = true;
            this.passwdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdLbl.Location = new System.Drawing.Point(21, 266);
            this.passwdLbl.Name = "passwdLbl";
            this.passwdLbl.Size = new System.Drawing.Size(159, 24);
            this.passwdLbl.TabIndex = 15;
            this.passwdLbl.Text = "Password Result: ";
            // 
            // passwdResLbl
            // 
            this.passwdResLbl.AutoSize = true;
            this.passwdResLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdResLbl.ForeColor = System.Drawing.Color.Red;
            this.passwdResLbl.Location = new System.Drawing.Point(186, 266);
            this.passwdResLbl.Name = "passwdResLbl";
            this.passwdResLbl.Size = new System.Drawing.Size(42, 24);
            this.passwdResLbl.TabIndex = 16;
            this.passwdResLbl.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Current Password: ";
            // 
            // wordCountLbl
            // 
            this.wordCountLbl.AutoSize = true;
            this.wordCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordCountLbl.Location = new System.Drawing.Point(21, 180);
            this.wordCountLbl.Name = "wordCountLbl";
            this.wordCountLbl.Size = new System.Drawing.Size(121, 24);
            this.wordCountLbl.TabIndex = 20;
            this.wordCountLbl.Text = "Word Count: ";
            // 
            // wordCountNumLbl
            // 
            this.wordCountNumLbl.AutoSize = true;
            this.wordCountNumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordCountNumLbl.Location = new System.Drawing.Point(186, 180);
            this.wordCountNumLbl.Name = "wordCountNumLbl";
            this.wordCountNumLbl.Size = new System.Drawing.Size(20, 24);
            this.wordCountNumLbl.TabIndex = 19;
            this.wordCountNumLbl.Text = "0";
            // 
            // TimeCtrLbl
            // 
            this.TimeCtrLbl.AutoSize = true;
            this.TimeCtrLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeCtrLbl.Location = new System.Drawing.Point(21, 213);
            this.TimeCtrLbl.Name = "TimeCtrLbl";
            this.TimeCtrLbl.Size = new System.Drawing.Size(109, 24);
            this.TimeCtrLbl.TabIndex = 21;
            this.TimeCtrLbl.Text = "Total Time: ";
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLbl.Location = new System.Drawing.Point(186, 213);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(105, 24);
            this.timeLbl.TabIndex = 22;
            this.timeLbl.Text = "00:00:00:00";
            // 
            // PassCrackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 308);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.TimeCtrLbl);
            this.Controls.Add(this.wordCountLbl);
            this.Controls.Add(this.wordCountNumLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwdResLbl);
            this.Controls.Add(this.passwdLbl);
            this.Controls.Add(this.currentWordLbl);
            this.Controls.Add(this.hashLbl);
            this.Controls.Add(this.currentHashLbl);
            this.Controls.Add(this.selectFileBtn);
            this.Controls.Add(this.crackBtn);
            this.Controls.Add(this.hashInputField);
            this.Controls.Add(this.fileSelLbl);
            this.Controls.Add(this.hashValLbl);
            this.Controls.Add(this.dictionaryLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PassCrackForm";
            this.Text = "PassCrack Password Cracking";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PassCrackForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dictionaryLbl;
        private System.Windows.Forms.Label hashValLbl;
        private System.Windows.Forms.Label fileSelLbl;
        private System.Windows.Forms.TextBox hashInputField;
        private System.Windows.Forms.Button crackBtn;
        private System.Windows.Forms.Button selectFileBtn;
        private System.Windows.Forms.Label currentHashLbl;
        private System.Windows.Forms.Label hashLbl;
        private System.Windows.Forms.Label currentWordLbl;
        private System.Windows.Forms.Label passwdLbl;
        private System.Windows.Forms.Label passwdResLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label wordCountLbl;
        private System.Windows.Forms.Label wordCountNumLbl;
        private System.Windows.Forms.Label TimeCtrLbl;
        private System.Windows.Forms.Label timeLbl;
    }
}

