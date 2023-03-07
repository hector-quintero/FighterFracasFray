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

        return root;
    }
}