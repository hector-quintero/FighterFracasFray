using System;

namespace FighterFracasFray;

public class Program {
    static void Main(string[] args) {
        Map map = new Map(2);
        Coordinate coord = new Coordinate(1,0,1,0);
        Node n = map.getNode(coord);
        Console.WriteLine($"Hi {n.data}");
    }
}
