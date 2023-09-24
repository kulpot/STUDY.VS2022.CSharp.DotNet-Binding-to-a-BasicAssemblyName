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
C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName>erase *.*
C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName\*.*, Are you sure (Y/N)? y

C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName

25/09/2023  06:04 am    <DIR>          .
25/09/2023  06:04 am    <DIR>          ..
25/09/2023  05:57 am    <DIR>          bin
25/09/2023  05:57 am    <DIR>          obj
25/09/2023  05:57 am    <DIR>          Properties
               0 File(s)              0 bytes
               5 Dir(s)  489,945,767,936 bytes free

C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName

25/09/2023  06:04 am    <DIR>          .
25/09/2023  06:04 am    <DIR>          ..
25/09/2023  05:57 am    <DIR>          bin
25/09/2023  05:57 am    <DIR>          obj
25/09/2023  06:04 am             5,458 Program.cs
25/09/2023  05:57 am    <DIR>          Properties
               1 File(s)          5,458 bytes
               5 Dir(s)  489,949,421,568 bytes free

C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName>csc /t:library /out:Farm.dll Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName

25/09/2023  06:07 am    <DIR>          .
25/09/2023  06:07 am    <DIR>          ..
25/09/2023  05:57 am    <DIR>          bin
25/09/2023  06:07 am             3,584 Farm.dll
25/09/2023  05:57 am    <DIR>          obj
25/09/2023  06:06 am               516 Program.cs
25/09/2023  05:57 am    <DIR>          Properties
               2 File(s)          4,100 bytes
               5 Dir(s)  489,945,579,520 bytes free

C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName>ildasm /out:moo.txt Farm.dll

C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName>moo.txt
--------------------------NOTEPAD: moo.txt--------------------------------


//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly Farm  <<<<------------------- Assembly Manifest ---------|
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.module Farm.dll
// MVID: {0ED1D9A4-A24D-48A7-9AFC-EB1B5370AF65}
.custom instance void System.Runtime.CompilerServices.RefSafetyRulesAttribute::.ctor(int32) = ( 01 00 0B 00 00 00 00 00 ) 
.imagebase 0x10000000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x00CC0000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi sealed beforefieldinit Microsoft.CodeAnalysis.EmbeddedAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method EmbeddedAttribute::.ctor

} // end of class Microsoft.CodeAnalysis.EmbeddedAttribute

.class private auto ansi sealed beforefieldinit System.Runtime.CompilerServices.RefSafetyRulesAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 02 00 00 00 02 00 54 02 0D 41 6C 6C 6F 77   // ........T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 00 54 02 09 49 6E 68 65   // Multiple.T..Inhe
                                                                                                                         72 69 74 65 64 00 )                               // rited.
  .field public initonly int32 Version
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(int32 A_1) cil managed
  {
    // Code size       15 (0xf)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ldarg.0
    IL_0008:  ldarg.1
    IL_0009:  stfld      int32 System.Runtime.CompilerServices.RefSafetyRulesAttribute::Version
    IL_000e:  ret
  } // end of method RefSafetyRulesAttribute::.ctor

} // end of class System.Runtime.CompilerServices.RefSafetyRulesAttribute

.class public auto ansi beforefieldinit Cow
       extends [mscorlib]System.Object
{
  .method public hidebysig static void  Moo() cil managed
  {
    // Code size       13 (0xd)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldstr      "Moooooooooooooo"
    IL_0006:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_000b:  nop
    IL_000c:  ret
  } // end of method Cow::Moo

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Cow::.ctor

} // end of class Cow


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file moo.res


--------------------------NOTEPAD: moo.txt--------------------------------END

:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName>del moo*.*

C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName

25/09/2023  06:12 am    <DIR>          .
25/09/2023  06:12 am    <DIR>          ..
25/09/2023  05:57 am    <DIR>          bin
25/09/2023  06:07 am             3,584 Farm.dll
25/09/2023  05:57 am    <DIR>          obj
25/09/2023  06:11 am             8,502 Program.cs
25/09/2023  05:57 am    <DIR>          Properties
               2 File(s)         12,086 bytes
               5 Dir(s)  489,950,785,536 bytes free

C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName>csc /r:Farm.dll Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName

25/09/2023  06:13 am    <DIR>          .
25/09/2023  06:13 am    <DIR>          ..
25/09/2023  05:57 am    <DIR>          bin
25/09/2023  06:07 am             3,584 Farm.dll
25/09/2023  05:57 am    <DIR>          obj
25/09/2023  06:12 am             9,347 Program.cs
25/09/2023  06:13 am             4,096 Program.exe
25/09/2023  05:57 am    <DIR>          Properties
               3 File(s)         17,027 bytes
               5 Dir(s)  489,950,052,352 bytes free

C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName>Program.exe
Moooooooooooooo

