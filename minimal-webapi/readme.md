# minimal web api

- [Exploring a minimal WebAPI with ASP.NET Core](http://www.hanselman.com/blog/ExploringAMinimalWebAPIWithASPNETCore.aspx)
- `yo aspnet`
- `curl http://localhost:5000/api/values`
- add in project json   "Microsoft.AspNetCore.Mvc.Formatters.Xml" : "1.0.0",



## responding xml 
- add  .AddXmlSerializerFormatters();
```csharp
public void ConfigureServices(IServiceCollection services)
{
    // Add framework services.
    services.AddMvc()
        .AddXmlSerializerFormatters();
}
```
- in postman, get http://localhost:5000/api/values with Accept: application/xml header
