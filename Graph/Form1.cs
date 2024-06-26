using GraphLibrary;
using System.Drawing.Drawing2D;
using System.Security.Cryptography.X509Certificates;

namespace Graph
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        Font font = new Font("Arial", 14, FontStyle.Regular);
        DekstraAlgorim algoritm = new DekstraAlgorim();
        string[] coordinates = new string[0];
        Vertex[] arrayOfVertex = new Vertex[0];
        Dictionary<string, int> edges = new Dictionary<string, int>();
        Form2 resForm;
        public bool WindowOpen { get; set; }

        public void createGraph_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt16(EdgesCount.Value);
            

            if (count > 0)
            {
                theFirstVertexId.Maximum = count - 1;
                theSecondVertexId.Maximum = count - 1;
                int ak = 1;
                int bk = 1;
                // 100 120
                if (count > 0 && count <= 3)
                {
                    ak = 500;
                    bk = 300;
                }
                else if (count > 3 && count <= 9)
                {
                    ak = 200;
                    bk = 260;
                }
                else if (count > 9 && count <= 15)
                {
                    ak = 130;
                    bk = 170;
                }
                else
                {
                    ak = 100;
                    bk = 130;
                }

                Array.Resize(ref coordinates, count);
                Array.Resize(ref arrayOfVertex, count);
                edges.Clear();
                g = pictureBox.CreateGraphics();
                g.Clear(Color.White);
                double x;
                double y;
                int row = 1;
                for (int i = 0; i < count; i++)
                {
                    arrayOfVertex[i] = new Vertex(i);
                    if (i % 3 == 2)
                    {
                        arrayOfVertex[i].CreateVertex(g, ak * row + 30, 70);
                        g.DrawString(i.ToString(), font, Brushes.White, ak * row + 50, 90);
                        coordinates[i] = $"{(ak * row + 30).ToString()} {(70).ToString()}";

                    }
                    else if (i % 3 == 1)
                    {
                        arrayOfVertex[i].CreateVertex(g, bk * row -100, 270);
                        g.DrawString(i.ToString(), font, Brushes.White, bk * row - 80, 290);
                        coordinates[i] = $"{(bk * row - 100).ToString()} {(270).ToString()}";
                    }
                    else
                    {
                        arrayOfVertex[i].CreateVertex(g, ak * row + 30, 470);
                        g.DrawString(i.ToString(), font, Brushes.White, ak * row + 50, 490);
                        coordinates[i] = $"{(ak * row + 30).ToString()} {(470).ToString()}";
                    }

                    if ((i + 3) % 3 == 2)
                    {
                        row += 1;
                    }
                }

                g.Dispose();
            }
        }

        public void createEdge_Click(object sender, EventArgs e)
        {
            int theFirstVertex = Convert.ToInt16(theFirstVertexId.Value);
            int theSecondVertex = Convert.ToInt16(theSecondVertexId.Value);
            int edgeVal = Convert.ToInt16(edgeValue.Value);

            if (arrayOfVertex.Length > 0 && edges.ContainsKey($"{theFirstVertex} {theSecondVertex}") == false && edges.ContainsKey($"{theSecondVertex} {theFirstVertex}") == false && theSecondVertex != theFirstVertex && edgeVal != 0)
            {
                float x1 = float.Parse(coordinates[theFirstVertex].Split()[0]) + 40;
                float x2 = float.Parse(coordinates[theSecondVertex].Split()[0]) + 40;
                float y1 = float.Parse(coordinates[theFirstVertex].Split()[1]) + 40;
                float y2 = float.Parse(coordinates[theSecondVertex].Split()[1]) + 40;
                g = pictureBox.CreateGraphics();
                Pen pen = new Pen(Color.Blue, 3);
                PointF a = new PointF(x1, y1);
                PointF b = new PointF(x2, y2);
                edges.Add($"{theFirstVertex} {theSecondVertex}", edgeVal);
                g.DrawLine(pen, a, b);
                g.DrawString(edgeVal.ToString(), font, Brushes.Black,((x1 + x2) / 2)-20, ((y1 + y2) / 2) + 15);
                
            }
            if (IsZeroHere(edges))
            {
                dekstraGo.Enabled = true;
            }

        }

        public static bool IsZeroHere(Dictionary<string, int> dict)
        {
            bool flag = false;

            foreach(var item in dict)
            {
                if (item.Key[0] == '0' || item.Key[item.Key.Length - 1] == '0')
                {
                    flag = true;
                }
            }
            return flag;
        }
        public void dekstraGo_Click(object sender, EventArgs e)
        {
            if (IsZeroHere(edges))
            {
                algoritm.Go(arrayOfVertex, edges, out int[] resArray);
                dekstraGo.Enabled = true;

                if (resForm == null || resForm.IsDisposed)
                {
                    resForm = new Form2();
                    resForm.Show();
                }
                else
                {
                    resForm.Show();
                    resForm.Focus();
                }

                resForm.GetResult(ref resArray);
                resForm.ShowResult(ref resForm);

            }
            else
            {
                dekstraGo.Enabled = false;
            }

        }
    }
}
