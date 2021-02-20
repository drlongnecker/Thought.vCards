nugetSource = https://api.nuget.org/v3/index.json
dotnetFramework = net5.0
solution = ./Solution/vCards.sln
testProject = Solution/Thought.vCards.UnitTests/Thought.vCards.UnitTests.csproj
libProject = Solution/Thought.vCards/Thought.vCards.csproj
distPath = ./dist
nupkgFile = ./dist/Thought.vCards.Core.nupkg

run-clean: clean restore build run 

all : clean restore build

clean:
	dotnet clean ${solution}

restore:
	dotnet restore ${solution}

build:
	dotnet build -c Release ${solution}

test:
	dotnet test ${testProject}

# More: https://docs.microsoft.com/pt-br/dotnet/core/tools/dotnet-pack
# dotnet pack [<PROJECT>|<SOLUTION>] [-c|--configuration <CONFIGURATION>]
#     [--force] [--include-source] [--include-symbols] [--interactive]
#     [--no-build] [--no-dependencies] [--no-restore] [--nologo]
#     [-o|--output <OUTPUT_DIRECTORY>] [--runtime <RUNTIME_IDENTIFIER>]
#     [-s|--serviceable] [-v|--verbosity <LEVEL>]
#     [--version-suffix <VERSION_SUFFIX>]
pack:
	dotnet pack ${libProject} -c Release -p:TargetFrameworks=${dotnetFramework} --include-symbols -o ${distPath}

push:
	dotnet nuget push ./dist/*.nupkg --api-key ${NUGET_API} --source ${nugetSource}