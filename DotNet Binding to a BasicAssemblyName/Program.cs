using System;

//ref link:https://www.youtube.com/watch?v=GvXbSZvIcjU&list=PLRwVmtr-pp06rfSgNYu_oBg40DkwXiRHt&index=14
// Assembly Names

//----4 Assembly IDENTIFYER---
// 1- Name
// 2- Version
// 3- Public Key
// 4- Culture

/*----------------------------CMD----------------------------
 * 
C:\Users\sunny\source\repos\DotNet Assembly Names>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Assembly Names

25/09/2023  05:46 am    <DIR>          .
25/09/2023  05:46 am    <DIR>          ..
25/09/2023  05:47 am    <DIR>          DotNet Assembly Names
25/09/2023  05:46 am             1,169 DotNet Assembly Names.sln
               1 File(s)          1,169 bytes
               3 Dir(s)  489,949,769,728 bytes free

C:\Users\sunny\source\repos\DotNet Assembly Names>cd DotNet Assembly Names

C:\Users\sunny\source\repos\DotNet Assembly Names\DotNet Assembly Names>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Assembly Names\DotNet Assembly Names

25/09/2023  05:47 am    <DIR>          .
25/09/2023  05:47 am    <DIR>          ..
25/09/2023  05:45 am               189 App.config
25/09/2023  05:45 am    <DIR>          bin
25/09/2023  05:46 am             2,392 DotNet Assembly Names.csproj
25/09/2023  05:45 am    <DIR>          obj
25/09/2023  05:47 am               192 Program.cs
25/09/2023  05:45 am    <DIR>          Properties
               3 File(s)          2,773 bytes
               5 Dir(s)  489,948,942,336 bytes free

C:\Users\sunny\source\repos\DotNet Assembly Names\DotNet Assembly Names>csc Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DotNet Assembly Names\DotNet Assembly Names>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Assembly Names\DotNet Assembly Names

25/09/2023  05:49 am    <DIR>          .
25/09/2023  05:49 am    <DIR>          ..
25/09/2023  05:45 am               189 App.config
25/09/2023  05:45 am    <DIR>          bin
25/09/2023  05:46 am             2,392 DotNet Assembly Names.csproj
25/09/2023  05:45 am    <DIR>          obj
25/09/2023  05:48 am             1,600 Program.cs
25/09/2023  05:49 am             4,096 Program.exe
25/09/2023  05:45 am    <DIR>          Properties
               4 File(s)          8,277 bytes
               5 Dir(s)  489,950,490,624 bytes free

C:\Users\sunny\source\repos\DotNet Assembly Names\DotNet Assembly Names>csc /t:library Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.

C:\Users\sunny\source\repos\DotNet Assembly Names\DotNet Assembly Names>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Assembly Names\DotNet Assembly Names

25/09/2023  05:50 am    <DIR>          .
25/09/2023  05:50 am    <DIR>          ..
25/09/2023  05:45 am               189 App.config
25/09/2023  05:45 am    <DIR>          bin
25/09/2023  05:46 am             2,392 DotNet Assembly Names.csproj
25/09/2023  05:45 am    <DIR>          obj
25/09/2023  05:49 am             2,607 Program.cs
25/09/2023  05:50 am             3,584 Program.dll
25/09/2023  05:49 am             4,096 Program.exe
25/09/2023  05:45 am    <DIR>          Properties
               5 File(s)         12,868 bytes
               5 Dir(s)  489,949,200,384 bytes free

-----------------------------------------------------------------------------
------------------------------------------------------------------------------
-------------------------------------------------------------------------------
C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName>csc Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName>csc /t:library Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName

25/09/2023  06:02 am    <DIR>          .
25/09/2023  06:02 am    <DIR>          ..
25/09/2023  05:57 am               189 App.config
25/09/2023  05:57 am    <DIR>          bin
25/09/2023  05:57 am             2,424 DotNet Binding to a BasicAssemblyName.csproj
25/09/2023  05:57 am    <DIR>          obj
25/09/2023  06:02 am             3,784 Program.cs
25/09/2023  06:01 am             3,584 Program.dll
25/09/2023  05:59 am             4,096 Program.exe
25/09/2023  05:57 am    <DIR>          Properties
               5 File(s)         14,077 bytes
               5 Dir(s)  489,946,734,592 bytes free



 * 
 */


class MainClass
{
    static void Main()
    {

    }
}