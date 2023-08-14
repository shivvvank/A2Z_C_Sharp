#include<bits/stdc++.h>
using namespace std;

int minEnergyJumps(int n,int k,vector<int>& stairs)
{
    vector<int> dp(n,0);
    for(int i=1;i<n;i++)
    {
        int minsteps = INT_MAX;
        for(int j=1;j<=k;j++)
        {   
            if(i-j>=0)
            {
                int jump = dp[i-j]+abs(stairs[i-j]-stairs[i]);
                minsteps = min(minsteps,jump);
            }
        }
        dp[i]=minsteps;
    }
    return dp[n-1];
}
int main()
{
    freopen("input.txt","r",stdin);
    int n,k;
    cin>>n>>k;
    vector<int> stairs(n,0);
    for(int i=0;i<n;i++)
    {
        cin>>stairs[i];
    }
    cout<<minEnergyJumps(n,k,stairs)<<endl;
    return 0;
}