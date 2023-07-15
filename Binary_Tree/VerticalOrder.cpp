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
map<int,vector<int>> verticalOrder(Node* root)
{
    stack<pair<Node*,int> > st;
    st.push({root,0});
    map<int,vector<int>> m;
    while(!st.empty())
    {
        Node* temp = st.top().first;
        int col = st.top().second;
        st.pop();
        if(m.find(col)==m.end())
        {
            vector<int> temp;
            m[col]=temp;
        }
        m[col].push_back(temp->val);
        if(temp->left)
        {
            st.push({temp->left,col-1});
        }
        if(temp->right)
        {
            st.push({temp->right,col+1});
        }
    }
    return m;
}
int main(){
    Node* root = createBT();
    preorder(root);
    cout<<endl;
    map<int,vector<int>> m = verticalOrder(root);
    for(auto i : m)
    {
        cout<<"COLUMN : "<<i.first<<endl;
        for(int j = 0;j<i.second.size();j++)
        {
            cout<<i.second[j]<<" ";
        }
        cout<<endl;
    }
    return 0;
}
/*

            1
        2       3
    4       56      7
8
preorder - 
*/