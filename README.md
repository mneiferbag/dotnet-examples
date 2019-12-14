# C# Examples

Collection of C# code examples.

# .NET Core SDK

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

# Links

* [.NET Conf](https://www.dotnetconf.net/ ".NET Conf")
* [.NET Foundation](https://dotnetfoundation.org/ ".NET Foundation")
* [BASTA!](https://basta.net/ "BASTA!")
* [Channel 9](https://channel9.msdn.com/ "Channel 9")
* [Microsoft .NET](https://dotnet.microsoft.com/ "Microsoft .NET")
* [Microsoft Azure](https://azure.microsoft.com/ "Microsoft Azure")
* [Microsoft Developer](https://developer.microsoft.com/ "Microsoft Developer")
* [Microsoft Docs](https://docs.microsoft.com/ "Microsoft Docs")
