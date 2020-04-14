using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;

namespace AnimeCartot
{
    public class AnimeInfo
    {
        private int id;
        private string name;
        private int year;
        private string stat;
        private string genre;
        private string сountry;
        private string typeA;
        private int numbEpisod;
        private string producer;
        private string primarySource;
        private string origAuthor;
        private string studioVoice;
        private string studio;
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Year { get => year; set => year = value; }
        public string Stat { get => stat; set => stat = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Сountry { get => сountry; set => сountry = value; }
        public string TypeA { get => typeA; set => typeA = value; }
        public int NumbEpisod { get => numbEpisod; set => numbEpisod = value; }
        public string Producer { get => producer; set => producer = value; }
        public string PrimarySource { get => primarySource; set => primarySource = value; }
        public string OrigAuthor { get => origAuthor; set => origAuthor = value; }
        public string StudioVoice { get => studioVoice; set => studioVoice = value; }
        public string Studio { get => studio; set => studio = value; }
        public AnimeInfo() { }
        public AnimeInfo(string[] str)
        {
            this.Id = int.Parse(str[0]);
            this.Name = str[1];
            this.Year = int.Parse(str[2]);
            this.Stat = str[3];
            this.Genre = str[4];
            this.Сountry = str[5];
            this.TypeA = str[6];
            this.NumbEpisod = int.Parse(str[7]);
            this.Producer = str[8];
            this.PrimarySource = str[9];
            this.OrigAuthor = str[10];
            this.StudioVoice = str[11];
            this.Studio = str[12];
        }
        public AnimeInfo(int id, string name, int year, string stat, string genre, string country, string typea, int numbepisode, string producer, string primarySource, string origauthor, string studiovoice, string studio)
        {
            this.Id = id;
            this.Name = name;
            this.Year = year;
            this.Stat = stat;
            this.Genre = genre;
            this.Сountry = country;
            this.TypeA = typea;
            this.NumbEpisod = numbepisode;
            this.Producer = producer;
            this.PrimarySource = primarySource;
            this.OrigAuthor = origauthor;
            this.StudioVoice = studiovoice;
            this.Studio = studio;
        }

    }
    public class ListAnime
    {
        public string fp = "AF.txt";
        public BindingList<AnimeInfo> AnimeI;
        public ListAnime()
        {
            this.AnimeI = new BindingList<AnimeInfo>();
        }
        public BindingList<AnimeInfo> getlist()
        {
            FileStream file = new FileStream(fp, FileMode.OpenOrCreate);
            StreamReader sf = new StreamReader(file);
            string bstr;
            while ((bstr = sf.ReadLine()) != null && bstr != string.Empty)
            {
                string[] str = bstr.Split(';');
                AnimeI.Add(new AnimeInfo(str));
            }
            sf.Close();
            file.Close();
            return AnimeI;
        }
        public void inFile()
        {
            File.WriteAllText(@"AF.txt", string.Empty);
            FileStream file = new FileStream(fp, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(file);
            for (int i = 0; i< AnimeI.Count; i++)
            {
                sw.WriteLine(AnimeI[i].Id+";"+AnimeI[i].Name+";"+AnimeI[i].Year+";"+AnimeI[i].Stat+";"+
                    AnimeI[i].Genre+";"+AnimeI[i].Сountry+";"+AnimeI[i].TypeA+";"+AnimeI[i].NumbEpisod+";"+
                    AnimeI[i].Producer+";"+AnimeI[i].PrimarySource+";"+AnimeI[i].OrigAuthor+";"+
                    AnimeI[i].StudioVoice+";"+AnimeI[i].Studio);
            }
            sw.Close();
            file.Close();
        }
    }
}
