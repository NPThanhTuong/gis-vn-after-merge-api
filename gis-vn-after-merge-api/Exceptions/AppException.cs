namespace gis_vn_after_merge_api.Exceptions;

public abstract class AppException(string message) : Exception(message)
{
	public abstract int StatusCode { get; }
}