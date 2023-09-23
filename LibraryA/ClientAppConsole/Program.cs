using LibraryA;



Book book = new Book();
book.Title = "To kill a Mocking bird";
book.Author = "Harper Lee";
book.Genre = "Social";
book.BookPrice  = 100;
book.DateOfPublish = new DateTime(1995, 06, 01);
book.BookMarkPage(124);
Console.WriteLine(book.GetCurrentPage());
Calculator cal = new Calculator();
int addresult = cal.Add(10, 40);



Console.WriteLine(addresult);



int multiplyResult = cal.Multiply(100, 20);



Console.WriteLine(multiplyResult);



int divideResult = cal.Divide(100, 50);



Console.WriteLine(divideResult);

