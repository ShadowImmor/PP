namespace AnimeCartot
{
    partial class Mform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mform));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.Searchlabel = new System.Windows.Forms.Label();
            this.SeachtextBox = new System.Windows.Forms.TextBox();
            this.Clearbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(184)))), ((int)(((byte)(214)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(38, 263);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(859, 98);
            this.dataGridView.TabIndex = 0;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(651, 382);
            this.add.Name = "add";
            this.add.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.add.Size = new System.Drawing.Size(246, 68);
            this.add.TabIndex = 1;
            this.add.Text = "Добавить запись";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Searchlabel
            // 
            this.Searchlabel.AutoSize = true;
            this.Searchlabel.BackColor = System.Drawing.Color.Transparent;
            this.Searchlabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Searchlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Searchlabel.Location = new System.Drawing.Point(12, 23);
            this.Searchlabel.Name = "Searchlabel";
            this.Searchlabel.Size = new System.Drawing.Size(234, 28);
            this.Searchlabel.TabIndex = 2;
            this.Searchlabel.Text = "Поиск по названию";
            // 
            // SeachtextBox
            // 
            this.SeachtextBox.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeachtextBox.Location = new System.Drawing.Point(266, 20);
            this.SeachtextBox.Name = "SeachtextBox";
            this.SeachtextBox.Size = new System.Drawing.Size(247, 35);
            this.SeachtextBox.TabIndex = 3;
            this.SeachtextBox.TextChanged += new System.EventHandler(this.SearchTex_change);
            // 
            // Clearbutton
            // 
            this.Clearbutton.BackColor = System.Drawing.Color.Transparent;
            this.Clearbutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Clearbutton.FlatAppearance.BorderSize = 0;
            this.Clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbutton.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clearbutton.Location = new System.Drawing.Point(706, 23);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(129, 35);
            this.Clearbutton.TabIndex = 4;
            this.Clearbutton.Text = "Очистка";
            this.Clearbutton.UseVisualStyleBackColor = false;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // Mform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(934, 476);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.SeachtextBox);
            this.Controls.Add(this.Searchlabel);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dataGridView);
            this.Name = "Mform";
            this.Text = "Картатека аниме";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label Searchlabel;
        private System.Windows.Forms.TextBox SeachtextBox;
        private System.Windows.Forms.Button Clearbutton;
    }
}

