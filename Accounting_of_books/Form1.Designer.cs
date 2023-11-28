namespace Accounting_of_books
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
            System.Windows.Forms.Label label8;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_genre = new System.Windows.Forms.TextBox();
            this.textBox_sum = new System.Windows.Forms.TextBox();
            this.textBox_writer = new System.Windows.Forms.TextBox();
            this.textBox_inStock = new System.Windows.Forms.TextBox();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.but_add = new System.Windows.Forms.Button();
            this.but_del = new System.Windows.Forms.Button();
            this.but_redact = new System.Windows.Forms.Button();
            this.but_cancel = new System.Windows.Forms.Button();
            this.but_save = new System.Windows.Forms.Button();
            this.but_sort = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_genre = new System.Windows.Forms.ComboBox();
            this.comboBox_writer = new System.Windows.Forms.ComboBox();
            this.comboBox_date = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Жанр";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 630);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Количество всех";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 630);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Количество на складе";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Автор";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(423, 537);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Год издания";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(15, 452);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(377, 22);
            this.textBox_name.TabIndex = 7;
            // 
            // textBox_genre
            // 
            this.textBox_genre.Location = new System.Drawing.Point(12, 556);
            this.textBox_genre.Name = "textBox_genre";
            this.textBox_genre.Size = new System.Drawing.Size(380, 22);
            this.textBox_genre.TabIndex = 8;
            // 
            // textBox_sum
            // 
            this.textBox_sum.Location = new System.Drawing.Point(15, 649);
            this.textBox_sum.Name = "textBox_sum";
            this.textBox_sum.Size = new System.Drawing.Size(377, 22);
            this.textBox_sum.TabIndex = 9;
            // 
            // textBox_writer
            // 
            this.textBox_writer.Location = new System.Drawing.Point(415, 452);
            this.textBox_writer.Name = "textBox_writer";
            this.textBox_writer.Size = new System.Drawing.Size(349, 22);
            this.textBox_writer.TabIndex = 10;
            // 
            // textBox_inStock
            // 
            this.textBox_inStock.Location = new System.Drawing.Point(415, 649);
            this.textBox_inStock.Name = "textBox_inStock";
            this.textBox_inStock.Size = new System.Drawing.Size(349, 22);
            this.textBox_inStock.TabIndex = 11;
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(415, 556);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(349, 22);
            this.textBox_date.TabIndex = 12;
            // 
            // but_add
            // 
            this.but_add.Location = new System.Drawing.Point(809, 451);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(168, 23);
            this.but_add.TabIndex = 13;
            this.but_add.Text = "Добавить книгу";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // but_del
            // 
            this.but_del.Location = new System.Drawing.Point(809, 502);
            this.but_del.Name = "but_del";
            this.but_del.Size = new System.Drawing.Size(168, 23);
            this.but_del.TabIndex = 14;
            this.but_del.Text = "Удалить книгу";
            this.but_del.UseVisualStyleBackColor = true;
            this.but_del.Click += new System.EventHandler(this.but_del_Click);
            // 
            // but_redact
            // 
            this.but_redact.Location = new System.Drawing.Point(809, 556);
            this.but_redact.Name = "but_redact";
            this.but_redact.Size = new System.Drawing.Size(168, 23);
            this.but_redact.TabIndex = 15;
            this.but_redact.Text = "Редактировать ";
            this.but_redact.UseVisualStyleBackColor = true;
            this.but_redact.Click += new System.EventHandler(this.but_redact_Click);
            // 
            // but_cancel
            // 
            this.but_cancel.Location = new System.Drawing.Point(809, 649);
            this.but_cancel.Name = "but_cancel";
            this.but_cancel.Size = new System.Drawing.Size(168, 23);
            this.but_cancel.TabIndex = 16;
            this.but_cancel.Text = "Отмена";
            this.but_cancel.UseVisualStyleBackColor = true;
            this.but_cancel.Click += new System.EventHandler(this.but_cancel_Click);
            // 
            // but_save
            // 
            this.but_save.Location = new System.Drawing.Point(809, 605);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(168, 23);
            this.but_save.TabIndex = 17;
            this.but_save.Text = "Сохранить";
            this.but_save.UseVisualStyleBackColor = true;
            this.but_save.Click += new System.EventHandler(this.but_save_Click);
            // 
            // but_sort
            // 
            this.but_sort.Location = new System.Drawing.Point(787, 386);
            this.but_sort.Name = "but_sort";
            this.but_sort.Size = new System.Drawing.Size(115, 23);
            this.but_sort.TabIndex = 18;
            this.but_sort.Text = "Сортировать";
            this.but_sort.UseVisualStyleBackColor = true;
            this.but_sort.Click += new System.EventHandler(this.but_sort_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(806, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Сортировка";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(681, 179);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(73, 16);
            label8.TabIndex = 20;
            label8.Text = "по автору";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(681, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "по году издания";
            // 
            // comboBox_genre
            // 
            this.comboBox_genre.FormattingEnabled = true;
            this.comboBox_genre.Location = new System.Drawing.Point(681, 64);
            this.comboBox_genre.Name = "comboBox_genre";
            this.comboBox_genre.Size = new System.Drawing.Size(322, 24);
            this.comboBox_genre.TabIndex = 22;
            // 
            // comboBox_writer
            // 
            this.comboBox_writer.FormattingEnabled = true;
            this.comboBox_writer.Location = new System.Drawing.Point(681, 198);
            this.comboBox_writer.Name = "comboBox_writer";
            this.comboBox_writer.Size = new System.Drawing.Size(322, 24);
            this.comboBox_writer.TabIndex = 23;
            // 
            // comboBox_date
            // 
            this.comboBox_date.FormattingEnabled = true;
            this.comboBox_date.Location = new System.Drawing.Point(681, 335);
            this.comboBox_date.Name = "comboBox_date";
            this.comboBox_date.Size = new System.Drawing.Size(322, 24);
            this.comboBox_date.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(678, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "по жанру";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(12, 13);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(663, 404);
            this.listBox.TabIndex = 29;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 695);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox_date);
            this.Controls.Add(this.comboBox_writer);
            this.Controls.Add(this.comboBox_genre);
            this.Controls.Add(this.label9);
            this.Controls.Add(label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.but_sort);
            this.Controls.Add(this.but_save);
            this.Controls.Add(this.but_cancel);
            this.Controls.Add(this.but_redact);
            this.Controls.Add(this.but_del);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.textBox_date);
            this.Controls.Add(this.textBox_inStock);
            this.Controls.Add(this.textBox_writer);
            this.Controls.Add(this.textBox_sum);
            this.Controls.Add(this.textBox_genre);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_genre;
        private System.Windows.Forms.TextBox textBox_sum;
        private System.Windows.Forms.TextBox textBox_writer;
        private System.Windows.Forms.TextBox textBox_inStock;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Button but_del;
        private System.Windows.Forms.Button but_redact;
        private System.Windows.Forms.Button but_cancel;
        private System.Windows.Forms.Button but_save;
        private System.Windows.Forms.Button but_sort;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_genre;
        private System.Windows.Forms.ComboBox comboBox_writer;
        private System.Windows.Forms.ComboBox comboBox_date;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox listBox;
    }
}

