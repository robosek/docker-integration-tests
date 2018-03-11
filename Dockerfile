# /Dockerfile
FROM microsoft/dotnet:sdk as builder
COPY . /app
WORKDIR /app/asp_net_tests_docker_xunit
RUN curl https://raw.githubusercontent.com/vishnubob/wait-for-it/master/wait-for-it.sh > /app/wait_for_it.sh && dotnet restore
    