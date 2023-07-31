#include<bits/stdc++.h>
using namespace std;
vector<int> kahnsTopSort(int n ,vector<int> adj[])
{
    vector<int> tops;
    vector<int> indegree(n,0);
    queue<int> q;
    for(int i = 0;i<n;i++)
    {
        for(auto it : adj[i])
        {
            indegree[it]++;
        }
    }
    for(int i =0;i<n;i++)
    {
        if(indegree[i]==0)
            q.push(i);
    }
    while(!q.empty())
    {
        int node = q.front();
        q.pop();
        tops.push_back(node);
        for(auto i : adj[node])
        {
            indegree[i]--;
            if(indegree[i]==0)
                q.push(i);
        }
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
    vector<int> tops = kahnsTopSort(n,adj);
    for(auto i : tops)
    {
        cout<<i<<" ";
    }
    cout<<endl;
    return 0;
}
