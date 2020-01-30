using System;

namespace Zebra.Savanna.Models.Errors
{
    /// <summary>
    /// Thrown when a Savanna API call does not succeed.
    /// </summary>
    public class Error : Exception, IResponse
    {
        /// <summary>
        /// Provides information about the result of the API call.
        /// </summary>
        protected object _developerMessage;

        /// <summary>
        /// The status code returned by the API.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Link to a web page providing more information about result of the API call.
        /// </summary>
        public Uri Info { get; set; }

        /// <summary>
        /// Provides details about the error encountered while making the API call.
        /// </summary>
        public string ErrorDetail { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error{T}"/> class.
        /// </summary>
        public Error() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error{T}"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public Error(string message) : base(message) { }

        /// <summary>
        /// Initializes a new instance of the System.Exception class with a specified error message and a reference to
        /// the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference
        /// if no inner exception is specified.</param>
        public Error(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// The formatted error message.
        /// </summary>
        public string MessageFormatted
        {
            get
            {
                string message = ErrorDetail;
                if (string.IsNullOrWhiteSpace(message))
                {
                    if (_developerMessage is string sdm && !string.IsNullOrWhiteSpace(sdm))
                    {
                        message = sdm;
                    }
                    else if (_developerMessage is DeveloperMessage dm && !string.IsNullOrWhiteSpace(dm.Fault?.FaultString))
                    {
                        message = dm.Fault.FaultString;
                    }
                }
                return string.IsNullOrWhiteSpace(message) || message == Message ? Message : $"{Message}: {message}";
            }
        }
    }

    /// <summary>
    /// Thrown when a Savanna API call does not succeed.
    /// </summary>
    /// <typeparam name="T">The type for the <see cref="DeveloperMessage"/>.</typeparam>
    public class Error<T> : Error
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Error{T}"/> class.
        /// </summary>
        public Error() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error{T}"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public Error(string message) : base(message) { }

        /// <summary>
        /// Initializes a new instance of the System.Exception class with a specified error message and a reference to
        /// the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference
        /// if no inner exception is specified.</param>
        public Error(string message, Exception innerException) : base(message, innerException) { }

        /// <summary>
        /// Provides information about the result of the API call.
        /// </summary>
        public T DeveloperMessage
        {
            get { return (T)_developerMessage; }
            set { _developerMessage = value; }
        }
    }
}