using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UsersAdd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string ConvertWord2Translit(string word)
        {
            word = word.ToLower();
            string newWord = "";
            for (int i = 0; i < word.Length; i++)
                newWord += ConvertChar2Translit(word[i]);
            return newWord;
        }

        static string ConvertChar2Translit(char c)
        {
            string[] rus = new string[33];
            string[] eng = new string[33];
            rus[0] = "а"; eng[0] = "a";
            rus[1] = "б"; eng[1] = "b";
            rus[2] = "в"; eng[2] = "v";
            rus[3] = "г"; eng[3] = "g";
            rus[4] = "д"; eng[4] = "d";
            rus[5] = "е"; eng[5] = "e";
            rus[6] = "ё"; eng[6] = "yo";
            rus[7] = "ж"; eng[7] = "g";
            rus[8] = "з"; eng[8] = "z";
            rus[9] = "и"; eng[9] = "i";
            rus[10] = "й"; eng[10] = "y";
            rus[11] = "к"; eng[11] = "k";
            rus[12] = "л"; eng[12] = "l";
            rus[13] = "м"; eng[13] = "m";
            rus[14] = "н"; eng[14] = "n";
            rus[15] = "о"; eng[15] = "o";
            rus[16] = "п"; eng[16] = "p";
            rus[17] = "р"; eng[17] = "r";
            rus[18] = "с"; eng[18] = "s";
            rus[19] = "т"; eng[19] = "t";
            rus[20] = "у"; eng[20] = "u";
            rus[21] = "ф"; eng[21] = "f";
            rus[22] = "х"; eng[22] = "h";
            rus[23] = "ц"; eng[23] = "c";
            rus[24] = "ч"; eng[24] = "ch";
            rus[25] = "ш"; eng[25] = "w";
            rus[26] = "щ"; eng[26] = "w";
            rus[27] = "ь"; eng[27] = "";
            rus[28] = "ъ"; eng[28] = "";
            rus[29] = "ы"; eng[29] = "i";
            rus[30] = "э"; eng[30] = "e";
            rus[31] = "ю"; eng[31] = "yu";
            rus[32] = "я"; eng[32] = "ya";
            for (byte n = 0; n < rus.Length; n++)
                if (rus[n][0] == c) return eng[n];
            return c.ToString();
        }
        string result = string.Empty;
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (radText.Checked)
            {
                char[] splitchar = { ' ' };
                foreach (string s in txtUsers.Text.Split(splitchar,StringSplitOptions.RemoveEmptyEntries))
                {

                }
            }
            if (radFile.Checked)
            {
                if(!System.IO.File.Exists(txtFile.Text))
                {
                    MessageBox.Show("Файл не найден");
                    return;
                }
                System.IO.StreamReader read = new System.IO.StreamReader(txtFile.Text);
                System.IO.StreamWriter write = new System.IO.StreamWriter("users.bat", true, Encoding.GetEncoding(866));
                string fullname = read.ReadLine();
                while (fullname != null)
                {
                    string[] separator = { " " };
                    fullname = fullname.Trim();
                    if (fullname == "") { fullname = read.ReadLine(); continue; }
                    string[] pieces = fullname.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                    fullname = pieces[0] + " " + pieces[1];
                    Console.WriteLine(fullname);
                    string firstName = ConvertWord2Translit(pieces[0]);
                    string lastName = ConvertWord2Translit(pieces[1]);
                    string profileName = firstName + "." + lastName;
                    Console.WriteLine(profileName);
                    Console.WriteLine();
                    write.WriteLine("dssadd user \"cn={0}{1}\" -display \"{0}\" -samid {2} -upn {2} -profile \\\\inf0\\Prifiles$\\{2} -pwd {3} -ln {3} -fn {4} -rewersiblepwn yes -mustchpwd yes",
                                                    fullname,txtDepartments,profileName,lastName,firstName);
                    fullname = read.ReadLine();
                    System.Threading.Thread.Sleep(200);
                }
                write.Flush(); write.Close();
                read.Close();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                txtFile.Text = openFileDialog1.FileName;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(result);
        }
    }
}
