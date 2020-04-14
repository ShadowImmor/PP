namespace AnimeCartot
{
    partial class FormAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEdit));
            this.NameBox = new System.Windows.Forms.TextBox();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Yearlabel = new System.Windows.Forms.Label();
            this.Yearnumber = new System.Windows.Forms.NumericUpDown();
            this.Statlabel = new System.Windows.Forms.Label();
            this.CameOutButton = new System.Windows.Forms.RadioButton();
            this.OngoingButton = new System.Windows.Forms.RadioButton();
            this.AnonsButton = new System.Windows.Forms.RadioButton();
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.GenersListBox = new System.Windows.Forms.CheckedListBox();
            this.Generslabel = new System.Windows.Forms.Label();
            this.Countrylabel = new System.Windows.Forms.Label();
            this.CountryBox = new System.Windows.Forms.TextBox();
            this.TypeAlabel = new System.Windows.Forms.Label();
            this.TypeApanel = new System.Windows.Forms.Panel();
            this.ONAButton = new System.Windows.Forms.RadioButton();
            this.SerialsButton = new System.Windows.Forms.RadioButton();
            this.ShortSeriesButton = new System.Windows.Forms.RadioButton();
            this.FullengthFilmButton = new System.Windows.Forms.RadioButton();
            this.OVAButton = new System.Windows.Forms.RadioButton();
            this.ShortFilmButton = new System.Windows.Forms.RadioButton();
            this.SpecialButton = new System.Windows.Forms.RadioButton();
            this.NumbEpisodlabel = new System.Windows.Forms.Label();
            this.NumbEpisodNumber = new System.Windows.Forms.NumericUpDown();
            this.Producerlabel = new System.Windows.Forms.Label();
            this.ProducertextBox = new System.Windows.Forms.TextBox();
            this.PrimarySourcelabel = new System.Windows.Forms.Label();
            this.PrimarySourcepanel = new System.Windows.Forms.Panel();
            this.RanobeButton = new System.Windows.Forms.RadioButton();
            this.MangaButton = new System.Windows.Forms.RadioButton();
            this.OriginalButton = new System.Windows.Forms.RadioButton();
            this.OriginalAutherlabel = new System.Windows.Forms.Label();
            this.OriginalAuthertextBox = new System.Windows.Forms.TextBox();
            this.StudioVoicelabel = new System.Windows.Forms.Label();
            this.StudioVoicetextBox = new System.Windows.Forms.TextBox();
            this.Studiolabel = new System.Windows.Forms.Label();
            this.StudiotextBox = new System.Windows.Forms.TextBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Delbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Yearnumber)).BeginInit();
            this.StatusPanel.SuspendLayout();
            this.TypeApanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumbEpisodNumber)).BeginInit();
            this.PrimarySourcepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.Location = new System.Drawing.Point(155, 12);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(206, 34);
            this.NameBox.TabIndex = 0;
            // 
            // Namelabel
            // 
            this.Namelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(139)))), ((int)(((byte)(33)))));
            this.Namelabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Namelabel.ForeColor = System.Drawing.Color.Black;
            this.Namelabel.Location = new System.Drawing.Point(12, 9);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(137, 38);
            this.Namelabel.TabIndex = 1;
            this.Namelabel.Text = "Название";
            // 
            // Yearlabel
            // 
            this.Yearlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(139)))), ((int)(((byte)(33)))));
            this.Yearlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Yearlabel.Location = new System.Drawing.Point(12, 55);
            this.Yearlabel.Name = "Yearlabel";
            this.Yearlabel.Size = new System.Drawing.Size(145, 39);
            this.Yearlabel.TabIndex = 2;
            this.Yearlabel.Text = "Год выхода";
            // 
            // Yearnumber
            // 
            this.Yearnumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Yearnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Yearnumber.Location = new System.Drawing.Point(163, 56);
            this.Yearnumber.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.Yearnumber.Minimum = new decimal(new int[] {
            1958,
            0,
            0,
            0});
            this.Yearnumber.Name = "Yearnumber";
            this.Yearnumber.Size = new System.Drawing.Size(120, 34);
            this.Yearnumber.TabIndex = 4;
            this.Yearnumber.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // Statlabel
            // 
            this.Statlabel.AutoSize = true;
            this.Statlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(139)))), ((int)(((byte)(33)))));
            this.Statlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Statlabel.Location = new System.Drawing.Point(17, 127);
            this.Statlabel.Name = "Statlabel";
            this.Statlabel.Size = new System.Drawing.Size(89, 28);
            this.Statlabel.TabIndex = 5;
            this.Statlabel.Text = "Статус";
            // 
            // CameOutButton
            // 
            this.CameOutButton.AutoSize = true;
            this.CameOutButton.Checked = true;
            this.CameOutButton.Location = new System.Drawing.Point(3, 3);
            this.CameOutButton.Name = "CameOutButton";
            this.CameOutButton.Size = new System.Drawing.Size(75, 21);
            this.CameOutButton.TabIndex = 6;
            this.CameOutButton.TabStop = true;
            this.CameOutButton.Text = "Вышел";
            this.CameOutButton.UseVisualStyleBackColor = true;
            // 
            // OngoingButton
            // 
            this.OngoingButton.AutoSize = true;
            this.OngoingButton.Location = new System.Drawing.Point(3, 30);
            this.OngoingButton.Name = "OngoingButton";
            this.OngoingButton.Size = new System.Drawing.Size(82, 21);
            this.OngoingButton.TabIndex = 7;
            this.OngoingButton.TabStop = true;
            this.OngoingButton.Text = "Онгоинг";
            this.OngoingButton.UseVisualStyleBackColor = true;
            // 
            // AnonsButton
            // 
            this.AnonsButton.AutoSize = true;
            this.AnonsButton.Location = new System.Drawing.Point(3, 57);
            this.AnonsButton.Name = "AnonsButton";
            this.AnonsButton.Size = new System.Drawing.Size(69, 21);
            this.AnonsButton.TabIndex = 8;
            this.AnonsButton.TabStop = true;
            this.AnonsButton.Text = "Анонс";
            this.AnonsButton.UseVisualStyleBackColor = true;
            // 
            // StatusPanel
            // 
            this.StatusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(207)))));
            this.StatusPanel.Controls.Add(this.CameOutButton);
            this.StatusPanel.Controls.Add(this.AnonsButton);
            this.StatusPanel.Controls.Add(this.OngoingButton);
            this.StatusPanel.Location = new System.Drawing.Point(155, 104);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(90, 82);
            this.StatusPanel.TabIndex = 9;
            // 
            // GenersListBox
            // 
            this.GenersListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(207)))));
            this.GenersListBox.FormattingEnabled = true;
            this.GenersListBox.Items.AddRange(new object[] {
            "Сёнэн",
            "Романтика",
            "Драма",
            "Комедия",
            "Этти",
            "Меха",
            "Фантастика",
            "Фэнтези",
            "Повседневность",
            "Школа",
            "Война",
            "Сёдзё",
            "Детектив",
            "Ужасы",
            "История",
            "Триллер",
            "Приключения",
            "Киберпанк",
            "Мистика",
            "Музыкальный",
            "Спорт",
            "Пародия",
            "Для детей",
            "Махо-сёдзё",
            "Сказка",
            "Сёдзё-ай",
            "Сёнэн-ай",
            "Боевые искусства",
            "Самйрайский боевик"});
            this.GenersListBox.Location = new System.Drawing.Point(17, 312);
            this.GenersListBox.MultiColumn = true;
            this.GenersListBox.Name = "GenersListBox";
            this.GenersListBox.Size = new System.Drawing.Size(445, 174);
            this.GenersListBox.TabIndex = 10;
            // 
            // Generslabel
            // 
            this.Generslabel.AutoSize = true;
            this.Generslabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(139)))), ((int)(((byte)(33)))));
            this.Generslabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Generslabel.Location = new System.Drawing.Point(119, 267);
            this.Generslabel.Name = "Generslabel";
            this.Generslabel.Size = new System.Drawing.Size(77, 28);
            this.Generslabel.TabIndex = 11;
            this.Generslabel.Text = "Жанр";
            // 
            // Countrylabel
            // 
            this.Countrylabel.AutoSize = true;
            this.Countrylabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(139)))), ((int)(((byte)(33)))));
            this.Countrylabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Countrylabel.Location = new System.Drawing.Point(12, 192);
            this.Countrylabel.Name = "Countrylabel";
            this.Countrylabel.Size = new System.Drawing.Size(94, 28);
            this.Countrylabel.TabIndex = 12;
            this.Countrylabel.Text = "Страна";
            // 
            // CountryBox
            // 
            this.CountryBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CountryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryBox.Location = new System.Drawing.Point(155, 192);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(100, 34);
            this.CountryBox.TabIndex = 13;
            // 
            // TypeAlabel
            // 
            this.TypeAlabel.AutoSize = true;
            this.TypeAlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(139)))), ((int)(((byte)(33)))));
            this.TypeAlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeAlabel.Location = new System.Drawing.Point(304, 69);
            this.TypeAlabel.Name = "TypeAlabel";
            this.TypeAlabel.Size = new System.Drawing.Size(57, 28);
            this.TypeAlabel.TabIndex = 14;
            this.TypeAlabel.Text = "Тип";
            // 
            // TypeApanel
            // 
            this.TypeApanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(207)))));
            this.TypeApanel.Controls.Add(this.ONAButton);
            this.TypeApanel.Controls.Add(this.SerialsButton);
            this.TypeApanel.Controls.Add(this.ShortSeriesButton);
            this.TypeApanel.Controls.Add(this.FullengthFilmButton);
            this.TypeApanel.Controls.Add(this.OVAButton);
            this.TypeApanel.Controls.Add(this.ShortFilmButton);
            this.TypeApanel.Controls.Add(this.SpecialButton);
            this.TypeApanel.Location = new System.Drawing.Point(369, 12);
            this.TypeApanel.Name = "TypeApanel";
            this.TypeApanel.Size = new System.Drawing.Size(215, 135);
            this.TypeApanel.TabIndex = 15;
            // 
            // ONAButton
            // 
            this.ONAButton.AutoSize = true;
            this.ONAButton.Location = new System.Drawing.Point(87, 84);
            this.ONAButton.Name = "ONAButton";
            this.ONAButton.Size = new System.Drawing.Size(59, 21);
            this.ONAButton.TabIndex = 17;
            this.ONAButton.TabStop = true;
            this.ONAButton.Text = "ONA";
            this.ONAButton.UseVisualStyleBackColor = true;
            // 
            // SerialsButton
            // 
            this.SerialsButton.AutoSize = true;
            this.SerialsButton.Location = new System.Drawing.Point(3, 84);
            this.SerialsButton.Name = "SerialsButton";
            this.SerialsButton.Size = new System.Drawing.Size(78, 21);
            this.SerialsButton.TabIndex = 17;
            this.SerialsButton.TabStop = true;
            this.SerialsButton.Text = "Сериал";
            this.SerialsButton.UseVisualStyleBackColor = true;
            // 
            // ShortSeriesButton
            // 
            this.ShortSeriesButton.AutoSize = true;
            this.ShortSeriesButton.Location = new System.Drawing.Point(3, 57);
            this.ShortSeriesButton.Name = "ShortSeriesButton";
            this.ShortSeriesButton.Size = new System.Drawing.Size(190, 21);
            this.ShortSeriesButton.TabIndex = 16;
            this.ShortSeriesButton.TabStop = true;
            this.ShortSeriesButton.Text = "Малометражный сериал";
            this.ShortSeriesButton.UseVisualStyleBackColor = true;
            // 
            // FullengthFilmButton
            // 
            this.FullengthFilmButton.AutoSize = true;
            this.FullengthFilmButton.Checked = true;
            this.FullengthFilmButton.Location = new System.Drawing.Point(3, 3);
            this.FullengthFilmButton.Name = "FullengthFilmButton";
            this.FullengthFilmButton.Size = new System.Drawing.Size(193, 21);
            this.FullengthFilmButton.TabIndex = 16;
            this.FullengthFilmButton.TabStop = true;
            this.FullengthFilmButton.Text = "Полнометражный фильм";
            this.FullengthFilmButton.UseVisualStyleBackColor = true;
            // 
            // OVAButton
            // 
            this.OVAButton.AutoSize = true;
            this.OVAButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OVAButton.Location = new System.Drawing.Point(88, 111);
            this.OVAButton.Name = "OVAButton";
            this.OVAButton.Size = new System.Drawing.Size(58, 21);
            this.OVAButton.TabIndex = 18;
            this.OVAButton.TabStop = true;
            this.OVAButton.Text = "OVA";
            this.OVAButton.UseVisualStyleBackColor = true;
            // 
            // ShortFilmButton
            // 
            this.ShortFilmButton.AutoSize = true;
            this.ShortFilmButton.Location = new System.Drawing.Point(3, 30);
            this.ShortFilmButton.Name = "ShortFilmButton";
            this.ShortFilmButton.Size = new System.Drawing.Size(206, 21);
            this.ShortFilmButton.TabIndex = 19;
            this.ShortFilmButton.TabStop = true;
            this.ShortFilmButton.Text = "Короткометражный фильм";
            this.ShortFilmButton.UseVisualStyleBackColor = true;
            // 
            // SpecialButton
            // 
            this.SpecialButton.AutoSize = true;
            this.SpecialButton.Location = new System.Drawing.Point(3, 111);
            this.SpecialButton.Name = "SpecialButton";
            this.SpecialButton.Size = new System.Drawing.Size(75, 21);
            this.SpecialButton.TabIndex = 20;
            this.SpecialButton.TabStop = true;
            this.SpecialButton.Text = "Special";
            this.SpecialButton.UseVisualStyleBackColor = true;
            // 
            // NumbEpisodlabel
            // 
            this.NumbEpisodlabel.AutoSize = true;
            this.NumbEpisodlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(139)))), ((int)(((byte)(33)))));
            this.NumbEpisodlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumbEpisodlabel.Location = new System.Drawing.Point(304, 173);
            this.NumbEpisodlabel.Name = "NumbEpisodlabel";
            this.NumbEpisodlabel.Size = new System.Drawing.Size(253, 28);
            this.NumbEpisodlabel.TabIndex = 16;
            this.NumbEpisodlabel.Text = "Количество эпизодов";
            // 
            // NumbEpisodNumber
            // 
            this.NumbEpisodNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NumbEpisodNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumbEpisodNumber.Location = new System.Drawing.Point(583, 170);
            this.NumbEpisodNumber.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumbEpisodNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumbEpisodNumber.Name = "NumbEpisodNumber";
            this.NumbEpisodNumber.Size = new System.Drawing.Size(120, 34);
            this.NumbEpisodNumber.TabIndex = 17;
            this.NumbEpisodNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Producerlabel
            // 
            this.Producerlabel.AutoSize = true;
            this.Producerlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(139)))), ((int)(((byte)(33)))));
            this.Producerlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Producerlabel.Location = new System.Drawing.Point(603, 15);
            this.Producerlabel.Name = "Producerlabel";
            this.Producerlabel.Size = new System.Drawing.Size(109, 28);
            this.Producerlabel.TabIndex = 18;
            this.Producerlabel.Text = "Режисёр";
            // 
            // ProducertextBox
            // 
            this.ProducertextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ProducertextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProducertextBox.Location = new System.Drawing.Point(726, 11);
            this.ProducertextBox.Name = "ProducertextBox";
            this.ProducertextBox.Size = new System.Drawing.Size(140, 34);
            this.ProducertextBox.TabIndex = 19;
            // 
            // PrimarySourcelabel
            // 
            this.PrimarySourcelabel.AutoSize = true;
            this.PrimarySourcelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(139)))), ((int)(((byte)(33)))));
            this.PrimarySourcelabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrimarySourcelabel.Location = new System.Drawing.Point(644, 69);
            this.PrimarySourcelabel.Name = "PrimarySourcelabel";
            this.PrimarySourcelabel.Size = new System.Drawing.Size(191, 28);
            this.PrimarySourcelabel.TabIndex = 20;
            this.PrimarySourcelabel.Text = "Первоисточник";
            // 
            // PrimarySourcepanel
            // 
            this.PrimarySourcepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(207)))));
            this.PrimarySourcepanel.Controls.Add(this.RanobeButton);
            this.PrimarySourcepanel.Controls.Add(this.MangaButton);
            this.PrimarySourcepanel.Controls.Add(this.OriginalButton);
            this.PrimarySourcepanel.Location = new System.Drawing.Point(733, 103);
            this.PrimarySourcepanel.Name = "PrimarySourcepanel";
            this.PrimarySourcepanel.Size = new System.Drawing.Size(102, 83);
            this.PrimarySourcepanel.TabIndex = 21;
            // 
            // RanobeButton
            // 
            this.RanobeButton.AutoSize = true;
            this.RanobeButton.Location = new System.Drawing.Point(4, 59);
            this.RanobeButton.Name = "RanobeButton";
            this.RanobeButton.Size = new System.Drawing.Size(77, 21);
            this.RanobeButton.TabIndex = 2;
            this.RanobeButton.TabStop = true;
            this.RanobeButton.Text = "Ранобэ";
            this.RanobeButton.UseVisualStyleBackColor = true;
            // 
            // MangaButton
            // 
            this.MangaButton.AutoSize = true;
            this.MangaButton.Location = new System.Drawing.Point(4, 31);
            this.MangaButton.Name = "MangaButton";
            this.MangaButton.Size = new System.Drawing.Size(69, 21);
            this.MangaButton.TabIndex = 1;
            this.MangaButton.TabStop = true;
            this.MangaButton.Text = "Манга";
            this.MangaButton.UseVisualStyleBackColor = true;
            // 
            // OriginalButton
            // 
            this.OriginalButton.AutoSize = true;
            this.OriginalButton.Checked = true;
            this.OriginalButton.Location = new System.Drawing.Point(3, 3);
            this.OriginalButton.Name = "OriginalButton";
            this.OriginalButton.Size = new System.Drawing.Size(93, 21);
            this.OriginalButton.TabIndex = 0;
            this.OriginalButton.TabStop = true;
            this.OriginalButton.Text = "Оригинал";
            this.OriginalButton.UseVisualStyleBackColor = true;
            // 
            // OriginalAutherlabel
            // 
            this.OriginalAutherlabel.AutoSize = true;
            this.OriginalAutherlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(139)))), ((int)(((byte)(33)))));
            this.OriginalAutherlabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OriginalAutherlabel.Location = new System.Drawing.Point(307, 219);
            this.OriginalAutherlabel.Name = "OriginalAutherlabel";
            this.OriginalAutherlabel.Size = new System.Drawing.Size(274, 28);
            this.OriginalAutherlabel.TabIndex = 22;
            this.OriginalAutherlabel.Text = "Автор первоисточника";
            // 
            // OriginalAuthertextBox
            // 
            this.OriginalAuthertextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OriginalAuthertextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OriginalAuthertextBox.Location = new System.Drawing.Point(603, 214);
            this.OriginalAuthertextBox.Name = "OriginalAuthertextBox";
            this.OriginalAuthertextBox.Size = new System.Drawing.Size(121, 34);
            this.OriginalAuthertextBox.TabIndex = 23;
            // 
            // StudioVoicelabel
            // 
            this.StudioVoicelabel.AutoSize = true;
            this.StudioVoicelabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(139)))), ((int)(((byte)(33)))));
            this.StudioVoicelabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudioVoicelabel.Location = new System.Drawing.Point(307, 261);
            this.StudioVoicelabel.Name = "StudioVoicelabel";
            this.StudioVoicelabel.Size = new System.Drawing.Size(192, 28);
            this.StudioVoicelabel.TabIndex = 24;
            this.StudioVoicelabel.Text = "Студия озвучки";
            // 
            // StudioVoicetextBox
            // 
            this.StudioVoicetextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StudioVoicetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudioVoicetextBox.Location = new System.Drawing.Point(522, 257);
            this.StudioVoicetextBox.Name = "StudioVoicetextBox";
            this.StudioVoicetextBox.Size = new System.Drawing.Size(202, 34);
            this.StudioVoicetextBox.TabIndex = 25;
            // 
            // Studiolabel
            // 
            this.Studiolabel.AutoSize = true;
            this.Studiolabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(139)))), ((int)(((byte)(33)))));
            this.Studiolabel.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Studiolabel.Location = new System.Drawing.Point(770, 220);
            this.Studiolabel.Name = "Studiolabel";
            this.Studiolabel.Size = new System.Drawing.Size(96, 28);
            this.Studiolabel.TabIndex = 26;
            this.Studiolabel.Text = "Студия";
            // 
            // StudiotextBox
            // 
            this.StudiotextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StudiotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudiotextBox.Location = new System.Drawing.Point(740, 250);
            this.StudiotextBox.Name = "StudiotextBox";
            this.StudiotextBox.Size = new System.Drawing.Size(126, 34);
            this.StudiotextBox.TabIndex = 27;
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(97)))), ((int)(((byte)(38)))));
            this.Addbutton.FlatAppearance.BorderSize = 0;
            this.Addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbutton.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Addbutton.Location = new System.Drawing.Point(538, 417);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(133, 47);
            this.Addbutton.TabIndex = 28;
            this.Addbutton.Text = "Добавить";
            this.Addbutton.UseVisualStyleBackColor = false;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Delbutton
            // 
            this.Delbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(97)))), ((int)(((byte)(38)))));
            this.Delbutton.FlatAppearance.BorderSize = 0;
            this.Delbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delbutton.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delbutton.Location = new System.Drawing.Point(717, 417);
            this.Delbutton.Name = "Delbutton";
            this.Delbutton.Size = new System.Drawing.Size(130, 47);
            this.Delbutton.TabIndex = 29;
            this.Delbutton.Text = "Удалить";
            this.Delbutton.UseVisualStyleBackColor = false;
            this.Delbutton.Click += new System.EventHandler(this.Delbutton_Click);
            // 
            // FormAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(878, 498);
            this.Controls.Add(this.Delbutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.StudiotextBox);
            this.Controls.Add(this.Studiolabel);
            this.Controls.Add(this.StudioVoicetextBox);
            this.Controls.Add(this.StudioVoicelabel);
            this.Controls.Add(this.OriginalAuthertextBox);
            this.Controls.Add(this.OriginalAutherlabel);
            this.Controls.Add(this.PrimarySourcepanel);
            this.Controls.Add(this.PrimarySourcelabel);
            this.Controls.Add(this.ProducertextBox);
            this.Controls.Add(this.Producerlabel);
            this.Controls.Add(this.NumbEpisodNumber);
            this.Controls.Add(this.NumbEpisodlabel);
            this.Controls.Add(this.TypeApanel);
            this.Controls.Add(this.TypeAlabel);
            this.Controls.Add(this.CountryBox);
            this.Controls.Add(this.Countrylabel);
            this.Controls.Add(this.Generslabel);
            this.Controls.Add(this.GenersListBox);
            this.Controls.Add(this.StatusPanel);
            this.Controls.Add(this.Statlabel);
            this.Controls.Add(this.Yearnumber);
            this.Controls.Add(this.Yearlabel);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.NameBox);
            this.Name = "FormAddEdit";
            this.Text = "Аниме информация";
            ((System.ComponentModel.ISupportInitialize)(this.Yearnumber)).EndInit();
            this.StatusPanel.ResumeLayout(false);
            this.StatusPanel.PerformLayout();
            this.TypeApanel.ResumeLayout(false);
            this.TypeApanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumbEpisodNumber)).EndInit();
            this.PrimarySourcepanel.ResumeLayout(false);
            this.PrimarySourcepanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label Yearlabel;
        private System.Windows.Forms.NumericUpDown Yearnumber;
        private System.Windows.Forms.Label Statlabel;
        private System.Windows.Forms.RadioButton CameOutButton;
        private System.Windows.Forms.RadioButton OngoingButton;
        private System.Windows.Forms.RadioButton AnonsButton;
        private System.Windows.Forms.Panel StatusPanel;
        private System.Windows.Forms.CheckedListBox GenersListBox;
        private System.Windows.Forms.Label Generslabel;
        private System.Windows.Forms.Label Countrylabel;
        private System.Windows.Forms.TextBox CountryBox;
        private System.Windows.Forms.Label TypeAlabel;
        private System.Windows.Forms.Panel TypeApanel;
        private System.Windows.Forms.RadioButton SpecialButton;
        private System.Windows.Forms.RadioButton FullengthFilmButton;
        private System.Windows.Forms.RadioButton OVAButton;
        private System.Windows.Forms.RadioButton ShortFilmButton;
        private System.Windows.Forms.RadioButton SerialsButton;
        private System.Windows.Forms.RadioButton ShortSeriesButton;
        private System.Windows.Forms.RadioButton ONAButton;
        private System.Windows.Forms.Label NumbEpisodlabel;
        private System.Windows.Forms.NumericUpDown NumbEpisodNumber;
        private System.Windows.Forms.Label Producerlabel;
        private System.Windows.Forms.TextBox ProducertextBox;
        private System.Windows.Forms.Label PrimarySourcelabel;
        private System.Windows.Forms.Panel PrimarySourcepanel;
        private System.Windows.Forms.RadioButton RanobeButton;
        private System.Windows.Forms.RadioButton MangaButton;
        private System.Windows.Forms.RadioButton OriginalButton;
        private System.Windows.Forms.Label OriginalAutherlabel;
        private System.Windows.Forms.TextBox OriginalAuthertextBox;
        private System.Windows.Forms.Label StudioVoicelabel;
        private System.Windows.Forms.TextBox StudioVoicetextBox;
        private System.Windows.Forms.Label Studiolabel;
        private System.Windows.Forms.TextBox StudiotextBox;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Delbutton;
    }
}