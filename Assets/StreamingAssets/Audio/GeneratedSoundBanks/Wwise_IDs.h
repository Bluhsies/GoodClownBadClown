/////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Audiokinetic Wwise generated include file. Do not edit.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef __WWISE_IDS_H__
#define __WWISE_IDS_H__

#include <AK/SoundEngine/Common/AkTypes.h>

namespace AK
{
    namespace EVENTS
    {
        static const AkUniqueID PLAY_DUCK_SWAPPER = 723492182U;
        static const AkUniqueID PLAY_FINAL_BALLOON = 406281678U;
        static const AkUniqueID PLAY_FINAL_BALLOON_01 = 1264613660U;
        static const AkUniqueID PLAY_FINAL_BELL = 1660887386U;
        static const AkUniqueID PLAY_FINAL_DUCK = 2190624446U;
        static const AkUniqueID PLAY_FINAL_HORNS = 1981288325U;
        static const AkUniqueID PLAY_FIRE_SOUND = 1813085682U;
        static const AkUniqueID PLAY_RANDOM_BALLOON = 2945822887U;
        static const AkUniqueID PLAY_RANDOM_BALLOON_01 = 285164011U;
        static const AkUniqueID PLAY_RANDOM_DISTRESSED_DUCK = 270042352U;
        static const AkUniqueID PLAY_RANDOM_DUCK = 4129614625U;
        static const AkUniqueID PLAY_RANDOM_FARTS = 4024218666U;
        static const AkUniqueID PLAY_RANDOM_FARTS_01 = 3820289000U;
        static const AkUniqueID PLAY_RANDOM_GREETING = 1533232227U;
        static const AkUniqueID PLAY_RANDOM_HONK = 3481879412U;
        static const AkUniqueID PLAY_RANDOM_LEVEL = 1603401656U;
        static const AkUniqueID PLAY_RANDOM_POP = 1880099235U;
        static const AkUniqueID PLAY_RANDOM_POP_01 = 2890990743U;
        static const AkUniqueID PLAY_RANDOM_TARGET = 2260914217U;
        static const AkUniqueID PLAY_TANNOY_ON = 1668555701U;
        static const AkUniqueID PLAY_TANNOY_REVERBED = 3568384201U;
        static const AkUniqueID STOP_FINAL_BELL = 3443401776U;
        static const AkUniqueID STOP_FINAL_DUCK = 650256992U;
        static const AkUniqueID STOP_RANDOM_DISTRESSED_DUCK = 3360668650U;
        static const AkUniqueID STOP_RANDOM_DUCK = 1792611331U;
        static const AkUniqueID STOP_RANDOM_GREETING = 1624968805U;
        static const AkUniqueID STOP_RANDOM_TARGET = 1165255667U;
    } // namespace EVENTS

    namespace STATES
    {
        namespace CLOSEDUCK
        {
            static const AkUniqueID GROUP = 1200566504U;

            namespace STATE
            {
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID OFF = 930712164U;
                static const AkUniqueID ON = 1651971902U;
            } // namespace STATE
        } // namespace CLOSEDUCK

    } // namespace STATES

    namespace SWITCHES
    {
        namespace QUACKS
        {
            static const AkUniqueID GROUP = 433183545U;

            namespace SWITCH
            {
                static const AkUniqueID NORMAL = 1160234136U;
                static const AkUniqueID STRESSED = 3309335698U;
            } // namespace SWITCH
        } // namespace QUACKS

    } // namespace SWITCHES

    namespace GAME_PARAMETERS
    {
        static const AkUniqueID RTPC_OCCLUSION_LOWPASS = 1565745694U;
        static const AkUniqueID RTPC_OCCLUSION_VOLUME = 342905355U;
        static const AkUniqueID RTPC_POOP_FULL = 2603982447U;
        static const AkUniqueID RTPC_POOP_HIGH = 2949163900U;
        static const AkUniqueID RTPC_POOP_LOW = 640280894U;
        static const AkUniqueID RTPC_SCORERS_FULL = 361950326U;
        static const AkUniqueID RTPC_SCORERS_HIGH = 289050377U;
        static const AkUniqueID RTPC_SCORERS_LOW = 1855821357U;
    } // namespace GAME_PARAMETERS

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID MASTER = 4056684167U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID DD_BUS = 1044488314U;
        static const AkUniqueID DUCKING = 2712164154U;
        static const AkUniqueID MAIN = 3161908922U;
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
        static const AkUniqueID ND_BUS = 3574202736U;
        static const AkUniqueID OBJECTS = 1695690031U;
        static const AkUniqueID PASS_DUCK = 2181382990U;
        static const AkUniqueID PASS_DUCK_HIGH = 2870235153U;
        static const AkUniqueID PASS_DUCK_LOW = 794722165U;
        static const AkUniqueID PASS_FIRE = 3314319729U;
        static const AkUniqueID PASS_FIRE_HIGH = 1654434312U;
        static const AkUniqueID PASS_FIRE_LOW = 3801212178U;
        static const AkUniqueID PASSTHROUGH = 2804736953U;
        static const AkUniqueID POOP_OBJ = 2473655501U;
        static const AkUniqueID POOP_PRE = 2175160017U;
        static const AkUniqueID REVERB = 348963605U;
        static const AkUniqueID SIDE_POOPS = 561204928U;
        static const AkUniqueID SIDE_SCORERS = 325653778U;
        static const AkUniqueID SIDECHAIN = 1883033791U;
        static const AkUniqueID TARGET_OBJ = 332024420U;
        static const AkUniqueID TARGET_PRE = 4260296736U;
    } // namespace BUSSES

    namespace AUX_BUSSES
    {
        static const AkUniqueID ROOM_BUS = 3923769827U;
        static const AkUniqueID SIDE_POOPS_FULL = 3401835852U;
        static const AkUniqueID SIDE_POOPS_HIGH = 946111543U;
        static const AkUniqueID SIDE_POOPS_LOW = 652135267U;
        static const AkUniqueID SIDE_SCORERS_FULL = 470848594U;
        static const AkUniqueID SIDE_SCORERS_HIGH = 4042189213U;
        static const AkUniqueID SIDE_SCORERS_LOW = 2267226089U;
    } // namespace AUX_BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__
