using System;
using System.IO;
using System.Data;
using System.Linq;

using System.Text;
using System.Drawing;
using System.Windows.Forms;

using System.Diagnostics;
using System.ComponentModel;
using System.Collections.Generic;

using System.Globalization;

namespace AES_Fencrypt_GUI
{
    public partial class Browser : Form
    {
        private string filePath = "C:\\"; // Default file path explorer will use
        private string currentItemName = "";
        private bool isFile; // compiler automatically initializes to false

        private readonly Home mainform;
        public Browser(Home mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
            loadFilesAndDirectories();
        }

        private void FileExpLoad(object sender, EventArgs e)
        {
            filePathBox.Text = filePath;
            loadFilesAndDirectories();
        }

        public void removeBackslash() // used to enable functionality of "Back" button or remove erroneous slashes
        {
            try
            {
                string path = filePathBox.Text;
                if (path.LastIndexOf('\\') == path.Length - 1)
                {
                    filePathBox.Text = path.Substring(0, path.Length - 1);
                }
            }
            catch(Exception e) // any exception will cause an error to occur and return to "root" directory.
            {
                string[] dList = System.IO.Directory.GetLogicalDrives();
                int dLength = dList.Length;
                fileListBox.Items.Clear();

                for(int i = 0; i < dLength; i++)
                {
                    fileListBox.Items.Add(dList[i], 9);
                }
                MessageBox.Show("An error occurred. returning to drive list directory.");
            }
        }

        public void goBack()
        {
            try
            {
                removeBackslash();
                string path = filePathBox.Text;
                path = path.Substring(0, path.LastIndexOf("\\"));
                this.isFile = false;
                filePathBox.Text = path;
                removeBackslash();
            }
            catch(Exception e)
            {
                MessageBox.Show("An exception occurred: {0}", e.ToString());
            }
        }

        public void loadFilesAndDirectories() // main class used to load files/folders visually
        {
            DirectoryInfo fileList;
            string tempfilepath = "";
            FileAttributes fileAttributes;
            try
            {
                if (isFile) // we cannot display the contents of a singular file
                {
                    tempfilepath = filePath + "\\" + currentItemName;
                    FileInfo fileDetails = new FileInfo(tempfilepath);
                    fnlabel.Text = fileDetails.Name;
                    fntype.Text = fileDetails.Extension;
                    fileAttributes = File.GetAttributes(tempfilepath);
                    Process.Start(tempfilepath);
                }
                else
                {
                    fileAttributes = File.GetAttributes(filePath);
                }

                if((fileAttributes & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    fileList = new DirectoryInfo(filePath);
                    FileInfo[] files = fileList.GetFiles(); // list of files in array
                    DirectoryInfo[] dirs = fileList.GetDirectories(); // list of directories in array
                    string fileExtension = "";

                    fileListBox.Items.Clear();

                    int fLength = files.Length; // only check file length once, minor performance uplift

                    for (int i = 0; i < fLength; i++)
                    {
                        // Switch Gate
                        fileExtension = files[i].Extension.ToUpper(CultureInfo.InvariantCulture);
                        switch(fileExtension)
                        {
                            case ".MP3":
                            case ".MP2":
                            case ".WAV":
                            case ".FLV":
                                fileListBox.Items.Add(files[i].Name, 0);
                                break;
                            case ".EXE":
                            case ".COM":
                                fileListBox.Items.Add(files[i].Name, 1);
                                break;
                            case ".MP4":
                            case ".AVI":
                            case ".MKV":
                                fileListBox.Items.Add(files[i].Name, 4);
                                break;
                            case ".PDF":
                                fileListBox.Items.Add(files[i].Name, 2);
                                break;
                            case ".DOCX":
                            case ".DOC":
                                fileListBox.Items.Add(files[i].Name, 5);
                                break;
                            case ".PNG":
                            case ".JPG":
                            case ".JPEG":
                                fileListBox.Items.Add(files[i].Name, 8);
                                break;

                            default:
                                fileListBox.Items.Add(files[i].Name, 7);
                                break;
                        }
                    }

                    for (int i = 0; i < dirs.Length; i++)
                    {
                        fileListBox.Items.Add(dirs[i].Name, 6);
                    }
                }
                else
                {
                    fnlabel.Text = this.currentItemName;
                }
            }
            catch (Exception e) // markiplier
            {
                MessageBox.Show("An exception occurred: {0}", e.ToString());
            }
        }

        public void loadButtonAction() // when file path is entered and we press go, this part is used in goButton_click
        {
            if(filePathBox.Text == "C:\\")
            {
                
            }
            else
            {
                removeBackslash(); // unique issue with C: drive ?
            }
            filePath = filePathBox.Text;
            loadFilesAndDirectories();
            isFile = false;
        }
        private void gobutton_Click(object sender, EventArgs e)
        {
            loadButtonAction();
        }

        private void fileListBox_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentItemName = e.Item.Text;
            // Exception for Source Drives
            // if CurrentItemName = "%:\\" then file.getAttributes directly from %:\ where % = drive letter

            FileAttributes fileAttr;

            if(currentItemName.EndsWith("\\"))
            {
                isFile = false;
                filePathBox.Text = currentItemName; // allows us to view the "root" directory with all drives listed
            }
            else
            {
                fileAttr = File.GetAttributes(filePath + "\\" + currentItemName);
                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    isFile = false;
                    filePathBox.Text = filePath + "\\" + currentItemName;
                }
                else
                {
                    isFile = true;
                }
            }
        }

        private void fileListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadButtonAction();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            if(filePath.Length == 2)
            {
                string[] dList = System.IO.Directory.GetLogicalDrives();
                int dLength = dList.Length;
                fileListBox.Items.Clear();

                for (int i = 0; i < dLength; i++)
                {
                    fileListBox.Items.Add(dList[i], 9);
                }
            }
            else
            {
                goBack();
                loadButtonAction();
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            mainform.textBox1.Text = filePathBox.Text + "\\" + currentItemName;
            mainform.openTxt.Enabled = true;
            this.Close();
        }
    }
}