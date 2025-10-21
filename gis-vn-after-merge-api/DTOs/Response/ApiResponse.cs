using System.Text.Json.Serialization;

namespace gis_vn_after_merge_api.DTOs.Response;

public class ApiResponse<T>
{
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public T? Data { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public string? Error { get; set; }

	public int Code { get; set; }

	public static ApiResponse<T> Success(T data, int code = StatusCodes.Status200OK)
	{
		return new ApiResponse<T> { Data = data, Code = code };
	}

	public static ApiResponse<T> Fail(string error, int code)
	{
		return new ApiResponse<T> { Error = error, Code = code };
	}
}