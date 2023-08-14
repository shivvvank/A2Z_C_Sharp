#include<bits/stdc++.h>
using namespace std;
int uniquePathsWithObstacles(vector<vector<int>>& grid) {
    int n = grid.size();
    int m = grid[0].size();
    vector<vector<int>> dp(n,vector<int>(m,0));
    int k=0;
    while(k<n&&grid[k][0]!=1)
    {
        dp[k][0]=1;
        k++;
    }
    k=0;
    while(k<m&&grid[0][k]!=1)
    {
        dp[0][k]=1;
        k++;
    }
    for(int i = 1;i<n;i++)
    {
        for(int j=1;j<m;j++)
        {
            if(grid[i][j]==1)
                dp[i][j]=0;
            else
                dp[i][j]=dp[i-1][j]+dp[i][j-1];
        }
    }
    return dp[n-1][m-1];
}
int main()
{
    freopen("input.txt","r",stdin);
    int n,m;
    cin>>n>>m;
    vector<vector<int>> grid(n,vector<int>(m,0));
    for(int i = 0;i<n;i++)
    {
        for(int j=0;j<m;j++)
        {
            cin>>grid[i][j];
        }
    }
    cout<<uniquePathsWithObstacles(grid)<<endl;
    return 0;
}