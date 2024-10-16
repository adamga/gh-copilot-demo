# Chat App Server

This is the server-side of the Chat App project. It provides the backend functionality for real-time chat using WebSocket connections.

## Project Structure

The project has the following files and directories:

- `src/server.js`: This file is the entry point of the server-side application. It sets up a Node.js server using Express and handles WebSocket connections for real-time chat functionality.

- `src/routes/chatRoutes.js`: This file exports the routes for the chat functionality on the server-side.

- `package.json`: This file is the configuration file for npm on the server-side. It lists the dependencies and scripts for the server-side application.

## Getting Started

To run the server-side application, follow these steps:

1. Install the dependencies by running the following command:

   ```
   npm install
   ```

2. Start the server by running the following command:

   ```
   npm start
   ```

   The server will start running on `http://localhost:5000`.

## Dependencies

The server-side application has the following dependencies:

- `express`: Fast, unopinionated, minimalist web framework for Node.js.
- `ws`: Simple to use, blazing fast and thoroughly tested WebSocket client and server for Node.js.

These dependencies are listed in the `package.json` file.

## Contributing

Contributions are welcome! If you find any issues or want to add new features, please open an issue or submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE).

For more information, please refer to the client-side documentation in the [client/README.md](../client/README.md) file.