To run this demo:

# Create database
Install postgreSQL and pgAdmin4.

Create a new Server, and in it a new Database.
Give the database a name of `InterviewDatabase`.
Create a User called `postgres` with a password of `12345678`.
Leave all other options as default.

If any options are changed, make sure to update the connection string in appsettings.json accordingly.

# Migrate database
Install `dotnet ef`

`dotnet tool install --global dotnet-ef`

Add and migrate model. Run these from root of cloned dir.

Replace `<uniquename>` with something unique
`dotnet ef migrations add <uniquename>`

`dotnet ef database update`

# Start API
Install .NET Core 8.0(.10) and SDK.

Open root diretory and run

`dotnet run`

Note: If packages are missing, try `dotnet restore`

# Make requests
## Swagger
Open the http://localhost:5032/swagger/index.html (confirm port number is same as terminal output when calling `dotnet run`)

Swagger will show the available endpoints, and example payloads to send.

## Postman
Connect to send GET, POST, PUT, DELETE commands to http://localhost:5032 with the appropriate endpoint appended

# Endpoint docs
### GET /Products
Returns all Products in the database. A Product has 3 attributes; ID (auto-generated), Name (string), Price (decimal).
### GET /Products/{id}
Get a specific product by ID.
### POST /Products
Create a new product. If an ID is provided, this will be ignored and the next available ID will be used. Example of payload: {"name":"jumper", "price":25.99}
### PUT /Products/{id}
Update an existing product by the given ID. If an ID is provided, this will be ignored. Example of payload: {"name":"jumper discounted","price":18.45}
### DELETE /Products/{id}
Delete a Product by the given ID.