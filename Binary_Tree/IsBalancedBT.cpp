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
vector<int> preorder(Node* root)
{
    vector<int> pre;
    stack<Node*> st;
    if(root==nullptr)
        return pre;
    st.push(root);
    while(!st.empty())
    {
        Node* temp = st.top();
        st.pop();
        pre.push_back(temp->val);
        if(temp->right!=nullptr)
            st.push(temp->right);
        if(temp->left!=nullptr)
            st.push(temp->left);
    }
    return pre;
}
int IsBalanced(Node* root,bool& flag)
{
    if(root==nullptr)
        return 0;
    if(flag==false)
        return 0;
    int lh = IsBalanced(root->left,flag);
    int rh = IsBalanced(root->right,flag);
    if(abs(lh-rh)>1)
        flag=false;
    return 1+max(lh,rh);
}
int main(){
    Node* root = createBT();
    bool flag=true;
    IsBalanced(root,flag);
    if(flag)
        cout<<"Binary tree is balanced"<<endl;
    else 
        cout<<"Binary tree is not balanced"<<endl;
    return 0;
}
/*

            1
        2       3
    4       56      7
8

preorder - 1 2 4 8 5 3 6 7 
*/