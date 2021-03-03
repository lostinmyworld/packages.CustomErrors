namespace Packages.CustomErrors.Helpers
{
    public enum ErrorCodeEnum
    {
        Unexpected,
        RequestParameterNull,
        InvalidAuthenticationCredentials,
        UnauthorizedUser,
        MissingConfiguration,
        EmptyResponse,
        InsertAlreadyExists,
        EntityNotFound
    }

    public enum LogLevelEnum
    {
        Error,
        SafeError,
        InnerWarning
    }
}
