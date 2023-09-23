using Microsoft.AspNetCore.Authorization.Policy;
using System.Text;
using System.Xml.Linq;

namespace FirstMVCapp.Models
{
    public class AuthorRepository
    {
        public static Dictionary<int, Author> GetAuthorDictionary()
        {
            String fName = @"c:\temp\Author2.txt";
            Dictionary<int, Author> list = new Dictionary<int, Author>();
            bool isFileExists = System.IO.File.Exists(fName);
            if (isFileExists)
            {
                using (StreamReader sr = new StreamReader(fName))
                {
                    string strAuthor = $"{sr.ReadLine()}";
                    String[] data = strAuthor.Split(',');
                    Author author = null;
                    if (data.Length == 5)
                    {
                        author = StringToAuthor(data, new Author());
                        list.Add(author.AuthorID, author);
                    }
                    while (!sr.EndOfStream)
                    {
                        strAuthor = $"{sr.ReadLine()}";
                        data = strAuthor.Split(",");
                        author = StringToAuthor(data, new Author());
                        list.Add(author.AuthorID, author);
                    }
                }
            }
            return list;

        }
        private static Author StringToAuthor(String[] data, Author author)
        {
            author.AuthorID = int.Parse(data[0]);
            author.AuthorName = data[1];
            if (DateTime.TryParse(data[2], out DateTime dateOfBirth))
            {
                author.DateofBirth = dateOfBirth;
            }
            else
            {

            }
            author.NoOfBooks = int.Parse(data[3]);
            author.RoyaltyCompany = data[4];
            return author;
        }
        public static Author FindAuthotByID(int id)
        {
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            Author author = null;
            if (list != null)
            {
                author = list.FirstOrDefault(x => (x.Key == id)).Value;
            }
            return author;
        }
        public static void SaveToFile(Author pAuthor)
        {
            String fname = @"c:\temp\Author2.txt";
            string strAuthor = $"{pAuthor.AuthorID}, {pAuthor.AuthorName},{pAuthor.DateofBirth},{pAuthor.NoOfBooks},{pAuthor.RoyaltyCompany}";
            using (StreamWriter sw = new StreamWriter(fname, true))
            {
                sw.WriteLine(strAuthor);
            }
        }
        public static void UpdateAuthorToFile(Author pAuthor)
        {
            /* String fname = @"c:\temp\Author2.txt";
             Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
              string strAuthor = String.Empty;
              using (StreamWriter sw = new StreamWriter(fname))
              {
                  foreach (Author author in list.Values)
                  {

                      if (author.AuthorID != pAuthor.AuthorID)
                          strAuthor = $"{author.AuthorID},{author.AuthorName},{author.DateofBirth},{author.NoOfBooks},{author.RoyaltyCompany}";

                      else
                          strAuthor = $"{pAuthor.AuthorID},{pAuthor.AuthorName},{pAuthor.DateofBirth},{pAuthor.NoOfBooks},{pAuthor.RoyaltyCompany}";
                      sw.WriteLine(strAuthor);
                  }
              } */
            string fName = @"c:\temp\Author2.txt";
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            StringBuilder sbAuthors = new StringBuilder(list.Count + 100);
            foreach (Author author in list.Values)
            {
                if (author.AuthorID != pAuthor.AuthorID)
                {
                    sbAuthors.Append($"{author.AuthorID}, {author.AuthorName}, {author.DateofBirth}, {author.NoOfBooks}, {author.RoyaltyCompany} {Environment.NewLine}");
                }
                else
                {
                    sbAuthors.Append($"{pAuthor.AuthorID}, {pAuthor.AuthorName}, {pAuthor.DateofBirth}, {pAuthor.NoOfBooks}, {pAuthor.RoyaltyCompany} {Environment.NewLine}");
                }
            }
            File.WriteAllText(fName, sbAuthors.ToString());
        }

        public static void RemoveAuthor(int id)
        {
            String fName = @"c:\temp\Author2.txt";
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            /* string strAuthor = String.Empty;
             using (StreamWriter sw = new StreamWriter(fName))
             {
                 foreach (Author author in list.Values)
                 {
                     if (author.AuthorID != id)
                         strAuthor = $"{author.AuthorID},{author.AuthorName},{author.DateofBirth},{author.NoOfBooks},{author.RoyaltyCompany}";
                     sw.WriteLine(strAuthor);
                 }

             }*/
            StringBuilder sbAuthors = new StringBuilder(list.Count + 100);
            foreach (Author author in list.Values)
            {
                if (author.AuthorID != id)
                {
                    sbAuthors.Append($"{author.AuthorID}, {author.AuthorName}, {author.DateofBirth}, {author.NoOfBooks}, {author.RoyaltyCompany} {Environment.NewLine}");



                }
            }
            File.WriteAllText(fName, sbAuthors.ToString());

        }
    }
}
