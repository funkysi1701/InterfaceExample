packages\OpenCover.4.6.519\tools\OpenCover.Console.exe -target:"packages\NUnit.ConsoleRunner.3.6.1\tools\nunit3-console.exe" -targetargs:"InterfaceExample.Test\bin\Release\InterfaceExample.Test.dll" -output:"TestResults\coverage.xml" -register:user

packages\ReportGenerator.2.5.6\tools\ReportGenerator.exe "-reports:TestResults\*.xml" "-targetdir:TestResults"