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
vector<int> zigzag(Node* root)
{
    vector<int> pre;
    queue<Node*> q;
    q.push(root);
    int flag = 0;
    while(!q.empty())
    {
        int size = q.size();
        vector<int> temporder;
        for(int i=0;i<size;i++)
        {
            Node* temp = q.front();
            q.pop();
            temporder.push_back(temp->val);
            if(temp->left)
                q.push(temp->left);
            if(temp->right)
                q.push(temp->right);
        }
        if(flag==0)
        {
            for(int i=0;i<temporder.size();i++)
            {
                pre.push_back(temporder[i]);
            }
            flag=1;
        }
        else
        {
            for(int i=temporder.size()-1;i>=0;i--)
            {
                pre.push_back(temporder[i]);
            }
            flag=0;
        }
    }
    return pre;
}
int main(){
    Node* root = createBT();
    vector<int> pre = zigzag(root);
    for(int i = 0;i<pre.size();i++)
        cout<<pre[i]<<" ";
    cout<<endl;
    return 0;
}

/*
            1
        2       3
    4       56      7
8
preorder - 1 2 4 8 5 3 6 7
*/