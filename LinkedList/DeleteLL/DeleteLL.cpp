#include<bits/stdc++.h>
using namespace std;
class Node{
    public :
    int val;
    Node* next;
    Node(int k)
    {
        val=k;
        next=nullptr;
    }
    Node(int k,Node* nxt)
    {
        val=k;
        next=nxt;
    }
};
void printLL(Node* head)
{
    Node* temp = head;
    while(temp!=nullptr)
    {
        cout<<temp->val<<" ";
        temp=temp->next;
    }
    cout<<endl;
}
Node* insertLL(Node* head,int k)
{
    if(head==nullptr)
    {
        head = new Node(k);
        return head;
    }
    Node* temp = head;
    while(temp->next!=nullptr)
    {
        temp=temp->next;
    }
    temp->next=new Node(k);
    return head;
}
Node* deleteLL(Node* head,int k)
{
    Node* temp = head;
    Node* prev = nullptr;
    if(head->val==k)
    {
        head=head->next;
        temp->next=nullptr;
        delete(temp);
        return head;
    }
    while(temp!=nullptr&&temp->val!=k)
    {
        prev = temp;
        temp=temp->next;
    }
    if(temp==nullptr)
    {
        cout<<"Element couldn't be found in Linked list, Sorry !"<<endl;
        return head;
    }
    else
    {
        prev->next=temp->next;
        temp->next=nullptr;
        delete(temp);
    }
    return head;
}
int main(){
    cout<<"Enter number of elements to be added to LL : "<<endl;
    int n ;
    cin>>n;
    cout<<"Enter elements : "<<endl;
    Node* head = nullptr;
    int k;
    for(int i=0;i<n;i++)
    {
        
        cin>>k;
        head = insertLL(head,k);
    }
    printLL(head);
    cout<<"Enter element to be deleted : "<<endl;
    cin>>k;
    head = deleteLL(head,k);
    cout<<"Linked List after deleting "<<k<<" : "<<endl;
    printLL(head);
}