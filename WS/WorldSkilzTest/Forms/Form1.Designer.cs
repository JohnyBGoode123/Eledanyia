namespace WorldSkilzTest
{
	partial class Main
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
			this.Exit = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.Start = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Exit
			// 
			this.Exit.Location = new System.Drawing.Point(713, 415);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(75, 23);
			this.Exit.TabIndex = 0;
			this.Exit.Text = "Выход";
			this.Exit.UseVisualStyleBackColor = true;
			this.Exit.Click += new System.EventHandler(this.Exit_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(334, 141);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 1;
			// 
			// Start
			// 
			this.Start.Location = new System.Drawing.Point(334, 186);
			this.Start.Name = "Start";
			this.Start.Size = new System.Drawing.Size(75, 23);
			this.Start.TabIndex = 2;
			this.Start.Text = "Начать";
			this.Start.UseVisualStyleBackColor = true;
			this.Start.Click += new System.EventHandler(this.Start_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Start);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.Exit);
			this.Name = "Main";
			this.Text = "Main";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Exit;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button Start;
	}
}

