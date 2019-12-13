#include "allcourses.h"
#include <iostream>

using namespace std; 
 

LinkedList :: LinkedList()
{
    this->length = 0;
    this->head = NULL;
}

LinkedList :: ~LinkedList()
{
    cout << "LIST DELETED." << endl;
}

// insert new_node at the end of the linked list
void LinkedList::insertEnd(string value) 
{ 
    // If the list is empty, create a single node 
    if (this->head == NULL) 
    { 
        Node* new_node = new Node(); 
        new_node->data = value; 
        new_node->next = new_node->prev = this->head; 
        this->head = new_node; 
        this->length++; 
        return; 
    } 
  
    // If list is not empty 
    Node *last = head->prev; 
  
    // Create Node
    Node *new_node = new Node(); 
    new_node->data = value; 
  
    // new_node -> next points to head 
    new_node->next = this->head; 
  
    // head -> prev points to new_node for doubly linked insertion 
    this->head = new_node; 
  
    // Make last previous of new node 
   // new_node->prev = last; 
  
    // Make new node next of old last 
    //new_node = last->next; 

    this->length++;
} 
  /*
// insert new_node at the beginning of the linked list
void LinkedList::insertBegin(string value) 
{ 
    // Pointer points to last Node 
    Node *last = (*head)->prev; 
  
   // create node
    Node *new_node = new Node; 
    new_node->data = value;
  
    // inserts new_node so its doubly linked
    new_node->next = *head; 
    new_node->prev = last; 
  
    // Update ptrs next and last
    last->next = (*head)->prev = new_node; 
  
    // Update head pointer 
    *head = new_node; 


}   
  */
void LinkedList::display() 
{ 
    Node *head = this->head; 
  
    // forward iterative print
    cout << "Traversal in forward direction:" << endl; 
    while (head) 
    { 
        cout << head->data << endl;
        head = head->next; 
    } 
   // cout << head->data << endl; 
  
  /*
    // backward iterative print
    cout << "Traversal in reverse direction:" << endl; 
    Node *last = head->prev; 
    head = last; 
    while (last) 
    { 
        cout << head->data << endl; 
        head = head->prev; 
    } 
    cout << head->data << endl; 
    */
} 

/*

// finds results matching an input value from start, store in second 'skipped' list start2
bool LinkedList::search(string value) 
{ 
    // Node *temp = head;
    Node *last = (*head)->prev; 
    Node *temp = last->next;
     
    Node *temp2 = *head2;

    cout << "Searching for: " << value << endl;

    while(temp != NULL)
    {
        if(temp->data.find(value) != string::npos) // if temp -> data is equal to the value
        {
            cout << temp->data << endl;

            void Node::insertEnd(&temp2, temp->data);
            
            if(temp == last)
            {  
                void Node::display(temp2);
                cout << "Skipped list containing searched value: " << value << " constructed." << endl;
                return 0;
            }
        }
        else if(temp == last && temp->data.find(value) == string::npos) // if temp -> next is equal to start and temp -> data isn't equal to the value, search concluded
        {
            temp = NULL;
            cout << "Search returned no results." << endl;
            return 0;
        }
        temp = temp->next;  // iterate until value search is resolved
    }
} 
*/

  
int main() 
{ 
    /* Initialize empty list */
    LinkedList* list = new LinkedList();
    
    /* Initialize second list */

    list->insertEnd("CAS, PY212, SI II, Quantitiative Reasoning Two, CT, T/C"); 
  
    list->insertEnd("CAS, PY211, SI I, Quantitiative Reasoning One, CT, T/C"); 
   
    cout << "Circular doubly linked list & its elements constructed." << endl; 
    
    list->display();
    cout << "List length: " << list->length << endl;
    delete list;
    
    //search(&start,&start2, "Quantitiative Reasoning");

   // display(start2);
  
    return 0; 
} 

  