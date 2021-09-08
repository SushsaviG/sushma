## Routing in ASP.NET
 - Routing is a process through which the application matches any incoming URL path and execute the corresponding action methods of ASP.net MVC. 
 - Routing is a pattern matching system that is responsible for mapping incoming browser requests to specified MVC controller actions.
 - routing engine uses the route table for matching the incoming request.
 - Route config file is used for adding route rules.
 - We invoke a RegisterRoutes methods in the App_Start() method.
 
### Types of Routing
1) Default  routing
2) Custom routing <br/>
    Types of custom <br/>
    a) Conventional Routing <br/>
    b) Attribute Routing
### 1) Default  routing  
      When you create a new ASP.NET MVC application, the application is already configured to use ASP.NET Routing.
```C#
public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default",                                              // Route name
                "{controller}/{action}/{id}",                           // URL with parameters
                new { controller = "Home", action = "Index", id = "" }  // Parameter defaults
            );
        }
 
    }
```
     
### a) Conventional Routing    
```C#
public class OrdersController:Controller
    { 
        public ActionResult GetOrderByID(long orderId)
        {
            return View();
        }
    }
 ```
 ```C#
 @inherits System.Web.Mvc.WebViewPage
@{
    ViewBag.Title = "GetOrderByID";
}

<h2>GetOrderByID Called Successfully</h2>
```
 ```C#
 public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name:"Orders",
                url:"Orders/{orderID}", //url pattern
                new {Controller="Orders",Action= "GetOrderByID" } //url segment pattern
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}"
                
            );
        }
 ```

## VIEWDATA AND VIEWBAG
 - viewdata and viewbag are used to pass data from a controller to view .
 - view data is a dictionary of object that are stored and retrieved using strings as keys.
 - viewbag uses dynamic feature. it allows an object to have properties dynamically added to it.
 ```C#
 ViewData["key"]="data";
 ViewBag.property="data";
 ```
 - Both viewdata and viewbag does not provide compile time error checking .<br/>
 for example if you miss spell keys or property names you would not get any compile time error you get to know about the error only at runtime.
 - Internally viewbag properties are stored as name/value pairs in the ViewData dictionary.
   
```C#
namespace MvcApplication.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Viewbag()
        {
            ViewBag.Countries = new List<string>()
            {
                "India",
                "Us",
                "Australia",
                "Canada"

            };
            return View();
        }
        public ViewResult viewdata()
        {
           ViewData["countries"] = new List<string>()
            {
                "India",
                "Us",
                "Australia",
                "Canada"

            };
            return View();
        }
    }
}
```
```C#
@inherits System.Web.Mvc.WebViewPage
@{
    ViewBag.Title = "Countries List";
}

<h2>Countries List</h2>
<ul>
    @foreach (string strcountry in ViewBag.Countries)
    {
        <li>
            @strcountry
        </li>
    }
</ul>
```
```C#
@inherits System.Web.Mvc.WebViewPage
@{
   
}

<h2>Countries List</h2>
<ul>
    @foreach (string country in (List<string>)ViewData["countries"])
    {
        <li>
            @country
        </li>
    }
</ul>
```
## Action Result
 - It is the base class for all types that an action method Returns.
 - actionresult in MVC defines Framework level operation
 -  It encapsulate the result of an action Method .
 -  Actionresult can return a file to response, view to response, JSON to response <br/>
  
  different types of action results that an action Method can return in asp.net MVC are <br/>
  |ActionResult        |  Methods    |
|--------|------|
|ViewResult        | View()     |
|PartialViewResult       | PartialView()     |
|FileResult        | File()     |
|JsonResult        | Json()     |
|ContentResult       |  Content()    |
|RedirectResult      | Redirect()     | 
|JavaScriptResult      | JavaScript     |
|        |      |

If action method returns one type of result then it is good to use specific derived type based on the return  value. <br/>
 but if you are action method returns different kind of results based on different condition then you should use ActionResult.
 
 ```C#
 Public ViewResult view()
 {
    return view();
 }
 ```
 ```C#
  Public ActionResult Index()
 {  if(Condition)
    return view();
    else
    return Json("data");
 }
 ```
 
 ## Route Constraints
 - Route constraints is used to restrict the browser request that much a particular route.
 - Route constraint is way to put some validation around define the route
 ```C#
 routes.MapRoute(
 "Default", // Route name
 "{controller}/{action}/{id}", // Route Pattern
 new { controller = "Home", action = "Index", id = UrlParameter.Optional }, // Default values for parameters
 new { controller = "^H.*", action = "^Index$|^Contact$" } //Restriction for controller and action
);
 ```
 

 

    
    
    
    
    

 
 
 
 
  
  




 
 
