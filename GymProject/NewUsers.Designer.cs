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
            this.lbl1 = new Label();
            this.textBox3 = new TextBox();
            this.btnNewUser = new Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new Point(119, 81);
            this.lblName.Name = "lblName";
            this.lblName.Size = new Size(82, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre:";
            // 
            // txtName
            // 
            this.txtName.Location = new Point(321, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new Size(279, 31);
            this.txtName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new Point(119, 166);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new Size(82, 25);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Apellido:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new Point(321, 160);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new Size(279, 31);
            this.txtLastName.TabIndex = 3;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new Point(119, 253);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new Size(56, 25);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Edad:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new Point(321, 247);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Size(279, 31);
            this.textBox3.TabIndex = 5;
            // 
            // btnNewUser
            // 
            this.btnNewUser.Location = new Point(270, 365);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new Size(245, 34);
            this.btnNewUser.TabIndex = 6;
            this.btnNewUser.Text = "agregar";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += this.btnNewUser_Click;
            // 
            // NewUsers
            // 
            this.AutoScaleDimensions = new SizeF(10F, 25F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(728, 507);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lbl1);
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
        private Label lbl1;
        private TextBox textBox3;
        private Button btnNewUser;
    }
}
