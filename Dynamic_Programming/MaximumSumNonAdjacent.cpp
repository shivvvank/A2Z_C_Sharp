#include<bits/stdc++.h>
using namespace std;
vector<int> dp;
int helper(int in,int n, int sum,vector<int>&nums)
{
    if(in<0)
    {
        return sum;
    }
    if(dp[in]!=-1)
        return dp[in];
    int x = helper(in-1,n,sum,nums);
    int y = helper(in-2,n,sum+nums[in],nums);
    dp[in]=max(x,y);
    return dp[in];
}
int maxSum(vector<int> &nums)
{
    int n = nums.size();
    dp.resize(n,-1);
    helper(n-1,n,0,nums);
    return dp[n-1];
}
// 2 1 4 9 
int maxSumIterative(vector<int>&nums)
{
    int n = nums.size();
    if(n==0)
        return 0;
    dp.resize(n,0);
    dp[0]=nums[0];
    for(int i=1;i<n;i++)
    {
        if(i-2<0)
            dp[i]=max(dp[i-1],nums[i]);
        else
            dp[i]=max(dp[i-1],dp[i-2]+nums[i]);
    }
    return dp[n-1];
}
int main()
{
    freopen("input.txt","r",stdin);
    int t,n;
    cin>>t;
    for(int j = 0;j<t;j++)
    {
        cin>>n;
        vector<int> arr(n,0);
        for(int i=0;i<n;i++)
        {
            cin>>arr[i];
        }  
        cout<<maxSumIterative(arr)<<endl;
    }
    return 0;
}