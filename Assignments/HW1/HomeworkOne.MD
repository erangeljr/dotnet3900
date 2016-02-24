		Assignment 1: Class, Inheritance and Polymorphism
	                  Eddie Rangel

I.	Purpose: Object-Oriented Prgramming in C# 

II.	Description:

   The purpose of this exercise is to practice the object-oriented
programming methodologies with C#. The OOP features, data encapsulation,
inheritance and polymorphism, are used to implment a group of related
class. Save the class objects in HTML Table format into a HTML file,
and display the html file by launching the default internet browser to
display the html file containning the objects you will define.


III.	Specification:

   Define the following class and minimum members:


    Class/	Super Class	Members (minimum request)
   Interface     & interfac
=============   ==============  =======================================
   Names        Object		Interface containing constant names such
				first names, last names, department names
				and etc.

   Member 	Object		public default constructor
		Comparable	public void generate();
				public String toString();
				public String toString( boolean );
				public int    compareTo(Member);
				public String htmlRow();
				public String htmlColumns();
				other necessay methods....
				protected String firstName, lastName; long ID;

   Student	Member		public default constructor
				public void generate();
				public String toString();
				public String toString( boolean);
				public String htmlRow();
				public String htmlColumns();
				other necessay methods....
				protected String major; float GPA;

   Employee	Member		public default constructor
				public void generate();
				public String toString();
				public String toString( boolean);
				public String htmlRow();
				public String htmlColumns();
				other necessay methods....
				protected String department; int yearHired;

   Faculty	Employee        public default  constructor
				public void generate();
				public String toString();
				public String toString(boolean);
				public String htmlRow();
				public String htmlColumns();
				other necessay methods....
				protected String degreeHeld;

   Staff        Employee        public default constructor
				public void generate();
				public String toString();
				public String toString(boolean);
				public String htmlRow();
				public String htmlColumns();
				other necessay methods....
				protected String jobTitle;

---------------------------------------------------------------------------

	Write a program which displays the following line:


	Enter H/h/? for help, or command : 


   When H/h/? is entered, the following menu is printed:

		================ CS 394 Homework 1 ===============
		G/g:   Ask for a N, and generate N members of mixed
               Member class's objects, and store in a List 
		       and a array Objects.

		S/s/ : Sort the members in the List and array in
               ascending order.

		V/v/ : Show the members in the List and array .

		O/o/ : Save objects inside List into a HTML file
		       with objects saved in the format of HTML
		       Table.
               
		F/f  : Show HTML file contents on screen.

		L/l  : Launch the default internet browser to
		       display the generated HTML file.
		--------------------------------------------------
		H/h/?: Display this menu.
		E/e  : Exit
		=================================================
  To launch the default browser for opening a html file:

    -- Store the file, say hw01.html, in the currenct director ( the directory
       with the C# source files ).
   -- Use the following code: 
    -----------------------------------------------------
    public static void showHTMLFile( String fileName ) {
       if(Desktop.isDesktopSupported()) {
	      try {
	         File file = new File( fileName ); // fileNae example: "hw01.html".
	         Desktop.getDesktop().browse( file.toURI() );
	      } catch ( Exception e ) { e.printStackTrace(); }
      }
    }
   ------------------------------------------------------


IV.	Things worth to mention:

  1. Install .Net Core https://dotnet.github.io/
  2. Randomly generate mixed N members (including its subclass objects).
     When an object is generated, add the N members into List and array.
  3. An class can 'extends' one class and can 'implements' many interfaces.
  4. An interface can 'extends' many interfaces.
  5. Methods in interfaces are always abstract and public even if you don't
     specify them that way.
  6. Data members in interface are always static and final even if you don't
     specify that way.
  7. A abstrat function is function begun with 'abstract' or any function defined
     in an interface.
  8. When a class implements an interface and the class doesnt implement all
     function in the interface, the class is an abstract.
  9. Abstract class can be used to define a variable but cannot be used to
     instanciate a variable. That is, you cannot use interface or abstact as
     operand of the 'new' operator.
  10. Always use a search engine (such as google) on any question you may have.
     For example, type "how to launch browser in C#" to search for what you
     want.
  11. https://msdn.microsoft.com/en-us/library/dybz98h0%28v=vs.71%29.aspx
  1v2. https://msdn.microsoft.com/en-us/library/618ayhy6.aspx 

V.	Files Available

	Names.cs : interface contain names of members, department, sports.

VI.	CLASSPATH Environment Variable



VII.	How to turn in your C# programs

    One C# project may spread in several files. Sending individual files to
the instructor will be a big burden to him/her. Here is how can you put all
C# source files into one tar file and mail to me as attachment.

	1. Always create a subdirctory for each homework in a separate
	   sub-directory. Move the source codes that you don't need to
	   turn in into my_cs_class subdirectory and add my_cs_class
       directory into into environment variable CLASSPATH.

	2. Zip all required files into a zip file:

		$ zip FLxxxdd.zip *.cs

	   where 'F' is the your first inital, "Lxxx" is the first 4 letter
	   of your last name, and "dd" is two digits indicating the homewok
	   number, such as 01, 02 and etc.

           Make sure you have all the C# files in the same subdirectory
           and issue the zip commend in that subdirectory.

        3. Verify the all files are included by
		- Create a subdirectoy,
		- move the zip file the subdirectory,
		- unzip it (unzip FLxxx01.zip)
		- compile your C# file containing the main function
		- run it.

	4. Mail FLxxxdd.zip file with pine with the following steps:


