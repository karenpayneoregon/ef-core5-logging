﻿using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace ConfigurationHelper
{
    /// <summary>
    /// Responsible for reading appsettings.json properties
    /// </summary>
    public class Helper
    {
        private static string _fileName = "appsettings.json";
        
        /// <summary>
        /// Connection string for application database stored in appsettings.json
        /// Another option would be to have the full connection string in the json file.
        /// </summary>
        /// <returns></returns>
        public static string ConnectionString()
        {

            InitConfiguration();
            
            var applicationSettings = InitOptions<DatabaseSettings>("database");

            var connectionString =
                $"Data Source={applicationSettings.DatabaseServer};" +
                $"Initial Catalog={applicationSettings.Catalog};" +
                "Integrated Security=True";

            return connectionString;
        }
        /// <summary>
        /// Log options
        /// </summary>
        /// <returns></returns>
        public static LoggingDestination LoggingDistination()
        {
            InitConfiguration();
            return InitOptions<DatabaseSettings>("database").LoggingDistination;
        }
        /// <summary>
        /// Log file name
        /// </summary>
        /// <returns></returns>
        public static string LogFileName()
        {
            InitConfiguration();
            return InitOptions<DatabaseSettings>("database").LogFileName;
        }
        /// <summary>
        /// Initialize ConfigurationBuilder
        /// </summary>
        /// <returns>IConfigurationRoot</returns>
        private static IConfigurationRoot InitConfiguration()
        {

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(_fileName);

            return builder.Build();

        }
        /// <summary>
        /// Generic method to read a section from the json configuration file.
        /// </summary>
        /// <typeparam name="T">Class type</typeparam>
        /// <param name="section">Section to read</param>
        /// <returns>Instance of T</returns>
        public static T InitOptions<T>(string section) where T : new()
        {
            var config = InitConfiguration();
            return config.GetSection(section).Get<T>();
        }
    }
}
