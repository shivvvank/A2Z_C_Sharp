#include<bits/stdc++.h>
using namespace std;
void dfs(int node,vector<int> adj[],vector<int>& vis,stack<int>& st)
{
    vis[node]=1;
    for(auto it : adj[node])
    {
        if(!vis[it])
        {
            dfs(it,adj,vis,st);
        }
    }
    st.push(node);
}
vector<int> topologicalSort(int n, vector<int> adj[])
{
    vector<int> tops;
    vector<int> vis(n,0);
    stack<int> st;
    for(int i = 0;i<n;i++)
    {
        if(!vis[i])
            dfs(i,adj,vis,st);
    }
    while(!st.empty())
    {
        tops.push_back(st.top());
        st.pop();
    }
    return tops;
}
int main()
{
    int n,m;
    freopen("../input.txt","r",stdin);
    cin>>n>>m;
    vector<int> adj[n];
    for(int i=0;i<m;i++)
    {
        int x,y;
        cin>>x>>y;
        adj[x].push_back(y);
    }
    vector<int> tops = topologicalSort(n,adj);
    for(auto i : tops)
    {
        cout<<i<<" ";
    }
    cout<<endl;
    return 0;
}

