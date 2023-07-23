#include<bits/stdc++.h>
using namespace std;
int noOfProvinces(vector<int> *adj,int n)
{
    queue<int> q;
    vector<int> vis(n+1,0);
    int count=0;
    for(int i=1;i<=n;i++)
    {
        if(vis[i])
            continue;
        count++;
        q.push(i);
        vis[i]=1;
        while(!q.empty())
        {
            int temp = q.front();
            q.pop();
            vis[temp]=1;
            for(auto j : adj[temp])
            {
                if(!vis[j])
                {
                    q.push(j);
                    vis[j]=1;
                }
            }
        }
    }
    return count;
}
int main()
{
    freopen("../input.txt","r",stdin);
    int n,m;
    cin>>n>>m;
    vector<int> adj[n+1];
    for(int i=0;i<m;i++)
    {
        int x,y;
        cin>>x>>y;
        adj[x].push_back(y);
        adj[y].push_back(x);
    }
    cout<<"Number of provinces : "<<noOfProvinces(adj,n)<<endl;
    return 0;
}