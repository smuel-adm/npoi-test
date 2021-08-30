
# NPOI - Tests
Test the NPOI Library


## Used components
* Logging - [log4net]

### Logging

To enable logging install the [log4net] package.

```console
dotnet add package log4net
```

Now add this attribute to your namespace.

```c#
[assembly: log4net.Config.XmlConfigurator(Watch = true)]
```

And create the `ILog` object called **log** in your programs main class. This object is later used to print your messages as shown later in this manual.

```c#
private static readonly ILog log = LogManager.GetLogger(typeof(Program));
```

Now add an App.config to your `.csproj`'s `<PropertyGroup>`

```xml
  <PropertyGroup>
    ...
    <AppConfig>App.config</AppConfig>
  </PropertyGroup>
```

and create the `App.config` file with that content:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <configSections>
        <section name="log4net" type="log4net.Config.Log4NetConfigurationSectionHandler, log4net" />
    </configSections>
    <log4net>
        <appender name="ConsoleAppender" type="log4net.Appender.ConsoleAppender" >
            <layout type="log4net.Layout.PatternLayout">
                <conversionPattern value="%date [%thread] %-5level %logger [%ndc] - %message%newline" />
            </layout>
        </appender>

        <appender name="RollingFile" type="log4net.Appender.RollingFileAppender">
            <file value="npoi-test.log" />
            <appendToFile value="true" />
            <maximumFileSize value="100KB" />
            <maxSizeRollBackups value="2" />
    
            <layout type="log4net.Layout.PatternLayout">
                <conversionPattern value="%date [%thread] %-5level %logger [%ndc] - %message%newline" />
            </layout>
        </appender>
        <root>
            <level value="INFO" />
            <appender-ref ref="ConsoleAppender" />
            <appender-ref ref="RollingFile" />
        </root>
    </log4net>
</configuration>
```

This [log4net] configuration adds an Console appender and an RollingFile appender as well. In your functions use the `log` object for debug messages.

```c#
log.Info("Entering application.");
```

or

```c#
log.Error("Error!");
```



## Development
### Render README.md

```console
pandoc -f markdown -t html5 --standalone -o README.html .\README.md; start .\README.html
```
_**Hint**: You need [pandoc] installed for the above command_

[log4net]: https://logging.apache.org/log4net/
[pandoc]: https://pandoc.org/