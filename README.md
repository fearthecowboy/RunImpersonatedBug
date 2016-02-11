# RunImpersonatedBug

``` batch
C:\tmp>dotnet build
Compiling tmp for DNXCore,Version=v5.0

Compilation succeeded.
    0 Warning(s)
    0 Error(s)

Time elapsed 00:00:01.5898345


Compiling tmp for .NETFramework,Version=v4.6

Compilation succeeded.
    0 Warning(s)
    0 Error(s)

Time elapsed 00:00:01.5765484

C:\tmp>dotnet run
Project tmp (DNXCore,Version=v5.0) was previously compiled. Skipping compilation.
Hello World!
I am NTDEV\garretts!

C:\tmp>bin\Debug\net46\tmp.exe
Hello World!

Unhandled Exception: System.Security.SecurityException: Unable to retrieve security descriptor for this frame.
   at System.Security.Principal.WindowsIdentity.SafeImpersonate(SafeAccessTokenHandle userToken, WindowsIdentity wi, StackCrawlMark& stackMark)
   at System.Security.Principal.WindowsIdentity.RunImpersonated(SafeAccessTokenHandle safeAccessTokenHandle, Action action)
   at ConsoleApplication.Program.Main(String[] args) in C:\tmp\Program.cs:line 21

C:\tmp>

```