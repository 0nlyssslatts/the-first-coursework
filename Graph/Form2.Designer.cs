namespace Graph
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            saveFile = new Button();
            closeButton = new Button();
            resBox = new ListBox();
            saveFileDialog = new SaveFileDialog();
            SuspendLayout();
            // 
            // saveFile
            // 
            saveFile.Location = new Point(12, 409);
            saveFile.Name = "saveFile";
            saveFile.Size = new Size(183, 29);
            saveFile.TabIndex = 0;
            saveFile.Text = "Сохранить txt файлом";
            saveFile.UseVisualStyleBackColor = true;
            saveFile.Click += saveFile_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(210, 409);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(94, 29);
            closeButton.TabIndex = 1;
            closeButton.Text = "Закрыть";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // resBox
            // 
            resBox.FormattingEnabled = true;
            resBox.Location = new Point(12, 12);
            resBox.Name = "resBox";
            resBox.Size = new Size(776, 384);
            resBox.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(resBox);
            Controls.Add(closeButton);
            Controls.Add(saveFile);
            Name = "Form2";
            Text = "Результат";
            TopMost = true;
            ResumeLayout(false);
        }

        #endregion

        private Button saveFile;
        private Button closeButton;
        public ListBox resBox;
        private SaveFileDialog saveFileDialog;
    }
}