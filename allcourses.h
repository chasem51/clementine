#ifndef ALL_COURSES_H
#define ALL_COURSES_H
#include <string>
#include <cstdlib>

using namespace std;
  
// Structure of a Node 
class Node
{ 
    public:
    string data; 
    Node *next; 
    Node *prev;
};

class LinkedList
{
    public:
    int length;
    Node *head;
    LinkedList();
    ~LinkedList();
    void insertEnd(string value);
    void insertBegin(string value);
    void display();
    bool search(string value);  
};

#endif
