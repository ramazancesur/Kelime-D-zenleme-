using FinalliziedProject.Databases;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FinalliziedProject
{
    public partial class Form1 : Form
    {
        ChangableFont changableFont;
        ColorGenerate generate;
        WordProcess wordProcess;
        Spelling spelling;
        DataProcess dbProcess;
        private static string firstValue;
        private static string tempValue;
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
            changableFont = new ChangableFont();
            grpRenk.Visible = false;
            dbProcess = new DataProcess();
            generate = new ColorGenerate();
            wordProcess = new WordProcess();
        }

        // Object orianteda ve aspect orianteda ters

        private List<CheckBox> getSelectedCheckBox()
        {
            List<CheckBox> lstCheck = new List<CheckBox>();

            foreach (CheckBox box in grupBox.Controls.OfType<CheckBox>())
            {
                if (box.Checked)
                {
                    lstCheck.Add(box);
                }
            }

            return lstCheck;
        }
        // Object orianteda ve aspect orianteda ters
        private List<RadioButton> getSelectedRadioBox()
        {
            List<RadioButton> lstCheck = new List<RadioButton>();

            foreach (RadioButton box in grpRenk.Controls.OfType<RadioButton>())
            {
                if (box.Checked)
                {
                    lstCheck.Add(box);
                }
            }

            return lstCheck;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DummyDataCreator dataCreator = new DummyDataCreator();
            try
            {
                dataCreator.createDummyData("ceit436DB");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            comboBox1.DataSource = dbProcess.getAll();
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "text";

        }
      
        

        public string getFilteringText(string applicantText)
        {
            wordProcess = new WordProcess();
            spelling = new Spelling();
            List<CheckBox> lstCheckBox = this.getSelectedCheckBox();
            if ( cbHecelereAyır.Checked)
            {
                applicantText = spelling.getSpellingText(applicantText);
            }
            foreach (var selectedCheckBox in lstCheckBox)
            {
                if (selectedCheckBox.Name.Contains("Kelime"))
                {
                    applicantText = wordProcess.kelimeAyır(applicantText);
                }
                else if (selectedCheckBox.Name.Contains("Cumle"))
                {
                    applicantText = wordProcess.cumlelereAyir(applicantText);
                }
                else if (selectedCheckBox.Name.Contains("Harf"))
                {
                    applicantText = wordProcess.harflereAyır(applicantText);
                }
             
                else if (selectedCheckBox.Name.Contains("Noktalama"))
                {
                    applicantText = wordProcess.noktalamalariKaldir(applicantText);
                }
            }

        
            if (ckRenklendir.Checked)
            {
                List<RadioButton> lstRadioButton = this.getSelectedRadioBox();
                // goto
                Color fontColor = Color.Black;
                foreach (var radioButton in lstRadioButton)
                {

                    // Object orianteda ters
                    if (radioButton.Name.Contains("Kırmızı"))
                    {
                        fontColor = Color.Red;
                    }
                    else if (radioButton.Name.Contains("Mavi"))
                    {
                        fontColor = Color.Blue;
                    }
                    else if (radioButton.Name.Contains("Sarı"))
                    {
                        fontColor = Color.Yellow;
                    }
                    else if (radioButton.Name.Contains("Ye"))
                    {
                        fontColor = Color.Green;
                    }
              
                }
                changableFont.setFontColor(fontColor, txtMetin);

            }
            return applicantText;
        }

        private void btnUygula_Click(object sender, EventArgs e)
        {
            txtMetin.SelectAll();
            txtMetin.SelectionIndent += 15;//play with this values to match yours
            txtMetin.SelectionRightIndent += 15;//this too
            txtMetin.SelectionLength = 0;
            // deneyeceğim

            if (count == 0)
            {
                firstValue = txtMetin.Text;
                count++;
            }
            tempValue = txtMetin.Text;
            if(this.getSelectedCheckBox().Count == 0)
            {
                MessageBox.Show("Seçim Yapmadınız Lutfen Seçim Yapınız...");
            }
            else if (this.getSelectedCheckBox().Count > 1)
            {
                MessageBox.Show("Yalnızca bir tane özellik seçebilirsiniz...");
            }
            else
            { 
                string text = this.getFilteringText(txtMetin.Text);
                txtMetin.Text = text;
            }
        }

        private void btnIndır_Click(object sender, EventArgs e)
        {
            DocxProccesig docx = new DocxProccesig();
            string currentDirectory = Helper.getCurrentPath();
            string path = currentDirectory + "\\"+DateTime.Now.Ticks + ".docx";
            docx.writeText(path, txtMetin.Text);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            LibraryPasage pasage = new LibraryPasage();
            if (txtBaslik.Text.Trim() == "")
            {
                MessageBox.Show("Başlık Olmadan Kayıt Yapamazsınız");
            }
            else
            {
                pasage.text = txtMetin.Text;
                pasage.name = txtBaslik.Text;
                try
                {
                    dbProcess.save(pasage);
                    comboBox1.DataSource = dbProcess.getAll();
                    MessageBox.Show("materyaliniz kütüphaneye kaydedildi");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }


        private void ckRenklendir_CheckedChanged(object sender, EventArgs e)
        {
            if (ckRenklendir.Checked)
            {
                grpRenk.Visible = true;
                rdSiyah.Select();
                changableFont.setFontColor(Color.Black, txtMetin);
            }
            else
            {
                grpRenk.Visible = false;
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            txtMetin.Text = firstValue;
        }

        private void btnGeriAl_Click(object sender, EventArgs e)
        {
            txtMetin.Text = tempValue;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMetin.Text = "";
            count = 0;
            changableFont.setFontColor(Color.Black, txtMetin);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selectedItem = comboBox1.SelectedItem;
            String str = ((LibraryPasage)selectedItem).text;
            txtBaslik.Text = ((LibraryPasage)selectedItem).name;
            txtMetin.Text = str;

        }

        private void rdRengarenk_CheckedChanged(object sender, EventArgs e)
        {
            if (rdRengarenk.Checked)
            {
                List<string> lstKelime = wordProcess.getKelimeList(txtMetin.Text);
                foreach (var item in lstKelime)
                {
                    Color randomColor = generate.generateColor();
                    changableFont.changeFontAboutLetter(item, txtMetin, randomColor, ChangableFont.RENKLENDIRME_SECENEGI.ON);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Color randomColor = generate.generateColor();
            changableFont.changeFontAboutLetter(txtAranacakKelime.Text, txtMetin, randomColor,ChangableFont.RENKLENDIRME_SECENEGI.ARKA);
        }
    }

    
}
