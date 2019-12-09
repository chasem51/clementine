#include <iostream>
#include <string>
#include <cstdlib>
#include <iomanip>
#include <cstdio>
using namespace std; 
  
// Structure of a Node 
class Node 
{ 
    public:
    string data; 
    Node *next; 
    Node *prev; 
}; 
  
// Function to insert at the end 
void insertEnd(Node** start, string value) 
{ 
    // If the list is empty, create a single node 
    if (*start == NULL) 
    { 
        Node* new_node = new Node; 
        new_node->data = value; 
        new_node->next = new_node->prev = new_node; 
        *start = new_node; 
        return; 
    } 
  
    // If list is not empty 
  
    /* Find last node */
    Node *last = (*start)->prev; 
  
    // Create Node dynamically 
    Node* new_node = new Node; 
    new_node->data = value; 
  
    // Start is going to be next of new_node 
    new_node->next = *start; 
  
    // Make new node previous of start 
    (*start)->prev = new_node; 
  
    // Make last preivous of new node 
    new_node->prev = last; 
  
    // Make new node next of old last 
    last->next = new_node; 
} 
  
// Function to insert Node at the beginning of the List, 
void insertBegin(Node** start, string value) 
{ 
    // Pointer points to last Node 
    Node *last = (*start)->prev; 
  
    Node* new_node = new Node; 
    new_node->data = value;   // Inserting the data 
  
    // setting up previous and next of new node 
    new_node->next = *start; 
    new_node->prev = last; 
  
    // Update next and previous pointers of start 
    // and last. 
    last->next = (*start)->prev = new_node; 
  
    // Update start pointer 
    *start = new_node; 
} 
  
// Function to insert node with value as value1. 
// The new node is inserted after the node with 
// with value2 
void insertAfter(Node** start, string value1, string value2) 
{ 
    Node* new_node = new Node; 
    new_node->data = value1; // Inserting the data 
  
    // Find node having value2 and next node of it 
    Node *temp = *start; 
    while (temp->data != value2) 
        temp = temp->next; 
    Node *next = temp->next; 
  
    // insert new_node between temp and next. 
    temp->next = new_node; 
    new_node->prev = temp; 
    new_node->next = next; 
    next->prev = new_node; 
} 
  
  
void display(Node* start) 
{ 
    Node *temp = start; 
  
    // forward iterative print
    cout << "College of ENG elements~" << endl;
    cout << "Traversal in forward direction:" << endl; 
    while (temp->next != start) 
    { 
        cout << temp->data << endl;
        temp = temp->next; 
    } 
    cout << temp->data << endl; 
  
    // backward iterative print
    cout << "College of ENG elements~" << endl;
    cout << "Traversal in reverse direction:" << endl; 
    Node *last = start->prev; 
    temp = last; 
    while (temp->prev != last) 
    { 
        cout << temp->data << endl; 
        temp = temp->prev; 
    } 
    cout << temp->data << endl; 
} 


bool search(Node** start, string value) 
{ 

    Node *temp = *start;
    Node *last = (*start)->prev; 

    cout << "Searching for: " << value << endl;

    while(temp->next != NULL)
    {
        if(temp->data.find(value) != string::npos)
        {
            cout << temp->data << endl;
            break;
        }
        temp = temp->next;  // interate until NULL if value doesnt match
    }
    
    if(temp->next == NULL)
    {
        cout << "Search returned no results." << endl;
    }
} 

  
int main() 
{ 
    /* Initialize empty list */
    Node* start = NULL; 

    insertEnd(&start, "CAS, PY212, SI II, QR II, CT, T/C"); 
  
    insertEnd(&start, "CAS, PY211, SI I, QR I, CT, T/C"); 
   
    cout << "Circular doubly linked list & its elements constructed." << endl; 
    display(start); 
    
    search(&start,"PY211");
  
    return 0; 
} 