using Packages.CustomErrors.Exceptions.Base;
using Packages.CustomErrors.Helpers;
using System;
using System.Net;

namespace Packages.CustomErrors.Exceptions
{
    public class EntityNotFoundException : BaseException
    {
        private const HttpStatusCode STATUS = HttpStatusCode.NotFound;
        private const string TITLE = "Entity Not Found";
        private const string DETAILS = "The entity does not exist in the database. Try again with correct parameter(s).";
        private const ErrorCodeEnum ERROR_CODE = ErrorCodeEnum.EntityNotFound;

        public EntityNotFoundException()
            : base(STATUS, TITLE, DETAILS, ERROR_CODE) { }
        public EntityNotFoundException(string message)
            : base(STATUS, TITLE, DETAILS, ERROR_CODE, message) { }
        public EntityNotFoundException(Exception inner)
            : base(STATUS, TITLE, DETAILS, ERROR_CODE, inner) { }
    }
}
