using System.Collections.Generic;

namespace Battle.Models
{
    public class FileRepository : IRepository
    {
        public void Add(Movie movie)
        {
            // open the file
            // write the movie to the file
            // close the file
        }

        public Movie Get(int id)
        {
            // open the file
            // retrieve the record
            // return the record
            return new Movie();
        }

        public List<Movie> GetAll()
        {
            // open the file
            // retrieve ALL records
            // return the records

            return new List<Movie>();
        }
    }
}