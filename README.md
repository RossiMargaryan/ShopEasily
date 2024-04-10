# ShopEasily

ShopEasily is an open-source e-commerce platform designed to provide a seamless and intuitive shopping experience for users. With a robust architecture and user-friendly interface, ShopEasily empowers businesses to showcase their products effectively and enables customers to browse, purchase, and manage orders with ease.

## Features

- Dynamic Product Catalog: Easily manage and display a wide range of products, including detailed descriptions, images, and pricing information.
- Real-time Updates: Receive real-time updates and notifications about order status, new products, and promotional offers.
- Secure Payment Processing: Utilize secure payment gateways to process transactions and protect sensitive financial information.
- Responsive Design: Enjoy a seamless shopping experience across various devices, including desktops, tablets, and smartphones.

## Architecture

The ShopEasily project consists of three main components:

- ShopEasily.Client: The client-side application built using Blazor WebAssembly, responsible for rendering the user interface and interacting with the server-side API.
- ShopEasily.Server: The server-side application developed with ASP.NET Core, responsible for handling business logic, data processing, and serving API endpoints.
- ShopEasily.Shared: A shared library containing common models, entities, and services used by both the client and server applications.

## Getting Started

To get started with ShopEasily, follow these steps:

1. Clone the repository: git clone https://github.com/RossiMargaryan/ShopEasily.git
2. Navigate to the project directory: cd ShopEasily
3. Install dependencies:
   - For the client-side application, navigate to the ShopEasily.Client directory and run dotnet restore.
   - For the server-side application, navigate to the ShopEasily.Server directory and run dotnet restore.
4. Configure the database connection in the appsettings.json file located in the ShopEasily.Server project.
5. Run the application:
   - For the client-side application, navigate to the ShopEasily.Client directory and run dotnet run.
   - For the server-side application, navigate to the ShopEasily.Server directory and run dotnet run.
