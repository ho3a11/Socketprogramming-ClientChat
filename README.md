Socket Programming - Client Chat This project is a simple chat application built using Socket Programming in Python. It includes a server and a client that communicate over a network, allowing multiple clients to connect to the server simultaneously and chat with each other.

## Features

*   Client-Server Architecture: A central server that manages all communication.
*   Multi-Client Support: The ability for multiple users to connect at the same time.
*   TCP Protocol: Uses the TCP protocol for reliable, connection-oriented communication.

## Prerequisites

*   Python 3.x: Ensure that Python 3 is installed on your system.

## How to Run

To run this application, you must first start the server and then the clients.

### Run the Server

In your terminal or Command Prompt, execute the `server_chat.py` file:

```bash
python server_chat.py
```

Once running, the server will display a message indicating it's listening for connections.

### Run the Client

In a new terminal window, run the `client_chat.py` file. You can do this multiple times to run more clients.

```bash
python client_chat.py
```

After running, you will be prompted to enter a username. Once you have done so, you can begin chatting.

## Notes

*   If you plan to run the server and client on two separate computers, you'll need to change the server's IP Address in the `client_chat.py` file to the server's actual IP address.
*   To exit the program, you can use Ctrl+C in the terminal.
