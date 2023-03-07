public enum DIRECTION {
    UP, 
    UPRIGHT,
    DOWNRIGHT,
    DOWN, 
    DOWNLEFT, 
    UPLEFT,
    NONE
}

public class NeighborDirection {
    public DIRECTION direction { get; }
    public int distance { get; }

    public NeighborDirection(DIRECTION direction, int distance) {
        this.direction = direction;
        this.distance = distance;
    }

    public NeighborDirection deduct() {
        return new NeighborDirection(direction, distance - 1);
    }
}