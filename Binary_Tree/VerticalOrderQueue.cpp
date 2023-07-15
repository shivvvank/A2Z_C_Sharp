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
void preorder(Node* root)
{
    if(root==nullptr)
        return;
    cout<<root->val<<" ";
    preorder(root->left);
    preorder(root->right);
}
vector<int> verticalOrder(Node* root)
{
    queue<pair<Node*,int>> q;
    q.push({root,0});
    map<int,int> m;
    vector<int> ans;
    while(!q.empty())
    {
        Node* temp = q.front().first;
        int col = q.front().second;
        q.pop();
        if(m.find(col)==m.end())
        {
            m[col]=temp->val;
        }
        if(temp->left)
        {
            q.push({temp->left,col-1});
        }
        if(temp->right)
        {
            q.push({temp->right,col+1});
        }
    }
    for(auto i : m)
    {
        ans.push_back(i.second);
    }
    return ans;
}
int main(){
    Node* root = createBT();
    vector<int> ans = verticalOrder(root);
    for(auto i : ans)
    {
        cout<<i<<" ";
    }
    cout<<endl;
    return 0;
}
/*

            1
        2       3
    4       56      7
8
preorder - 
*/