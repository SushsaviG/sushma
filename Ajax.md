# AJAX

Ajax is a set of web development techniques that uses various web technologies on the client-side to create asynchronous web applications. <br/>
With Ajax, web applications can send and retrieve data from a server asynchronously without interfering with the display and behaviour of the existing page. <br/>

### What is AJAX
- asynchronous JavaScript and XML 
- sends and receives data from client and server asynchronously 
- different than regular http request
- uses XMLHTTPRequest object 
- carries data in XML and json format
- does not refresh the browser to receive data from server


![ajax2](https://user-images.githubusercontent.com/86051136/131979158-56307141-0bef-4845-a88f-20eb997a4c53.png)

### AJAX Examples <br/>
- Facebook like and comments 
- youtube like and comments

### Advantages
- Reduces the traffic travels between the client and the server. 
- Better interactivity and responsiveness.

### Basic Controls of ASP.NET AJAX

### 1) ScriptManager

ScriptManager is a server-side control.The ScriptManager control is central to Ajax functionality in ASP.NET. <br/>
The ScriptManager manages all ASP.NET AJAX resources on a web page. It renders the AJAX library to the browser and supports partial page rendering. <br/>
 It also manages partial page uploads and provide access to web service method. Without script manager we can't use AJAX controls on the web page.
 
### 2) UpdatePanel

The UpdatePanel control specifies a part of a Web page which can be updated or refreshed partially based on the update condition. <br/>
 Refreshing a specific part of a Web page is referred as partial-page update. <br/>
 You can also add one or more UpdatePanel control in the Web page. <br/>
The UpdatePanel control uses the AJAX library to support the partial-page rendering. <br/>
 UpdatePanel controls  are used with the ScriptManager control to enable partial-page rendering. <br/>
 Partial-page rendering reduces the need for synchronous postbacks and complete page updates when only part of the page has to be updated.
 
 ``` C#
 <html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
             <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick"></asp:Timer>

              <asp:Label ID="Label1" runat="server" ></asp:Label>

            </ContentTemplate>

            </asp:UpdatePanel>
      
        </div>
    </form>
</body>
</html>

``` 

``` C#
namespace AjaxApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToLongTimeString();

        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
