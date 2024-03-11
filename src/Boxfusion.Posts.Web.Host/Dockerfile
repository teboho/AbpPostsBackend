FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/Boxfusion.Posts.Web.Host/Boxfusion.Posts.Web.Host.csproj", "src/Boxfusion.Posts.Web.Host/"]
COPY ["src/Boxfusion.Posts.Web.Core/Boxfusion.Posts.Web.Core.csproj", "src/Boxfusion.Posts.Web.Core/"]
COPY ["src/Boxfusion.Posts.Application/Boxfusion.Posts.Application.csproj", "src/Boxfusion.Posts.Application/"]
COPY ["src/Boxfusion.Posts.Core/Boxfusion.Posts.Core.csproj", "src/Boxfusion.Posts.Core/"]
COPY ["src/Boxfusion.Posts.EntityFrameworkCore/Boxfusion.Posts.EntityFrameworkCore.csproj", "src/Boxfusion.Posts.EntityFrameworkCore/"]
WORKDIR "/src/src/Boxfusion.Posts.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Boxfusion.Posts.Web.Host", "src/Boxfusion.Posts.Web.Host"]
COPY ["src/Boxfusion.Posts.Web.Core", "src/Boxfusion.Posts.Web.Core"]
COPY ["src/Boxfusion.Posts.Application", "src/Boxfusion.Posts.Application"]
COPY ["src/Boxfusion.Posts.Core", "src/Boxfusion.Posts.Core"]
COPY ["src/Boxfusion.Posts.EntityFrameworkCore", "src/Boxfusion.Posts.EntityFrameworkCore"]
WORKDIR "/src/src/Boxfusion.Posts.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Boxfusion.Posts.Web.Host.dll"]
