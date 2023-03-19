namespace LB1
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(217, 58);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(571, 380);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 58);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 38);
			this.button1.TabIndex = 1;
			this.button1.Text = "Вибрати";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(776, 20);
			this.textBox1.TabIndex = 2;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(12, 124);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 39);
			this.button2.TabIndex = 3;
			this.button2.Text = "Рахувати";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(12, 182);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 52);
			this.button3.TabIndex = 4;
			this.button3.Text = "Негатив";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click_1);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(12, 300);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 35);
			this.button4.TabIndex = 5;
			this.button4.Text = "Градація сірого";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4_Click_1);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(12, 344);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 35);
			this.button5.TabIndex = 6;
			this.button5.Text = "Яскравість";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5_Click_1);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(12, 391);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 35);
			this.button6.TabIndex = 7;
			this.button6.Text = "В обраний кольоровий градієнт";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6_Click_1);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(93, 308);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 8;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(93, 352);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 9;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(93, 399);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 10;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form1";
			this.Text = "MyApp1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
	}
}

