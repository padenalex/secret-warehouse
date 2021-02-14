FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Alex-Warehouse.csproj", "Alex-Warehouse/"]
RUN dotnet restore "Alex-Warehouse/Alex-Warehouse.csproj"
COPY . Alex-Warehouse/
WORKDIR "/src/Alex-Warehouse"
RUN dotnet build "Alex-Warehouse.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Alex-Warehouse.csproj" -c Release -o /app

#Angular build
FROM node as nodebuilder

# set working directory
RUN mkdir /usr/src/app
WORKDIR /usr/src/app

# add `/usr/src/app/node_modules/.bin` to $PATH
ENV PATH /usr/src/app/node_modules/.bin:$PATH


# install and cache app dependencies
COPY client-app/package.json /usr/src/app/package.json
RUN yarn install
RUN yarn global add @vue/cli --unsafe

# add app

COPY client-app/. /usr/src/app

RUN yarn run build

#End Angular build

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
RUN mkdir -p /app/client-app/dist
COPY --from=nodebuilder /usr/src/app/dist/. /app/client-app/dist/
ENTRYPOINT ["dotnet", "Alex-Warehouse.dll"]