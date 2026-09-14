using System;
using System.Linq;
using System.Runtime.CompilerServices;
 
internal class Program
{
    struct Path
    {
        public int Length {get; }
        public int ToNum { get; }
        public int FromNum { get; }
       
        public int ToIdx => ToNum -1;
        public int FromIdx => FromNum -1;
 
        public Path(int length, int from, int to)
        {
            this.Length = length;
            this.FromNum = from;
            this.ToNum = to;
        }
        public override string ToString()
        {
            return $"{FromNum} -> {ToNum} [{Length}]";
        }
    }
    static bool IsBadVilage(int villageNum, Path[] paths)
    {
        bool hasPath=false;
        bool hasSecondPath = false;
 
        foreach (var path in paths)
        {
            if (path.ToNum == villageNum || path.FromNum == villageNum)
            {
                if (!hasPath) {
                    hasPath = true;
                    continue;
                }
 
                if (hasPath)
                {
                    hasSecondPath = true;
                    break;
                }
            }
        }
 
        return !hasSecondPath;
    }
 
    static int PathsVillage(int villageNum, Path[] paths) => paths.Count(p => p.FromNum == villageNum || p.ToNum == villageNum);
 
    static int ToCivilization(int villageNum, int previousVillage, int sum, Path[] paths)
    {
        var currentVillage = villageNum;
 
        var currentVillagePaths = paths.Where(p => p.FromNum == villageNum || p.ToNum == villageNum).ToArray();
 
        if (currentVillagePaths.Length > 2) return sum;
       
        var path = currentVillagePaths.First(p => p.ToNum != previousVillage);
 
        if (path.FromNum == villageNum) return ToCivilization(path.ToNum, currentVillage, sum += path.Length, paths);
       
        return ToCivilization(path.FromNum, currentVillage, sum += path.Length, paths);
    }
 
    static void Main()
    {
        string[] lines = File.ReadAllLines("falvak.be");
        string[] firstLine = lines[0].Split(" ");
 
        int[] villages = new int[int.Parse(firstLine[0])];
        for (int i = 0; i < villages.Length; i++)
        {
            villages[i] = i+1;
        }
 
        Path[] paths = new Path[int.Parse(firstLine[1])];
 
        for (int i = 1; i < paths.Length+1; i++)
        {
            string[] line = lines[i].Split(" ");
            int from = int.Parse(line[0]);
            int to = int.Parse(line[1]);
            int length = int.Parse(line[2]);
 
            paths[i-1] = new Path(length, from, to);
        }
 
       
 
        List<int> badVillages = villages.ToList().Where(v => IsBadVilage(v, paths) && PathsVillage(v, paths) != 0).ToList();
        int largestCount = 0;
        foreach (var v in badVillages)
        {
            int distance = ToCivilization(v, -1, 0, paths);
            if (distance > largestCount) largestCount = distance;
        }
 
       
    }
}