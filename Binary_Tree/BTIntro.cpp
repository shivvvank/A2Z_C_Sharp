#include<bits/stdc++.h>
using namespace std;
class Node{
    public : 
    int val;
    Node* left;
    Node* right;
    Node(int val)
    {
        this->val=val;
        this->left=nullptr;
        this->right=nullptr;
    }
    Node(int val,Node* left,Node* right)
    {
        this->val=val;
        this->left=left;
        this->right=right;
    }
};
Node* createBT()
{
    Node* root = new Node(1);
    Node* temp1 = new Node(2);
    Node* temp2 = new Node(3);
    Node* temp3= new Node(4);
    Node* temp4 = new Node(5);
    Node* temp5 = new Node(6);
    Node* temp6 = new Node(7);
    Node* temp7 = new Node(8);
    root->left = temp1;
    root->right = temp2;
    temp1->left = temp3;
    temp1->right = temp4;
    temp2->left = temp5;
    temp2->right = temp6;
    temp3->left = temp7;
    return root;
}
int main(){
    Node* root = createBT();
    return 0;
}