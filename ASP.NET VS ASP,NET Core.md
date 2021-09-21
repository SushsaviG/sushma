# .NET Framework v/s .NET Core


|           .NET FRAMEWORK                                    |                    .NET CORE                                         |
|-------------------------------------------------------------|----------------------------------------------------------------------|
| 1) Old Framework                                               |1) new Framework                                                        |
|2) .Net Framework is a full-fledged development framework.      |2) .Net Core is a platform on top of which there are                    |
|The framework provides all the basic requirements for        |  frameworks such as ASP .Net Core and Universal                      |
|the development of applications – UI, DB connectivity,       |  Windows Platform that leverage and extend the                       |
| Services, APIs, etc                                         |  features of .Net Core                                               |
| 3) .Net Framework is used to build both                       | 3)  .Net Core focuses more on Web,                                     |
|   Desktop as well as Web applications.                      |    Windows Mobile, and Windows Store applications.                   |
| 4) .Net Framework is too heavy for Command Line Interface.    | 4)    Net Core supports a very lightweight CLI for all platforms.      |                 
|                                                             |                                                                      | 
| 5) not open source                                             |5) open source                                                          |
| 6) Supports only Windows                                       |6) It is a cross platform,It supports windows,mac and Linux             |
| 7) 4.8 is the last version of .net Framework                   |7) 3.0 is the last version of .net core                                 |
| 8) A high-performance and scalable system without UI           |8) .NET Core is much faster.                                            |


# ASP.NET MVC v/s ASP.NET Core

| ASP.NET MVC                                                             |                          ASP.NET Core MVC                                                           |
|--------|------|
| Platform support: Windows only            | Windows,Linux,Mac OS        |
|Architecture:Based on .net framework only | Based on .net framework and core framework   |
|Not Open Source|Open Source|
|It is not cross-platform|It is cross-platform can use it on Windows, Mac or Linux|
| To build up our project  we use DI containers like Unity, AutoFac, StructureMap|In ASP.NET Core dependency injection is inbuilt, no setup is required for DI|
|  But setup is required for DI|   |

# CORS 
- Cross Origin Resource Sharing (CORS) allows a server to relax the same-origin policy.
- Using CORS, a server can explicitly allow some cross-origin requests while rejecting others.
- CORS is safer and more flexible than earlier techniques. 
- Is not a security feature, CORS relaxes security. An API is not safer by allowing CORS.
- Allows a server to explicitly allow some cross-origin requests while rejecting others.

### ways to enable Cros

- Middleware using default policy
- Endpoint Routing
- EnableCors attribute







