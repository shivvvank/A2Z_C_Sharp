#include<bits/stdc++.h>
using namespace std;
pair<int,vector<vector<int>>> createGraph()
{
    int m,n;
    vector<vector<int>> edges;
    cout<<"Enter number of Nodes : "<<endl;
    cin>>n;
    cout<<"Enter the number of edges : "<<endl;
    cin>>m;
    for(i=0;i<m;i++)
    {
        vector<int> temp;
        int t1,t2;
        cin>>t1>>t2;
        temp.push_back(t1);
        temp.push_back(t2);
        edges.push_back(temp);
    }
    return {n,edges};
}
int main()
{
    pair<int,vector<vector<int>>> t = createGraph(); 
    int n = t.first;
    vector<vector<int>> edges = t.second;
    vector<int> adj[n+1];
    for(int i=0;i<edges.size();i++)
    {
        adj[edges[i][0]].push_back(edges[i][1]);
        adj[edges[i][1]].push_back(edges[i][0]);
    }
    return 0;
}