namespace RAD302_S00141926.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RAD302_S00141926.Models.MoviesDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RAD302_S00141926.Models.MoviesDBContext context)
        {
            
            var movies = new List<Movies>
            {
                new Movies() {ID=1, FilmName="The Social Network", ReleaseYear="2010", Director="David Fincher" },
                new Movies() {ID=2, FilmName="Her", ReleaseYear="2013", Director="Spike Jonze" },
                new Movies() {ID=3, FilmName="Boyhood", ReleaseYear="2014", Director="Richard Linklater" },
                new Movies() {ID=4, FilmName="No Country For Old Men", ReleaseYear="2007", Director="Coen Brothers" },
                new Movies() {ID=5, FilmName="There Will Be Blood", ReleaseYear="2007", Director="Paul Thomas Anderson" },
                new Movies() {ID=6, FilmName="Drive", ReleaseYear="2011", Director="Nicolas Winding Refn" },
                new Movies() {ID=7, FilmName="Eternal Sunshine of the Spotless Mind", ReleaseYear="2004", Director="Michel Gondry" },
                new Movies() {ID=8, FilmName="Under The Skin", ReleaseYear="2013", Director="Jonathan Glazer" }

            };
        }
    }
}
