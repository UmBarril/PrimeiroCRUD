namespace CRUD
{
    partial class RegisterEditForm
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
            this.photoBox = new System.Windows.Forms.PictureBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.mobileText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addEditBtn = new System.Windows.Forms.Button();
            this.changePhotoBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // photoBox
            // 
            this.photoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.photoBox.Location = new System.Drawing.Point(42, 45);
            this.photoBox.Name = "photoBox";
            this.photoBox.Size = new System.Drawing.Size(150, 150);
            this.photoBox.TabIndex = 0;
            this.photoBox.TabStop = false;
            // 
            // nameText
            // 
            this.nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.Location = new System.Drawing.Point(211, 45);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(459, 38);
            this.nameText.TabIndex = 1;
            this.nameText.Enter += new System.EventHandler(this.nameText_Enter);
            this.nameText.Leave += new System.EventHandler(this.nameText_Leave);
            // 
            // mobileText
            // 
            this.mobileText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileText.Location = new System.Drawing.Point(211, 89);
            this.mobileText.Name = "mobileText";
            this.mobileText.Size = new System.Drawing.Size(459, 38);
            this.mobileText.TabIndex = 2;
            this.mobileText.Enter += new System.EventHandler(this.mobileText_Enter);
            this.mobileText.Leave += new System.EventHandler(this.mobileText_Leave);
            // 
            // emailText
            // 
            this.emailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailText.Location = new System.Drawing.Point(211, 133);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(459, 38);
            this.emailText.TabIndex = 3;
            this.emailText.Enter += new System.EventHandler(this.emailText_Enter);
            this.emailText.Leave += new System.EventHandler(this.emailText_Leave);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(360, 177);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(310, 35);
            this.dateTimePicker.TabIndex = 4;
            // 
            // addEditBtn
            // 
            this.addEditBtn.Location = new System.Drawing.Point(211, 221);
            this.addEditBtn.Name = "addEditBtn";
            this.addEditBtn.Size = new System.Drawing.Size(340, 40);
            this.addEditBtn.TabIndex = 6;
            this.addEditBtn.Text = "Add";
            this.addEditBtn.UseVisualStyleBackColor = true;
            this.addEditBtn.Click += new System.EventHandler(this.addEditBtn_Click);
            // 
            // changePhotoBtn
            // 
            this.changePhotoBtn.Location = new System.Drawing.Point(72, 201);
            this.changePhotoBtn.Name = "changePhotoBtn";
            this.changePhotoBtn.Size = new System.Drawing.Size(90, 28);
            this.changePhotoBtn.TabIndex = 7;
            this.changePhotoBtn.Text = "Change Photo";
            this.changePhotoBtn.UseVisualStyleBackColor = true;
            this.changePhotoBtn.Click += new System.EventHandler(this.changePhotoBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(557, 221);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(113, 40);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Birth Date:";
            // 
            // RegisterEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 296);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.changePhotoBtn);
            this.Controls.Add(this.addEditBtn);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.mobileText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.photoBox);
            this.Name = "RegisterEditForm";
            this.Text = "RegisterEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox photoBox;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox mobileText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button addEditBtn;
        private System.Windows.Forms.Button changePhotoBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label1;
    }
}