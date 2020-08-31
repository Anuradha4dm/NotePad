using FileOperationLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace nodepad
{
    public partial class Form1 : Form
    {
        FileOperation fileOperation;
        public Form1()
        {
            InitializeComponent();
            fileOperation = new FileOperation();
            fileOperation.InitializeFile();
            fileViewUpdate();
        }

        private void cutItem_Click(object sender, EventArgs e)
        {
            if(richTextBox.SelectionLength>0)
            {
                Clipboard.SetData(DataFormats.Text, richTextBox.SelectedText);
                richTextBox.SelectedText = String.Empty;
            }
        }

        private void pasteItem_Click(object sender, EventArgs e)
        {
            int position = richTextBox.SelectionStart;
            richTextBox.Text = richTextBox.Text.Insert(position, Clipboard.GetText());
        }

        private void copyItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionLength>0)
            {
                Clipboard.SetData(DataFormats.Text, richTextBox.SelectedText);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cutItem.Enabled = richTextBox.SelectedText.Length > 0 ? true : false;
            copyItem.Enabled = richTextBox.SelectedText.Length > 0 ? true : false;

            pasteItem.Enabled = Clipboard.GetDataObject().GetDataPresent(DataFormats.Text);

        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionLength > 0)
            {
                richTextBox.SelectedText = string.Empty;
            }
        }

        private void fileViewUpdate()
        {
            string filename;
            
            if (!fileOperation.IsSave)
            {
                fileOperation.Filename += "*";
            }else
            {

                filename = fileOperation.Filename;
                fileOperation.Filename = filename.Replace("*","");
                
            }
                this.Text = fileOperation.Filename;
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            fileOperation.IsSave = false;

            if (!fileOperation.Filename.Contains("*"))
            {
                fileOperation.Filename += "*";
                this.Text = fileOperation.Filename;

            }

        }

        private void newItem_Click(object sender, EventArgs e)
        {
            if (fileOperation.IsSave)
            {
                fileOperation.InitializeFile();
                this.Text = fileOperation.Filename;
            }
            else
            {
                MessageBox.Show("Do you need to save file " + fileOperation.Filename, "NodePad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            }
        }

        private void openItemMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog();
            fileOpen.Filter = "text|*.txt";
            fileOpen.InitialDirectory = "D:";

            if (fileOpen.ShowDialog() != DialogResult.Cancel)
            {
                try
                {
                    richTextBox.LoadFile(fileOpen.FileName, RichTextBoxStreamType.PlainText);
                    fileOperation.setFileName(fileOpen.FileName);
                    fileOperation.IsSave = true;
                    fileOperation.InitialSave = true;
                    fileViewUpdate();
                    
                }
                finally
                {
                    fileOperation.FileLocation = fileOpen.FileName;
                }
            }


        }

        private void saveItemMenu_Click(object sender, EventArgs e)
        {
            if (fileOperation.InitialSave)
            {
                richTextBox.SaveFile(fileOperation.FileLocation, RichTextBoxStreamType.PlainText);
                fileOperation.IsSave = true;
                fileViewUpdate();

            }
            else
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.InitialDirectory = "D:";
                saveFile.Filter = "text(*.txt)|*.txt";


                if (saveFile.ShowDialog() != DialogResult.Cancel)
                {

                    try
                    {
                        richTextBox.SaveFile(saveFile.FileName, RichTextBoxStreamType.PlainText);
                        fileOperation.savefile(saveFile.FileName);
                        fileViewUpdate();


                    }
                    finally
                    {
                        fileOperation.InitialSave = true;
                    }
                }
            }
        }

        private void saveAsItemMenu_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.InitialDirectory = "D:";
            saveFile.Filter = "Text(*.txt)|*.txt";

            if (saveFile.ShowDialog() != DialogResult.Cancel)
            {
                try
                {
                    richTextBox.SaveFile(saveFile.FileName, RichTextBoxStreamType.PlainText);
                    fileOperation.savefile(saveFile.FileName);
                    fileViewUpdate();
                }
                catch (Exception)
                {

                    throw ;
                }
            }
        }

        private void exitItemMenu_Click(object sender, EventArgs e)
        {
            if (!fileOperation.IsSave)
            {
                MessageBox.Show("File is not save \n are you sure exis? ","notepad",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            }
            Application.Exit();
        }
    }
}
