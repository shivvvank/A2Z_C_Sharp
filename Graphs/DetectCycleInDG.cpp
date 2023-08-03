#include<bits/stdc++.h>
using namespace std;
// 3# ways : Kahns algorithm, DFS + Pathvis + vis, topological sort
bool dfs(int node, vector<int> adj[],vector<int>& vis,vector<int>& pathvis)
{
    vis[node]=1;
    pathvis[node]=1;
    for(auto i : adj[node])
    {
        if(!vis[i])
        {
            if(dfs(i,adj,vis,pathvis))
                return true;
        }
        else if(pathvis[i])
            return true;
    }
    pathvis[node]=0;
    return false;
}
bool isCycle(int n , vector<int> adj[])
{
    vector<int> vis(n,0);
    vector<int> pathvis(n,0);
    for(int i = 0;i<n;i++)
    {
        if(!vis[i])
        {
            if(dfs(i,adj,vis,pathvis))
                return true;
        }
    }
    return false;
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
    if(isCycle(n,adj))
        cout<<"Contains Cycle"<<endl;
    else
        cout<<"No Cycle Found"<<endl;
    return 0;
}