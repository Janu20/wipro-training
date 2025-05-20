using System;

class DijkstraExample
{
    public static int MinDistance(int[] dist, bool[] visited, int V)
    {
        int min = int.MaxValue, minIndex = -1;

        for (int v = 0; v < V; v++)
        {
            if (!visited[v] && dist[v] <= min)
            {
                min = dist[v];
                minIndex = v;
            }
        }
        return minIndex;
    }

    public static void PrintSolution(int[] dist, int[] parent, int src, int V)
    {
        Console.WriteLine("Vertex\tDistance\tPath");
        for (int i = 0; i < V; i++)
        {
            Console.Write(src + " -> " + i + "\t" + dist[i] + "\t\t");
            PrintPath(parent, i);
            Console.WriteLine();
        }
    }

    public static void PrintPath(int[] parent, int j)
    {
        if (parent[j] == -1)
        {
            Console.Write(j + " ");
            return;
        }
        PrintPath(parent, parent[j]);
        Console.Write(j + " ");
    }

    public static void Dijkstra(int[,] graph, int src, int V)
    {
        int[] dist = new int[V];
        bool[] visited = new bool[V];
        int[] parent = new int[V];

        for (int i = 0; i < V; i++)
        {
            dist[i] = int.MaxValue;
            visited[i] = false;
            parent[i] = -1;
        }

        dist[src] = 0;

        for (int count = 0; count < V - 1; count++)
        {
            int u = MinDistance(dist, visited, V);
            visited[u] = true;

            for (int v = 0; v < V; v++)
            {
                if (!visited[v] && graph[u, v] != 0 && dist[u] != int.MaxValue &&
                    dist[u] + graph[u, v] < dist[v])
                {
                    dist[v] = dist[u] + graph[u, v];
                    parent[v] = u;
                }
            }
        }

        PrintSolution(dist, parent, src, V);
    }

    public static void Main()
    {
        int V = 5;
        int[,] graph = {
            { 0, 10, 0, 30, 100 },
            { 10, 0, 50, 0, 0 },
            { 0, 50, 0, 20, 10 },
            { 30, 0, 20, 0, 60 },
            { 100, 0, 10, 60, 0 }
        };

        Console.WriteLine("Enter source vertex (0 to 4):");
        int src = int.Parse(Console.ReadLine());

        Dijkstra(graph, src, V);
    }
}
