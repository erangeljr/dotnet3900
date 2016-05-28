
		Assignment 6 : Sockets, Multi-Threading & Synchronization
				and Grapical User Interface
 
	               Eddie Rangel

###I.	Purposes: Get familiar with and apply following concepts to build application
 
	- Socket, Multithreaing and thread-synchronization 
	- Applet, and Grapical user Interface components.

###II.	Assignment Description

    
     Write a server and and client chatroom programs with the following
     general featuress:

 
     G1. The server runs on a server machine that allow multiple clients to talk to
         each others by sending text to each other.
     G2. The client program should be  able to  applet or application program that
         allows users to log into the chat room to talk to each others.
         Each client should be able to have his/her own name and ID assigned by server.
     G3. When multiple clients try to send/talk to each other, the messages of different
         users should should not messed each others. That is, the action of sending the
         message must be mutually exclusive.
     G4. Each client should be able to send and received others message freely (without
         blocking by sending or receiving operations). That is client needs to have two
         threds one for send message and one for receiving messge.
     G5. Each client can be a public message to all clients and send a private message to selected
         clients. To achieve that goal, a list of Checkboxes, one for each client, must
         listed on the east side of JFrame.  