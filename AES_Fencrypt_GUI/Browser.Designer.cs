
namespace AES_Fencrypt_GUI
{
    partial class Browser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            this.backbutton = new System.Windows.Forms.Button();
            this.gobutton = new System.Windows.Forms.Button();
            this.fileListBox = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.filePathBox = new System.Windows.Forms.TextBox();
            this.filename = new System.Windows.Forms.Label();
            this.filetype = new System.Windows.Forms.Label();
            this.fntype = new System.Windows.Forms.Label();
            this.fnlabel = new System.Windows.Forms.Label();
            this.selectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backbutton
            // 
            this.backbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.Location = new System.Drawing.Point(12, 404);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(78, 34);
            this.backbutton.TabIndex = 0;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // gobutton
            // 
            this.gobutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gobutton.Location = new System.Drawing.Point(648, 404);
            this.gobutton.Name = "gobutton";
            this.gobutton.Size = new System.Drawing.Size(49, 34);
            this.gobutton.TabIndex = 1;
            this.gobutton.Text = "Go";
            this.gobutton.UseVisualStyleBackColor = true;
            this.gobutton.Click += new System.EventHandler(this.gobutton_Click);
            // 
            // fileListBox
            // 
            this.fileListBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileListBox.HideSelection = false;
            this.fileListBox.LargeImageList = this.iconList;
            this.fileListBox.Location = new System.Drawing.Point(12, 67);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.Size = new System.Drawing.Size(776, 320);
            this.fileListBox.SmallImageList = this.iconList;
            this.fileListBox.TabIndex = 2;
            this.fileListBox.UseCompatibleStateImageBehavior = false;
            this.fileListBox.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.fileListBox_ItemSelectionChanged);
            this.fileListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fileListBox_MouseDoubleClick);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "file-audio-solid.png");
            this.iconList.Images.SetKeyName(1, "file-code-solid.png");
            this.iconList.Images.SetKeyName(2, "file-pdf-solid.png");
            this.iconList.Images.SetKeyName(3, "file-solid.png");
            this.iconList.Images.SetKeyName(4, "file-video-solid.png");
            this.iconList.Images.SetKeyName(5, "file-word-solid.png");
            this.iconList.Images.SetKeyName(6, "folder-open-solid.png");
            this.iconList.Images.SetKeyName(7, "file-medical-solid.png");
            this.iconList.Images.SetKeyName(8, "file-image-solid.png");
            this.iconList.Images.SetKeyName(9, "hdd-solid.png");
            // 
            // filePathBox
            // 
            this.filePathBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePathBox.Location = new System.Drawing.Point(96, 408);
            this.filePathBox.Name = "filePathBox";
            this.filePathBox.Size = new System.Drawing.Size(546, 27);
            this.filePathBox.TabIndex = 3;
            // 
            // filename
            // 
            this.filename.AutoSize = true;
            this.filename.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.filename.Location = new System.Drawing.Point(12, 39);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(95, 25);
            this.filename.TabIndex = 4;
            this.filename.Text = "Filename:";
            // 
            // filetype
            // 
            this.filetype.AutoSize = true;
            this.filetype.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filetype.Location = new System.Drawing.Point(541, 39);
            this.filetype.Name = "filetype";
            this.filetype.Size = new System.Drawing.Size(92, 25);
            this.filetype.TabIndex = 5;
            this.filetype.Text = "File Type:";
            // 
            // fntype
            // 
            this.fntype.AutoSize = true;
            this.fntype.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fntype.Location = new System.Drawing.Point(639, 39);
            this.fntype.Name = "fntype";
            this.fntype.Size = new System.Drawing.Size(28, 25);
            this.fntype.TabIndex = 6;
            this.fntype.Text = "--";
            // 
            // fnlabel
            // 
            this.fnlabel.AutoSize = true;
            this.fnlabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnlabel.Location = new System.Drawing.Point(113, 39);
            this.fnlabel.Name = "fnlabel";
            this.fnlabel.Size = new System.Drawing.Size(28, 25);
            this.fnlabel.TabIndex = 7;
            this.fnlabel.Text = "--";
            // 
            // selectButton
            // 
            this.selectButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectButton.Location = new System.Drawing.Point(703, 404);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(85, 34);
            this.selectButton.TabIndex = 8;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.fnlabel);
            this.Controls.Add(this.fntype);
            this.Controls.Add(this.filetype);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.filePathBox);
            this.Controls.Add(this.fileListBox);
            this.Controls.Add(this.gobutton);
            this.Controls.Add(this.backbutton);
            this.Name = "Browser";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button gobutton;
        private System.Windows.Forms.ListView fileListBox;
        private System.Windows.Forms.Label filename;
        private System.Windows.Forms.Label filetype;
        private System.Windows.Forms.Label fntype;
        private System.Windows.Forms.Label fnlabel;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.Button selectButton;
        public System.Windows.Forms.TextBox filePathBox;
    }
}

