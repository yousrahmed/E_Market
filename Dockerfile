#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1803 AS base
WORKDIR /app
EXPOSE 53360
EXPOSE 44315

FROM microsoft/dotnet:2.1-sdk-nanoserver-1803 AS build
WORKDIR /src
COPY ["E_Market/E_Market.csproj", "E_Market/"]
RUN dotnet restore "E_Market/E_Market.csproj"
COPY . .
WORKDIR "/src/E_Market"
RUN dotnet build "E_Market.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "E_Market.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "E_Market.dll"]