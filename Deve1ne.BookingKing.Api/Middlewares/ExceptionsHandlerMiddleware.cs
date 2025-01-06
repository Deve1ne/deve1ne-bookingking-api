namespace Deve1ne.BookingKing.Api.Middlewares;

public class ExceptionsHandlerMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionsHandlerMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            context.Response.StatusCode = 500;
            await context.Response.WriteAsync("An error occurred. Message : " + ex.Message + "\n"
                                              + "Stacktrace : "+ ex.StackTrace );
        }
    }
}