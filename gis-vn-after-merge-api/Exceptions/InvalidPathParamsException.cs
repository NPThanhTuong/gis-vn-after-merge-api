namespace gis_vn_after_merge_api.Exceptions;

public class InvalidPathParamsException(string message) : AppException(message)
{
	public override int StatusCode => StatusCodes.Status400BadRequest;
}