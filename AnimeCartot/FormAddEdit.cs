using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeCartot
{
    public partial class FormAddEdit : Form
    {
        public BindingList<AnimeInfo> bai;
        public bool neadlyUpdate = false;
        private int id;
        public FormAddEdit(BindingList<AnimeInfo> bai)
        {
            InitializeComponent();
            this.bai = bai;
            Addbutton.Text = "Добавить";
            Delbutton.Text = "Очистить";
        }
        public FormAddEdit(BindingList<AnimeInfo> bai, int id)
        {
            InitializeComponent();
            this.bai = bai;
            neadlyUpdate = true;
            Addbutton.Text = "Изменить";
            Delbutton.Text = "Удалить";
            this.id = id;
            NameBox.Text = bai[id].Name;
            Yearnumber.Value = bai[id].Year;
            if (OngoingButton.Text == bai[id].Stat)
                OngoingButton.Checked = true;
            if (AnonsButton.Text == bai[id].Stat)
                AnonsButton.Checked = true;
            string[] str = bai[id].Genre.Split(',');
            for (int i = 0; i < GenersListBox.Items.Count; i++)
            {
                if(str.Contains(GenersListBox.Items[i].ToString()))
                    GenersListBox.SetItemChecked(i, true);
            }
            CountryBox.Text = bai[id].Сountry;
            if (ShortFilmButton.Text == bai[id].TypeA)
                ShortFilmButton.Checked = true;
            if (ShortSeriesButton.Text == bai[id].TypeA)
                ShortSeriesButton.Checked = true;
            if (SerialsButton.Text == bai[id].TypeA)
                SerialsButton.Checked = true;
            if (SpecialButton.Text == bai[id].TypeA)
                SpecialButton.Checked = true;
            if (ONAButton.Text == bai[id].TypeA)
                ONAButton.Checked = true;
            if (OVAButton.Text == bai[id].TypeA)
                OVAButton.Checked = true;
            NumbEpisodNumber.Value = bai[id].NumbEpisod;
            ProducertextBox.Text = bai[id].Producer;
            if (MangaButton.Text == bai[id].PrimarySource)
                MangaButton.Checked = true;
            if (RanobeButton.Text == bai[id].PrimarySource)
                RanobeButton.Checked = true;
            OriginalAuthertextBox.Text = bai[id].OrigAuthor;
            StudioVoicetextBox.Text = bai[id].StudioVoice;
            StudiotextBox.Text = bai[id].Studio;
        }
        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (neadlyUpdate)
            {
                int idCurRadButStatus = StatusPanel.Controls.OfType<RadioButton>().Select((rb, i) => new { rb, i }).Single(z => z.rb.Checked).i;
                int idCurRadButTypeA = TypeApanel.Controls.OfType<RadioButton>().Select((rb, i) => new { rb, i }).Single(z => z.rb.Checked).i;
                int idCurRadButPrimarySource = PrimarySourcepanel.Controls.OfType<RadioButton>().Select((rb, i) => new { rb, i }).Single(z => z.rb.Checked).i;
                bai[id].Name = NameBox.Text;
                bai[id].Year = Convert.ToInt32(Yearnumber.Value);
                bai[id].Stat = StatusPanel.Controls[idCurRadButStatus].Text;
                bai[id].Genre = convertGeners();
                bai[id].Сountry = CountryBox.Text;
                bai[id].TypeA = TypeApanel.Controls[idCurRadButTypeA].Text;
                bai[id].NumbEpisod = Convert.ToInt32(NumbEpisodNumber.Value);
                bai[id].Producer = ProducertextBox.Text;
                bai[id].PrimarySource = PrimarySourcepanel.Controls[idCurRadButPrimarySource].Text;
                bai[id].OrigAuthor = OriginalAuthertextBox.Text;
                bai[id].StudioVoice = StudioVoicetextBox.Text;
                bai[id].Studio = StudiotextBox.Text;
                this.Close();
            }
            else
            {
                int idCurRadButStatus = StatusPanel.Controls.OfType<RadioButton>().Select((rb, i) => new { rb, i }).Single(z => z.rb.Checked).i;
                int idCurRadButTypeA = TypeApanel.Controls.OfType<RadioButton>().Select((rb, i) => new { rb, i }).Single(z => z.rb.Checked).i;
                int idCurRadButPrimarySource = PrimarySourcepanel.Controls.OfType<RadioButton>().Select((rb, i) => new { rb, i }).Single(z => z.rb.Checked).i;
                AnimeInfo ba = new AnimeInfo((bai.Count() + 1), NameBox.Text, Convert.ToInt32(Yearnumber.Value),
                    StatusPanel.Controls[idCurRadButStatus].Text, convertGeners(), CountryBox.Text,
                    TypeApanel.Controls[idCurRadButTypeA].Text, Convert.ToInt32(NumbEpisodNumber.Value), ProducertextBox.Text,
                    PrimarySourcepanel.Controls[idCurRadButPrimarySource].Text, OriginalAuthertextBox.Text, StudioVoicetextBox.Text,
                    StudiotextBox.Text);
                bai.Add(ba);
            }
        }
        private string convertGeners()
        {
            string bstr = "";
            for(int i =0; i< GenersListBox.CheckedItems.Count; i++)
            {
                bstr += GenersListBox.CheckedItems[i];
                if(i+1 != GenersListBox.CheckedItems.Count)
                    bstr += ",";
            }
            return bstr;
        }

        private void Delbutton_Click(object sender, EventArgs e)
        {
            if (neadlyUpdate)
            {
                bai.RemoveAt(id);
                this.Close();
            }
            else
            {
                NameBox.Clear();
                Yearnumber.Value = Yearnumber.Maximum;
                for (int i = 0; i < GenersListBox.Items.Count;i++)
                {
                    GenersListBox.SetItemChecked(i, false);
                }    
                CountryBox.Clear();
                NumbEpisodNumber.Value = 1;
                ProducertextBox.Clear();
                OriginalAuthertextBox.Clear();
                StudioVoicetextBox.Clear();
                StudiotextBox.Clear();
            }
        }
    }
}
