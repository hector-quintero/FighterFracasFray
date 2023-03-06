public static class DirectionHelper {
    public static DIRECTION getOpposite(this DIRECTION direction) {
        switch(direction) {
            case DIRECTION.UP:
                return DIRECTION.DOWN;
            case DIRECTION.UPRIGHT:
                return DIRECTION.DOWNLEFT;
            case DIRECTION.DOWNRIGHT:
                return DIRECTION.UPLEFT;
            case DIRECTION.DOWN:
                return DIRECTION.UP;
            case DIRECTION.DOWNLEFT:
                return DIRECTION.UPRIGHT;
            case DIRECTION.UPLEFT:
                return DIRECTION.DOWNRIGHT;
            default:
                return DIRECTION.UP;
        }
    }
}