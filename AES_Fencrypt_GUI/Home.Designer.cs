
namespace AES_Fencrypt_GUI
{
    partial class Home
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.aboutButton = new System.Windows.Forms.Button();
            this.fileSelLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.openTxt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(254, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(273, 38);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Text Encryption Tool";
            // 
            // aboutButton
            // 
            this.aboutButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.aboutButton.Location = new System.Drawing.Point(12, 406);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(75, 32);
            this.aboutButton.TabIndex = 1;
            this.aboutButton.Text = "About...";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // fileSelLabel
            // 
            this.fileSelLabel.AutoSize = true;
            this.fileSelLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileSelLabel.Location = new System.Drawing.Point(12, 141);
            this.fileSelLabel.Name = "fileSelLabel";
            this.fileSelLabel.Size = new System.Drawing.Size(125, 28);
            this.fileSelLabel.TabIndex = 2;
            this.fileSelLabel.Text = "Selected File:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 22);
            this.textBox1.TabIndex = 3;
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.browseButton.Location = new System.Drawing.Point(385, 140);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(93, 32);
            this.browseButton.TabIndex = 4;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // openTxt
            // 
            this.openTxt.Enabled = false;
            this.openTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.openTxt.Location = new System.Drawing.Point(484, 140);
            this.openTxt.Name = "openTxt";
            this.openTxt.Size = new System.Drawing.Size(75, 32);
            this.openTxt.TabIndex = 5;
            this.openTxt.Text = "Open...   ";
            this.openTxt.UseVisualStyleBackColor = true;
            this.openTxt.Click += new System.EventHandler(this.openTxt_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openTxt);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fileSelLabel);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "Home";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Label fileSelLabel;
        private System.Windows.Forms.Button browseButton;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button openTxt;
    }
}