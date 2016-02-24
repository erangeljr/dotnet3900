          Assignment 2: Implmentation of Linked List Structures
                             Eddie Rangel


I.     Purpose: OOP & Doubly Linked List Data Structures, and Generic Classes in C#

II.     Program Description:

   The exercise is aimed at practicing the object-oriented
programming methodology and the implementation of linked list data
structures in C#.

   The OOP features, data encapsulation, inheritance, polymorphism and
generic classes will be used. The basic doubly-linked list structures including
List, Stack, Queue and sorted queue will be defined using C# reference type.


III.     Specification:

   Define the following generic classes with at least the following members with
the following structures:

  // In file MyList.C# 
  public class MyList<C> {

     // Two inner classes
     protected class Node {
       // Node constructor, data and function members
       ....
     }

     protected class ListIterator implements Iterator<C> {
       // ListerIterator's constructor, data and function members
       ....
     }

     // Mylist constructors, data and function members
     .....

  }
     
  // In file MyStack.C#
     
  pulic class MyStack<C> extends MyList<C>{
     // MyStack's function memebers and overriding MyList's insert() and
     // remove member functions so that the two functions will not be
     // called from my stack. All other functions will be inherited here.
     // Don't define inner classes, and related functions, they are inherited.
  }

  // In file MyQueue.C#
 
  pulic class MyQueue<C> extends MyList<C>{  ... }

  // In file SortedQueue.C#

  pulic class SortedQueue<C> extends MyList<C>{ ... }

--------------------------------------------------------------------------
               Specifictions of Classes and Their Members
..............|...............+...........................................
   Class      | Base class    | Members
--------------+------------------------------------------------------------
  
   Node       | Object        | Node class is an inner class of MyList
                                public constructor(s)
                                T info; Node next, previous;

  ListIterator Iterator<C>      An inner class of MyList
                                public ListIterator( booleam dir );
                                protected Node currentNode;
                                protected bool forward;
                                public boolean hasNext();
                                public E     next();
                                public void    remove(); // optional

   MyList<C>   Object,          public constructor(s)
                                Iterable<C>     protected Node<C> front, rear; int count;
                                public boolean empty();
                                public int     size();
                                void     insert(C obj, int position);
                                C remove( int position );

                                // MyList methods.
                                public Iterator<C> iterator() { iterator( true ); }
                                public Iterator<C> iterator(boolean direction) {
                                         return ListIterator( direction );
                                } 

  MyStack<T>    MyList<T>       A derived class of MyList
                                public constructor(s)
                                void     push( T obj );
                                public T     pop();
                                T     top(); // return object on top without removing it

  MyQueue<T>    MyList<T>       A derived class of MyList
                                public constructor(s)
                                public void     enque( T ) ; // to the end.
                                public T     deque(); // remove object from front. 

  SortedQueue<T>  MyList<T>     A derived class of MyList
                                public constructors
                                public void insert( T obj ); // Keep queue sorted keys.
                                public T remove ( T obj);

Notice that the insert() and remove() must be hidden in the derived MyStack,
MyQueue and SortedQueue classs.
------------------------------------------------------------------------------


     Write a program which displays the following line:


     Enter H/h/? for help, or command : 


   When H/h/? is entered, the following menu is printed:

          +===================================================+
          |    CS 394 Assignment:   Linked List Structures    | 
          +===================================================+
          | G: Ask for a N, and generate N members of mixed   |
          |     kinds and put them into three list structures.|
          |     Make sure you destroy the lists before create |
          |     new ones if the lists are not empty.          |
          +---------------------------------------------------+
          | R: Ask for boolean value (true/false) set iterator|
          |    directoion to forward or backward.             | 
          +---------------------------------------------------+
          | S: List members in stack, 1 memebr per line,      |
          |     20 members per screen with header line, allow |
          |     Q/q to quit listing after each 20 members.    |
          +---------------------------------------------------+
          | Q: List members in queue (same requirements).     |
          +---------------------------------------------------+
          | O: List members in ordered queue sorted by SSN    |
          |    (same requirements).                           |
          |                                                   |
          +---------------------------------------------------+
          | D: Remove first element from queue, pop member    |
          |    from stack, and delete the same member from    |
          |    sorted queue as the one removed from stack.    |
          |                                                   |
          +---------------------------------------------------+
          | I: Randomly generate new member, and put          |
          |    the object into the three structures. Print    |
          |    out the new member added in.                   |
          +---------------------------------------------------+
          | H/?: Display this menu.                           |
          | E  : Exit                                         |
          +===================================================+

IV.     Things worth to mention:

  1. Randomly generate mixed N members (including Member's subclass objects).
     When an object is generated, insert the the same node in each of
     the three data structures, so that all data structures contains
     the same set of members but in different order.
  2. An class can 'extends' one class and can 'implements' many interfaces.
  3. An interface can 'extends' many interfaces.
  4. Methods in interfaces are always abstract and public even if you don't
     specify them that way.
  5. Data members in interface are always static and final even if you don't
     specify that way.
  6. A abstrat function is function begun with 'abstract' or any function defined
     in an interface.
  7. When a class implements an interface and the class doesnt implement all
     function in the interface, the class is an abstract.
  8. Abstract class can be used to define a variable but cannot be used to
     instanciate a variable. That is, you cannot use interface or abstact as
     operand of the 'new' operator.

V.     Available Filess

    Refer to homework 1


VI.     CLASSPATH Environment Variable 

    Refer to homeowrk 1

VII.     How to turn in your assingment

    Refer to homework 1
