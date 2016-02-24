		Assignment 4 : Multi-Threading & Piped Input/Oupt 
	                   Eddie Rangel

I. 	Concurrency or Parallel Programming	

   Concurrecy or Parallet programming means multiple programs running at the same time
   to achive some common goals. Those programs may be running at the same machine
   of different machines conncted through network.

   The examples of concurrency programming including email clients and servers, File transfer
   clients and servers, HTTP servers and browsers and etc. In those examples, the clients and
   servers work separately and coorperately together to achieve some goals such as sending and
   receiving emails, files and webpages. 

   In concurrency or parallel programming, you will
	1. create multiple processes or threads running at the same time so that
           some sub-task of a task can be working on at the same time.
	2. Share some common data along processes and threads.
        3. synchronze the processes and threads so that the shared data can be
           access in some order.

	To achieve those two goals, we can use the following two techniques:

II. 	Pipeline

   1. In cases of multiple processes or threads running and the same time, if one process/threa'
      output is the input of anther process/thread. The technique called pipeline can be used
      to avoid using file to save output from the first process/thread, and the second process/
      thread to read from the file.

   2. Unix piped I/O      who | sort

   3. C# piped Input and Output

      See C#.io package for APIs of piped input and ouput classe.
   

III.	Assignment Description

   You are asked to write a program that implements heap-sort with multi-thread and
   piped input and output features. The basic requirements are

   The Requirements for Concurrent Two-way Merge-Sort are

       1. The algorithm will 1,000,000 integer elements.
       2. The array elements are divided into 32 sections and have 32 threads sorting on eacch of the
          32 sections.
       3. There are 16  merge threads waiting for 32 sorting threads to merge 2 adjacent sorted sections.
          The data are sent from sorter to merger through piped output & input.
       4. There are other 4 levels of merging threads with 8, 4, 2, and 1 merger thereads to merge the larger
          sections. Also the data between two adjacent mergers are passed through pipes.
       5. At the end of last level of merging, the array should be sorted.


    The program will use the following menu to test the program.

	
	    +----------------------------------------------------------------------------+
	    |          Merge Sort with Multi Threads and Piped Input and Output          |
	    +----------------------------------------------------------------------------+
        | G/G: Ask a integer N >= 1,000,000, and generate a integer array of N       |
        |      elements, and fill the array with N integers (int).                   |
	    +----------------------------------------------------------------------------+
        | C/c: Display the contents of array, 10 integers per line, and 20 lines     |
        |      screen. Allow quit during the display. If it quits in the middle,     |
        |      the last 3 lines must be display.                                     |
	    +----------------------------------------------------------------------------+
        | S/s: Sort the array using multithreaded piped I/O algorithm described above|
	    +----------------------------------------------------------------------------+
        | F/f: Shuffle the data.                                                     |
	    +----------------------------------------------------------------------------+
        | H//h/?: Show this menu.                                                    |
	    +----------------------------------------------------------------------------+
        | E/Q: Exit or quit the program.                                             | 
	    +----------------------------------------------------------------------------+
