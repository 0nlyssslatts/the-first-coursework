using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphLibrary;

namespace Graph
{
    public partial class Form2 : Form
    {
        Form2 form; 
        int[] result = new int[0];
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 f)
        {
            InitializeComponent();
        }
 
        public void GetResult(ref int[] nums)
        {
            result = nums;
        }
        public void ShowResult(ref Form2 resForm)
        {
            form = resForm;
            if (resBox.Items.Count == 0)
            {
                for (int i = 1; i < result.Length; i++)
                {
                    if (result[i] != 999)
                    {
                        resBox.Items.Add($"Кратчайший путь от вершины 0 до вершины {i} равен {result[i]}");
                    }
                    else
                    {
                        resBox.Items.Add($"Вершина 0 никак не связана с вершиной {i}");
                    }
                    
                }
            }

        }


        private void saveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Text Files|*.txt";
            saveFileDialog1.Title = "Save a Text File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile()))
                {
                    foreach (string item in resBox.Items)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            form.Close();
        }
    }
}
