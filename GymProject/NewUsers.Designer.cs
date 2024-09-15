namespace GymProject
{
    partial class NewUsers
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
            this.lblName = new Label();
            this.txtName = new TextBox();
            this.lblLastName = new Label();
            this.txtLastName = new TextBox();
            this.lblPhoneNumber = new Label();
            this.txtEmail = new TextBox();
            this.btnNewUser = new Button();
            this.lblIdNumber = new Label();
            this.txtIdNumber = new TextBox();
            this.label1 = new Label();
            this.txtPhoneNumber = new TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new Point(119, 157);
            this.lblName.Name = "lblName";
            this.lblName.Size = new Size(82, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre:";
            // 
            // txtName
            // 
            this.txtName.Location = new Point(321, 154);
            this.txtName.Name = "txtName";
            this.txtName.Size = new Size(279, 31);
            this.txtName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new Point(119, 237);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new Size(82, 25);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Apellido:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new Point(321, 231);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new Size(279, 31);
            this.txtLastName.TabIndex = 3;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new Point(119, 363);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new Size(136, 25);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "Numero celular:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new Point(321, 301);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(279, 31);
            this.txtEmail.TabIndex = 5;
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new Point(249, 434);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new Size(245, 34);
            this.btnNewUser.TabIndex = 6;
            this.btnNewUser.Text = "agregar";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += this.btnNewUser_Click;
            // 
            // lblIdNumber
            // 
            this.lblIdNumber.AutoSize = true;
            this.lblIdNumber.Location = new Point(119, 91);
            this.lblIdNumber.Name = "lblIdNumber";
            this.lblIdNumber.Size = new Size(190, 25);
            this.lblIdNumber.TabIndex = 7;
            this.lblIdNumber.Text = "Numero identificación:";
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.Location = new Point(321, 88);
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new Size(279, 31);
            this.txtIdNumber.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(119, 307);
            this.label1.Name = "label1";
            this.label1.Size = new Size(58, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Email:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new Point(321, 357);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new Size(279, 31);
            this.txtPhoneNumber.TabIndex = 10;
            // 
            // NewUsers
            // 
            this.AutoScaleDimensions = new SizeF(10F, 25F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(728, 507);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdNumber);
            this.Controls.Add(this.lblIdNumber);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "NewUsers";
            this.Text = "Form1";
            this.Load += this.Form1_Load;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblPhoneNumber;
        private TextBox txtEmail;
        private Button btnNewUser;
        private Label lblIdNumber;
        private TextBox txtIdNumber;
        private Label label1;
        private TextBox txtPhoneNumber;
    }
}