-------------------Chicken Farm.dll replace---------------------------------
C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName>csc /t:library /out:Farm.dll Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName

25/09/2023  06:15 am    <DIR>          .
25/09/2023  06:15 am    <DIR>          ..
25/09/2023  05:57 am    <DIR>          bin
25/09/2023  06:16 am             3,584 Farm.dll <-----Overwritten with chicken
25/09/2023  05:57 am    <DIR>          obj
25/09/2023  06:15 am            10,670 Program.cs
25/09/2023  06:13 am             4,096 Program.exe
25/09/2023  05:57 am    <DIR>          Properties
               3 File(s)         18,350 bytes
               5 Dir(s)  489,950,425,088 bytes free

C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName>ildasm /out:moo.txt Farm.dll

C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName>moo.txt
------------------------NOTEPAD: moo.txt-----------------------------------


//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly Farm
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.module Farm.dll
// MVID: {273F5E9B-5B17-49CE-B427-E5356FD5C4E7}
.custom instance void System.Runtime.CompilerServices.RefSafetyRulesAttribute::.ctor(int32) = ( 01 00 0B 00 00 00 00 00 ) 
.imagebase 0x10000000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x06430000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi sealed beforefieldinit Microsoft.CodeAnalysis.EmbeddedAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method EmbeddedAttribute::.ctor

} // end of class Microsoft.CodeAnalysis.EmbeddedAttribute

.class private auto ansi sealed beforefieldinit System.Runtime.CompilerServices.RefSafetyRulesAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 02 00 00 00 02 00 54 02 0D 41 6C 6C 6F 77   // ........T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 00 54 02 09 49 6E 68 65   // Multiple.T..Inhe
                                                                                                                         72 69 74 65 64 00 )                               // rited.
  .field public initonly int32 Version
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(int32 A_1) cil managed
  {
    // Code size       15 (0xf)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ldarg.0
    IL_0008:  ldarg.1
    IL_0009:  stfld      int32 System.Runtime.CompilerServices.RefSafetyRulesAttribute::Version
    IL_000e:  ret
  } // end of method RefSafetyRulesAttribute::.ctor

} // end of class System.Runtime.CompilerServices.RefSafetyRulesAttribute

.class public auto ansi beforefieldinit Chicken
       extends [mscorlib]System.Object
{
  .method public hidebysig static void  MakeSound() cil managed
  {
    // Code size       13 (0xd)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldstr      "chicken sound...."
    IL_0006:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_000b:  nop
    IL_000c:  ret
  } // end of method Chicken::MakeSound

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Chicken::.ctor

} // end of class Chicken


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file moo.res


------------------------NOTEPAD: moo.txt-----------------------------------END

C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName>Program.exe

----------------ERROR------DLL HELL: installed an dllfile over a another dllfile
Unhandled Exception: System.TypeLoadException: Could not load type 'Cow' from assembly 'Farm, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null'.
   at MyMainClass.Main()

----------------ERROR-----Different----
C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName>Program.exe

Unhandled Exception: System.IO.FileNotFoundException: Could not load file or assembly 'Farm, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null' or one of its dependencies. The system cannot find the file specified.
   at MyMainClass.Main()

--------------------------
public class Cow
{
    public static void Moo()
    {
        Console.WriteLine("chicken sound....");
    }
}
---------------------------
C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName>csc /t:library /out:Farm.dll Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName>Program.exe
chicken sound....

C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Binding to a BasicAssemblyName\DotNet Binding to a BasicAssemblyName

25/09/2023  06:29 am    <DIR>          .
25/09/2023  06:29 am    <DIR>          ..
25/09/2023  05:57 am    <DIR>          bin
25/09/2023  06:27 am             3,584 Farm.dll
25/09/2023  06:19 am               636 moo.res
25/09/2023  06:19 am             4,886 moo.txt
25/09/2023  05:57 am    <DIR>          obj
25/09/2023  06:29 am            18,748 Program.cs
25/09/2023  06:13 am             4,096 Program.exe
25/09/2023  05:57 am    <DIR>          Properties
               5 File(s)         31,950 bytes
               5 Dir(s)  489,941,434,368 bytes free




 * 
 */

/*
 * 
 * Name: Farm
 * Version: 0.0.0.0
 * Public Key Token: null
 * Culture: Neutral
 * 
 */


//class MainClass
//{
//    static void Main()
//    {
//
//    }
//}

//public class Cow
//{
//    public static void Moo()
//    {
//        Console.WriteLine("Moooooooooooooo");
//    }
//}

//class MyMainClass
//{
//    static void Main()
//    {
//        Cow.Moo();
//    }
//}

//public class Chicken
//{
//    public static void MakeSound()
//    {
//        Console.WriteLine("chicken sound....");
//    }
//}

public class Cow
{
    public static void Moo()
    {
        Console.WriteLine("chicken sound....");
    }
}