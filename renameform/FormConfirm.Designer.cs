namespace renameform
{
    partial class FormConfirm
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
            this.tb = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb
            // 
            this.tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tb.Location = new System.Drawing.Point(0, 0);
            this.tb.Multiline = true;
            this.tb.Name = "tb";
            this.tb.ReadOnly = true;
            this.tb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb.Size = new System.Drawing.Size(804, 404);
            this.tb.TabIndex = 0;
            // 
            // btOk
            // 
            this.btOk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btOk.Location = new System.Drawing.Point(0, 381);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(804, 23);
            this.btOk.TabIndex = 1;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btCancel.Location = new System.Drawing.Point(0, 358);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(804, 23);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // FormConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 404);
            this.ControlBox = false;
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.tb);
            this.Name = "FormConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "変更内容";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
    }
}