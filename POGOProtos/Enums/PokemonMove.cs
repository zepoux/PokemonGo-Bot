// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Enums/PokemonMove.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Enums
{

    /// <summary>Holder for reflection information generated from POGOProtos/Enums/PokemonMove.proto</summary>
    public static partial class PokemonMoveReflection
    {

        #region Descriptor
        /// <summary>File descriptor for POGOProtos/Enums/PokemonMove.proto</summary>
        public static pbr::FileDescriptor Descriptor
        {
            get { return descriptor; }
        }
        private static pbr::FileDescriptor descriptor;

        static PokemonMoveReflection()
        {
            byte[] descriptorData = global::System.Convert.FromBase64String(
                string.Concat(
                  "CiJQT0dPUHJvdG9zL0VudW1zL1Bva2Vtb25Nb3ZlLnByb3RvEhBQT0dPUHJv",
                  "dG9zLkVudW1zKuMXCgtQb2tlbW9uTW92ZRIOCgpNT1ZFX1VOU0VUEAASEQoN",
                  "VEhVTkRFUl9TSE9DSxABEhAKDFFVSUNLX0FUVEFDSxACEgsKB1NDUkFUQ0gQ",
                  "AxIJCgVFTUJFUhAEEg0KCVZJTkVfV0hJUBAFEgoKBlRBQ0tMRRAGEg4KClJB",
                  "Wk9SX0xFQUYQBxINCglUQUtFX0RPV04QCBINCglXQVRFUl9HVU4QCRIICgRC",
                  "SVRFEAoSCQoFUE9VTkQQCxIPCgtET1VCTEVfU0xBUBAMEggKBFdSQVAQDRIO",
                  "CgpIWVBFUl9CRUFNEA4SCAoETElDSxAPEg4KCkRBUktfUFVMU0UQEBIICgRT",
                  "TU9HEBESCgoGU0xVREdFEBISDgoKTUVUQUxfQ0xBVxATEg0KCVZJQ0VfR1JJ",
                  "UBAUEg8KC0ZMQU1FX1dIRUVMEBUSDAoITUVHQUhPUk4QFhIPCgtXSU5HX0FU",
                  "VEFDSxAXEhAKDEZMQU1FVEhST1dFUhAYEhAKDFNVQ0tFUl9QVU5DSBAZEgcK",
                  "A0RJRxAaEgwKCExPV19LSUNLEBsSDgoKQ1JPU1NfQ0hPUBAcEg4KClBTWUNI",
                  "T19DVVQQHRILCgdQU1lCRUFNEB4SDgoKRUFSVEhRVUFLRRAfEg4KClNUT05F",
                  "X0VER0UQIBINCglJQ0VfUFVOQ0gQIRIPCgtIRUFSVF9TVEFNUBAiEg0KCURJ",
                  "U0NIQVJHRRAjEhAKDEZMQVNIX0NBTk5PThAkEggKBFBFQ0sQJRIOCgpEUklM",
                  "TF9QRUNLECYSDAoISUNFX0JFQU0QJxIMCghCTElaWkFSRBAoEg0KCUFJUl9T",
                  "TEFTSBApEg0KCUhFQVRfV0FWRRAqEg0KCVRXSU5FRURMRRArEg4KClBPSVNP",
                  "Tl9KQUIQLBIOCgpBRVJJQUxfQUNFEC0SDQoJRFJJTExfUlVOEC4SEgoOUEVU",
                  "QUxfQkxJWlpBUkQQLxIOCgpNRUdBX0RSQUlOEDASDAoIQlVHX0JVWloQMRIP",
                  "CgtQT0lTT05fRkFORxAyEg8KC05JR0hUX1NMQVNIEDMSCQoFU0xBU0gQNBIP",
                  "CgtCVUJCTEVfQkVBTRA1Eg4KClNVQk1JU1NJT04QNhIPCgtLQVJBVEVfQ0hP",
                  "UBA3Eg0KCUxPV19TV0VFUBA4EgwKCEFRVUFfSkVUEDkSDQoJQVFVQV9UQUlM",
                  "EDoSDQoJU0VFRF9CT01CEDsSDAoIUFNZU0hPQ0sQPBIOCgpST0NLX1RIUk9X",
                  "ED0SEQoNQU5DSUVOVF9QT1dFUhA+Eg0KCVJPQ0tfVE9NQhA/Eg4KClJPQ0tf",
                  "U0xJREUQQBINCglQT1dFUl9HRU0QQRIQCgxTSEFET1dfU05FQUsQQhIQCgxT",
                  "SEFET1dfUFVOQ0gQQxIPCgtTSEFET1dfQ0xBVxBEEhAKDE9NSU5PVVNfV0lO",
                  "RBBFEg8KC1NIQURPV19CQUxMEEYSEAoMQlVMTEVUX1BVTkNIEEcSDwoLTUFH",
                  "TkVUX0JPTUIQSBIOCgpTVEVFTF9XSU5HEEkSDQoJSVJPTl9IRUFEEEoSFAoQ",
                  "UEFSQUJPTElDX0NIQVJHRRBLEgkKBVNQQVJLEEwSEQoNVEhVTkRFUl9QVU5D",
                  "SBBNEgsKB1RIVU5ERVIQThIPCgtUSFVOREVSQk9MVBBPEgsKB1RXSVNURVIQ",
                  "UBIRCg1EUkFHT05fQlJFQVRIEFESEAoMRFJBR09OX1BVTFNFEFISDwoLRFJB",
                  "R09OX0NMQVcQUxITCg9ESVNBUk1JTkdfVk9JQ0UQVBIRCg1EUkFJTklOR19L",
                  "SVNTEFUSEgoOREFaWkxJTkdfR0xFQU0QVhINCglNT09OQkxBU1QQVxIOCgpQ",
                  "TEFZX1JPVUdIEFgSEAoMQ1JPU1NfUE9JU09OEFkSDwoLU0xVREdFX0JPTUIQ",
                  "WhIPCgtTTFVER0VfV0FWRRBbEg0KCUdVTktfU0hPVBBcEgwKCE1VRF9TSE9U",
                  "EF0SDQoJQk9ORV9DTFVCEF4SDAoIQlVMTERPWkUQXxIMCghNVURfQk9NQhBg",
                  "Eg8KC0ZVUllfQ1VUVEVSEGESDAoIQlVHX0JJVEUQYhIPCgtTSUdOQUxfQkVB",
                  "TRBjEg0KCVhfU0NJU1NPUhBkEhAKDEZMQU1FX0NIQVJHRRBlEg8KC0ZMQU1F",
                  "X0JVUlNUEGYSDgoKRklSRV9CTEFTVBBnEgkKBUJSSU5FEGgSDwoLV0FURVJf",
                  "UFVMU0UQaRIJCgVTQ0FMRBBqEg4KCkhZRFJPX1BVTVAQaxILCgdQU1lDSElD",
                  "EGwSDQoJUFNZU1RSSUtFEG0SDQoJSUNFX1NIQVJEEG4SDAoISUNZX1dJTkQQ",
                  "bxIQCgxGUk9TVF9CUkVBVEgQcBIKCgZBQlNPUkIQcRIOCgpHSUdBX0RSQUlO",
                  "EHISDgoKRklSRV9QVU5DSBBzEg4KClNPTEFSX0JFQU0QdBIOCgpMRUFGX0JM",
                  "QURFEHUSDgoKUE9XRVJfV0hJUBB2EgoKBlNQTEFTSBB3EggKBEFDSUQQeBIO",
                  "CgpBSVJfQ1VUVEVSEHkSDQoJSFVSUklDQU5FEHoSDwoLQlJJQ0tfQlJFQUsQ",
                  "exIHCgNDVVQQfBIJCgVTV0lGVBB9Eg8KC0hPUk5fQVRUQUNLEH4SCQoFU1RP",
                  "TVAQfxINCghIRUFEQlVUVBCAARIPCgpIWVBFUl9GQU5HEIEBEgkKBFNMQU0Q",
                  "ggESDgoJQk9EWV9TTEFNEIMBEgkKBFJFU1QQhAESDQoIU1RSVUdHTEUQhQES",
                  "FAoPU0NBTERfQkxBU1RPSVNFEIYBEhkKFEhZRFJPX1BVTVBfQkxBU1RPSVNF",
                  "EIcBEg8KCldSQVBfR1JFRU4QiAESDgoJV1JBUF9QSU5LEIkBEhUKEEZVUllf",
                  "Q1VUVEVSX0ZBU1QQyAESEgoNQlVHX0JJVEVfRkFTVBDJARIOCglCSVRFX0ZB",
                  "U1QQygESFgoRU1VDS0VSX1BVTkNIX0ZBU1QQywESFwoSRFJBR09OX0JSRUFU",
                  "SF9GQVNUEMwBEhcKElRIVU5ERVJfU0hPQ0tfRkFTVBDNARIPCgpTUEFSS19G",
                  "QVNUEM4BEhIKDUxPV19LSUNLX0ZBU1QQzwESFQoQS0FSQVRFX0NIT1BfRkFT",
                  "VBDQARIPCgpFTUJFUl9GQVNUENEBEhUKEFdJTkdfQVRUQUNLX0ZBU1QQ0gES",
                  "DgoJUEVDS19GQVNUENMBEg4KCUxJQ0tfRkFTVBDUARIVChBTSEFET1dfQ0xB",
                  "V19GQVNUENUBEhMKDlZJTkVfV0hJUF9GQVNUENYBEhQKD1JBWk9SX0xFQUZf",
                  "RkFTVBDXARISCg1NVURfU0hPVF9GQVNUENgBEhMKDklDRV9TSEFSRF9GQVNU",
                  "ENkBEhYKEUZST1NUX0JSRUFUSF9GQVNUENoBEhYKEVFVSUNLX0FUVEFDS19G",
                  "QVNUENsBEhEKDFNDUkFUQ0hfRkFTVBDcARIQCgtUQUNLTEVfRkFTVBDdARIP",
                  "CgpQT1VORF9GQVNUEN4BEg0KCENVVF9GQVNUEN8BEhQKD1BPSVNPTl9KQUJf",
                  "RkFTVBDgARIOCglBQ0lEX0ZBU1QQ4QESFAoPUFNZQ0hPX0NVVF9GQVNUEOIB",
                  "EhQKD1JPQ0tfVEhST1dfRkFTVBDjARIUCg9NRVRBTF9DTEFXX0ZBU1QQ5AES",
                  "FgoRQlVMTEVUX1BVTkNIX0ZBU1QQ5QESEwoOV0FURVJfR1VOX0ZBU1QQ5gES",
                  "EAoLU1BMQVNIX0ZBU1QQ5wESHQoYV0FURVJfR1VOX0ZBU1RfQkxBU1RPSVNF",
                  "EOgBEhIKDU1VRF9TTEFQX0ZBU1QQ6QESFgoRWkVOX0hFQURCVVRUX0ZBU1QQ",
                  "6gESEwoOQ09ORlVTSU9OX0ZBU1QQ6wESFgoRUE9JU09OX1NUSU5HX0ZBU1QQ",
                  "7AESEAoLQlVCQkxFX0ZBU1QQ7QESFgoRRkVJTlRfQVRUQUNLX0ZBU1QQ7gES",
                  "FAoPU1RFRUxfV0lOR19GQVNUEO8BEhMKDkZJUkVfRkFOR19GQVNUEPABEhQK",
                  "D1JPQ0tfU01BU0hfRkFTVBDxARITCg5UUkFOU0ZPUk1fRkFTVBDyAWIGcHJv",
                  "dG8z"));
            descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
                new pbr::FileDescriptor[] { },
                new pbr::GeneratedClrTypeInfo(new[] { typeof(global::POGOProtos.Enums.PokemonMove), }, null));
        }
        #endregion

    }
    #region Enums
    public enum PokemonMove
    {
        [pbr::OriginalName("MOVE_UNSET")]
        MoveUnset = 0,
        [pbr::OriginalName("THUNDER_SHOCK")]
        ThunderShock = 1,
        [pbr::OriginalName("QUICK_ATTACK")]
        QuickAttack = 2,
        [pbr::OriginalName("SCRATCH")]
        Scratch = 3,
        [pbr::OriginalName("EMBER")]
        Ember = 4,
        [pbr::OriginalName("VINE_WHIP")]
        VineWhip = 5,
        [pbr::OriginalName("TACKLE")]
        Tackle = 6,
        [pbr::OriginalName("RAZOR_LEAF")]
        RazorLeaf = 7,
        [pbr::OriginalName("TAKE_DOWN")]
        TakeDown = 8,
        [pbr::OriginalName("WATER_GUN")]
        WaterGun = 9,
        [pbr::OriginalName("BITE")]
        Bite = 10,
        [pbr::OriginalName("POUND")]
        Pound = 11,
        [pbr::OriginalName("DOUBLE_SLAP")]
        DoubleSlap = 12,
        [pbr::OriginalName("WRAP")]
        Wrap = 13,
        [pbr::OriginalName("HYPER_BEAM")]
        HyperBeam = 14,
        [pbr::OriginalName("LICK")]
        Lick = 15,
        [pbr::OriginalName("DARK_PULSE")]
        DarkPulse = 16,
        [pbr::OriginalName("SMOG")]
        Smog = 17,
        [pbr::OriginalName("SLUDGE")]
        Sludge = 18,
        [pbr::OriginalName("METAL_CLAW")]
        MetalClaw = 19,
        [pbr::OriginalName("VICE_GRIP")]
        ViceGrip = 20,
        [pbr::OriginalName("FLAME_WHEEL")]
        FlameWheel = 21,
        [pbr::OriginalName("MEGAHORN")]
        Megahorn = 22,
        [pbr::OriginalName("WING_ATTACK")]
        WingAttack = 23,
        [pbr::OriginalName("FLAMETHROWER")]
        Flamethrower = 24,
        [pbr::OriginalName("SUCKER_PUNCH")]
        SuckerPunch = 25,
        [pbr::OriginalName("DIG")]
        Dig = 26,
        [pbr::OriginalName("LOW_KICK")]
        LowKick = 27,
        [pbr::OriginalName("CROSS_CHOP")]
        CrossChop = 28,
        [pbr::OriginalName("PSYCHO_CUT")]
        PsychoCut = 29,
        [pbr::OriginalName("PSYBEAM")]
        Psybeam = 30,
        [pbr::OriginalName("EARTHQUAKE")]
        Earthquake = 31,
        [pbr::OriginalName("STONE_EDGE")]
        StoneEdge = 32,
        [pbr::OriginalName("ICE_PUNCH")]
        IcePunch = 33,
        [pbr::OriginalName("HEART_STAMP")]
        HeartStamp = 34,
        [pbr::OriginalName("DISCHARGE")]
        Discharge = 35,
        [pbr::OriginalName("FLASH_CANNON")]
        FlashCannon = 36,
        [pbr::OriginalName("PECK")]
        Peck = 37,
        [pbr::OriginalName("DRILL_PECK")]
        DrillPeck = 38,
        [pbr::OriginalName("ICE_BEAM")]
        IceBeam = 39,
        [pbr::OriginalName("BLIZZARD")]
        Blizzard = 40,
        [pbr::OriginalName("AIR_SLASH")]
        AirSlash = 41,
        [pbr::OriginalName("HEAT_WAVE")]
        HeatWave = 42,
        [pbr::OriginalName("TWINEEDLE")]
        Twineedle = 43,
        [pbr::OriginalName("POISON_JAB")]
        PoisonJab = 44,
        [pbr::OriginalName("AERIAL_ACE")]
        AerialAce = 45,
        [pbr::OriginalName("DRILL_RUN")]
        DrillRun = 46,
        [pbr::OriginalName("PETAL_BLIZZARD")]
        PetalBlizzard = 47,
        [pbr::OriginalName("MEGA_DRAIN")]
        MegaDrain = 48,
        [pbr::OriginalName("BUG_BUZZ")]
        BugBuzz = 49,
        [pbr::OriginalName("POISON_FANG")]
        PoisonFang = 50,
        [pbr::OriginalName("NIGHT_SLASH")]
        NightSlash = 51,
        [pbr::OriginalName("SLASH")]
        Slash = 52,
        [pbr::OriginalName("BUBBLE_BEAM")]
        BubbleBeam = 53,
        [pbr::OriginalName("SUBMISSION")]
        Submission = 54,
        [pbr::OriginalName("KARATE_CHOP")]
        KarateChop = 55,
        [pbr::OriginalName("LOW_SWEEP")]
        LowSweep = 56,
        [pbr::OriginalName("AQUA_JET")]
        AquaJet = 57,
        [pbr::OriginalName("AQUA_TAIL")]
        AquaTail = 58,
        [pbr::OriginalName("SEED_BOMB")]
        SeedBomb = 59,
        [pbr::OriginalName("PSYSHOCK")]
        Psyshock = 60,
        [pbr::OriginalName("ROCK_THROW")]
        RockThrow = 61,
        [pbr::OriginalName("ANCIENT_POWER")]
        AncientPower = 62,
        [pbr::OriginalName("ROCK_TOMB")]
        RockTomb = 63,
        [pbr::OriginalName("ROCK_SLIDE")]
        RockSlide = 64,
        [pbr::OriginalName("POWER_GEM")]
        PowerGem = 65,
        [pbr::OriginalName("SHADOW_SNEAK")]
        ShadowSneak = 66,
        [pbr::OriginalName("SHADOW_PUNCH")]
        ShadowPunch = 67,
        [pbr::OriginalName("SHADOW_CLAW")]
        ShadowClaw = 68,
        [pbr::OriginalName("OMINOUS_WIND")]
        OminousWind = 69,
        [pbr::OriginalName("SHADOW_BALL")]
        ShadowBall = 70,
        [pbr::OriginalName("BULLET_PUNCH")]
        BulletPunch = 71,
        [pbr::OriginalName("MAGNET_BOMB")]
        MagnetBomb = 72,
        [pbr::OriginalName("STEEL_WING")]
        SteelWing = 73,
        [pbr::OriginalName("IRON_HEAD")]
        IronHead = 74,
        [pbr::OriginalName("PARABOLIC_CHARGE")]
        ParabolicCharge = 75,
        [pbr::OriginalName("SPARK")]
        Spark = 76,
        [pbr::OriginalName("THUNDER_PUNCH")]
        ThunderPunch = 77,
        [pbr::OriginalName("THUNDER")]
        Thunder = 78,
        [pbr::OriginalName("THUNDERBOLT")]
        Thunderbolt = 79,
        [pbr::OriginalName("TWISTER")]
        Twister = 80,
        [pbr::OriginalName("DRAGON_BREATH")]
        DragonBreath = 81,
        [pbr::OriginalName("DRAGON_PULSE")]
        DragonPulse = 82,
        [pbr::OriginalName("DRAGON_CLAW")]
        DragonClaw = 83,
        [pbr::OriginalName("DISARMING_VOICE")]
        DisarmingVoice = 84,
        [pbr::OriginalName("DRAINING_KISS")]
        DrainingKiss = 85,
        [pbr::OriginalName("DAZZLING_GLEAM")]
        DazzlingGleam = 86,
        [pbr::OriginalName("MOONBLAST")]
        Moonblast = 87,
        [pbr::OriginalName("PLAY_ROUGH")]
        PlayRough = 88,
        [pbr::OriginalName("CROSS_POISON")]
        CrossPoison = 89,
        [pbr::OriginalName("SLUDGE_BOMB")]
        SludgeBomb = 90,
        [pbr::OriginalName("SLUDGE_WAVE")]
        SludgeWave = 91,
        [pbr::OriginalName("GUNK_SHOT")]
        GunkShot = 92,
        [pbr::OriginalName("MUD_SHOT")]
        MudShot = 93,
        [pbr::OriginalName("BONE_CLUB")]
        BoneClub = 94,
        [pbr::OriginalName("BULLDOZE")]
        Bulldoze = 95,
        [pbr::OriginalName("MUD_BOMB")]
        MudBomb = 96,
        [pbr::OriginalName("FURY_CUTTER")]
        FuryCutter = 97,
        [pbr::OriginalName("BUG_BITE")]
        BugBite = 98,
        [pbr::OriginalName("SIGNAL_BEAM")]
        SignalBeam = 99,
        [pbr::OriginalName("X_SCISSOR")]
        XScissor = 100,
        [pbr::OriginalName("FLAME_CHARGE")]
        FlameCharge = 101,
        [pbr::OriginalName("FLAME_BURST")]
        FlameBurst = 102,
        [pbr::OriginalName("FIRE_BLAST")]
        FireBlast = 103,
        [pbr::OriginalName("BRINE")]
        Brine = 104,
        [pbr::OriginalName("WATER_PULSE")]
        WaterPulse = 105,
        [pbr::OriginalName("SCALD")]
        Scald = 106,
        [pbr::OriginalName("HYDRO_PUMP")]
        HydroPump = 107,
        [pbr::OriginalName("PSYCHIC")]
        Psychic = 108,
        [pbr::OriginalName("PSYSTRIKE")]
        Psystrike = 109,
        [pbr::OriginalName("ICE_SHARD")]
        IceShard = 110,
        [pbr::OriginalName("ICY_WIND")]
        IcyWind = 111,
        [pbr::OriginalName("FROST_BREATH")]
        FrostBreath = 112,
        [pbr::OriginalName("ABSORB")]
        Absorb = 113,
        [pbr::OriginalName("GIGA_DRAIN")]
        GigaDrain = 114,
        [pbr::OriginalName("FIRE_PUNCH")]
        FirePunch = 115,
        [pbr::OriginalName("SOLAR_BEAM")]
        SolarBeam = 116,
        [pbr::OriginalName("LEAF_BLADE")]
        LeafBlade = 117,
        [pbr::OriginalName("POWER_WHIP")]
        PowerWhip = 118,
        [pbr::OriginalName("SPLASH")]
        Splash = 119,
        [pbr::OriginalName("ACID")]
        Acid = 120,
        [pbr::OriginalName("AIR_CUTTER")]
        AirCutter = 121,
        [pbr::OriginalName("HURRICANE")]
        Hurricane = 122,
        [pbr::OriginalName("BRICK_BREAK")]
        BrickBreak = 123,
        [pbr::OriginalName("CUT")]
        Cut = 124,
        [pbr::OriginalName("SWIFT")]
        Swift = 125,
        [pbr::OriginalName("HORN_ATTACK")]
        HornAttack = 126,
        [pbr::OriginalName("STOMP")]
        Stomp = 127,
        [pbr::OriginalName("HEADBUTT")]
        Headbutt = 128,
        [pbr::OriginalName("HYPER_FANG")]
        HyperFang = 129,
        [pbr::OriginalName("SLAM")]
        Slam = 130,
        [pbr::OriginalName("BODY_SLAM")]
        BodySlam = 131,
        [pbr::OriginalName("REST")]
        Rest = 132,
        [pbr::OriginalName("STRUGGLE")]
        Struggle = 133,
        [pbr::OriginalName("SCALD_BLASTOISE")]
        ScaldBlastoise = 134,
        [pbr::OriginalName("HYDRO_PUMP_BLASTOISE")]
        HydroPumpBlastoise = 135,
        [pbr::OriginalName("WRAP_GREEN")]
        WrapGreen = 136,
        [pbr::OriginalName("WRAP_PINK")]
        WrapPink = 137,
        [pbr::OriginalName("FURY_CUTTER_FAST")]
        FuryCutterFast = 200,
        [pbr::OriginalName("BUG_BITE_FAST")]
        BugBiteFast = 201,
        [pbr::OriginalName("BITE_FAST")]
        BiteFast = 202,
        [pbr::OriginalName("SUCKER_PUNCH_FAST")]
        SuckerPunchFast = 203,
        [pbr::OriginalName("DRAGON_BREATH_FAST")]
        DragonBreathFast = 204,
        [pbr::OriginalName("THUNDER_SHOCK_FAST")]
        ThunderShockFast = 205,
        [pbr::OriginalName("SPARK_FAST")]
        SparkFast = 206,
        [pbr::OriginalName("LOW_KICK_FAST")]
        LowKickFast = 207,
        [pbr::OriginalName("KARATE_CHOP_FAST")]
        KarateChopFast = 208,
        [pbr::OriginalName("EMBER_FAST")]
        EmberFast = 209,
        [pbr::OriginalName("WING_ATTACK_FAST")]
        WingAttackFast = 210,
        [pbr::OriginalName("PECK_FAST")]
        PeckFast = 211,
        [pbr::OriginalName("LICK_FAST")]
        LickFast = 212,
        [pbr::OriginalName("SHADOW_CLAW_FAST")]
        ShadowClawFast = 213,
        [pbr::OriginalName("VINE_WHIP_FAST")]
        VineWhipFast = 214,
        [pbr::OriginalName("RAZOR_LEAF_FAST")]
        RazorLeafFast = 215,
        [pbr::OriginalName("MUD_SHOT_FAST")]
        MudShotFast = 216,
        [pbr::OriginalName("ICE_SHARD_FAST")]
        IceShardFast = 217,
        [pbr::OriginalName("FROST_BREATH_FAST")]
        FrostBreathFast = 218,
        [pbr::OriginalName("QUICK_ATTACK_FAST")]
        QuickAttackFast = 219,
        [pbr::OriginalName("SCRATCH_FAST")]
        ScratchFast = 220,
        [pbr::OriginalName("TACKLE_FAST")]
        TackleFast = 221,
        [pbr::OriginalName("POUND_FAST")]
        PoundFast = 222,
        [pbr::OriginalName("CUT_FAST")]
        CutFast = 223,
        [pbr::OriginalName("POISON_JAB_FAST")]
        PoisonJabFast = 224,
        [pbr::OriginalName("ACID_FAST")]
        AcidFast = 225,
        [pbr::OriginalName("PSYCHO_CUT_FAST")]
        PsychoCutFast = 226,
        [pbr::OriginalName("ROCK_THROW_FAST")]
        RockThrowFast = 227,
        [pbr::OriginalName("METAL_CLAW_FAST")]
        MetalClawFast = 228,
        [pbr::OriginalName("BULLET_PUNCH_FAST")]
        BulletPunchFast = 229,
        [pbr::OriginalName("WATER_GUN_FAST")]
        WaterGunFast = 230,
        [pbr::OriginalName("SPLASH_FAST")]
        SplashFast = 231,
        [pbr::OriginalName("WATER_GUN_FAST_BLASTOISE")]
        WaterGunFastBlastoise = 232,
        [pbr::OriginalName("MUD_SLAP_FAST")]
        MudSlapFast = 233,
        [pbr::OriginalName("ZEN_HEADBUTT_FAST")]
        ZenHeadbuttFast = 234,
        [pbr::OriginalName("CONFUSION_FAST")]
        ConfusionFast = 235,
        [pbr::OriginalName("POISON_STING_FAST")]
        PoisonStingFast = 236,
        [pbr::OriginalName("BUBBLE_FAST")]
        BubbleFast = 237,
        [pbr::OriginalName("FEINT_ATTACK_FAST")]
        FeintAttackFast = 238,
        [pbr::OriginalName("STEEL_WING_FAST")]
        SteelWingFast = 239,
        [pbr::OriginalName("FIRE_FANG_FAST")]
        FireFangFast = 240,
        [pbr::OriginalName("ROCK_SMASH_FAST")]
        RockSmashFast = 241,
        [pbr::OriginalName("TRANSFORM_FAST")]
        TransformFast = 242,
    }

    #endregion

}

#endregion Designer generated code