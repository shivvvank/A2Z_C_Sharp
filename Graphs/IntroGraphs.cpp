#include<bits/stdc++.h>
using namespace std;
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
    return 0;
}