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
void preorder(Node* root)
{
    if(root==nullptr)
        return;
    cout<<root->val<<" ";
    preorder(root->left);
    preorder(root->right);
}
Node* buildTree(vector<int>& pre,int prestart,int preend,vector<int>& in,int instart,int inend,unordered_map<int,int>& m)
{
    if(prestart>preend||instart>inend)
        return nullptr;
    int rootval = pre[prestart];
    int ind = m[rootval];
    int x = ind-instart;
    Node* root = new Node(rootval);
    Node* lefty = buildTree(pre,prestart+1,prestart+x,in,instart,ind-1,m);
    Node* righty = buildTree(pre,prestart+x+1,preend,in,ind+1,inend,m);
    root->left = lefty;
    root->right = righty;
    return root;
}
int main(){
    vector<int> pre,in;
    int n ;
    unordered_map<int,int> mapin;
    cout<<"Enter size :"<<endl;
    cin>>n;
    cout<<"Enter preorder "<<endl;
    for(int i =0;i<n;i++)
    {
        int x;
        cin>>x;
        pre.push_back(x);
    }
    cout<<"Enter inorder"<<endl;
    for(int i =0;i<n;i++)
    {
        int x;
        cin>>x;
        in.push_back(x);
        mapin[x]=i;
    }
    int prestart = 0, preend=n-1,instart=0,inend=n-1;
    Node* root = buildTree(pre,prestart,preend,in,instart,inend,mapin);
    preorder(root);
    cout<<endl;
    return 0;
}