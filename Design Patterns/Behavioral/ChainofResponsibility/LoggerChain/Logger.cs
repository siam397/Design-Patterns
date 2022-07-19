namespace Design_Patterns.Behavioral.ChainofResponsibility.LoggerChain
{
    public abstract class Logger
    {
        public static int ERROR = 3;
        public static int WARNING = 2;
        public static int INFO = 1;
        public Logger? _nextLog;
        protected int _level;

        public static Logger GetLoggerConfiguration()
        {
            Logger errorLogger = new ErrorLogger(ERROR);
            Logger warnLogger = new WarnLogger(WARNING);
            Logger infoLogger = new InfoLogger(INFO);

            errorLogger.setNextLogger(warnLogger);
            warnLogger.setNextLogger(infoLogger);
            return errorLogger;
        }

        public void setNextLogger(Logger nextLog)
        {
            _nextLog = nextLog;
        }

        public void logMessage(int level, string message)
        {
            if (_level <= level)
            {
                Write(message);
            }
            if (_nextLog != null)
            {
                _nextLog.logMessage(level, message);
            }
        }

        public abstract void Write(string message);
    }
}
