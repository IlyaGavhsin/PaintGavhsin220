namespace WindowsFormsApp3
{
    partial class Form1
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
            System.Windows.Forms.PictureBox imgCircle;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.PictureBox pictureBox1;
            System.Windows.Forms.PictureBox pictureBox2;
            System.Windows.Forms.PictureBox pictureBox3;
            System.Windows.Forms.PictureBox pictColor;
            this.label2 = new System.Windows.Forms.Label();
            this.btnDrowCircle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFigur = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paramDatas = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTrin = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelRec = new System.Windows.Forms.Panel();
            this.panelCircle = new System.Windows.Forms.Panel();
            this.panelLine = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorBtn = new System.Windows.Forms.Button();
            imgCircle = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictColor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(imgCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramDatas)).BeginInit();
            this.panelTrin.SuspendLayout();
            this.panelRec.SuspendLayout();
            this.panelCircle.SuspendLayout();
            this.panelLine.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgCircle
            // 
            imgCircle.BackColor = System.Drawing.Color.Transparent;
            imgCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            imgCircle.ImageLocation = "C:\\Users\\Gafhi\\source\\repos\\WindowsFormsApp3\\WindowsFormsApp3\\img\\Ellipse 78.png";
            imgCircle.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgCircle.InitialImage")));
            imgCircle.Location = new System.Drawing.Point(20, 15);
            imgCircle.Name = "imgCircle";
            imgCircle.Size = new System.Drawing.Size(48, 50);
            imgCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            imgCircle.TabIndex = 7;
            imgCircle.TabStop = false;
            imgCircle.Click += new System.EventHandler(this.imgCircle_Click);
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox1.ImageLocation = "C:\\Users\\Gafhi\\source\\repos\\WindowsFormsApp3\\WindowsFormsApp3\\img\\Line 23.png";
            pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            pictureBox1.Location = new System.Drawing.Point(16, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(48, 50);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox2.ImageLocation = "C:\\Users\\Gafhi\\source\\repos\\WindowsFormsApp3\\WindowsFormsApp3\\img\\Polygon 2.png";
            pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            pictureBox2.Location = new System.Drawing.Point(20, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(48, 49);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = System.Drawing.Color.Transparent;
            pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox3.ImageLocation = "C:\\Users\\Gafhi\\source\\repos\\WindowsFormsApp3\\WindowsFormsApp3\\img\\Rectangle 1435." +
    "png";
            pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            pictureBox3.Location = new System.Drawing.Point(20, 15);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(98, 50);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictColor
            // 
            pictColor.BackColor = System.Drawing.Color.Transparent;
            pictColor.Cursor = System.Windows.Forms.Cursors.Hand;
            pictColor.ImageLocation = "C:\\Users\\Gafhi\\source\\repos\\WindowsFormsApp3\\WindowsFormsApp3\\img\\color.jpg";
            pictColor.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictColor.InitialImage")));
            pictColor.Location = new System.Drawing.Point(76, 730);
            pictColor.Name = "pictColor";
            pictColor.Size = new System.Drawing.Size(48, 47);
            pictColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictColor.TabIndex = 13;
            pictColor.TabStop = false;
            pictColor.Click += new System.EventHandler(this.colorBtn_click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(41, 383);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 59);
            this.label2.TabIndex = 4;
            this.label2.Text = "СВОЙСТВА ФИГУРЫ";
            // 
            // btnDrowCircle
            // 
            this.btnDrowCircle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnDrowCircle.Font = new System.Drawing.Font("Montserrat Medium", 16F, System.Drawing.FontStyle.Bold);
            this.btnDrowCircle.ForeColor = System.Drawing.Color.White;
            this.btnDrowCircle.Location = new System.Drawing.Point(500, 704);
            this.btnDrowCircle.Margin = new System.Windows.Forms.Padding(4);
            this.btnDrowCircle.Name = "btnDrowCircle";
            this.btnDrowCircle.Size = new System.Drawing.Size(1181, 82);
            this.btnDrowCircle.TabIndex = 5;
            this.btnDrowCircle.Text = "Отчистить Поле";
            this.btnDrowCircle.UseVisualStyleBackColor = false;
            this.btnDrowCircle.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(84, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Круг";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(78, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "Линия";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(85, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 33);
            this.label4.TabIndex = 14;
            this.label4.Text = "Треугольник";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtFigur
            // 
            this.txtFigur.AutoSize = true;
            this.txtFigur.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFigur.Location = new System.Drawing.Point(45, 17);
            this.txtFigur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtFigur.Name = "txtFigur";
            this.txtFigur.Size = new System.Drawing.Size(190, 59);
            this.txtFigur.TabIndex = 4;
            this.txtFigur.Text = "ФИГУРЫ";
            this.txtFigur.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(500, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 707);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClicks);
            // 
            // paramDatas
            // 
            this.paramDatas.AllowUserToAddRows = false;
            this.paramDatas.AllowUserToDeleteRows = false;
            this.paramDatas.BackgroundColor = System.Drawing.Color.White;
            this.paramDatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paramDatas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Value});
            this.paramDatas.GridColor = System.Drawing.Color.White;
            this.paramDatas.Location = new System.Drawing.Point(48, 470);
            this.paramDatas.Name = "paramDatas";
            this.paramDatas.RowHeadersWidth = 51;
            this.paramDatas.RowTemplate.Height = 24;
            this.paramDatas.Size = new System.Drawing.Size(391, 237);
            this.paramDatas.TabIndex = 0;
            // 
            // Name
            // 
            this.Name.FillWeight = 175F;
            this.Name.HeaderText = "Название";
            this.Name.MinimumWidth = 10;
            this.Name.Name = "Name";
            this.Name.Width = 169;
            // 
            // Value
            // 
            this.Value.FillWeight = 175F;
            this.Value.HeaderText = "Значение";
            this.Value.MinimumWidth = 6;
            this.Value.Name = "Value";
            this.Value.Width = 169;
            // 
            // panelTrin
            // 
            this.panelTrin.Controls.Add(pictureBox2);
            this.panelTrin.Controls.Add(this.label4);
            this.panelTrin.Location = new System.Drawing.Point(48, 274);
            this.panelTrin.Name = "panelTrin";
            this.panelTrin.Size = new System.Drawing.Size(391, 80);
            this.panelTrin.TabIndex = 0;
            this.panelTrin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelTrin_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(135, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 33);
            this.label5.TabIndex = 12;
            this.label5.Text = "Прямоугольник";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panelRec
            // 
            this.panelRec.Controls.Add(pictureBox3);
            this.panelRec.Controls.Add(this.label5);
            this.panelRec.Location = new System.Drawing.Point(48, 188);
            this.panelRec.Name = "panelRec";
            this.panelRec.Size = new System.Drawing.Size(391, 80);
            this.panelRec.TabIndex = 0;
            this.panelRec.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelRec_MouseClick);
            // 
            // panelCircle
            // 
            this.panelCircle.BackColor = System.Drawing.Color.Transparent;
            this.panelCircle.Controls.Add(this.label1);
            this.panelCircle.Controls.Add(imgCircle);
            this.panelCircle.Location = new System.Drawing.Point(48, 102);
            this.panelCircle.Name = "panelCircle";
            this.panelCircle.Size = new System.Drawing.Size(187, 80);
            this.panelCircle.TabIndex = 0;
            this.panelCircle.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCircle_Paint);
            this.panelCircle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelCircle_MouseClick);
            // 
            // panelLine
            // 
            this.panelLine.Controls.Add(this.label3);
            this.panelLine.Controls.Add(pictureBox1);
            this.panelLine.Location = new System.Drawing.Point(241, 102);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(198, 80);
            this.panelLine.TabIndex = 0;
            this.panelLine.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelLine_MouseClick);
            // 
            // colorBtn
            // 
            this.colorBtn.BackColor = System.Drawing.Color.White;
            this.colorBtn.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold);
            this.colorBtn.ForeColor = System.Drawing.Color.Black;
            this.colorBtn.Location = new System.Drawing.Point(48, 722);
            this.colorBtn.Name = "colorBtn";
            this.colorBtn.Size = new System.Drawing.Size(391, 64);
            this.colorBtn.TabIndex = 20;
            this.colorBtn.Text = "Выбрать Цвет";
            this.colorBtn.UseVisualStyleBackColor = false;
            this.colorBtn.Click += new System.EventHandler(this.colorBtn_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1725, 831);
            this.Controls.Add(pictColor);
            this.Controls.Add(this.colorBtn);
            this.Controls.Add(this.panelLine);
            this.Controls.Add(this.paramDatas);
            this.Controls.Add(this.panelCircle);
            this.Controls.Add(this.panelRec);
            this.Controls.Add(this.panelTrin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDrowCircle);
            this.Controls.Add(this.txtFigur);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Text = "Создай свой круг";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(imgCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paramDatas)).EndInit();
            this.panelTrin.ResumeLayout(false);
            this.panelTrin.PerformLayout();
            this.panelRec.ResumeLayout(false);
            this.panelRec.PerformLayout();
            this.panelCircle.ResumeLayout(false);
            this.panelCircle.PerformLayout();
            this.panelLine.ResumeLayout(false);
            this.panelLine.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDrowCircle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtFigur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTrin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelRec;
        private System.Windows.Forms.Panel panelCircle;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.DataGridView paramDatas;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button colorBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
    }
}

