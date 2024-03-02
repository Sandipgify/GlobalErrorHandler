# GlobalErrorHandler
Handle Error Globally with dotnet 7

# Global Error Handler Middleware Example

This is an example .NET  application showcasing the usage of a custom Global Error Handler Middleware. The middleware is responsible for catching unhandled exceptions in the application and responding with an appropriate error message.

## GlobalErrorHandlerMiddleware

The `GlobalErrorHandlerMiddleware` is a class that implements the `IMiddleware` interface. It intercepts requests and catches any unhandled exceptions that occur during the processing of the request. In case of an exception, it logs the error and sends a JSON response with a standard error message and a 500 Internal Server Error status code.

### Usage

To use the `GlobalErrorHandlerMiddleware`, it needs to be registered in the application's middleware pipeline.
