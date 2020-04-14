@echo on

:: this script needs https://www.nuget.org/packages/ilmerge

:: set your target executable name (typically [projectname].exe)
SET APP_NAME=MachineLearningTest.exe

:: Set build, used for directory. Typically Release or Debug
SET ILMERGE_BUILD=test

:: Set platform, typically x64
SET ILMERGE_PLATFORM=x64

:: set your NuGet ILMerge Version, this is the number from the package manager install, for example:
:: PM> Install-Package ilmerge -Version 3.0.29
:: to confirm it is installed for a given project, see the packages.config file
SET ILMERGE_VERSION=3.0.29

:: the full ILMerge should be found here:
SET ILMERGE_PATH=%USERPROFILE%\.nuget\packages\ilmerge\%ILMERGE_VERSION%\tools\net452
:: dir "%ILMERGE_PATH%"\ILMerge.exe

echo Merging %APP_NAME% ...

:: add project DLL's starting with replacing the FirstLib with this project's DLL
"%ILMERGE_PATH%"\ILMerge.exe Bin\x64\test\%APP_NAME%  ^
  /lib:Bin\%ILMERGE_PLATFORM%\%ILMERGE_BUILD%\ ^
  /out:%APP_NAME% ^
  CpuMathNative.dll^
Cyotek.Windows.Forms.ColorPicker.dll^
FastTreeNative.dll^
LdaNative.dll^
lib_lightgbm.dll^
Microsoft.ML.Core.dll^
Microsoft.ML.CpuMath.dll^
Microsoft.ML.Data.dll^
Microsoft.ML.DataView.dll^
Microsoft.ML.FastTree.dll^
Microsoft.ML.KMeansClustering.dll^
Microsoft.ML.LightGbm.dll^
Microsoft.ML.PCA.dll^
Microsoft.ML.StandardTrainers.dll^
Microsoft.ML.Transforms.dll^
Newtonsoft.Json.dll^
System.Buffers.dll^
System.CodeDom.dll^
System.Collections.Immutable.dll^
System.Memory.dll^
System.Numerics.Vectors.dll^
System.Resources.Extensions.dll^
System.Runtime.CompilerServices.Unsafe.dll^
System.Threading.Tasks.Dataflow.dll

:Done
dir %APP_NAME%
pause