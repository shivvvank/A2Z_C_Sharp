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
int lengthLL(Node* head)
{
    Node* temp = head;
    int count = 0;
    while(temp!=nullptr)
    {
        count++;
        temp=temp->next;
    }
    return count;
}
int main(){
    cout<<"Enter number of elements to be added to LL : "<<endl;
    int n ;
    cin>>n;
    cout<<"Enter elements : "<<endl;
    Node* head = nullptr;
    for(int i=0;i<n;i++)
    {
        int k;
        cin>>k;
        head = insertLL(head,k);
    }
    printLL(head);
    cout<<"Number of elements in Linked List : "<<lengthLL(head)<<endl;
}