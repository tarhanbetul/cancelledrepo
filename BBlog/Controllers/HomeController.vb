Using Models;
Public Class HomeController
    Inherits System.Web.Mvc.Controller

    BBlogContext context = New BBlogContext();
    Function Index() As ActionResult
            Return View()
        End Function

    Function PartialView() As ActionResult
        Return context.Makales.ToList()
    End Function
    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class
