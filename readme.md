# About

:heavy_check_mark: Read EF Core connection string from appsettings.json

:heavy_check_mark: Configuring EF Core logging from appsettings.json

</br>

**Options** for logging

```csharp
public enum LoggingDestination
{
    /// <summary>
    /// Log to Output window
    /// </summary>
    DebugWindow,
    /// <summary>
    /// Log to file
    /// </summary>
    LogFile,
    /// <summary>
    /// No logging
    /// </summary>
    None
}
```
</br>

**Usage**: reads [appsettings.json](https://github.com/karenpayneoregon/ef-core5-logging/blob/master/LogToFile/appsettings.json)

```csharp
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    if (!optionsBuilder.IsConfigured)
    {
        switch (Helper.LoggingDistination())
        {
            case LoggingDestination.DebugWindow:
                LogQueryInfoToDebugOutputWindow(optionsBuilder);
                break;
            case LoggingDestination.LogFile:
                LogQueryInfoToFile(optionsBuilder);
                break;
            case LoggingDestination.None:
                NoLogging(optionsBuilder);
                break;
            default: throw new ArgumentOutOfRangeException();
        }
    }
}
```

</br>


![img](assets/efcore.png) ![image](assets/Versions.png)
![img](assets/csharpSmall.png)

# NuGet packages

|Id| Versions | 
| :--- | :---         |
|Microsoft.Extensions.Configuration.FileExtensions|  {5.0.0} | 
|Newtonsoft.Json|  {12.0.3} | 
|Microsoft.Extensions.Configuration.Binder|   {5.0.0} |
|Microsoft.Extensions.Configuration.Json|   {5.0.0} | 
|Microsoft.Extensions.Configuration|   {5.0.0} | 

</br>

# See also

- Microsoft TechNet: 
  - [.NET Core desktop application configurations (C#)](http://example.com)
  - [Entity Framework/Entity Framework Core dynamic connection strings (C#)](https://social.technet.microsoft.com/wiki/contents/articles/54079.entity-frameworkentity-framework-core-dynamic-connection-strings-c.aspx)
  - [Entity Framework Core/Windows Forms tips and tricks](https://social.technet.microsoft.com/wiki/contents/articles/53635.entity-framework-corewindows-forms-tips-and-tricks.aspx)
- Microsoft docs
  - [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
  - [Porting from EF6 to EF Core](https://docs.microsoft.com/en-us/ef/efcore-and-ef6/porting/)
- Tools
  - [EF Core Power Tools](https://marketplace.visualstudio.com/items?itemName=ErikEJ.EFCorePowerTools)
  
---
 




![img](assets/kpmvp1.png)

