
namespace BusinessClubLottery2.Settings {
    partial class NameBox {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.NameListBox = new System.Windows.Forms.CheckedListBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameListBox
            // 
            this.NameListBox.FormattingEnabled = true;
            this.NameListBox.Location = new System.Drawing.Point(13, 13);
            this.NameListBox.MaximumSize = new System.Drawing.Size(259, 328);
            this.NameListBox.MinimumSize = new System.Drawing.Size(259, 328);
            this.NameListBox.Name = "NameListBox";
            this.NameListBox.Size = new System.Drawing.Size(259, 328);
            this.NameListBox.TabIndex = 0;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(146, 347);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(126, 39);
            this.Submit.TabIndex = 1;
            this.Submit.Text = "確定";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.Location = new System.Drawing.Point(13, 347);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(126, 39);
            this.Cancelbtn.TabIndex = 2;
            this.Cancelbtn.Text = "キャンセル";
            this.Cancelbtn.UseVisualStyleBackColor = true;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // NameBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 399);
            this.Controls.Add(this.Cancelbtn);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.NameListBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 438);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 438);
            this.Name = "NameBox";
            this.Text = "欠席者設定";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox NameListBox;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Cancelbtn;
    }
}