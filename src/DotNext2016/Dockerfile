FROM microsoft/dotnet:1.0.0-preview1

# Usage:
#	docker build -t dotnext .
#	docker run -p 5000:5000 -d dotnext

MAINTAINER Maurice de Beijer <maurice.de.beijer@gmail.com>

RUN mkdir -p /app
WORKDIR /app

COPY . /app
RUN dotnet restore

ENV ASPNETCORE_SERVER.URLS http://*:5000
EXPOSE 5000

CMD ["dotnet", "run"]

