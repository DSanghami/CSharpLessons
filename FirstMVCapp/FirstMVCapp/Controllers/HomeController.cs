using FirstMVCapp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Policy;

namespace FirstMVCapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger; // contr

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(); // is a method when executes check controller name which is home which contains index.cs
        }

        public IActionResult SayHello(String name) // HTML output 
        {
            if (String.IsNullOrEmpty(name))
                ViewData["v1"] = "Name is Empty";

            else
                ViewData["v1"] = name;
            return View();
        }
        public IActionResult Add(int x, int y)
        {
            int result = x + y;
            ViewData["Add result"] = result;
            return View();
        }
        public IActionResult Multiply(int x, int y)
        {
            int result = x * y;
            ViewData["Multiply result"] = result;
            return View();
        }
        public IActionResult Divide(int x, int y)
        {
            int result = x / y;
            ViewData["Divide result"] = result;
            return View();
        }
        public IActionResult DoLogin(String txtUser, String txtPad) // HTML output 
        {
            ViewData["userValue"] = $"{txtUser},{txtPad} ";
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // Working with object
        public IActionResult AddnewBook()
        {
            Book book = new Book();
            return View(book);
        }
        public IActionResult SaveNextBook(Book pBook)
        {
            String fname = @"c:\temp\book.txt";
            string strBook = $"{pBook.BookID}, {pBook.Title}, {pBook.AuthorName}, {pBook.Cost}";
            using (StreamWriter sw = new StreamWriter(fname, true))
            {
                sw.WriteLine(strBook);
            }
            return View(pBook);
        }
        private Book StringToBook(String[] data, Book book)
        {
            book.BookID = int.Parse(data[0]);
            book.Title = data[1];
            book.AuthorName = data[2];
            book.Cost = float.Parse(data[3]);
            return book;
        }
        public IActionResult ListAllBook()
        {
            String fName = @"c:\temp\book.txt";
            List<Book> list = new List<Book>();
            using (StreamReader sr = new StreamReader(fName))
            {
                string strBook = $"{sr.ReadLine()}";
                String[] data = strBook.Split(',');
                Book book = StringToBook(data, new Book());
                list.Add(book);
                while (!sr.EndOfStream)
                {
                    strBook = $"{sr.ReadLine()}";
                    data = strBook.Split(',');
                    book = StringToBook(data, new Book());
                    list.Add(book);
                }

            }
            return View(list);
        }
        // Creating Author file in local file
        public IActionResult AddnewAuthor()
        {
            Author author = new Author();
            return View(author);
        }

        // this view is created using details and shows in web application
        public IActionResult SaveNextAuthor(Author author)
        {
            String fname = @"c:\temp\author2.txt";
            string strAuthor = $"{author.AuthorID}, {author.AuthorName}, {author.DateofBirth}, {author.NoOfBooks}, {author.RoyaltyCompany}";
            using (StreamWriter sw = new StreamWriter(fname, true))
            {
                sw.WriteLine(strAuthor);
            }
            return View(author);
        }
        
        private Author StringToAuthor(String[] data, Author author)
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
        public IActionResult ListAllAuthor()
        {
            String fName = @"c:\temp\author2.txt";
            List<Author> list = new List<Author>();
            using (StreamReader sr = new StreamReader(fName))
            {
                string strAuthor = $"{sr.ReadLine()}";
                String[] data = strAuthor.Split(',');
                Author author = StringToAuthor(data, new Author());
                list.Add(author);
                while (!sr.EndOfStream)
                {
                    strAuthor = $"{sr.ReadLine()}";
                    data = strAuthor.Split(',');
                    author = StringToAuthor(data, new Author());
                    list.Add(author);
                }

            }
            return View(list);
        }
        public IActionResult DeleteAuthor(int id)
        {
            String fName = @"c:\temp\author2.txt";

            string[] lines = System.IO.File.ReadAllLines(fName);

           
            List<string> updatedLines = new List<string>();
            bool authorFound = false;

            foreach (string line in lines)
            {
                string[] data = line.Split(',');

                if (data.Length >= 5)
                {
                    int authorID = int.Parse(data[0]);

                    if (authorID == id)
                    {
                        authorFound = true;
                    }
                    else
                    {
                        // Author not found, add this line to the updated list
                        updatedLines.Add(line);
                    }
                }
            }

         
            if (!authorFound)
            {
                return NotFound(); 
            }

       
            System.IO.File.WriteAllLines(fName, updatedLines);
            return RedirectToAction("ListAllAuthor");
        }


        /*
        
        private List<Author> Find(int id)
        {
            String fName = @"C:\temp\author2.txt";
            List<Author> list = new List<Author>();
            using (StreamReader sr = new StreamReader(fName))
            {
                string strBook = $"{sr.ReadLine()}";
                String[] data = strBook.Split(',');
                Author author = StringToAuthor(data, new Author());
                if (author.AuthorID == id)
                {
                    list.Add(author);
                }



                while (!sr.EndOfStream)
                {
                    strBook = $"{sr.ReadLine()}";
                    data = strBook.Split(',');
                    author = StringToAuthor(data, new Author());
                    if (author.AuthorID == id)
                    {
                        list.Add(author);
                    }
                }
            }
            return list;
        }
        private int FindIndex(int id)
        {
            String fName = @"C:\temp\author2.txt";
            List<Author> list = new List<Author>();
            int count = 0;
            using (StreamReader sr = new StreamReader(fName))
            {
                string strBook = $"{sr.ReadLine()}";
                String[] data = strBook.Split(',');
                Author author = StringToAuthor(data, new Author());
                bool flag = true;
                if (flag)
                    count++;
                if (author.AuthorID == id)
                {
                    list.Add(author);
                    flag = false;
                }



                while (!sr.EndOfStream)
                {
                    strBook = $"{sr.ReadLine()}";
                    data = strBook.Split(',');
                    author = StringToAuthor(data, new Author());
                    if (flag)
                        count++;
                    if (author.AuthorID == id)
                    {
                        list.Add(author);
                        flag = false;
                    }
                }
            }
            return count;
        }*/

        public ActionResult GetAuthorById(int id)
        {
            // Retrieve the author by calling GetAuthorFromDataStore
            var author = GetAuthorFromDataStore(id);

            if (author == null)
            {
                return NotFound(); // Handle the case where the author is not found
            }

            return View(author); // Display the author in a view
        }

        private Author GetAuthorFromDataStore(int id)
        {
            // Define the path to your text file
            string filePath = @"c:\temp\author2.txt"; // Replace with the actual path

            // Read all lines from the text file
            string[] lines = System.IO.File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] data = line.Split(',');

                // Check if the current line has at least 4 parts (AuthorID, AuthorName, DateofBirth, other properties)
                if (data.Length >= 4)
                {
                    int authorID = int.Parse(data[0]);

                    // Check if the AuthorID matches the one we are looking for
                    if (authorID == id)
                    {
                        // Create an Author object and populate its properties
                        Author author = new Author
                        {
                            AuthorID = authorID,
                            AuthorName = data[1],
                            DateofBirth = DateTime.Parse(data[2]),
                            NoOfBooks = int.Parse(data[3]),
                            RoyaltyCompany = data[4]    
                            // Populate other properties as needed
                        };

                        return author; // Return the Author object
                    }
                }
            }

            return null; // Return null if the author with the specified ID is not found in the text file
        }

       /* public ActionResult Edit(int id)
        {
            // Retrieve the author to be edited (replace with your data access code)
            var author = GetAuthorById(id);

            if (author == null)
            {
                return NotFound(); // Handle the case where the author is not found
            }

            return View(author);
        }
       */
        private void UpdateAuthor(Author updatedAuthor)
        {
            // Define the path to your text file
            string filePath = @"c:\temp\author2.txt"; // Replace with the actual path

            // Read all lines from the text file
            string[] lines = System.IO.File.ReadAllLines(filePath);

            // Create a list to store updated author records
            List<string> updatedLines = new List<string>();

            foreach (string line in lines)
            {
                string[] data = line.Split(',');

                // Check if the current line has at least 4 parts (AuthorID, AuthorName, DateofBirth, other properties)
                if (data.Length >= 4)
                {
                    int authorID = int.Parse(data[0]);

                    // Check if the AuthorID matches the one we want to update
                    if (authorID == updatedAuthor.AuthorID)
                    {
                        // Update the AuthorName and other properties as needed
                        data[1] = updatedAuthor.AuthorName;
                        // Update other properties here

                        // Create a new line with updated data
                        string updatedLine = string.Join(",", data);
                        updatedLines.Add(updatedLine);
                    }
                    else
                    {
                        // If the AuthorID doesn't match, keep the original line
                        updatedLines.Add(line);
                    }
                }
            }

            // Write the updated lines back to the text file
            System.IO.File.WriteAllLines(filePath, updatedLines);
        }

        public IActionResult EditAuthor(Author author)
        {
            if (ModelState.IsValid)
            {
                // Update the author's information and save it (replace with your data access code)
                UpdateAuthor(author);

                return RedirectToAction("ListAllAuthor"); // Redirect to the author list or another appropriate action
            }

            // If the model state is not valid, redisplay the edit form with validation errors
            return View(author);
        }









    }
}