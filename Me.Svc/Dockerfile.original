FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["Me/Me.csproj", "Me/"]
RUN dotnet restore "Me/Me.csproj"
COPY . .
WORKDIR "/src/Me"
RUN dotnet build "Me.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Me.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Me.dll"]