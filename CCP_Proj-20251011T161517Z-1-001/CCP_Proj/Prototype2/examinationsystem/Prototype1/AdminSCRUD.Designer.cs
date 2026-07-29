
namespace Prototype1
{
    partial class AdminSCRUD
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
            this.btnAStudScrud = new System.Windows.Forms.Button();
            this.btnATeachScrud = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAStudScrud
            // 
            this.btnAStudScrud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAStudScrud.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAStudScrud.ForeColor = System.Drawing.Color.Brown;
            this.btnAStudScrud.Location = new System.Drawing.Point(28, 92);
            this.btnAStudScrud.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAStudScrud.Name = "btnAStudScrud";
            this.btnAStudScrud.Size = new System.Drawing.Size(622, 137);
            this.btnAStudScrud.TabIndex = 8;
            this.btnAStudScrud.Text = "Student SCRUD";
            this.btnAStudScrud.UseVisualStyleBackColor = false;
            this.btnAStudScrud.Click += new System.EventHandler(this.btnAStudScrud_Click);
            // 
            // btnATeachScrud
            // 
            this.btnATeachScrud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnATeachScrud.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnATeachScrud.ForeColor = System.Drawing.Color.Brown;
            this.btnATeachScrud.Location = new System.Drawing.Point(28, 247);
            this.btnATeachScrud.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnATeachScrud.Name = "btnATeachScrud";
            this.btnATeachScrud.Size = new System.Drawing.Size(622, 137);
            this.btnATeachScrud.TabIndex = 9;
            this.btnATeachScrud.Text = "Teacher SCRUD";
            this.btnATeachScrud.UseVisualStyleBackColor = false;
            this.btnATeachScrud.Click += new System.EventHandler(this.btnATeachScrud_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Snow;
            this.btnLogout.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.Brown;
            this.btnLogout.Location = new System.Drawing.Point(526, 392);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(115, 51);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.btnAStudScrud);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnATeachScrud);
            this.panel1.Location = new System.Drawing.Point(258, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 474);
            this.panel1.TabIndex = 11;
            // 
            // AdminSCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = global::Prototype1.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1191, 672);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminSCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminSCRUD";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAStudScrud;
        private System.Windows.Forms.Button btnATeachScrud;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
    }
}