

using System.Windows.Forms;

namespace Graph
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label3 = new Label();
            theFirstVertexId = new NumericUpDown();
            label4 = new Label();
            theSecondVertexId = new NumericUpDown();
            createEdge = new Button();
            createGraph = new Button();
            pictureBox = new PictureBox();
            EdgesCount = new NumericUpDown();
            label2 = new Label();
            label5 = new Label();
            edgeValue = new NumericUpDown();
            dekstraGo = new Button();
            groupBoxEdges = new GroupBox();
            groupBoxVertex = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)theFirstVertexId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)theSecondVertexId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EdgesCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)edgeValue).BeginInit();
            groupBoxEdges.SuspendLayout();
            groupBoxVertex.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(19, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 32);
            label1.TabIndex = 0;
            label1.Text = "Создание графа";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 23);
            label3.Name = "label3";
            label3.Size = new Size(188, 20);
            label3.TabIndex = 3;
            label3.Text = "Связать ребром вершину";
            // 
            // theFirstVertexId
            // 
            theFirstVertexId.Location = new Point(6, 50);
            theFirstVertexId.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            theFirstVertexId.Name = "theFirstVertexId";
            theFirstVertexId.Size = new Size(189, 27);
            theFirstVertexId.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 80);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 5;
            label4.Text = "С вершиной";
            // 
            // theSecondVertexId
            // 
            theSecondVertexId.Location = new Point(8, 112);
            theSecondVertexId.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            theSecondVertexId.Name = "theSecondVertexId";
            theSecondVertexId.Size = new Size(189, 27);
            theSecondVertexId.TabIndex = 6;
            // 
            // createEdge
            // 
            createEdge.Location = new Point(6, 202);
            createEdge.Name = "createEdge";
            createEdge.Size = new Size(189, 29);
            createEdge.TabIndex = 7;
            createEdge.Text = "Создать ребро";
            createEdge.UseVisualStyleBackColor = true;
            createEdge.Click += createEdge_Click;
            // 
            // createGraph
            // 
            createGraph.Location = new Point(6, 68);
            createGraph.Name = "createGraph";
            createGraph.Size = new Size(188, 29);
            createGraph.TabIndex = 9;
            createGraph.Text = "Создать граф";
            createGraph.UseVisualStyleBackColor = true;
            createGraph.Click += createGraph_Click;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.White;
            pictureBox.BackgroundImageLayout = ImageLayout.None;
            pictureBox.Location = new Point(222, 23);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(900, 600);
            pictureBox.TabIndex = 10;
            pictureBox.TabStop = false;
            pictureBox.Paint += createEdge_Click;
            // 
            // EdgesCount
            // 
            EdgesCount.Location = new Point(6, 35);
            EdgesCount.Maximum = new decimal(new int[] { 21, 0, 0, 0 });
            EdgesCount.Name = "EdgesCount";
            EdgesCount.Size = new Size(188, 27);
            EdgesCount.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 12);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 1;
            label2.Text = "Количество вершин";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 142);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 11;
            label5.Text = "Вес ребра:";
            // 
            // edgeValue
            // 
            edgeValue.Location = new Point(8, 165);
            edgeValue.Name = "edgeValue";
            edgeValue.Size = new Size(187, 27);
            edgeValue.TabIndex = 12;
            // 
            // dekstraGo
            // 
            dekstraGo.Enabled = false;
            dekstraGo.Font = new Font("Segoe UI", 10F);
            dekstraGo.Location = new Point(9, 494);
            dekstraGo.Name = "dekstraGo";
            dekstraGo.Size = new Size(203, 121);
            dekstraGo.TabIndex = 13;
            dekstraGo.Text = "Расчитать кратчайший путь от 0 вершины";
            dekstraGo.UseVisualStyleBackColor = true;
            dekstraGo.Click += dekstraGo_Click;
            // 
            // groupBoxEdges
            // 
            groupBoxEdges.BackColor = Color.LightBlue;
            groupBoxEdges.Controls.Add(label3);
            groupBoxEdges.Controls.Add(theFirstVertexId);
            groupBoxEdges.Controls.Add(edgeValue);
            groupBoxEdges.Controls.Add(label4);
            groupBoxEdges.Controls.Add(label5);
            groupBoxEdges.Controls.Add(createEdge);
            groupBoxEdges.Controls.Add(theSecondVertexId);
            groupBoxEdges.Location = new Point(11, 205);
            groupBoxEdges.Name = "groupBoxEdges";
            groupBoxEdges.Size = new Size(201, 248);
            groupBoxEdges.TabIndex = 14;
            groupBoxEdges.TabStop = false;
            // 
            // groupBoxVertex
            // 
            groupBoxVertex.BackColor = Color.LightBlue;
            groupBoxVertex.Controls.Add(label2);
            groupBoxVertex.Controls.Add(EdgesCount);
            groupBoxVertex.Controls.Add(createGraph);
            groupBoxVertex.Location = new Point(11, 63);
            groupBoxVertex.Name = "groupBoxVertex";
            groupBoxVertex.Size = new Size(201, 125);
            groupBoxVertex.TabIndex = 15;
            groupBoxVertex.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1128, 627);
            Controls.Add(groupBoxVertex);
            Controls.Add(groupBoxEdges);
            Controls.Add(dekstraGo);
            Controls.Add(label1);
            Controls.Add(pictureBox);
            Name = "Form1";
            Text = "Алгоритм Дейкстры";
            ((System.ComponentModel.ISupportInitialize)theFirstVertexId).EndInit();
            ((System.ComponentModel.ISupportInitialize)theSecondVertexId).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)EdgesCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)edgeValue).EndInit();
            groupBoxEdges.ResumeLayout(false);
            groupBoxEdges.PerformLayout();
            groupBoxVertex.ResumeLayout(false);
            groupBoxVertex.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private Label label3;
        private NumericUpDown theFirstVertexId;
        private Label label4;
        private NumericUpDown theSecondVertexId;
        private Button createEdge;
        private Button createGraph;
        private PictureBox pictureBox;
        private NumericUpDown EdgesCount;
        private Label label2;
        private Label label5;
        private NumericUpDown edgeValue;
        private Button dekstraGo;
        private GroupBox groupBoxEdges;
        private GroupBox groupBoxVertex;
    }
}
