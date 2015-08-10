SET MSBUILD="C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe"
SET MSTEST="C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\MSTest.exe"

SET SOLUTION=%~dp0%..\PhoneNumberValidator.sln
SET TEST_CONTAINER=%~dp0%..\PhoneNumberValidator.Test\bin\Debug\PhoneNumberValidator.Test.dll

%MSBUILD% %SOLUTION%
%MSTEST% /testcontainer:%TEST_CONTAINER%
