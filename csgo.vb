' 2019-09-03 09:49:10.484556800 UTC

Namespace hazedumper
    Public Shared Class netvars
        Public Const cs_gamerules_data as Integer = &H0
        Public Const m_ArmorValue as Integer = &HB340
        Public Const m_Collision as Integer = &H31C
        Public Const m_CollisionGroup as Integer = &H474
        Public Const m_Local as Integer = &H2FBC
        Public Const m_MoveType as Integer = &H25C
        Public Const m_OriginalOwnerXuidHigh as Integer = &H31B4
        Public Const m_OriginalOwnerXuidLow as Integer = &H31B0
        Public Const m_SurvivalGameRuleDecisionTypes as Integer = &H1320
        Public Const m_SurvivalRules as Integer = &HCF8
        Public Const m_aimPunchAngle as Integer = &H302C
        Public Const m_aimPunchAngleVel as Integer = &H3038
        Public Const m_angEyeAnglesX as Integer = &HB344
        Public Const m_angEyeAnglesY as Integer = &HB348
        Public Const m_bBombPlanted as Integer = &H99D
        Public Const m_bFreezePeriod as Integer = &H20
        Public Const m_bGunGameImmunity as Integer = &H392C
        Public Const m_bHasDefuser as Integer = &HB350
        Public Const m_bHasHelmet as Integer = &HB334
        Public Const m_bInReload as Integer = &H3285
        Public Const m_bIsDefusing as Integer = &H3918
        Public Const m_bIsQueuedMatchmaking as Integer = &H74
        Public Const m_bIsScoped as Integer = &H3910
        Public Const m_bIsValveDS as Integer = &H75
        Public Const m_bSpotted as Integer = &H93D
        Public Const m_bSpottedByMask as Integer = &H980
        Public Const m_bStartedArming as Integer = &H33D0
        Public Const m_clrRender as Integer = &H70
        Public Const m_dwBoneMatrix as Integer = &H26A8
        Public Const m_fAccuracyPenalty as Integer = &H3310
        Public Const m_fFlags as Integer = &H104
        Public Const m_flC4Blow as Integer = &H2990
        Public Const m_flDefuseCountDown as Integer = &H29AC
        Public Const m_flDefuseLength as Integer = &H29A8
        Public Const m_flFallbackWear as Integer = &H31C0
        Public Const m_flFlashDuration as Integer = &HA3F4
        Public Const m_flFlashMaxAlpha as Integer = &HA3F0
        Public Const m_flLastBoneSetupTime as Integer = &H2924
        Public Const m_flLowerBodyYawTarget as Integer = &H3A78
        Public Const m_flNextAttack as Integer = &H2D70
        Public Const m_flNextPrimaryAttack as Integer = &H3218
        Public Const m_flSimulationTime as Integer = &H268
        Public Const m_flTimerLength as Integer = &H2994
        Public Const m_hActiveWeapon as Integer = &H2EF8
        Public Const m_hMyWeapons as Integer = &H2DF8
        Public Const m_hObserverTarget as Integer = &H3388
        Public Const m_hOwner as Integer = &H29CC
        Public Const m_hOwnerEntity as Integer = &H14C
        Public Const m_iAccountID as Integer = &H2FC8
        Public Const m_iClip1 as Integer = &H3244
        Public Const m_iCompetitiveRanking as Integer = &H1A84
        Public Const m_iCompetitiveWins as Integer = &H1B88
        Public Const m_iCrosshairId as Integer = &HB3AC
        Public Const m_iEntityQuality as Integer = &H2FAC
        Public Const m_iFOV as Integer = &H31E4
        Public Const m_iFOVStart as Integer = &H31E8
        Public Const m_iGlowIndex as Integer = &HA40C
        Public Const m_iHealth as Integer = &H100
        Public Const m_iItemDefinitionIndex as Integer = &H2FAA
        Public Const m_iItemIDHigh as Integer = &H2FC0
        Public Const m_iMostRecentModelBoneCounter as Integer = &H2690
        Public Const m_iObserverMode as Integer = &H3374
        Public Const m_iShotsFired as Integer = &HA380
        Public Const m_iState as Integer = &H3238
        Public Const m_iTeamNum as Integer = &HF4
        Public Const m_lifeState as Integer = &H25F
        Public Const m_nFallbackPaintKit as Integer = &H31B8
        Public Const m_nFallbackSeed as Integer = &H31BC
        Public Const m_nFallbackStatTrak as Integer = &H31C4
        Public Const m_nForceBone as Integer = &H268C
        Public Const m_nTickBase as Integer = &H342C
        Public Const m_rgflCoordinateFrame as Integer = &H444
        Public Const m_szCustomName as Integer = &H303C
        Public Const m_szLastPlaceName as Integer = &H35B0
        Public Const m_thirdPersonViewAngles as Integer = &H31D8
        Public Const m_vecOrigin as Integer = &H138
        Public Const m_vecVelocity as Integer = &H114
        Public Const m_vecViewOffset as Integer = &H108
        Public Const m_viewPunchAngle as Integer = &H3020
    End Class
    Public Shared Class signatures
        Public Const clientstate_choked_commands as Integer = &H4D28
        Public Const clientstate_delta_ticks as Integer = &H174
        Public Const clientstate_last_outgoing_command as Integer = &H4D24
        Public Const clientstate_net_channel as Integer = &H9C
        Public Const convar_name_hash_table as Integer = &H2F0F8
        Public Const dwClientState as Integer = &H590D94
        Public Const dwClientState_GetLocalPlayer as Integer = &H180
        Public Const dwClientState_IsHLTV as Integer = &H4D40
        Public Const dwClientState_Map as Integer = &H28C
        Public Const dwClientState_MapDirectory as Integer = &H188
        Public Const dwClientState_MaxPlayer as Integer = &H388
        Public Const dwClientState_PlayerInfo as Integer = &H52B8
        Public Const dwClientState_State as Integer = &H108
        Public Const dwClientState_ViewAngles as Integer = &H4D88
        Public Const dwEntityList as Integer = &H4D07DD4
        Public Const dwForceAttack as Integer = &H3139490
        Public Const dwForceAttack2 as Integer = &H313949C
        Public Const dwForceBackward as Integer = &H31394D8
        Public Const dwForceForward as Integer = &H31394E4
        Public Const dwForceJump as Integer = &H51AB48C
        Public Const dwForceLeft as Integer = &H31394FC
        Public Const dwForceRight as Integer = &H31394F0
        Public Const dwGameDir as Integer = &H6376F0
        Public Const dwGetAllClasses as Integer = &HD1ABF4
        Public Const dwGlobalVars as Integer = &H590A98
        Public Const dwGlowObjectManager as Integer = &H5248228
        Public Const dwInput as Integer = &H5152E20
        Public Const dwInterfaceLinkList as Integer = &H8C9F14
        Public Const dwLocalPlayer as Integer = &HCF5A4C
        Public Const dwMouseEnable as Integer = &HCFB598
        Public Const dwMouseEnablePtr as Integer = &HCFB568
        Public Const dwPlayerResource as Integer = &H313781C
        Public Const dwRadarBase as Integer = &H513CB34
        Public Const dwSensitivity as Integer = &HCFB434
        Public Const dwSensitivityPtr as Integer = &HCFB408
        Public Const dwSetClanTag as Integer = &H89890
        Public Const dwViewMatrix as Integer = &H4CF9804
        Public Const dwWeaponTable as Integer = &H51538E8
        Public Const dwWeaponTableIndex as Integer = &H323C
        Public Const dwYawPtr as Integer = &HCFB1F8
        Public Const dwZoomSensitivityRatioPtr as Integer = &HD00418
        Public Const dwbSendPackets as Integer = &HD2CFA
        Public Const dwppDirect3DDevice9 as Integer = &HA6030
        Public Const force_update_spectator_glow as Integer = &H393662
        Public Const interface_engine_cvar as Integer = &H3E9EC
        Public Const is_c4_owner as Integer = &H39F8B0
        Public Const m_bDormant as Integer = &HED
        Public Const m_pStudioHdr as Integer = &H294C
        Public Const m_pitchClassPtr as Integer = &H513CDE0
        Public Const m_yawClassPtr as Integer = &HCFB1F8
        Public Const model_ambient_min as Integer = &H593DB4
        Public Const set_abs_angles as Integer = &H1CABA0
        Public Const set_abs_origin as Integer = &H1CA9E0
    End Class
End Namespace
