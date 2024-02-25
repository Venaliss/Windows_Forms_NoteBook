using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace NoteBook
{
    public partial class NoteBook : Form
    {
        private string _openFile;
        public NoteBook()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItemCreate_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Создать";
            dialog.Filter = "Текстовый документ(*.txt)|*.txt|Все файлы(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(dialog.FileName, RichTextBoxStreamType.PlainText);
                _openFile = dialog.FileName;
            }
        }

        private void ToolStripMenuItemSafe_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog_save = new SaveFileDialog();
            dialog_save.Title = "Сохранить";
            dialog_save.Filter = "Текстовый документ(*.txt)|*.txt|Все файлы(*.*)|*.*";
            if (dialog_save.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(dialog_save.FileName, false, Encoding.UTF8))
                {
                    writer.Write(richTextBox1.Text);
                }

                _openFile = dialog_save.FileName;
            }
        }

        private void ToolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog_open = new OpenFileDialog();
            dialog_open.Title = "Открыть";
            dialog_open.Filter = "Текстовый документ(*.txt)|*.txt|Все файлы(*.*)|*.*";
                if (dialog_open.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader reader = new StreamReader(dialog_open.FileName, Encoding.UTF8))
                    {
                        richTextBox1.Text = reader.ReadToEnd();
                    }
                    _openFile = dialog_open.FileName;
                }
        }

        private void ToolStripMenuItemPrint_Click(object sender, EventArgs e)
        {
            PrintDocument prnt_doc = new PrintDocument();
            prnt_doc.PrintPage += PrintPageH;
            PrintDialog prnt_dialog = new PrintDialog();
            prnt_dialog.Document = prnt_doc;
            if (prnt_dialog.ShowDialog() == DialogResult.OK)
            {
                prnt_dialog.Document.Print();
            }
        }
        public void PrintPageH(object sender, PrintPageEventArgs Event)
        {
            Event.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, 0, 0);
        }

        private void ToolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripMenuItemChangeColor_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.ShowDialog();
            richTextBox1.SelectionColor = color.Color;
        }

        private void ToolStripMenuItemFont_Click(object sender, EventArgs e)
        {
            FontDialog font_change = new FontDialog();
            if (font_change.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = font_change.Font;
            }
        }

        private void ToolStripMenuItemPaste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void ToolStripMenuItemCut_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void ToolStripMenuItemCopy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void ToolStripMenuItem_Click_ProgramInfo(object sender, EventArgs e)
        {
            MessageBox.Show("О программе - NotePad\n\nБлокнот - это текстовый редактор, который разработан и выпускается мной. Используется для создания и редактирования текстовых документов.\n\nВерсия: 0.1\nАвторы: Venaliss\n\nДата публикации: 25.02.2024", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);      
        }

        private void ToolStripMenuItemSaveChange_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog dialog = new OpenFileDialog();
            try
            {
                File.WriteAllText(_openFile, richTextBox1.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Ошибка сохранения файла. Файл не был открыт или создан.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
