﻿using System;
using System.Diagnostics;

namespace Noodle.Engine
{
    /// <summary>
    /// Wraps logging oprations performed by N2.
    /// </summary>
    public struct Logger<T>
    {
        private LogWriterBase Writer
        {
            get { return Logger.GetWriter<T>(); }
        }

        [Conditional("TRACE")]
        public void Error(string message)
        {
            Writer.Error(message);
        }

        [Conditional("TRACE")]
        public void Error(Exception ex)
        {
            Writer.Error(ex.ToString());
        }

        [Conditional("TRACE")]
        public void Error(string message, Exception ex)
        {
            Writer.Error(message + Environment.NewLine + ex);
        }

        [Conditional("TRACE")]
        public void ErrorFormat(string format, params object[] args)
        {
            Writer.Error(format, args);
        }

        [Conditional("TRACE")]
        public void Warn(string message)
        {
            Writer.Warning(message);
        }

        [Conditional("TRACE")]
        public void Warn(Exception ex)
        {
            Writer.Warning(ex.ToString());
        }

        [Conditional("TRACE")]
        public void Warn(string message, Exception ex)
        {
            Writer.Warning(message + Environment.NewLine + ex);
        }

        [Conditional("TRACE")]
        public void WarnFormat(string format, params object[] args)
        {
            Writer.Warning(format, args);
        }

        [Conditional("TRACE")]
        public void Info(string message)
        {
            Writer.Information(message);
        }

        [Conditional("TRACE")]
        public void Info(Exception ex)
        {
            Writer.Information(ex.ToString());
        }

        [Conditional("TRACE")]
        public void Info(string message, Exception ex)
        {
            Writer.Information(message);
        }

        [Conditional("TRACE")]
        public void InfoFormat(string format, params object[] args)
        {
            Writer.Information(format, args);
        }

        [Conditional("DEBUG")]
        public void Debug(string message)
        {
            Writer.Debug(message);
        }

        [Conditional("DEBUG")]
        public void Debug(Exception ex)
        {
            Writer.Debug(ex.ToString());
        }

        [Conditional("DEBUG")]
        public void Debug(string message, Exception ex)
        {
            Writer.Debug(message);
        }

        [Conditional("DEBUG")]
        public void DebugFormat(string format, params object[] args)
        {
            Writer.Debug(format, args);
        }
    }

    /// <summary>
    /// Wraps logging oprations performed.
    /// </summary>
    public static class Logger
    {
        public static void Error(string message)
        {
            Writer.Error(message);
        }

        public static void Error(Exception ex)
        {
            Writer.Error(ex.ToString());
        }

        public static void Error(string message, Exception ex)
        {
            Writer.Error(message + Environment.NewLine + ex);
        }

        public static void ErrorFormat(string format, params object[] args)
        {
            Writer.Error(format, args);
        }

        public static void Warn(string message)
        {
            Writer.Warning(message);
        }

        public static void Warn(Exception ex)
        {
            Writer.Warning(ex.ToString());
        }

        public static void Warn(string message, Exception ex)
        {
            Writer.Warning(message + Environment.NewLine + ex);
        }

        public static void WarnFormat(string format, params object[] args)
        {
            Writer.Warning(format, args);
        }

        public static void Info(string message)
        {
            Writer.Information(message);
        }

        public static void Info(Exception ex)
        {
            Writer.Information(ex.ToString());
        }

        public static void Info(string message, Exception ex)
        {
            Writer.Information(message + Environment.NewLine + ex);
        }

        public static void InfoFormat(string format, params object[] args)
        {
            Writer.Information(format, args);
        }

        [Conditional("DEBUG")]
        public static void Debug(string message)
        {
            Writer.Debug(message);
        }

        [Conditional("DEBUG")]
        public static void Debug(Exception ex)
        {
            Writer.Debug(ex.ToString());
        }

        [Conditional("DEBUG")]
        public static void Debug(string message, Exception ex)
        {
            Writer.Debug(message);
        }

        [Conditional("DEBUG")]
        public static void DebugFormat(string format, params object[] args)
        {
            Writer.Debug(format, args);
        }

        public static LogWriterBase GetWriter<T>()
        {
            if (WriterFactory != null)
                return WriterFactory(typeof(T));
            return new TraceLogWriter(DateTime.UtcNow.ToString("yyy-MM-dd HH:mm:ss.fff ") + typeof(T).Name + ": ");
        }

        public static LogWriterBase Writer
        {
            get
            {
                if (WriterFactory != null)
                    return WriterFactory(null);
                return new TraceLogWriter(DateTime.UtcNow.ToString("yyy-MM-dd HH:mm:ss.fff: "));
            }
        }

        public static Func<Type, LogWriterBase> WriterFactory { get; set; }
    }

    public class LogWriterBase
    {
        public virtual void Error(string message)
        {
        }

        public virtual void Error(string format, object[] args)
        {
        }

        public virtual void Warning(string message)
        {
        }

        public virtual void Warning(string format, object[] args)
        {
        }

        public virtual void Information(string message)
        {
        }

        public virtual void Information(string format, object[] args)
        {
        }

        public virtual void Debug(string message)
        {
        }

        public virtual void Debug(string format, object[] args)
        {
        }
    }

    public class TraceLogWriter : LogWriterBase
    {
        public TraceLogWriter(string prefix)
        {
            Prefix = prefix;
        }

        public string Prefix { get; set; }

        public override void Error(string message)
        {
            Trace.TraceError(Prefix + message);
        }

        public override void Error(string format, object[] args)
        {
            Trace.TraceError(Prefix + format, args);
        }

        public override void Warning(string message)
        {
            Trace.TraceWarning(Prefix + message);
        }
        public override void Warning(string format, object[] args)
        {
            Trace.TraceWarning(Prefix + format, args);
        }

        public override void Information(string message)
        {
            Trace.TraceInformation(Prefix + message);
        }
        public override void Information(string format, object[] args)
        {
            Trace.TraceInformation(Prefix + format, args);
        }

        public override void Debug(string message)
        {
            System.Diagnostics.Debug.WriteLine(Prefix + message);
        }

        public override void Debug(string format, object[] args)
        {
            System.Diagnostics.Debug.WriteLine(Prefix + string.Format(format, args));
        }
    }
}
