REM git bisect run cmd /K ..\BisectRunner\run_unit_tests.bat
SET MSBUILD="C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe"
SET MSTEST="C:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\MSTest.exe"

SET SOLUTION=%~dp0%BisectUnitTest.sln
SET TEST_CONTAINER=%~dp0%bin\Debug\BisectUnitTest.dll

%MSBUILD% %SOLUTION%
%MSTEST% /testcontainer:%TEST_CONTAINER%

exit