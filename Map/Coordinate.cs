public class Coordinate {
    private int[] ahead = new int[2];
    private int[] aheadRight = new int[2];

    public Coordinate(int up1, int right1, int up2, int right2) {
        ahead[0] = up1;
        ahead[1] = up2;

        aheadRight[0] = right1;
        aheadRight[1] = right2;
    }

    private NeighborDirection readInternal(int index) {
        
        bool isUp = ahead[index] > 0;
        bool isStraight = aheadRight[index] == 0;
        bool isRight = aheadRight[index] > 0;

        bool isStraightUp = isUp && isStraight;
        bool isUpRight = isUp && isRight;
        bool isUpLeft = isUp && !isRight;

        bool isStraightDown = !isUp && !isStraight;
        bool isDownRight = !isUp && isRight;
        bool isDownLeft = !isUp && !isRight;


        if(isStraightUp) {
            return new NeighborDirection(DIRECTION.UP, ahead[index]);
        }

        return null;
    }

    public NeighborDirection first() {
        return readInternal(0);
    }

    public NeighborDirection second() {
        return readInternal(1);
    }
}