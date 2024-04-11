namespace renameform.RenameOption
{
    partial class OptionForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAllSame = new System.Windows.Forms.RadioButton();
            this.rbReplace = new System.Windows.Forms.RadioButton();
            this.rbAddBack = new System.Windows.Forms.RadioButton();
            this.rbAddFront = new System.Windows.Forms.RadioButton();
            this.cbInteger = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "決定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "戻る";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAllSame);
            this.groupBox1.Controls.Add(this.rbReplace);
            this.groupBox1.Controls.Add(this.rbAddBack);
            this.groupBox1.Controls.Add(this.rbAddFront);
            this.groupBox1.Location = new System.Drawing.Point(30, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 125);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "編集項目";
            // 
            // rbAllSame
            // 
            this.rbAllSame.AutoSize = true;
            this.rbAllSame.Location = new System.Drawing.Point(6, 84);
            this.rbAllSame.Name = "rbAllSame";
            this.rbAllSame.Size = new System.Drawing.Size(96, 16);
            this.rbAllSame.TabIndex = 3;
            this.rbAllSame.Text = "全て同一にする";
            this.rbAllSame.UseVisualStyleBackColor = true;
            // 
            // rbReplace
            // 
            this.rbReplace.AutoSize = true;
            this.rbReplace.Location = new System.Drawing.Point(6, 62);
            this.rbReplace.Name = "rbReplace";
            this.rbReplace.Size = new System.Drawing.Size(66, 16);
            this.rbReplace.TabIndex = 2;
            this.rbReplace.Text = "置換する";
            this.rbReplace.UseVisualStyleBackColor = true;
            // 
            // rbAddBack
            // 
            this.rbAddBack.AutoSize = true;
            this.rbAddBack.Location = new System.Drawing.Point(6, 40);
            this.rbAddBack.Name = "rbAddBack";
            this.rbAddBack.Size = new System.Drawing.Size(86, 16);
            this.rbAddBack.TabIndex = 1;
            this.rbAddBack.Text = "後方に加える";
            this.rbAddBack.UseVisualStyleBackColor = true;
            // 
            // rbAddFront
            // 
            this.rbAddFront.AutoSize = true;
            this.rbAddFront.Location = new System.Drawing.Point(6, 18);
            this.rbAddFront.Name = "rbAddFront";
            this.rbAddFront.Size = new System.Drawing.Size(86, 16);
            this.rbAddFront.TabIndex = 0;
            this.rbAddFront.Text = "先頭に加える";
            this.rbAddFront.UseVisualStyleBackColor = true;
            // 
            // cbInteger
            // 
            this.cbInteger.AutoSize = true;
            this.cbInteger.Location = new System.Drawing.Point(165, 61);
            this.cbInteger.Name = "cbInteger";
            this.cbInteger.Size = new System.Drawing.Size(149, 28);
            this.cbInteger.TabIndex = 3;
            this.cbInteger.Text = "数値を追加する\r\n(先頭/後方に加える場合)";
            this.cbInteger.UseVisualStyleBackColor = true;
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 285);
            this.ControlBox = false;
            this.Controls.Add(this.cbInteger);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "OptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OptionForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private void BoolDelivery()
        {
            rbAddFront.Checked = optionFormBool.AddFront ? true : false;
            rbAddBack.Checked = optionFormBool.AddBack ? true : false;
            rbReplace.Checked = optionFormBool.Replace ? true : false;
            rbAllSame.Checked = optionFormBool.AllSame ? true : false;
            cbInteger.Checked = optionFormBool.AddInteger ? true : false;
        }


        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAllSame;
        private System.Windows.Forms.RadioButton rbReplace;
        private System.Windows.Forms.RadioButton rbAddBack;
        private System.Windows.Forms.RadioButton rbAddFront;
        private System.Windows.Forms.CheckBox cbInteger;
    }
}