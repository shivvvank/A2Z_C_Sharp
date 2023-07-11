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
vector<int> postorder(Node* root)
{
    vector<int> post;
    stack<Node*> st;
    Node* node = root;
    while(node!=nullptr||!st.empty())
    {
        if(node!=nullptr)
        {
            st.push(node);
            node=node->left;
        }
        else
        {
            Node* temp = st.top()->right;
            if(temp==nullptr)
            {
                temp = st.top();
                st.pop();
                post.push_back(temp->val);
                while(!st.empty()&&temp==st.top()->right)
                {
                    temp=st.top();
                    st.pop();
                    post.push_back(temp->val);
                }
            }
            else
            {
                node=temp;
            }
        }
    }
    return post;
}
int main(){
    Node* root = createBT();
    vector<int> post = postorder(root);
    for(int i=0;i<post.size();i++)
    {
        cout<<post[i]<<" ";
    }
    cout<<endl;
    return 0;
}
/*

            1
        2       3
    4       56      7
8

postorder - 8 4 5 2 6 7 3 1 
*/