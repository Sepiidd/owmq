# syntax=docker/dockerfile:1

# build
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

#only copy .csproj, tells CLR
COPY owmq-backend/owmq-backend.csproj owmq-backend/
RUN dotnet restore owmq-backend/

COPY . .
#gather all compiled dependencies (dlls) into /app/publish
RUN dotnet publish owmq-backend/owmq-backend.csproj -c Release -o /app/publish --no-restore /p:UseAppHost=False #restore done in previous step, useapphost false since we run dll directly

# run
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS live
WORKDIR /app

COPY --from=build /app/publish .

#remove root privilege, user is .net image user
USER $APP_UID
EXPOSE 8080

#run the dll via the CLR (c sharp JVM equivalent)
ENTRYPOINT ["dotnet", "owmq-backend.dll"]
