using System;
using SeriesDIO.Enums;

namespace SeriesDIO.Classes
{
    public class Serie : BaseEntity
    {
        private Genre Genre { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int Year { get; set; }
        private bool Excluded {get; set; }

        public Serie(int id, Genre genre, string title, string description, int year)
        {
            this.Id = id;
            this.Genre = genre;
            this.Title = title;
            this.Description = description;
            this.Year = year;
            this.Excluded = false;
        }

        public override string ToString()
        {
            string returnContent = "";
            returnContent += "Genre: " + this.Genre + Environment.NewLine;
            returnContent += "Title: " + this.Title + Environment.NewLine;
            returnContent += "Description: " + this.Description + Environment.NewLine;
            returnContent += "Year: " + this.Year + Environment.NewLine;
            returnContent += "Excluded: " + this.Excluded + Environment.NewLine;
            return returnContent;
        }

        public string getTitle()
        {
            return this.Title;
        }

        public int getId()
        {
            return this.Id;
        }

        public bool getExcluded()
        {
            return this.Excluded;
        }

        public void Exclude(){
            this.Excluded = true;
        }
    }
}