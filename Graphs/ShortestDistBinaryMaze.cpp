#include<bits/stdc++.h>
using namespace std;
vector<int> bf(vector<pair<int,int>> adj[],int n)
{
    vector<int> dist(n,1e9);
    dist[0]=0;
    // {dist, node}
    priority_queue<pair<int,int>,vector<pair<int,int>>,greater<pair<int,int>>> pq;
    pq.push({0,0});
    while(!pq.empty())
    {
        int dis = pq.top().first;
        int node = pq.top().second;
        pq.pop();
        for(auto it : adj[node])
        {
            int tnode = it.first;
            int tdist = it.second;
            if(dis+tdist<dist[tnode])
            {
                dist[tnode]=dis+tdist;
                pq.push({dist[tnode],tnode});
            }
        }
    } 
    return dist;
}
int main()
{
    int n,m;
    freopen("../input.txt","r",stdin);
    cin>>n>>m;
    vector<pair<int,int>> adj[n]; //Adjacency list
    for(int i=0;i<m;i++)
    {
        int x,y,z;
        cin>>x>>y>>z;
        adj[x].push_back({y,z});
        adj[y].push_back({x,z});
    }
    vector<int> ans = bf(adj,n);
    for(auto i : ans)
    {
        cout<<i<<" ";
    }
    cout<<endl;
    return 0;
}