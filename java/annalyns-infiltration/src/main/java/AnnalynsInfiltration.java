class AnnalynsInfiltration {
    public static boolean canFastAttack(boolean knightIsAwake) {
        return !knightIsAwake;
    }

    public static boolean canSpy(boolean knightIsAwake, boolean archerIsAwake, boolean prisonerIsAwake) {
        return knightIsAwake || prisonerIsAwake || archerIsAwake;
    }

    public static boolean canSignalPrisoner(boolean archerIsAwake, boolean prisonerIsAwake) {
        return !archerIsAwake && prisonerIsAwake;
    }

    public static boolean canFreePrisoner(boolean knightIsAwake, boolean archerIsAwake, boolean prisonerIsAwake, boolean petDogIsPresent) {
       Boolean flag = false;

       if(petDogIsPresent)
       {
           if(!archerIsAwake)
               flag = true;
       }
       if(!petDogIsPresent)
       {
           if(prisonerIsAwake && (!knightIsAwake && !archerIsAwake))
               flag = true;
       }

       return flag;
    }
}
