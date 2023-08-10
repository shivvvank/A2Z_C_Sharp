#include<bits/stdc++.h>
using namespace std;
vector<int> dp(100,-1);
int minEnergyFrogJumps(int n,vector<int> &v)
{
    if(n==v.size()-1)
    {
        return 0;
    }
    if(dp[n]!=-1)
        return dp[n];
    if(n+1<v.size())
        dp[n+1]=minEnergyFrogJumps(n+1,v);
    if(n+2<v.size())
        dp[n+2]=minEnergyFrogJumps(n+2,v);
    dp[n] = min(dp[n+1]+abs(v[n+1]-v[n]),dp[n+2]+abs(v[n]-v[n+2]));
    return dp[n];
}
int main()
{
    freopen("input.txt","r",stdin);
    int n;
    cin>>n;
    vector<int> v(n,0);
    for(int i = 0;i<n;i++)
    {
        cin>>v[i];
    }
    cout<<minEnergyFrogJumps(0,v)<<endl;
    return 0;
}