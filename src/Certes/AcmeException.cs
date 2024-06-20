﻿using System;

namespace Certes;

/// <summary>
///     The exception that is thrown when an error occurs while processing ACME operations.
/// </summary>
/// <seealso cref="Exception" />
[Serializable]
public class AcmeException : Exception
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="AcmeException" /> class.
    /// </summary>
    public AcmeException()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="AcmeException" /> class.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    public AcmeException(string message)
        : base(message)
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="AcmeException" /> class.
    /// </summary>
    /// <param name="message">
    ///     The error message that explains the reason for the exception.
    /// </param>
    /// <param name="innerException">
    ///     The exception that is the cause of the current exception,
    ///     or a null reference (Nothing in Visual Basic) if no inner
    ///     exception is specified.
    /// </param>
    public AcmeException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
