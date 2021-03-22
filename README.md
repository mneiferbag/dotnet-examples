# Microsoft .NET Development Examples

Licensed under the MIT License. See file LICENSE.

Collection of Microsoft .NET development examples. Examples include code written in C#.

## .NET Core SDK

The examples assume, that you have .NET Core SDK installed. You might want to have a look at Microsoft [Visual Studio Code Remote Development](https://code.visualstudio.com/docs/remote/remote-overview) to create a platform independent development environment.

To replace .NET Core SDK on Ubuntu, for example replace 3.0 with 3.1, do:

1. dotnet --list-sdks (check installed)
2. apt-get remove dotnet-sdk-3.0
3. apt-get autoremove
4. apt list --installed | grep dotnet (check deinstall)
5. apt-get update (refresh packages)
6. apt-get install dotnet-sdk-3.1
7. dotnet --list-sdks (check installed)
8. Update your .csproj files and rebuild.

See [Ubuntu 18.04 Package Manager - Install .NET Core](https://docs.microsoft.com/en-us/dotnet/core/install/linux-package-manager-ubuntu-1804) on [Microsoft Docs](https://docs.microsoft.com/).

## Tips

Use `Invoke-WebRequest` cmdlet from module Microsoft.PowerShell.Utility to get content from a web page on the internet. Like `curl` or `wget` on Linux.

## Links

* [.NET Conf](https://www.dotnetconf.net/ ".NET Conf")
* [.NET Decompiler - ILSpy](https://github.com/icsharpcode/ILSpy ".NET Decompiler")
* [.NET Fiddle](https://dotnetfiddle.net/ ".NET Fiddle")
* [.NET Foundation](https://dotnetfoundation.org/ ".NET Foundation")
* [BASTA!](https://basta.net/ "BASTA!")
* [C# Pad](https://csharppad.com/ "C# Pad")
* [Channel 9](https://channel9.msdn.com/ "Channel 9")
* [Microsoft .NET](https://dotnet.microsoft.com/ "Microsoft .NET")
* [Microsoft Azure](https://azure.microsoft.com/ "Microsoft Azure")
* [Microsoft Developer](https://developer.microsoft.com/ "Microsoft Developer")
* [Microsoft Docs](https://docs.microsoft.com/ "Microsoft Docs")
* [TestStack.White](https://teststackwhite.readthedocs.io/en/latest/ "TestStack.White")
