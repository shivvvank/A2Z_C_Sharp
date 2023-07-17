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
void postorder(Node* root)
{
    if(root==nullptr)
        return;
    postorder(root->left);
    postorder(root->right);
    cout<<root->val<<" ";
}
Node* buildTree(vector<int>& post,int poststart,int postend,vector<int>& in,int instart,int inend,unordered_map<int,int>& m)
{
    if(poststart>postend||instart>inend)
        return nullptr;
    int rootval = post[postend];
    int ind = m[rootval];
    int x = ind-instart-1;
    Node* root = new Node(rootval);
    Node* lefty = buildTree(post,poststart,poststart+x,in,instart,ind-1,m);
    Node* righty = buildTree(post,poststart+x+1,postend-1,in,ind+1,inend,m);
    root->left = lefty;
    root->right = righty;
    return root;
}
int main(){
    vector<int> post,in;
    int n ;
    unordered_map<int,int> mapin;
    cout<<"Enter size :"<<endl;
    cin>>n;
    cout<<"Enter postorder "<<endl;
    for(int i =0;i<n;i++)
    {
        int x;
        cin>>x;
        post.push_back(x);
    }
    cout<<"Enter inorder"<<endl;
    for(int i =0;i<n;i++)
    {
        int x;
        cin>>x;
        in.push_back(x);
        mapin[x]=i;
    }
    int poststart = 0, postend=n-1,instart=0,inend=n-1;
    Node* root = buildTree(post,poststart,postend,in,instart,inend,mapin);
    postorder(root);
    cout<<endl;
    return 0;
}

// 40 50 20 60 30 10 

// 40 20 50 10 60 30 