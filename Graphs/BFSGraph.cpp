#include<bits/stdc++.h>
using namespace std;
vector<int> bfs(vector<int> adj[],int n)
{
    queue<int> q;
    vector<int> bfs;
    vector<int> vis(n+1,0);
    q.push(2);
    vis[2]=1;
    while(!q.empty())
    {
        int temp = q.front();
        q.pop();
        bfs.push_back(temp);
        for(auto i : adj[temp])
        {
            if(!vis[i])
            {
                q.push(i);
                vis[i]=1;
            }
        }
    }
    return bfs;
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
    for(int i=1;i<=n;i++)
    {
        cout<<i<<" : ";
        for(auto j : adj[i])
        {
            cout<<j<<", ";
        }
        cout<<endl;
    }
    vector<int> ans = bfs(adj,n);
    for(auto i : ans)
    {
        cout<<i<<" ";
    }
    cout<<endl;
    return 0;
}