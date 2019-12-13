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

// insert temp at the end of the linked list
void LinkedList::insertEnd(string value) 
{ 
    // If the list is empty, create a single node 
    if (this->head == NULL) 
    { 
        Node* temp = new Node(); 
        temp->data = value; 
        temp->next = temp->prev = this->head; 
        this->head = temp; 
        this->length++; 
        return; 
    } 
  
    // If list is not empty 
    Node *last = this->end;
  
    // Create Node
    Node *temp = new Node(); 
    temp->data = value; 
  
    // temp -> next points to head 
    temp->next = this->head; 
  
    // head points to temp for doubly linked insertion 
    this->head = temp; 
  
    this->length++;
} 

void LinkedList::display(Node *head) 
{ 
    // forward iterative print
    cout << "Traversal in forward direction:" << endl; 
    while (head != end) 
    { 
        cout << head->data << endl;
        head = head->next; 
    } 
} 

// finds results matching an input value from start, store in second 'skipped' list start2
bool search(string value, LinkedList &list1, LinkedList &list2) 
{ 
    cout << "Searching for: " << value << endl;

    while(list1.head != NULL)
    {
        if(list1.head->data.find(value) != string::npos) // if temp -> data is equal to the value
        {
            list2.insertEnd(value);
            
            if(list1.head == list1.end)
            {  
                list2.display(list2.head);
                cout << "Number of courses matching the search: " << list2.length << endl;
                return 0;
            }
        }
        else if(list1.head == list1.end && list1.head->data.find(value) == string::npos) // if temp -> next is equal to start and temp -> data isn't equal to the value, search concluded
        {
            list1.end = NULL;
            cout << "Search returned no results." << endl;
            return 0;
        }
        list1.head = list1.head->next;  // iterate until value search is resolved
    }
} 
  
int main() 
{ 
    /* Initialize empty list */
    LinkedList *list = new LinkedList();

    /* Initialize empty list */
    LinkedList *list2 = new LinkedList();

    list->insertEnd("CAS, PY212, SI II, Quantitiative Reasoning Two, CT, T/C"); 
  
    list->insertEnd("CAS, PY211, SI I, Quantitiative Reasoning One, CT, T/C"); 
   
    cout << "Circular doubly linked list & its elements constructed." << endl; 
    
    list->display(list->head);
    
    cout << "Number of courses: " << list->length << endl;
    
    search("Quantitiative Reasoning", list, list2);

    delete list;
    delete list2;
  
    return 0; 
} 

  