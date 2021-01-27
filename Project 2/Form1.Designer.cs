
namespace Project_2
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
            this.tab = new System.Windows.Forms.TabControl();
            this.image = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.numbers = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.operations = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.result = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tab.SuspendLayout();
            this.image.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.numbers.SuspendLayout();
            this.operations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.result.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.image);
            this.tab.Controls.Add(this.numbers);
            this.tab.Controls.Add(this.operations);
            this.tab.Controls.Add(this.result);
            this.tab.Location = new System.Drawing.Point(12, 12);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(787, 435);
            this.tab.TabIndex = 0;
            // 
            // image
            // 
            this.image.Controls.Add(this.button6);
            this.image.Controls.Add(this.pictureBox1);
            this.image.Location = new System.Drawing.Point(4, 25);
            this.image.Margin = new System.Windows.Forms.Padding(0);
            this.image.Name = "image";
            this.image.Padding = new System.Windows.Forms.Padding(3);
            this.image.Size = new System.Drawing.Size(779, 406);
            this.image.TabIndex = 0;
            this.image.Text = "картинка";
            this.image.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(282, 147);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(196, 63);
            this.button6.TabIndex = 1;
            this.button6.Text = "выбрать изображение";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(773, 403);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // numbers
            // 
            this.numbers.Controls.Add(this.label2);
            this.numbers.Controls.Add(this.textBox2);
            this.numbers.Controls.Add(this.textBox1);
            this.numbers.Location = new System.Drawing.Point(4, 25);
            this.numbers.Name = "numbers";
            this.numbers.Padding = new System.Windows.Forms.Padding(3);
            this.numbers.Size = new System.Drawing.Size(779, 406);
            this.numbers.TabIndex = 1;
            this.numbers.Text = "числа";
            this.numbers.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(38, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите числа";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(41, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 41);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(41, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 41);
            this.textBox1.TabIndex = 0;
            // 
            // operations
            // 
            this.operations.Controls.Add(this.button5);
            this.operations.Controls.Add(this.button4);
            this.operations.Controls.Add(this.button3);
            this.operations.Controls.Add(this.button2);
            this.operations.Controls.Add(this.button1);
            this.operations.Controls.Add(this.pictureBox2);
            this.operations.Location = new System.Drawing.Point(4, 25);
            this.operations.Name = "operations";
            this.operations.Padding = new System.Windows.Forms.Padding(3);
            this.operations.Size = new System.Drawing.Size(779, 406);
            this.operations.TabIndex = 2;
            this.operations.Text = "операции";
            this.operations.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(127, 168);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(279, 54);
            this.button5.TabIndex = 4;
            this.button5.Text = "Посчитать!";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(405, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 54);
            this.button4.TabIndex = 3;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(281, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 54);
            this.button3.TabIndex = 2;
            this.button3.Text = "*";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(171, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(50, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(773, 403);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // result
            // 
            this.result.Controls.Add(this.label3);
            this.result.Controls.Add(this.label1);
            this.result.Location = new System.Drawing.Point(4, 25);
            this.result.Name = "result";
            this.result.Padding = new System.Windows.Forms.Padding(3);
            this.result.Size = new System.Drawing.Size(779, 406);
            this.result.TabIndex = 3;
            this.result.Text = "ответ";
            this.result.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(140, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 44);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ответ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(280, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 35);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tab.ResumeLayout(false);
            this.image.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.numbers.ResumeLayout(false);
            this.numbers.PerformLayout();
            this.operations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.result.ResumeLayout(false);
            this.result.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage image;
        private System.Windows.Forms.TabPage numbers;
        private System.Windows.Forms.TabPage operations;
        private System.Windows.Forms.TabPage result;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

