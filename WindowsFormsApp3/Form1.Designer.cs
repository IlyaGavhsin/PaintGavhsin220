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
            this.texRadius = new System.Windows.Forms.TextBox();
            this.labX = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textX = new System.Windows.Forms.TextBox();
            this.labY = new System.Windows.Forms.Label();
            this.textY = new System.Windows.Forms.TextBox();
            this.btnDrowCircle = new System.Windows.Forms.Button();
            this.labRadius = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            imgCircle = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(imgCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // texRadius
            // 
            this.texRadius.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.texRadius.Location = new System.Drawing.Point(81, 169);
            this.texRadius.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.texRadius.Name = "texRadius";
            this.texRadius.Size = new System.Drawing.Size(163, 27);
            this.texRadius.TabIndex = 1;
            this.texRadius.TextChanged += new System.EventHandler(this.texRadius_TextChanged);
            // 
            // labX
            // 
            this.labX.AutoSize = true;
            this.labX.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labX.Location = new System.Drawing.Point(74, 216);
            this.labX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labX.Name = "labX";
            this.labX.Size = new System.Drawing.Size(33, 33);
            this.labX.TabIndex = 2;
            this.labX.Text = "X";
            this.labX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labX.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(71, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 59);
            this.label2.TabIndex = 4;
            this.label2.Text = "СВОЙСТВА ФИГУРЫ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textX
            // 
            this.textX.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textX.Location = new System.Drawing.Point(109, 218);
            this.textX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textX.Name = "textX";
            this.textX.Size = new System.Drawing.Size(57, 27);
            this.textX.TabIndex = 3;
            this.textX.TextChanged += new System.EventHandler(this.textX_TextChanged);
            // 
            // labY
            // 
            this.labY.AutoSize = true;
            this.labY.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labY.Location = new System.Drawing.Point(191, 216);
            this.labY.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labY.Name = "labY";
            this.labY.Size = new System.Drawing.Size(32, 33);
            this.labY.TabIndex = 2;
            this.labY.Text = "Y";
            this.labY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labY.Click += new System.EventHandler(this.label1_Click);
            // 
            // textY
            // 
            this.textY.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textY.Location = new System.Drawing.Point(226, 218);
            this.textY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textY.Name = "textY";
            this.textY.Size = new System.Drawing.Size(57, 27);
            this.textY.TabIndex = 3;
            this.textY.TextChanged += new System.EventHandler(this.textY_TextChanged);
            // 
            // btnDrowCircle
            // 
            this.btnDrowCircle.BackColor = System.Drawing.Color.Black;
            this.btnDrowCircle.Font = new System.Drawing.Font("Montserrat Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDrowCircle.ForeColor = System.Drawing.Color.White;
            this.btnDrowCircle.Location = new System.Drawing.Point(83, 349);
            this.btnDrowCircle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDrowCircle.Name = "btnDrowCircle";
            this.btnDrowCircle.Size = new System.Drawing.Size(356, 52);
            this.btnDrowCircle.TabIndex = 5;
            this.btnDrowCircle.Text = "Вывести";
            this.btnDrowCircle.UseVisualStyleBackColor = false;
            this.btnDrowCircle.Click += new System.EventHandler(this.button1_Click);
            // 
            // labRadius
            // 
            this.labRadius.AutoSize = true;
            this.labRadius.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labRadius.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labRadius.Location = new System.Drawing.Point(75, 133);
            this.labRadius.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labRadius.Name = "labRadius";
            this.labRadius.Size = new System.Drawing.Size(112, 33);
            this.labRadius.TabIndex = 0;
            this.labRadius.Text = "Радиус";
            this.labRadius.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imgCircle
            // 
            imgCircle.BackColor = System.Drawing.Color.Transparent;
            imgCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            imgCircle.ImageLocation = "C:\\Users\\Gafhi\\source\\repos\\WindowsFormsApp3\\WindowsFormsApp3\\img\\Ellipse 78.png";
            imgCircle.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgCircle.InitialImage")));
            imgCircle.Location = new System.Drawing.Point(83, 436);
            imgCircle.Name = "imgCircle";
            imgCircle.Size = new System.Drawing.Size(50, 50);
            imgCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            imgCircle.TabIndex = 7;
            imgCircle.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(150, 446);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Круг";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox1.ImageLocation = "C:\\Users\\Gafhi\\source\\repos\\WindowsFormsApp3\\WindowsFormsApp3\\img\\Line 23.png";
            pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            pictureBox1.Location = new System.Drawing.Point(266, 436);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(50, 50);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(333, 446);
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
            this.label4.Location = new System.Drawing.Point(150, 597);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 33);
            this.label4.TabIndex = 14;
            this.label4.Text = "Треугольник";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox2.ImageLocation = "C:\\Users\\Gafhi\\source\\repos\\WindowsFormsApp3\\WindowsFormsApp3\\img\\Polygon 2.png";
            pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            pictureBox2.Location = new System.Drawing.Point(83, 585);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(50, 49);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(203, 522);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 33);
            this.label5.TabIndex = 12;
            this.label5.Text = "Прямоугольник";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = System.Drawing.Color.Transparent;
            pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBox3.ImageLocation = "C:\\Users\\Gafhi\\source\\repos\\WindowsFormsApp3\\WindowsFormsApp3\\img\\Rectangle 1435." +
    "png";
            pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            pictureBox3.Location = new System.Drawing.Point(84, 510);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(100, 50);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(258, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 33);
            this.label6.TabIndex = 15;
            this.label6.Text = "Высота";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(264, 169);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 27);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(82, 296);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 27);
            this.textBox2.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(76, 260);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 33);
            this.label7.TabIndex = 17;
            this.label7.Text = "Граница";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1456, 717);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(imgCircle);
            this.Controls.Add(this.btnDrowCircle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textY);
            this.Controls.Add(this.labY);
            this.Controls.Add(this.textX);
            this.Controls.Add(this.labX);
            this.Controls.Add(this.texRadius);
            this.Controls.Add(this.labRadius);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Создай свой круг";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(imgCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox texRadius;
        private System.Windows.Forms.Label labX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textX;
        private System.Windows.Forms.Label labY;
        private System.Windows.Forms.TextBox textY;
        private System.Windows.Forms.Button btnDrowCircle;
        private System.Windows.Forms.Label labRadius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
    }
}

