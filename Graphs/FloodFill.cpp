#include<bits/stdc++.h>
using namespace std;
void dfs(int n,int m,vector<vector<int>>& adj,vector<vector<int>>& vis,int i,int j,int colorval,int finalcolor)
{
    vis[i][j]=1;
    adj[i][j]=finalcolor;
    int x,y;
    x = i-1, y=j;
    if(x>=0&&x<n&&!vis[x][y]&&adj[x][y]==colorval)
    {
        dfs(n,m,adj,vis,x,y,colorval,finalcolor);
    }
    x = i+1, y=j;
    if(x>=0&&x<n&&!vis[x][y]&&adj[x][y]==colorval)
    {
        dfs(n,m,adj,vis,x,y,colorval,finalcolor);    
    }
    x = i, y=j-1;
    if(x>=0&&x<n&&!vis[x][y]&&adj[x][y]==colorval)
    {
        dfs(n,m,adj,vis,x,y,colorval,finalcolor);    
    }
    x = i, y=j+1;
    if(x>=0&&x<n&&!vis[x][y]&&adj[x][y]==colorval)
    {
        dfs(n,m,adj,vis,x,y,colorval,finalcolor);    
    }
}
void floodfill(int n,int m , vector<vector<int>>& adj,int tx,int ty,int tz)
{
    vector<vector<int>> vis(n,vector<int>(m,0));
    int colorval = adj[tx][ty];
    dfs(n,m,adj,vis,tx,ty,colorval,tz);
}
int main()
{
    int m,n;
    freopen("../input.txt","r",stdin);
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
    int tx,ty,tz;
    cin>>tx>>ty>>tz;
    floodfill(n,m,adj,tx,ty,tz);
    for(auto i : adj)
    {
        for(auto j : i)
        {
            cout<<j<<" ";
        }
        cout<<endl;
    }
    return 0;
}