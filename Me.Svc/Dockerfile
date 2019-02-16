FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY Me.Svc/Me.Svc.csproj Me.Svc/
RUN dotnet restore Me.Svc/Me.Svc.csproj
COPY . .
WORKDIR /src/Me.Svc
RUN dotnet build Me.Svc.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Me.Svc.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Me.Svc.dll"]
