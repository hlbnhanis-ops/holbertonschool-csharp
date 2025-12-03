#!/usr/bin/env bash

dotnet new console -n 0-new_project

cd 0-new_project

mv Program.cs 0-new_project.cs
sed -i 's|<Compile Include="Program.cs" />|<Compile Include="0-new_project.cs" />|' "0-new_project.csproj"
