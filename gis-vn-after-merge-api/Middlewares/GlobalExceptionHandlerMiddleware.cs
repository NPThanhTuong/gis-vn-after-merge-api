using gis_vn_after_merge_api.DTOs.Response;
using gis_vn_after_merge_api.Exceptions;

namespace gis_vn_after_merge_api.Middlewares;

public class GlobalExceptionHandlerMiddleware(RequestDelegate next, ILogger<GlobalExceptionHandlerMiddleware> logger)
{
	public async Task InvokeAsync(HttpContext context)
	{
		try
		{
			await next(context);
		}
		catch (AppException ex)
		{
			logger.LogWarning(ex, "App exception handled");
			await HandleExceptionAsync(context, ex.StatusCode, ex.Message);
		}
		catch (Exception ex)
		{
			logger.LogError(ex, "Unhandled exception");
			await HandleExceptionAsync(context, StatusCodes.Status500InternalServerError, "Internal Server Error");
		}
	}

	private static async Task HandleExceptionAsync(HttpContext context, int statusCode, string message)
	{
		context.Response.ContentType = "application/json";
		context.Response.StatusCode = statusCode;

		var result = ApiResponse<object>.Fail(message, statusCode);

		await context.Response.WriteAsJsonAsync(result);
	}
}