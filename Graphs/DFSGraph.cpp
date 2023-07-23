#include<bits/stdc++.h>
using namespace std;
void helper(vector<int> adj[],vector<int>& ans,int item,vector<int>& vis)
{   
    if(vis[item])
        return;
    ans.push_back(item);
    vis[item]=1;
    for(auto i : adj[item])
    {
        if(!vis[i])
        {
            helper(adj,ans,i,vis);
        }
    }
}
vector<int> dfs(vector<int> adj[],int n)
{
    vector<int> dfs;
    vector<int> vis(n+1,0);
    helper(adj,dfs,1,vis);
    return dfs;
}
int main()
{
    int n,m;
    freopen("../input.txt","r",stdin);
    cin>>n>>m;
    vector<int> adj[n+1]; //Adjacency list
    for(int i=1;i<=m;i++)
    {
        int x,y;
        cin>>x>>y;
        adj[x].push_back(y);
        adj[y].push_back(x);
    }
    vector<int> ans = dfs(adj,n);
    for(auto i : ans)
    {
        cout<<i<<" ";
    }
    cout<<endl;
    return 0;
}