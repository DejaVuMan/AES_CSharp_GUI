﻿
namespace AES_Fencrypt_GUI
{
    partial class EncryptWindow
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
            this.fileOutput = new System.Windows.Forms.TextBox();
            this.encButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileOutput
            // 
            this.fileOutput.Location = new System.Drawing.Point(12, 12);
            this.fileOutput.Multiline = true;
            this.fileOutput.Name = "fileOutput";
            this.fileOutput.Size = new System.Drawing.Size(520, 450);
            this.fileOutput.TabIndex = 0;
            // 
            // encButton
            // 
            this.encButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encButton.Location = new System.Drawing.Point(12, 493);
            this.encButton.Name = "encButton";
            this.encButton.Size = new System.Drawing.Size(86, 34);
            this.encButton.TabIndex = 2;
            this.encButton.Text = "Encrypt";
            this.encButton.UseVisualStyleBackColor = true;
            this.encButton.Click += new System.EventHandler(this.encButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(446, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Decrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EncryptWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 539);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.encButton);
            this.Controls.Add(this.fileOutput);
            this.Name = "EncryptWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fileOutput;
        private System.Windows.Forms.Button encButton;
        private System.Windows.Forms.Button button1;
    }
}