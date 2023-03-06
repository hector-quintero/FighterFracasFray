public class Map {
    private int size;
    private Node root;

    public Map(int size) {
        this.size = size;
        this.root = NodeManager.init(size);
    }

    public Node getNode(Coordinate coord) {
        return root.getNeighbor(coord.first()).getNeighbor(coord.second());
    }
}