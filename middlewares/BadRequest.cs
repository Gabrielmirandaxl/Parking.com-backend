using System.Net;
using System.Text.Json;

namespace estudos_crud.middlewares
{
  public class BadRequest
  {
    private readonly RequestDelegate next;

    public BadRequest(RequestDelegate next)
    {
      this.next = next;
    }



    public async Task InvokeAsync(HttpContext httpContext)
    {
      try
      {
        await this.next(httpContext);
      }
      catch (Exception ex)
      {
        await ErrorBadRequest(httpContext, ex);
      }
    }



    private static Task ErrorBadRequest(HttpContext httpContext, Exception ex)
    {
      var response = JsonSerializer.Serialize(new { ex.Message });

      httpContext.Response.ContentType = "application/json";
      httpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;

      return httpContext.Response.WriteAsync(response);
    }


  }
}