echo off
SET PATH=%PATH%;
c:\Windows\WinSxS\x86_netfx-csharp_compiler_csc_b03f5f7f11d50a3a_6.3.9600.20708_none_02afd7810ad4d85c\csc.exe


set arg1=%1
shift
csc %arg1% 