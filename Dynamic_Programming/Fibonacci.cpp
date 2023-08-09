#include<bits/stdc++.h>
using namespace std;
int fibonacci(int n, vector<int>& dp)
{
    if(n==0)
        return dp[n]=0;
    if(n==1)
        return dp[n]=1; 
    if(dp[n]!=-1)
        return dp[n];
    dp[n-1]=fibonacci(n-1,dp);
    dp[n-2]=fibonacci(n-2,dp);
    dp[n]=dp[n-1]+dp[n-2];
    return dp[n];
}
int main()
{
    int n;
    freopen("input.txt","r",stdin);
    cin>>n;
    vector<int> dp(n+1,-1);
    fibonacci(n,dp);
    for(auto i : dp)
    {
        cout<<i<<" ";
    }
    cout<<endl;
    return 0;
}
