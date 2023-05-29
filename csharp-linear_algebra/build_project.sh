#!/usr/bin/env bash
#simplifying projects preparation by Titania792 c:
for project in "$@"
do
    dotnet new console -o $project
    dotnet build $project
    mv $project/Program.cs $project/$project.cs
done
