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
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var movies = new List<Movies>
            {
                new Movies() {FilmName="The Social Network", ReleaseYear="2010", Director="David Fincher" },
                new Movies() {FilmName="Her", ReleaseYear="2013", Director="Spike Jonze" },
                new Movies() {FilmName="Boyhood", ReleaseYear="2014", Director="Richard Linklater" },
                new Movies() {FilmName="No Country For Old Men", ReleaseYear="2007", Director="Coen Brothers" },
                new Movies() {FilmName="There Will Be Blood", ReleaseYear="2007", Director="Paul Thomas Anderson" },
                new Movies() {FilmName="Drive", ReleaseYear="2011", Director="Nicolas Winding Refn" },
                new Movies() {FilmName="Eternal Sunshine of the Spotless Mind", ReleaseYear="2004", Director="Michel Gondry" },
                new Movies() {FilmName="Under The Skin", ReleaseYear="2013", Director="Jonathan Glazer" }

            };
        }
    }
}
