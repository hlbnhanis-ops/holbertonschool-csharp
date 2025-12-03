#!/bin/bash

dotnet new console -n 2-new_project

cd 2-new_project

mv Program.cs 2-new_project.cs
sed -i 's|<Compile Include="Program.cs" />|<Compile Include="2-new_project.cs" />|' "2-new_project.csproj"

dotnet build

dotnet run