public class NodeManager {

    public static Node init(int size) {

        Node root = new Node($"data {size}");

        Node up = new Node($"data {2}");
        Node upup = new Node($"data {3}");

        root.setInternalNeighbor(DIRECTION.UP, up);
        up.setInternalNeighbor(DIRECTION.UP, upup);
        
        return root;
    }
}