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
int main(){

    Node* temp = new Node(1);
    Node* head = temp;
    temp->next=new Node(2);
    printLL(head);
    return 0;  
}