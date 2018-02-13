Client Server Chat using UDP Sockets

Server 
Initially Console Application with argument <port>

Create an UDP server socket that listens on 127.0.0.1
  - create an IP address (localhost)
  - choose the same port for client and server
  - create a local endpoint that uses this address and port given as argument
  - display a message ">>Server started"
Create main loop logic that interprets messages like: join, quit and default(switch after message type)
  - Create a remote endpoint that has any IP address and port 0
  - The socket receives from the client the message, at first that could be of type: join, quit or other(use ReceiveFrom)
  - Use Encoding.ASCII.GetString(data) for getting the message
  - On the join case, the server display " >> Accepted connection from .."
  - On the quit case, the server displays ">> Closed connection from .. " 
  - On the default case, the server sends back the message received(use SendTo) and then breaks
  - In the main loop, the server shows ">> Waiting"
Add possibility to accept connections from multiple clients: use a list of clients(use ArrayList)
Add windows form for the server and show the list of clients that are connected and port


Client
Windows forms application

Create windows Forms that looks like preview client image
  - On button Join event click: an UDP socket is created, a remote endpoint that uses the IP Address entered, message join is sent to the server. On a newly created thread, the client expects receiving messages
  - On button Quit event click: message quit is sent to the server
  - On button Send, the message in the text area, it is sent to the server. Create a method “Send" that represents the callback for a newly created thread
  -  Window title: “Connected to <server name> on <port no>"

  
  
  
  