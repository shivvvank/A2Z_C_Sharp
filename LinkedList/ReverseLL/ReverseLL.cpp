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
// 1  2 -> 3 -> 4 -> 5
Node* reverseLL(Node* head)
{
    Node* prevNode = nullptr;
    Node* curNode = head;
    Node* nextNode = head->next;
    while(nextNode!=nullptr)
    {
        curNode->next=prevNode;
        prevNode=curNode;
        curNode=nextNode;
        nextNode=nextNode->next;
    }
    curNode->next=prevNode;
    head=curNode;
    return curNode;
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
    cout<<"After inserting"<<endl;
    printLL(head);
    head = reverseLL(head);
    cout<<"Linked List reversing : "<<endl;
    printLL(head);
}