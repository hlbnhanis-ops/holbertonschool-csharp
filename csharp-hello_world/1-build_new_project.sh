#!/bin/bash

dotnet new console -n 1-new_project

cd 1-new_project

mv Program.cs 1-new_project.cs
sed -i 's|<Compile Include="Program.cs" />|<Compile Include="1-new_project.cs" />|' "1-new_project.csproj"

dotnet build