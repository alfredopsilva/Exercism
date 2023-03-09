using System;

static class QuestLogic
{
      public static bool CanFastAttack(bool knightIsAwake)
    {
        return !knightIsAwake;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
       if(knightIsAwake || archerIsAwake || prisonerIsAwake)
           return true;
        return false;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        return (!archerIsAwake && prisonerIsAwake);
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
       if(petDogIsPresent && !archerIsAwake)
           return true;
        if(!petDogIsPresent && prisonerIsAwake)
            if(!knightIsAwake && !archerIsAwake)
                return true;
        return false;
    }
}
