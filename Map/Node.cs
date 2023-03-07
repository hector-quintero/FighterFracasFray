public class Node {

    private Node[] neighbors = new Node[6];

    public string data { get; set; }

    public Node(string data) {
        this.data = data;
    }

    public Node getNeighbor(NeighborDirection neighDirection){
        if(neighDirection.distance == 0 && neighDirection.direction == DIRECTION.NONE) {
            return this;
        }

        if(neighDirection.distance == 1) {
            return getInternalNeighbor(neighDirection.direction);
        }

        return getInternalNeighbor(neighDirection.direction).getNeighbor(neighDirection.deduct());
    }

    private Node getInternalNeighbor(DIRECTION direction) {
        switch(direction) {
            case DIRECTION.UP:
                return neighbors[0];
            case DIRECTION.UPRIGHT:
                return neighbors[1];
            case DIRECTION.DOWNRIGHT:
                return neighbors[2];
            case DIRECTION.DOWN:
                return neighbors[3];
            case DIRECTION.DOWNLEFT:
                return neighbors[4];
            case DIRECTION.UPLEFT:
                return neighbors[5];
        }

        return null;
    }

    public void setInternalNeighbor(DIRECTION direction, Node neighbor, int depth = 1) {
        if(depth == 0) return;
        switch(direction) {
            case DIRECTION.UP:
                neighbors[0] = neighbor;
                break;
            case DIRECTION.UPRIGHT:
                neighbors[1] = neighbor;
                break;
            case DIRECTION.DOWNRIGHT:
                neighbors[2] = neighbor;
                break;
            case DIRECTION.DOWN:
                neighbors[3] = neighbor;
                break;
            case DIRECTION.DOWNLEFT:
                neighbors[4] = neighbor;
                break;
            case DIRECTION.UPLEFT:
                neighbors[5] = neighbor;
                break;
        }
        setInternalNeighbor(direction.getOpposite(), this, depth - 1);
    }

    public void setNeighborUp(Node neighbor) {
        setInternalNeighbor(DIRECTION.UP, neighbor);
    }
    public void setNeighborUpRight(Node neighbor) {
        setInternalNeighbor(DIRECTION.UPRIGHT, neighbor);
    }
    public void setNeighborUpLeft(Node neighbor) {
        setInternalNeighbor(DIRECTION.UPLEFT, neighbor);
    }
    public void setNeighborDown(Node neighbor) {
        setInternalNeighbor(DIRECTION.DOWN, neighbor);
    }
    public void setNeighborDownLeft(Node neighbor) {
        setInternalNeighbor(DIRECTION.DOWNLEFT, neighbor);
    }
    public void setNeighborDownRight(Node neighbor) {
        setInternalNeighbor(DIRECTION.DOWNRIGHT, neighbor);
    }
}