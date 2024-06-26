
using System.Collections.Generic;

namespace GraphLibrary
{

    /// Вершина
    public class Vertex
    {
        public int Id { get; set; }
        Brush sB = new SolidBrush(Color.Blue);

        public Vertex(int id)
        {
            this.Id = id;
        }

        public void CreateVertex(Graphics g, double x, double y)
        {
            g.FillEllipse(sB, (float)x, (float)y, 70, 70);
        }

    }

    /// Ребро
    public class Edge
    {
        Pen pen = new Pen(Color.Blue);
        public int Value { get; set; }
        public int FirstVertexID {  get; set; }
        public int SecondVertexID { get; set; }

        public Edge(int firstId, int secondId, int value)
        {
            this.FirstVertexID = firstId;
            this.SecondVertexID = secondId;
            this.Value = value;
        }

        public void CreateEdge(Graphics g, PointF x, PointF y)
        {
            g.DrawLine(pen, x, y);
        }
        
    }

    /// Алгоритм
    public class DekstraAlgorim
    {

        public int[,] CreateMatrix(int vertexCount, Dictionary<string, int> edges)
        {
            int[,] matrix = new int[vertexCount,vertexCount];

            for (int i = 0; i < vertexCount; i++)
                for (int j = 0; j < vertexCount; j++)
                    matrix[i, j] = 0;

            foreach (var edge in edges)
            {
                int frst = Convert.ToInt16(edge.Key.Split()[0]);
                int scnd = Convert.ToInt16(edge.Key.Split()[1]);
                matrix[frst,scnd] = edge.Value;
                matrix[scnd, frst] = edge.Value;
            }

            return matrix;
        }

        public string GetConnected(int nowVert, int count, int[,] matrix)
        {
            string connectedVert = "";
            for(int i = 0;i < count; i++)
            {
                if (matrix[nowVert, i] != 0)
                {
                    connectedVert += i.ToString() + " ";
                }
            }
            return connectedVert;
        }

       

        public int TakeMin(int[] last, int[] checkedVert)
        {
            int minVert = -1;
            int maxm = last.Max();
            int i = 0;
            foreach(int vert in last)
            {
                if ((vert < maxm) && !(checkedVert.Contains(i))){
                    maxm = vert;
                    minVert = i;
                }
                i++;
            }

            return minVert;
        }

        public void Insert(ref int[] array, int value, int index)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[index] = value;

            for(int i = 0;i < index; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }

        public void Go(Vertex[] vertexArray, Dictionary<string, int> edges, out int[] last)
        {
            int count = vertexArray.Length;
            int[,] matrix = CreateMatrix(count, edges);
            last = Enumerable.Repeat(999, count).ToArray();
            int nowVert = 0;
            int[] checkedVert = [count];
            checkedVert[0] = nowVert;
            last[nowVert] = 0;


            while (nowVert != -1)
            {
                foreach (string vertex in GetConnected(nowVert, count, matrix).Split())
                {
                    if (int.TryParse(vertex, out int vert))
                    {
                        if (checkedVert.Contains(vert) == false)
                        {
                            int val = last[nowVert] + matrix[nowVert, vert];

                            if (val < last[vert])
                            {
                                last[vert] = val;
                            }
                        }
                    }
                }

                nowVert = TakeMin(last, checkedVert);
                if (nowVert > 0)
                {
                    Insert(ref checkedVert, nowVert, checkedVert.Length);
                }

            }
   

        }

    }

}