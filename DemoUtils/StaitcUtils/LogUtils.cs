using System;
using System.Collections.Generic;
using System.Text;

namespace DemoUtils.StaitcUtils
{
    public static class LogUtils
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public static void LogInformation<T>(IDictionary<string, T> messages)
        {
            var message = ProcessMessageMap<T>(messages);

            Logger.Info(message);
        }

        public static void LogInformation(string message)
        {
            Logger.Info(message);
        }

        public static void LogError(Exception ex)
        {
            Logger.Error(ex);
        }

        private static string ProcessMessageMap<T>(
            IDictionary<string, T> messages)
        {
            var stringBuilder = new StringBuilder();

            foreach (var keyValuePair in messages)
            {
                if (keyValuePair.Value == null)
                {
                    continue;
                }

                stringBuilder.Append(Environment.NewLine);
                stringBuilder.Append($"{keyValuePair.Key} : {keyValuePair.Value}");
            }

            stringBuilder.Append(Environment.NewLine);

            return stringBuilder.ToString();
        }
    }

   
}