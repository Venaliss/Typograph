using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typograph
{
    public partial class Form1 : Form
    {
        private string fileName;
        Commands cmd = new Commands();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string text = txtBoxBefore.Text;

            text = cmd.punctuationsFix(text);
            text = cmd.replacePlusMinusSymbol(text);
            text = cmd.replaceDefisNumberRange(text);
            text = cmd.myRuleCapitalLetter(text);
            text = cmd.myRuleReplaceEllipsis(text);
            text = cmd.nonSpaceBeforeDash(text);
            text = cmd.removeExcessiveSpaces(text);

            txtBoxAfter.Text = text;
        }

        private void btnAbsurd_Click(object sender, EventArgs e)
        {
            string text = txtBoxBefore.Text;
            text = cmd.myAbsurdRule(text);

            txtBoxAfter.Text = text;
        }

        private void openFileToolStrip_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog.FileName;
                string fileText = File.ReadAllText(fileName);
                txtBoxBefore.Text = fileText;
            }
        }

        private void saveFileToolStrip_Click(object sender, EventArgs e)
        {
            if (fileName != null)
            {
                File.WriteAllText(fileName, txtBoxAfter.Text);
                MessageBox.Show("Файл успешно сохранен.");
            }
            else
            {
                MessageBox.Show("Пожалуйста, первым делом откройте файл");
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBoxBefore.Clear();
        }

        private void CutToolMenu_Click(object sender, EventArgs e)
        {
            txtBoxBefore.Cut();
        }

        private void CopyToolMenu_Click(object sender, EventArgs e)
        {
            txtBoxBefore.Copy();
        }

        private void PasteToolMenu_Click(object sender, EventArgs e)
        {
            txtBoxBefore.Paste();
        }
    }
}
