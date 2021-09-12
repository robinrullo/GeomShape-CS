FROM mcr.microsoft.com/dotnet/sdk:5.0 as build-image

# Install Node.js
RUN curl -fsSL https://deb.nodesource.com/setup_16.x | bash - \
    && apt-get install -y \
        nodejs \
    && rm -rf /var/lib/apt/lists/*

WORKDIR /home/app

COPY ./*.sln ./
COPY ./*/*.csproj ./
RUN for file in $(ls *.csproj); do mkdir -p ./${file%.*}/ && mv $file ./${file%.*}/; done

RUN dotnet restore

COPY . .

# RUN dotnet test ./Tests/Tests.csproj


RUN dotnet publish -c release -o /publish/ --no-restore


FROM mcr.microsoft.com/dotnet/aspnet:5.0

WORKDIR /publish

COPY --from=build-image /publish .

ENV ASPNETCORE_URLS="http://0.0.0.0:5000"

ENTRYPOINT ["dotnet", "GeomShapeServer.dll"]
