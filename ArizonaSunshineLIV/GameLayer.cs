namespace ArizonaSunshineLIV
{
	public enum GameLayer
	{
        Default = 0,
        TransparentFX = 1, //Sky issues
        IgnoreRaycast = 2,
        Water = 4,
        OverlayUI = 8, //Rotation black out
        Item = 9,
        HolsterRing = 19, //Holster ring
        PlayerHands = 29, //Hands excluding weapon

        // Custom layers to use in the mod.
        LivOnly = 30 //Might be used by something else, didn't see conflict in 2nd and last levels.

        /* // These names might be incorrect
        Default = 0,
        TransparentFX = 1, //Sky issues
        IgnoreRaycast = 2,
        UNKNOWN3 = 3,
        Water = 4,
        UI = 5,
        UNKNOWN6 = 6,
        UNKNOWN7 = 7,
        OverlayUI = 8, //Rotation black out
        Item = 9,
        ZombieMutilated = 10,
        ZombieRagdoll = 11,
        ZombieAnimation = 12,
        Interaction = 13,
        ItemIgnoreBullets = 14,
        ItemPhysicsHittable = 15,
        Walkable = 16,
        IgnorePlayerHands = 17,
        NotWalkableInvis = 18,
        RemotePlayer = 19, //Holster ring
        IgnoreBullets = 20,
        ZombiePiercingItem = 21,
        PlayerHand = 22,
        LocalPlayer = 23,
        ZombieWalkableBlocker = 24,
        ZombieCollision = 25,
        PlayerTeleport = 26,
        DynamicArt = 27,
        DynamicArtIgnoreCheat = 28,
        PlayerTrigger = 29, //Hands excluding weapon
        */
    }
}