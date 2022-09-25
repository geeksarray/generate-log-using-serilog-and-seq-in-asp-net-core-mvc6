
# Generate Log using Serilog And Seq In ASP.NET Core MVC 6

This blog explains how to generate logs using Serilog, its feature like Sink, log level, JSONFormatter, Serilog Enricher, Output Templates, and analyze using Seq.

Serilog is a structured logging system that creates log messages and captures key attributes and data about the message's context. 
Serilog generates log messages as data, not just plain text. You can efficiently perform structured queries on these messages.


```
var _logger = new LoggerConfiguration()                        
    .WriteTo.File("./logs/log-.txt", 
        rollingInterval: RollingInterval.Day)       
    .WriteTo.Seq("http://localhost:5341", 
        Serilog.Events.LogEventLevel.Warning)
    .MinimumLevel.Debug()
    .CreateLogger();

builder.Logging.AddSerilog(_logger);
var app = builder.Build();

```

Seq

![ASP.NET Core Serilog Seq](https://geeksarray.com/images/blog/serilog-seq.png)

For more details [Generate Log using Serilog And Seq In ASP.NET Core MVC 6](https://geeksarray.com/blog/generate-log-using-serilog-and-seq-in-asp-net-core-mvc6)
