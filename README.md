# Hacker News Api Consumer

The project has been built using VS 2022 ASP.NET Core 6.0 as a RESTful API 
It is used to retrieve the details of the first n "best stories" from the Hacker News API, where n is specified by the caller to the API.
This has been tested using out of the box Swagger client.

How to run the project :
  1) Open the solution in HNCCApiconsumer/HNCCApiconsumer.sln
  2) Restore Nuget packages.
  3) Set HNCCApiconsumer as startup project.
  4) Run and test the api in Swagger.

Assumptions made:
  1) The application will be run on a single node and not on a web farm.
  2) Security requirements will be provided and added at a later stage.
  
Improvements that can be made given more time :
  1) Add more unit tests.
  2) Support other distributed cache like Redis or NCache depending on whichever is available.
  3) Refactor the Namespaces and Project names.
  4) Add more logging to allow monitoring the application.
  5) Exception handling 
   

  
