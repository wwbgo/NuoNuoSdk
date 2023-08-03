@echo off
Echo **Nuget Pack**

set suffix=
Echo **version%suffix%**

cd ../src/

rm -rf NuoNuoSdk/bin/nupkgs/*
dotnet build NuoNuoSdk/NuoNuoSdk.csproj --version-suffix "%suffix%" -c Release
dotnet pack NuoNuoSdk/NuoNuoSdk.csproj --version-suffix "%sufix%" -c Release

for %%i in (NuoNuoSdk/bin/nupkgs/*.nupkg) do ( 
    nuget push NuoNuoSdk/bin/nupkgs/%%i -Source https://nexus.flexem.net/repository/nuget-flexem/ 
    echo %%i push done!
    )

pause
