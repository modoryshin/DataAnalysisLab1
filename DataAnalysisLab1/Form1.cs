using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DataAnalysisLab1
{
    public partial class Form1 : Form
    {

        private static Dictionary<char, int> RomanMap = new Dictionary<char, int>()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };
        Regex reg = new Regex(@"^M{0,4}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            rtbOutput.Text = "";
            string[] text = rtbInput.Text.Split(' ');
            for(int i = 0; i < text.Length; i++)
            {
                if (reg.IsMatch(text[i]))
                {
                    text[i] = RomanToInt(text[i]);
                }
                rtbOutput.Text += text[i] + " ";
            }
            rtbOutput.Text.Trim(' ');
        }
        private static string RomanToInt(string roman)
        {
            int num = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                if (i + 1 < roman.Length && RomanMap[roman[i]] < RomanMap[roman[i + 1]])
                {
                    num -= RomanMap[roman[i]];
                }
                else
                {
                    num += RomanMap[roman[i]];
                }
            }
            return num.ToString();
        }
    }
}
