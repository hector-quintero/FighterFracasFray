public class NodeManager {

    public static Node init(int size) {

        Node root = new Node($"data {size}");

        DIRECTION[] directions = (DIRECTION[])(Enum.GetValues(typeof(DIRECTION)));
        for(int i = 0; i < directions.Length; ++i)
        {
            if(directions[i] == DIRECTION.NONE) continue;

            Node n = new Node($"data {i}");
            root.setInternalNeighbor(directions[i], n);
            n.setInternalNeighbor(directions[i].getOpposite(), root);
        }

        for(int i = 0; i < directions.Length; ++i)
        {
            if(directions[i] == DIRECTION.NONE) continue;

            Node n = root.getNeighbor(new NeighborDirection(directions[i], 1));
            Node n2 = root.getNeighbor(new NeighborDirection(directions[(i + 1) % (directions.Length-1)], 1));
            int dirIndex = (i + 2) % (directions.Length-1);
            n.setInternalNeighbor(directions[dirIndex], n);
            n.setInternalNeighbor(directions[dirIndex].getOpposite(), root);
        }


        return root;
    }
}