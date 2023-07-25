#include<bits/stdc++.h>
using namespace std;
void dfs(int a,int b,vector<vector<int>>& adj,vector<vector<int>>& vis,int n,int m)
{
    vis[a][b]=1;
    for(int i=a-1;i<=a+1;i++)
    {
        for(int j = b-1;j<=b+1;j++)
        {
            if(i>=0&&i<n&&j>=0&&j<m&&!vis[i][j]&&adj[i][j]==1)
            {
                dfs(i,j,adj,vis,n,m);
            }
        }
    }
}
int countIslands(vector<vector<int>>& adj,int& n,int& m)
{
    vector<vector<int>> vis(n,vector<int>(m,0));
    int count=0;
    for(int i=0;i<n;i++)
    {
        for(int j=0;j<m;j++)
        {
            if(adj[i][j]==1&&vis[i][j]==0)
            {
                count++;
                dfs(i,j,adj,vis,n,m);
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
    vector<vector<int>> adj(n,vector<int>(m,0));
    for(int i=0;i<n;i++)
    {
        for(int j=0;j<m;j++)
        {
            int x;
            cin>>x;
            adj[i][j]=x;
        }
    }
    cout<<countIslands(adj,n,m)<<endl;
    return 0;
}

/*

i-1 j
i-1 j-1
i-1 j+1
i j-1 
i j+1
i+1 j
i+1 j+1
i+1 j-1
*/