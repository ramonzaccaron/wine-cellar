# Wine Cellar - Cellar Control

Wine Cellar is a project that will be developed with Angular technology applying the Angular Material UI interface library and ASP.NET Core Web API in order to manage wine bottles in a cellar, such as storage and consumption of labels, their quantities and more.

## Technologies

#### Server-Side
- ASP.NET Core Web API 6 - is a cross-platform, high-performance, open-source framework for building modern, cloud-enabled, Internet-connected apps. [Official Site](https://learn.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-6.0)
- Serilog -  is a diagnostic logging library for .NET applications. [Official Site](https://serilog.net/)
- Elasticsearch - is a collection of tools for searching content. This project use a serilog sink for integration logs. [Official Site](https://www.elastic.co/pt/enterprise-search)

#### Client-Side
[WIP]

## Project Organization

All of the files of the projects are located inside this repository. The layers and their files are located inside of the main project, the Web API project. 
The backend is divided in layers even though existing just only one project, the division is made by folders, in this way we have the layers bellow:

- Distributed layer:
   - The main responsibility of this layer are communicate and distribute data with the UI layer.
   - Project types that are used: Web API.
- Domain layer: 
  - Business objects are developed here.
  - Objects that represent the enterprise logical domain and domain types.
  - Access interfaces to data repositories.

## Dependencies

The dependencies of the backend are managed by the Nuget. The instructions below are used to open the project ans install the dependencies before run the application.

1. Install Git to help you to clone the repository to your machine from the Github, [available here](https://gitforwindows.org/).
2. Install Nuget tool to restore the packages of the projects. [Download here](https://www.nuget.org/downloads).
3. Install an IDE to open, build and run the application. I recomend Visual Studio, [download here](https://visualstudio.microsoft.com/pt-br/downloads/).

## Running the project

After all the tools installed and the project cloned and open with your IDE in your machine, build the project and restore the packages.

#### Using Visual Studio

To run the project with Visual Studio you need just to select the IIS Express run mode and click the Run button. The swagger will open with the documentation of the API controllers in the follw address: https://localhost:44323/swagger/index.html.

#### Using Docker

To run the aplication using docker, you need first install Docker tool, [Official Site](https://www.docker.com/).

In the root of the project you'll see a docker-compose file, let's use this to run our project with diferent containers working together. With this file we'll run all resources that our project have: Web API, Client, Elasticsearch, Kibana, etc.

With your docker tool running, open a bash console where your docker-compose file was cloned. Run the following command:

```
docker compose up -d
```
This command will pull the images stored in the docker hub repository and run it with the application, and will get the docker file of the Wine Cellar projects and generate locally the images before run all together.
After all the images are running your Wine Cellar API will be listening in the address http://localhost:9005.

#### Using Elasticsearch

If you want to log data in the Elasticsearch use the containers configurations into the docker-compose file to run Elasticsearch and Kibana server to log and see logged data. Configure the Elasticsearch server address in the apropriated Wine Cellar API project configuration, like below:

```
  "Elasticsearch": {
    "Uri": "http://localhost:9200"
  }
```
So, serilog will push all log data to Elasticksearch server, and you can see it using the Kibana to search and analise logs from the Wine Celllar API. The Kibana address is http://localhost:5601/app/home#/.

#### Seeing data with Kibana

Like we said, to see data logged into Elasticsearch using a portal we can use the [Kibana](https://www.elastic.co/pt/kibana/). You can create indexes to filter your data and search especific informations.

## That's all!

This project will be always under construction, and it will be used to practice the use of languages, frameworks, design patterns, tests and so on. Fell free to join me and contribute if you want.

Cheers!