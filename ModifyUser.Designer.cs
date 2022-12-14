namespace ImageForm {
    partial class ModifyUser {
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nevBox = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.addImage = new System.Windows.Forms.Button();
            this.modifyUserButton = new System.Windows.Forms.Button();
            this.szulDate = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.cancelButton = new System.Windows.Forms.Button();
            this.removeImgButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Születési dátum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Név";
            // 
            // nevBox
            // 
            this.nevBox.Location = new System.Drawing.Point(140, 12);
            this.nevBox.Name = "nevBox";
            this.nevBox.Size = new System.Drawing.Size(288, 22);
            this.nevBox.TabIndex = 12;
            this.nevBox.TextChanged += new System.EventHandler(this.nevBox_TextChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(461, 12);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(127, 89);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 11;
            this.pictureBox.TabStop = false;
            // 
            // addImage
            // 
            this.addImage.Location = new System.Drawing.Point(472, 109);
            this.addImage.Margin = new System.Windows.Forms.Padding(4);
            this.addImage.Name = "addImage";
            this.addImage.Size = new System.Drawing.Size(127, 28);
            this.addImage.TabIndex = 16;
            this.addImage.Text = "Kép módosítása";
            this.addImage.UseVisualStyleBackColor = true;
            this.addImage.Click += new System.EventHandler(this.addImage_Click);
            // 
            // modifyUserButton
            // 
            this.modifyUserButton.Location = new System.Drawing.Point(140, 98);
            this.modifyUserButton.Name = "modifyUserButton";
            this.modifyUserButton.Size = new System.Drawing.Size(171, 39);
            this.modifyUserButton.TabIndex = 17;
            this.modifyUserButton.Text = "Felhasználó módosítása";
            this.modifyUserButton.UseVisualStyleBackColor = true;
            this.modifyUserButton.Click += new System.EventHandler(this.modifyUserButton_Click);
            // 
            // szulDate
            // 
            this.szulDate.Location = new System.Drawing.Point(141, 53);
            this.szulDate.Name = "szulDate";
            this.szulDate.Size = new System.Drawing.Size(287, 22);
            this.szulDate.TabIndex = 18;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(317, 98);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(137, 39);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Mégse";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // removeImgButton
            // 
            this.removeImgButton.Location = new System.Drawing.Point(473, 144);
            this.removeImgButton.Name = "removeImgButton";
            this.removeImgButton.Size = new System.Drawing.Size(127, 31);
            this.removeImgButton.TabIndex = 20;
            this.removeImgButton.Text = "Kép eltávolítása";
            this.removeImgButton.UseVisualStyleBackColor = true;
            this.removeImgButton.Click += new System.EventHandler(this.removeImgButton_Click);
            // 
            // ModifyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 204);
            this.Controls.Add(this.removeImgButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.szulDate);
            this.Controls.Add(this.modifyUserButton);
            this.Controls.Add(this.addImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nevBox);
            this.Controls.Add(this.pictureBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ModifyUser";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Felhasználó módosítása";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModifyUser_FormClosing);
            this.Load += new System.EventHandler(this.ModifyUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nevBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button addImage;
        private System.Windows.Forms.Button modifyUserButton;
        private System.Windows.Forms.DateTimePicker szulDate;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button removeImgButton;
    }
}