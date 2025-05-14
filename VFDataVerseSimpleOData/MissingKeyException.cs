using System;

namespace VFDataVerseSimpleOData.ODataDataSources
{
    /// <summary>
    /// The exception that is thrown when an entity could not be found.
    /// </summary>
    public sealed class MissingKeyException : ApplicationException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MissingKeyException"/> class.
        /// </summary>
        public MissingKeyException()
            : base("Entity key not found!")
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MissingKeyException"/> class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public MissingKeyException(String message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MissingKeyException"/> class with a specified error message 
        /// and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">
        /// The exception that is the cause of the current exception.If the innerException parameter is not a null reference 
        /// (Nothing in Visual Basic), the current exception is raised in a catch block that handles the inner exception.
        /// </param>
        public MissingKeyException(String message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MissingKeyException"/> class with serialized data.
        /// </summary>
        /// <param name="info">The object that holds the serialized object data.</param>
        /// <param name="context">The contextual information about the source or destination.</param>
        protected MissingKeyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }
    }
}
