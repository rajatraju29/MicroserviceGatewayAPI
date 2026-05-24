🚀 MicroserviceGatewayAPI

A scalable and modern Microservices API Gateway project built using .NET Core and Ocelot API Gateway.
📌 Features

✨ API Gateway using Ocelot
✨ Microservices Architecture
✨ JWT Authentication Support
✨ Routing & Load Balancing
✨ Swagger Integration
✨ Clean Architecture
✨ Scalable & Maintainable Structure

🛠️ Tech Stack
⚡ ASP.NET Core Web API
🌐 Ocelot API Gateway
🗄️ SQL Server
🔐 JWT Authentication
📦 Entity Framework Core
📄 Swagger / OpenAPI
example :
 {
  "UpstreamPathTemplate": "/gateway/orders",
  "DownstreamPathTemplate": "/api/orders",
  "DownstreamScheme": "https",
  "DownstreamHostAndPorts": [
    {
      "Host": "localhost",
      "Port": 7001
    }
  ]
}

👨‍💻 Author

Made with ❤️ by RAJAT
