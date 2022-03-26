namespace CustomerSupport.Extensions
{
    public static class LoggerExtensions
    {
        private static readonly Action<ILogger, Exception> _errorHappened;

        static LoggerExtensions()
        {
            _errorHappened = LoggerMessage.Define(
                LogLevel.Error,
                new EventId(1, nameof(ErrorHappended)),
                "Error happened");
        }
        public static void ErrorHappended(this ILogger logger, Exception ex)
        {
            _errorHappened(logger, ex);
        }
    }
}
