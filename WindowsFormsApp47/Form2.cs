using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp47
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ToolTip ipucu = new ToolTip();
            ipucu.SetToolTip(maskedTextBox3, "Tc Kimliğinizi Giriniz");
            ipucu.SetToolTip(textBox2, "Adınızı Giriniz");
            ipucu.SetToolTip(textBox3, "Soyadınızı Giriniz");
            ipucu.SetToolTip(maskedTextBox1, "Şifrenizi Giriniz");
            ipucu.SetToolTip(maskedTextBox2, "Doğum Tarihinizi Giriniz");
            ipucu.SetToolTip(button1,"Onayla");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = maskedTextBox3.Text;
            string b = textBox2.Text;
            string c = textBox3.Text;
            string d = maskedTextBox1.Text;
            string f = maskedTextBox2.Text;


            richTextBox1.Text = richTextBox1.Text + a + " " + b + " " + c +" "+ d +" "+ f +" "+"\n";
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Dosyaları | *.txt";
            DialogResult cevap = ofd.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                richTextBox1.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
            }

        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "text dosyası | *.txt| tüm dosyalar | *.*";
            DialogResult cevap = sfd.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                richTextBox1.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo);


            if (soru == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            DialogResult cevap = pd.ShowDialog();
            if (cevap == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void renkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = cd.Color;
            }
        }

        private void biçimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fd.Font;
            }
        }
    }
}
