# Client Chat Application (C# WinForms)

This project is a simple client-side chat application built using C# and Windows Forms. It connects to a server, sends messages, and receives messages from other clients connected to the same server.

## Features

*   **Client-Server Architecture:** Connects to a central server that manages all communication.
*   **TCP Protocol:** Uses the TCP protocol for reliable, connection-oriented communication.
*   **User Interface:** A simple WinForms UI for entering server IP/Port, connecting, sending messages, and displaying chat history.

## Prerequisites

*   **.NET Framework:** Ensure you have the .NET Framework (e.NET Core) installed on your system. This project was likely built with a specific version of .NET Framework compatible with Windows Forms.
*   **Visual Studio:** Recommended for opening, building, and running the project.

## How to Run

To run this application, you must first have a compatible chat server running. This project only provides the client-side application.

### 1. Build the Project

Open the `Client-Chat.sln` solution file in Visual Studio. Build the solution (Build -> Build Solution) to compile the application.

### 2. Run the Client

After building, you can run the application directly from Visual Studio or navigate to the `Client-Chat/bin/Debug` (or `Release`) directory and run the `Client-Chat.exe` executable.

1.  **Enter Server IP and Port:** In the application window, enter the IP address and port of the chat server you wish to connect to.
2.  **Click "Connect":** Click the "Connect" button to establish a connection with the server.
3.  **Start Chatting:** Once connected, type your message in the text box and click "Send" to send it to the server and other connected clients.

## Notes

*   This project is the client-side component only. A separate server application is required for full chat functionality.
*   To disconnect from the server, click the "Disconnect" button.
