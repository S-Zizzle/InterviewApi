To run this demo:

# Start database
Install postgreSQL.
Add and migrate model. Run from root of cloned dir.

`dotnet ef migrations add InitialCreate`

`dotnet ef database update`

# Start API
Install .NET Core 8.0(.10) and SDK.

Open root diretory and run

`dotnet run`

# Make requests
## Swagger
Open the link shown in the output (like http://localhost:XXXX)
## Postman
tjtjtjt

# Endpoint docs
### GET /Products
#### test
### GET /Products/{id}
#### test
### POST /Products
#### test
### PUT /Products/{id}
#### test
### DELETE /Products/{id}
#### test