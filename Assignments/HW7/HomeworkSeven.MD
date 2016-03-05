	Assignment 7 : Application of Multithreading, Synchronization, Socket
			And OOP Design and Implementation
	               		Eddie Rangel

A "live chat", or "online help" allows advisors or representatives of  banks, companies, and organizations to 
serve their customers by answering qutestions online.

You are going to modify the GROUP_STUDY program (in GroupStudy_ForClass.zip) to a live-chat program with
features defined in section II. 


-------------------------------------------------------------------------------------------

###I.	Purposes:

	    Get familiar with 
	- Apply Multithreaing, and  Thread -Synchronization, Network programming
	   (Sockets) to solve a more complicated problem.
	- Use OOP, top-down design method in program design and implementation.

###II.	Assignment Description

     
    The "Online help" or "Live Chat" program consists of two interfaces:

	(1) One for users to ask questions lively, and
	(2) One for Advisors answer questions of clients.

    This assignment will write a online-help prgram with following features:


   On Client Side:

   1. Enter a user name and zip code in two textboxes, and buttom "Chat start" to bring
      out a a different window. 
   2. The window will have at least 2 Boxes, one for typing questions and one for showing
      questions and answers.
   3. Message showing status of representative (such "Clark/advisor is typing")
   4. The questions and answers are prefixed with customer's and representative's names.
      The text color for names, and questions and answers with different colors.

  On Advisor/Representative Side (after I ask some adivosr at Ortho). 
    

   1. Representative can talk to N customers at the same time (The Ortho company bought
      the liences for talking to 3 clients for one presentative).

   2. A representative can use one shared windows or separated windows to talke to multiple
      customers. I suggest that a single window is used to host multiple clients. Only one client
      will be selected to answer his/her question at a given  time. The advisor can switch among
      his customers.

   3. If one window is used, a client name is clicked and name will appear somewhere,
      all the communications will go to the chosen cleint.

   4. Multiple representatives can login the sysems and each, and talk his/her group of clients.
      A represenative can transfer his/her clients to another representative.