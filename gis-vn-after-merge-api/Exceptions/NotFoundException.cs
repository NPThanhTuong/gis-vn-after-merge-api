namespace gis_vn_after_merge_api.Exceptions;

public class NotFoundException(string message) : AppException(message)
{
	public override int StatusCode => StatusCodes.Status404NotFound;
}