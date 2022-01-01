echo off
SET PATH=%PATH%;C:\Windows\Microsoft.NET\Framework64\v4.0.30319
set arg1=%1
shift
csc %arg1% 