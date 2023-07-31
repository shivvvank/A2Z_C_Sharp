#include<bits/stdc++.h>
using namespace std;
    void dfs(int in,vector<int> adj[],vector<int>& vis,vector<int>& score,int& maxi)
    {
        vis[in]=1;
        for(auto i : adj[in])
        {
            if(!vis[i])
            {
                dfs(i,adj,vis,score,maxi);
            }
            score[i]+=in;
            maxi = max(maxi,score[i]);
        }
    }
    int edgeScore(vector<int>& edges) 
    {
        int n= edges.size();
        vector<int> adj[n];
        vector<int> score(n,0);
        vector<int> vis(n,0);
        for(int i = 0;i<n;i++)
        {
            adj[i].push_back(edges[i]);
        }
        int maxi = INT_MIN;
        for(int i =0;i<n;i++)
        {
            if(!vis[i])
            {
                dfs(i,adj,vis,score,maxi);
            }
        }
        for(int i =0;i<n;i++)
            cout<<score[i]<<" ";
        cout<<endl;
        return 0;
    }
int main()
{
    freopen("../input.txt","r",stdin);
    int n;
    cin>>n;
    vector<int> v;
    for(int i=0;i<n;i++)
    {
        int x;
        cin>>x; 
        v.push_back(x);
    }
    cout<<edgeScore(v)<<endl;
    return 0;
}