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

class LinkedList : public Node
{
    public:
    int length;
    Node *head;
    Node *end;
    LinkedList();
    ~LinkedList();
    void insertEnd(string value);
    void display(Node *head); 
};

bool search(string  value, LinkedList &, LinkedList &); 


#endif
