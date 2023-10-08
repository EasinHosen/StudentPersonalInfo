namespace StudentPersonalInfo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pbUpload = new PictureBox();
            btnUpload = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtPhone = new TextBox();
            txtEamil = new TextBox();
            txtFName = new TextBox();
            txtMName = new TextBox();
            txtAddress = new TextBox();
            btnAddMore = new Button();
            btnViewAll = new Button();
            ((System.ComponentModel.ISupportInitialize)pbUpload).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(395, 9);
            label1.Name = "label1";
            label1.Size = new Size(415, 37);
            label1.TabIndex = 0;
            label1.Text = "Student's Personal Information";
            // 
            // pbUpload
            // 
            pbUpload.Image = Properties.Resources.person_placeholder;
            pbUpload.Location = new Point(857, 107);
            pbUpload.Name = "pbUpload";
            pbUpload.Size = new Size(185, 176);
            pbUpload.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUpload.TabIndex = 1;
            pbUpload.TabStop = false;
            // 
            // btnUpload
            // 
            btnUpload.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpload.Location = new Point(884, 298);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(132, 40);
            btnUpload.TabIndex = 2;
            btnUpload.Text = "Upload Photo";
            btnUpload.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(34, 109);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 3;
            label2.Text = "Student's ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(34, 256);
            label3.Name = "label3";
            label3.Size = new Size(112, 21);
            label3.TabIndex = 3;
            label3.Text = "Father's Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(34, 297);
            label4.Name = "label4";
            label4.Size = new Size(122, 21);
            label4.TabIndex = 3;
            label4.Text = "Mother's Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(34, 334);
            label5.Name = "label5";
            label5.Size = new Size(142, 21);
            label5.TabIndex = 3;
            label5.Text = "Student's Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(34, 147);
            label6.Name = "label6";
            label6.Size = new Size(125, 21);
            label6.TabIndex = 3;
            label6.Text = "Student's Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(34, 181);
            label7.Name = "label7";
            label7.Size = new Size(128, 21);
            label7.TabIndex = 3;
            label7.Text = "Student's Phone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(34, 217);
            label8.Name = "label8";
            label8.Size = new Size(120, 21);
            label8.TabIndex = 3;
            label8.Text = "Student's Email";
            // 
            // txtID
            // 
            txtID.Location = new Point(276, 107);
            txtID.Name = "txtID";
            txtID.Size = new Size(380, 23);
            txtID.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(276, 145);
            txtName.Name = "txtName";
            txtName.Size = new Size(380, 23);
            txtName.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(276, 179);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(380, 23);
            txtPhone.TabIndex = 4;
            // 
            // txtEamil
            // 
            txtEamil.Location = new Point(276, 215);
            txtEamil.Name = "txtEamil";
            txtEamil.Size = new Size(380, 23);
            txtEamil.TabIndex = 4;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(276, 254);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(380, 23);
            txtFName.TabIndex = 4;
            // 
            // txtMName
            // 
            txtMName.Location = new Point(276, 295);
            txtMName.Name = "txtMName";
            txtMName.Size = new Size(380, 23);
            txtMName.TabIndex = 4;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(276, 332);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(380, 23);
            txtAddress.TabIndex = 4;
            // 
            // btnAddMore
            // 
            btnAddMore.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddMore.Location = new Point(276, 414);
            btnAddMore.Name = "btnAddMore";
            btnAddMore.Size = new Size(185, 67);
            btnAddMore.TabIndex = 5;
            btnAddMore.Text = "Insert More(+)";
            btnAddMore.UseVisualStyleBackColor = true;
            // 
            // btnViewAll
            // 
            btnViewAll.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewAll.Location = new Point(857, 412);
            btnViewAll.Name = "btnViewAll";
            btnViewAll.Size = new Size(185, 67);
            btnViewAll.TabIndex = 5;
            btnViewAll.Text = "View All >>";
            btnViewAll.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1075, 536);
            Controls.Add(btnViewAll);
            Controls.Add(btnAddMore);
            Controls.Add(txtAddress);
            Controls.Add(txtMName);
            Controls.Add(txtFName);
            Controls.Add(txtEamil);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(btnUpload);
            Controls.Add(pbUpload);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbUpload).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pbUpload;
        private Button btnUpload;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtEamil;
        private TextBox txtFName;
        private TextBox txtMName;
        private TextBox txtAddress;
        private Button btnAddMore;
        private Button btnViewAll;
    }
}