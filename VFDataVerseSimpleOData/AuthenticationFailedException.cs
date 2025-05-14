using System;

namespace VFDataVerseSimpleOData.AuthenticationUtility
{
    public sealed class AuthenticationFailedException : ApplicationException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationFailedException"/> class.
        /// </summary>
        public AuthenticationFailedException()
            : base("Authentication failed!")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationFailedException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public AuthenticationFailedException(String message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationFailedException"/> class with a specified error message 
        /// and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">
        /// The exception that is the cause of the current exception.If the innerException parameter is not a null reference 
        /// (Nothing in Visual Basic), the current exception is raised in a catch block that handles the inner exception.
        /// </param>
        public AuthenticationFailedException(String message, Exception innerException)
            : base(message, innerException)
        {
        }

#pragma warning disable CS0628 // New protected member declared in sealed class
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationFailedException"/> class with serialized data.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data.</param>
        /// <param name="context">The contextual information about the source or destination.</param>
        protected AuthenticationFailedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
#pragma warning restore CS0628 // New protected member declared in sealed class
            : base(info, context)
        {
        }
    }
}
