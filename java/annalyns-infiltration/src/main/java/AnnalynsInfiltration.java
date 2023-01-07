class AnnalynsInfiltration {
    public static boolean canFastAttack(boolean knightIsAwake) {
      return !knightIsAwake;

    }

    public static boolean canSpy(boolean knightIsAwake, boolean archerIsAwake, boolean prisonerIsAwake) {
        return (knightIsAwake || archerIsAwake || prisonerIsAwake);


    }

    public static boolean canSignalPrisoner(boolean archerIsAwake, boolean prisonerIsAwake)  {
      return (!archerIsAwake && prisonerIsAwake);

    }

    public static boolean canFreePrisoner(boolean knightIsAwake, boolean archerIsAwake, boolean prisonerIsAwake, boolean petDogIsPresent) {
        return (petDogIsPresent && !archerIsAwake) || (prisonerIsAwake && !knightIsAwake && !archerIsAwake);

        /*
        if(archerIsAwake)
        {
            if(!prisonerIsAwake && !knightIsAwake &&!petDogIsPresent)
            {
                return false;
            }
        }
        else
            return true;
        throw new UnsupportedOperationException("Please implement the (static) AnnalynsInfiltration.canFreePrisoner() method");
    }*/
    }
}
