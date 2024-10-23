using ChainOfResponsibilty;

class Program
{
    static void Main()
    {
        
        var initialReview = new InitialReviewHandler();
        var departmentHead = new DepartmentHeadHandler();
        var finance = new FinanceHandler();

        initialReview.SetNext(departmentHead).SetNext(finance);

       
        var document = new Document
        {
            Complete = true,
            Necessary = true,
            FinanciallyCompliant = true
        };

      
        var result = initialReview.Handle(document);
        Console.WriteLine(result);  
    }
}