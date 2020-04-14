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
    public partial class Mform : Form
    {
        public ListAnime DataAI;
        public Mform()
        {
            InitializeComponent();
            this.dataGridView.CellMouseDoubleClick += DataGridViewCellMouseDoubleClickListener;
            DataAI = new ListAnime();
            this.DataAI.AnimeI = this.DataAI.getlist();
            dataGridView.DataSource = DataAI.AnimeI;
            dataGridView.ReadOnly = true;
            setColumns();
        }
        private void setColumns()
        {
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].HeaderText = "Название";
            dataGridView.Columns[2].HeaderText = "Год";
            dataGridView.Columns[3].HeaderText = "Статус";
            dataGridView.Columns[4].HeaderText = "Жанр";
            dataGridView.Columns[5].HeaderText = "Страна";
            dataGridView.Columns[6].HeaderText = "Тип";
            dataGridView.Columns[7].HeaderText = "Количество серий";
            dataGridView.Columns[8].HeaderText = "Продюсер";
            dataGridView.Columns[9].HeaderText = "Первоисточник";
            dataGridView.Columns[10].HeaderText = "Автор первоисточника";
            dataGridView.Columns[11].HeaderText = "Студия озвучки";
            dataGridView.Columns[12].HeaderText = "Студия";
        }
        private void DataGridViewCellMouseDoubleClickListener(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value);
            new FormAddEdit(DataAI.AnimeI, id-1).Show();
            dataGridView.Update();
        }

        private void add_Click(object sender, EventArgs e)
        {
            new FormAddEdit(DataAI.AnimeI).Show();
            dataGridView.Update();
        }
        private void Form1_FormClosed(Object sender, FormClosedEventArgs e)
        {
            DataAI.inFile();
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            this.SeachtextBox.Clear();
            dataGridView.DataSource = DataAI.AnimeI;
        }
        private void SearchTex_change(object sender, EventArgs e)
        {
            string str = SeachtextBox.Text;
            BindingList<AnimeInfo> nbAI = new BindingList<AnimeInfo>();
            for(int i=0;i< DataAI.AnimeI.Count;i++)
            {
                if (DataAI.AnimeI[i].Name.Contains(str)) nbAI.Add(DataAI.AnimeI[i]);
            }
            dataGridView.DataSource = nbAI;
            dataGridView.Update();
        }
    }
}
