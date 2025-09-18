using System;
using System.IO;

public class WeatherLogger
{
    public static void WriteLog(string city, double temp, double humidity, string desc)
    {
        string logFilePath = "data/weather_log.txt";
        string logEntry = $"{city}: {temp}°C, {humidity}%, {desc}";

        // Ensure the directory exists
        Directory.CreateDirectory(Path.GetDirectoryName(logFilePath));

        // Append the log entry to the file
        using (StreamWriter sw = new StreamWriter(logFilePath, append: true))
        {
            sw.WriteLine(logEntry);
        }
    }
}