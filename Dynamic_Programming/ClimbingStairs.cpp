#include<bits/stdc++.h>
using namespace std;
int climbStairs(int n,vector<int>& dp)
{
    if(n==1)
        return dp[n]=1;
    if(n==2)
        return dp[n]=2;
    dp[n-1]=climbStairs(n-1,dp);
    dp[n-2]=climbStairs(n-2,dp);
    return dp[n]=dp[n-1]+dp[n-2];
}
int climbStairsIterative(int n,vector<int>& dp)
{
    for(int i = 0;i<=n;i++)
    {
        if(i==0)
        {
            dp[i]=0;
        }
        else if(i==1)
        {
            dp[i]=1;
        }
        else{
            dp[i]=dp[i-1]+dp[i-2];
        }
    }
    return dp[n];
}
int main()
{
    int n ;
    freopen("input.txt","r",stdin);
    cin>>n;
    vector<int> dp(n+1,-1);
    cout<<climbStairs(n,dp)<<endl;
    for(auto i : dp)
    {
        cout<<i<<" ";
    }
    cout<<endl;
    return 0;
}