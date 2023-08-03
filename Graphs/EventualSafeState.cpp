#include<bits/stdc++.h>
using namespace std;
bool dfs(int ind,vector<int>& vis,vector<int>& pathvis,vector<int> adj[],vector<int>& ans)
{
    vis[ind]=1;
    pathvis[ind]=1;
    for(auto it:adj[ind])
    {
        if(!vis[it])
        {
            if(dfs(it,vis,pathvis,adj,ans))
                return true;
        }
        else if(pathvis[it])
        {
            return true;
        }
    }
    ans.push_back(ind);
    pathvis[ind]=0;
    return false;
}
vector<int> safeNode(int n,vector<int> adj[])
{
    vector<int> vis(n,0);
    vector<int> pathvis(n,0);
    vector<int> ans;
    for(int i = 0;i<n;i++)
    {
        if(!vis[i])
        {
            dfs(i,vis,pathvis,adj,ans);
        }
    }
    return ans;
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
    vector<int> ans = safeNode(n,adj);
    sort(ans.begin(),ans.end());
    for(auto i : ans)
    {
        cout<<i<<" ";
    }
    cout<<endl;
    return 0;
}