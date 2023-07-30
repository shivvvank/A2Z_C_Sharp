#include<bits/stdc++.h>
using namespace std;
bool detectCycle(vector<int> adj[],int n,int m)
{
    queue<pair<int,int>> q;
    vector<int> vis(n+1,0);
    vis[1]=1;
    q.push({1,-1});
    while(!q.empty())
    {
        int node = q.front().first;
        int parent = q.front().second;
        q.pop();
        for(int i=0;i<adj[node].size();i++)
        {
            if(!vis[adj[node][i]])
            {
                vis[adj[node][i]]=1;
                q.push({adj[node][i],node});
            }
            else if(adj[node][i]!=parent)
            {
                return false;
            }
        }
    }
    return true;
}
int main()
{
    int n,m;
    freopen("../input.txt","r",stdin);
    cin>>n>>m;
    vector<int> adj[n+1];
    for(int i=0;i<m;i++)
    {
        int x,y;
        cin>>x>>y;
        adj[x].push_back(y);
        adj[y].push_back(x);
    }
    if(!detectCycle(adj,n,m))
        cout<<"Contains Cycle\n";
    else
        cout<<"No Cycle\n";
    return 0;
}