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
        bool isDown = ahead[index] < 0;
        bool isStraight = aheadRight[index] == 0;
        bool isRight = aheadRight[index] > 0;
        bool isLeft = aheadRight[index] < 0;

        bool isStraightUp = isUp && isStraight;
        bool isUpRight = isUp && isRight;
        bool isUpLeft = isUp && isLeft;

        bool isStraightDown = isDown && isStraight;
        bool isDownRight = isDown && isRight;
        bool isDownLeft = isDown && isLeft;


        if(isStraightUp) {
            return new NeighborDirection(DIRECTION.UP, ahead[index]);
        }
        else if(isStraightDown) {
            return new NeighborDirection(DIRECTION.DOWN, 0-ahead[index]);
        }
        else if(isUpRight) {
            return new NeighborDirection(DIRECTION.UPRIGHT, ahead[index]);
        }
        else if(isUpLeft) {
            return new NeighborDirection(DIRECTION.UPLEFT, ahead[index]);
        }
        else if(isDownRight) {
            return new NeighborDirection(DIRECTION.DOWNRIGHT, ahead[index]);
        }
        else if(isDownLeft) {
            NeighborDirection n = new NeighborDirection(DIRECTION.DOWNLEFT, 0-ahead[index]);
            
            return n;
        }

        return new NeighborDirection(DIRECTION.NONE, ahead[index]);
    }

    public NeighborDirection first() {
        return readInternal(0);
    }

    public NeighborDirection second() {
        return readInternal(1);
    }
}