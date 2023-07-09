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
    temp1->left = temp2;
    temp2->left = temp3;
    temp3->left = temp4;
    temp4->left = temp5;
    temp5->left = temp6;
    temp6->left = temp7;
    return root;
}
void inorder(Node* root)
{
    if(root==nullptr)
        return;
    inorder(root->left);
    cout<<root->val<<" ";
    inorder(root->right);
}
int height(Node* root)
{
    if(root==nullptr)
        return 0;
    return max(1+height(root->left),1+height(root->right));
}
int main(){
    Node* root = createBT();
    cout<<"height : "<<height(root)<<endl;
    return 0;
}