using Microsoft.AspNetCore.Mvc;
using Packages.CustomErrors.Helpers;
using System;
using System.Net;

namespace Packages.CustomErrors.Exceptions.Base
{
    public class BaseException : Exception
    {
        public ErrorCodeEnum ErrorCode { get; set; }
        public LogLevelEnum LogLevel { get; set; }
        public string ExposedTitle { get; set; }
        public string ExposedDetails { get; set; }
        public HttpStatusCode StatusCode { get; set; }

        protected BaseException(HttpStatusCode statusCode, string title, string details, ErrorCodeEnum errorCode)
            : base(details)
        {
            StatusCode = statusCode;
            ExposedTitle = title;
            ExposedDetails = details;
            ErrorCode = errorCode;
        }

        protected BaseException(HttpStatusCode statusCode, string title, string details, ErrorCodeEnum errorCode, string message)
            : base(message)
        {
            StatusCode = statusCode;
            ExposedTitle = title;
            ExposedDetails = details;
            ErrorCode = errorCode;
        }

        protected BaseException(HttpStatusCode statusCode, string title, string details, ErrorCodeEnum errorCode, LogLevelEnum logLevel, string message)
            : base(message)
        {
            StatusCode = statusCode;
            ExposedTitle = title;
            ExposedDetails = details;
            ErrorCode = errorCode;
            LogLevel = logLevel;
        }

        protected BaseException(string title, string details, ErrorCodeEnum errorCode, ProblemDetails problemDetails)
            : base(details)
        {
            StatusCode = (HttpStatusCode)problemDetails.Status;
            ExposedTitle = $"{title} --- [Inner error status : {problemDetails?.Status?.ToString()} - title {problemDetails?.Title}] ---";
            ExposedDetails = $"{details} - [Inner errorCode: {problemDetails?.Type} - details : {problemDetails?.Detail} - Instance: {problemDetails?.Instance}]";
            ErrorCode = errorCode;
        }

        protected BaseException(HttpStatusCode statusCode, string title, string details, ErrorCodeEnum errorCode, Exception inner)
            : base(details, inner)
        {
            StatusCode = statusCode;
            ExposedTitle = title;
            ExposedDetails = details;
            ErrorCode = errorCode;
        }
    }
}
