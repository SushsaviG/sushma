# HTML Helper in ASP.NET MVC 

- HTML Helpers are methods that return a string.
- Helper class can create HTML controls programmatically. HTML Helpers are used in View to render HTML content.
- It is not mandatory to use HTML Helper classes for building an ASP.NET MVC application.
- HTML Helpers are more lightweight as compared to ASP.NET Web Form controls as they do not use ViewState.
- MVC has built-in Helpers methods


### HTML Helpers are categorized into three types</br>
1) Inline HTML helpers
2) Built-in HTML helpers<br>
   a) Standard HTML Helpers<br>
b) Strongly Typed HTML helpers<br>
c) Templated HTML helpers<br>
3) Custom HTML helpers

### Inline HTML Helper in MVC 
- Inline HTML Helper is used to create a reusable Helper method .
- Inline helpers can be reused only on the same view.
- We can not use Inline helper to the different view Pages.
- We can create our own Inline helper method based on our requirements.

### Syntax of Inline Html Helper
 
@helper HelperName(Parameters list..)<br>
{
// code.....
}

```C#
public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
```

```C#
<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <div>
        @helper MyListHelper(string[] str)
        {
            <ul>
                @foreach (var item in str)
                {
                    <li> @item</li>
                }
            </ul>
        }
    </div>
    <div>
        <label>Name List</label>
        @MyListHelper(new string[] { "swathi", "Pavithra", "shrithi" })
    </div>
    <div>
        <label>Programming Language</label>
        @MyListHelper(new string[] { ".net", "MVC", "java" })
    </div>
</body>
</html>

```
## 1. Standard HTML Helper 

The HTML helpers that are mainly used to render HTML elements like text boxes, checkboxes, Radio Buttons, and Dropdown lists, etc. <br>
are called Standard HTML helpers. 

List of Standard HTML Helpers 

    @Html.ActionLink() - Used to create link on html page
    @Html.TextBox() - Used to create text box
    @Html.CheckBox() - Used to create check box
    @Html.RadioButton() - Used to create Radio Button
    @Html.BeginFrom() - Used to start a form
    @Html.EndFrom() - Used to end a form
    @Html.DropDownList() - Used to create drop down list
    @Html.Hidden() - Used to create hidden fields
    @Html.label() - Used for creating HTML label is on the browser
    @Html.TextArea() - The TextArea Method renders textarea element on browser
    @Html.Password() - This method is responsible for creating password input field on browser
    @Html.ListBox() - The ListBox helper method creates html ListBox with scrollbar on browser

 
# Web API
The ASP.NET Web API is an extensible framework for building HTTP based services that can be accessed in different applications on different platforms 
such as web, windows, mobile etc. It works more or less the same way as ASP.NET MVC web application except that it sends data as a response instead of 
html view.

### ASP.NET Web API Characteristics
- ASP.NET Web API is built on top of ASP.NET and supports ASP.NET request/response.
- ASP.NET Web API maps HTTP verbs to method names.
- ASP.NET Web API supports different formats of response data. Built-in support for JSON, XML, BSON format.
- It supports only HTTP protocal
- ASP.NET Web API framework includes new HttpClient to communicate with Web API server.</br> 
- HttpClient can be used in ASP.MVC server side, Windows Form application, Console application or other apps.


 
