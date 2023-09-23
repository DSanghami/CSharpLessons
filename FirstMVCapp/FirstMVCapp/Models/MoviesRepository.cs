using System.Data.SqlClient;
using System.Data;

namespace FirstMVCapp.Models
{
    
        public class MoviesRepository
        {
            public static List<Movies> GetMovieList()
            {
                // These are null methods. We use this if we dont want to override all the methods only want to read particular number of methods.
                List<Movies> empList = new List<Movies>();
                using (SqlConnection cn = SqlHelper.CreateConnection())
                {
                    if (cn.State != ConnectionState.Open)
                    {
                        cn.Open();
                    }
                    SqlCommand selectmoviecmd = cn.CreateCommand();
                    String selectAllMovies = "Select * from Movies";
                    selectmoviecmd.CommandText = selectAllMovies;
                    SqlDataReader empdr = selectmoviecmd.ExecuteReader();
                    while (empdr.Read())
                    {
                        Movies emp = new Movies
                        {
                            Id = empdr.GetInt32(0),
                            Title = empdr.GetString(1),
                            Language = empdr.GetString(2),
                            Hero = empdr.GetString(3),
                            Director = empdr.GetString(4),
                            MusicDirector = empdr.GetString(5),
                            ReleaseDate = empdr.GetDateTime(6),
                            Cost = empdr.GetDecimal(7),
                            Collection = empdr.GetDecimal(8),
                            Review = empdr.GetString(9),


                        };
                        empList.Add(emp);
                    }
                    return empList;

                }
                return null;
            }
        public static Movies GetMoviesById(int id)
        {
            Movies moviesFound = new Movies();
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != System.Data.ConnectionState.Open)
                    cn.Open();
                SqlCommand selectmoviescmd = cn.CreateCommand();
                String selectMovies = "Select * from Movies where ID=@id";
                selectmoviescmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                selectmoviescmd.CommandText = selectMovies;
                SqlDataReader moviesdr = selectmoviescmd.ExecuteReader();
                while (moviesdr.Read())
                {
                    moviesFound = new Movies
                    {
                        Id = moviesdr.GetInt32(0),
                        Title = moviesdr.GetString(1),
                        Language = moviesdr.GetString(2),
                        Hero = moviesdr.GetString(3),
                        Director = moviesdr.GetString(4),
                        MusicDirector = moviesdr.GetString(5),
                        ReleaseDate = moviesdr.GetDateTime(6),
                        Cost = moviesdr.GetDecimal(7),
                        Collection = moviesdr.GetDecimal(8),
                        Review = moviesdr.GetString(9),
                    };
                }
            }
            return moviesFound;
        }

        public static int AddNewMovies(Movies newMovie)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand insertMoviecmd = cn.CreateCommand();
                String insertNewMovieQuery = "insert into Movies values( @id,@title,@language,@hero,@director,@musicdirector,@releasedate,@cost,@collection,@review )";
                insertMoviecmd.Parameters.Add("@id", SqlDbType.Int).Value = newMovie.Id; //id doesnt need to same with table column
                insertMoviecmd.Parameters.Add("@title", SqlDbType.NVarChar).Value = newMovie.Title;
                insertMoviecmd.Parameters.Add("@language", SqlDbType.NVarChar).Value = newMovie.Language;
                insertMoviecmd.Parameters.Add("@hero", SqlDbType.NVarChar).Value = newMovie.Hero;
                insertMoviecmd.Parameters.Add("@director", SqlDbType.NVarChar).Value = newMovie.Director;
                insertMoviecmd.Parameters.Add("@musicdirector", SqlDbType.NVarChar).Value = newMovie.MusicDirector;
                insertMoviecmd.Parameters.Add("@releasedate", SqlDbType.DateTime).Value = newMovie.ReleaseDate;
                insertMoviecmd.Parameters.Add("@cost", SqlDbType.Decimal).Value = newMovie.Cost;
                insertMoviecmd.Parameters.Add("@collection", SqlDbType.Decimal).Value = newMovie.Collection;
                insertMoviecmd.Parameters.Add("@review", SqlDbType.NVarChar).Value = newMovie.Review;

                insertMoviecmd.CommandText = insertNewMovieQuery;
                query_result = insertMoviecmd.ExecuteNonQuery(); //not executing . tells how many records got inserted
            }
            return query_result;
        }

        public static int UpdateMovies(int id,Movies movies)
        {
            int query_result = 0;
         //   Movies movies1 = movies;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand updateEmpcmd = cn.CreateCommand();
                String str = @"Update Movies set ID=@id,Title=@title,Language=@language,Hero=@hero,Director=@director,MusicDirector=@musicDirector,ReleaseDate=@releaseDate,Cost=@cost,Collection=@collection,Review=@review where ID=@id;";
                updateEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                updateEmpcmd.Parameters.Add("@title", SqlDbType.NVarChar).Value = movies.Title;
                updateEmpcmd.Parameters.Add("@language", SqlDbType.NVarChar).Value = movies.Language;
                updateEmpcmd.Parameters.Add("@hero", SqlDbType.NVarChar).Value = movies.Hero;
                updateEmpcmd.Parameters.Add("@director", SqlDbType.NVarChar).Value = movies.Director;
                updateEmpcmd.Parameters.Add("@musicDirector", SqlDbType.NVarChar).Value = movies.MusicDirector;
                updateEmpcmd.Parameters.Add("@releaseDate", SqlDbType.DateTime).Value = movies.ReleaseDate;
                updateEmpcmd.Parameters.Add("@cost", SqlDbType.Decimal).Value = movies.Cost;
                updateEmpcmd.Parameters.Add("@collection", SqlDbType.Decimal).Value = movies.Collection;
                updateEmpcmd.Parameters.Add("@review", SqlDbType.NVarChar).Value = movies.Review;
                updateEmpcmd.CommandText = str;
                query_result = updateEmpcmd.ExecuteNonQuery();
            }
            return query_result;
        }
        public static int DeletMovies(int id)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand deleteEmpcmd = cn.CreateCommand();
                String deleteEmpQuery = "Delete from Movies where ID=@id";
                deleteEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                deleteEmpcmd.CommandText = deleteEmpQuery;
                query_result = deleteEmpcmd.ExecuteNonQuery();
            }
            return query_result;
        }
    }
    }  
