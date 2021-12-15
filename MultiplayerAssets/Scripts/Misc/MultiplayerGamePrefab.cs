using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MedusaMultiplayer
{
    public class MultiplayerGamePrefab : MonoBehaviour
    {
        [Header("MultiplayerMatchMakingPrefabs")]
        public GameObject signalRGO;
        public GameObject lobbyGO;
        public GameObject roomListGO;
        public GameObject playerListGO;
        public GameObject enterNameGO;
        public GameObject matchConditionManagerGO;

        [Header("Unit Templates")]
        public GameObject rockFormation;
        public GameObject rockRemoval;
        public GameObject bigExplosion;
        public GameObject smallExplosion;
        public GameObject lightning;
        public GameObject earthquake;
        public GameObject tornadoAnimation;
        public GameObject leftFire;
        public GameObject rightFire;
        public GameObject upFire;
        public GameObject downFire;

        [Header("local")]
        public GameObject localMedusa;
        public GameObject localPosidanna;
        public GameObject localHelmis;
        public GameObject localErmolai;
        public GameObject localAverna;

        [Header("remote")]
        public GameObject remoteMedusa;
        public GameObject remotePosidanna;
        public GameObject remoteHelmis;
        public GameObject remoteErmolai;
        public GameObject remoteAverna;

        [Header("serverPredicted")]
        public GameObject serverPredictedMedusa;
        public GameObject serverPredictedPosidanna;
        public GameObject serverPredictedHelmis;
        public GameObject serverPredictedErmolai;
        public GameObject serverPredictedAverna;

        [Header("remoteClientOther")]
        public GameObject remoteClientOtherMedusa;
        public GameObject remoteClientOtherPosidanna;
        public GameObject remoteClientOtherHelmis;
        public GameObject remoteClientOtherErmolai;
        public GameObject remoteClientOtherAverna;

        [Header("serverInstance")]
        public GameObject serverInstanceMedusa;
        public GameObject serverInstancePosidanna;
        public GameObject serverInstanceHelmis;
        public GameObject serverInstanceErmolai;
        public GameObject serverInstanceAverna;

        [Header("ClientEnemyManager")]
        public GameObject clientEnemy;

        [Header("ClientOnly Projectiles")]
        public GameObject clientProjectilesArrow;
        public GameObject clientProjectilesBubbleShield;
        public GameObject clientProjectilesDispersedFireballMirrorKnight;
        public GameObject clientProjectilesEyeLaserMirrorKnight;
        public GameObject clientProjectilesFireballMirrorKnight;
        public GameObject clientProjectilesFlamePillar;
        public GameObject clientProjectilesMightyWind;
        public GameObject clientProjectilesMightyWindMirrorKnight;
        public GameObject clientProjectilesMightyWindTidalWave;

        [Header("ClientOnly TileGameObjects")]
        public GameObject clientTileGameObjectBigExplosions;
        public GameObject clientTileGameObjectSmallExplosion;
        public GameObject clientTileGameObjectEarthquake;
        public GameObject clientTileGameObjectLightning;

        

        [Header("ProjectileUtil")]
        public GameObject projectilesArrow;
        public GameObject projectilesEyeLaser;
        public GameObject projectilesFireBall;
        public GameObject projectilesTidalWave;
        public GameObject projectilesBubbleShield;
        public GameObject projectilesMightyWind;
        public GameObject projectilesFlamePillar;
        public GameObject projectilesEyeLaserMirrorKnight;
        public GameObject projectilesMightyWindMirrorKnight;
        public GameObject projectilesFireBallMirrorKnight;
        public GameObject projectilesDispersedFireBallMirrorKnight;
        public GameObject projectilesEyeLaserPortal;
        public GameObject projectilesStarShower;
        public GameObject projectilesCentaurBow;

        public GameObject GetProjectiles(EnumData.Projectiles projectiles)
        {
            switch (projectiles)
            {
                case EnumData.Projectiles.Arrow:
                    return projectilesArrow;
                case EnumData.Projectiles.EyeLaser:
                    return projectilesEyeLaser;
                case EnumData.Projectiles.FireBall:
                    return projectilesFireBall;
                case EnumData.Projectiles.TidalWave:
                    return projectilesTidalWave;
                case EnumData.Projectiles.BubbleShield:
                    return projectilesBubbleShield;
                case EnumData.Projectiles.MightyWind:
                    return projectilesMightyWind;
                case EnumData.Projectiles.FlamePillar:
                    return projectilesFlamePillar;
                case EnumData.Projectiles.EyeLaserMirrorKnight:
                    return projectilesEyeLaserMirrorKnight;
                case EnumData.Projectiles.MightyWindMirrorKnight:
                    return projectilesMightyWindMirrorKnight;
                case EnumData.Projectiles.FireBallMirrorKnight:
                    return projectilesFireBallMirrorKnight;
                case EnumData.Projectiles.DispersedFireBallMirrorKnight:
                    return projectilesDispersedFireBallMirrorKnight;
                case EnumData.Projectiles.EyeLaserPortal:
                    return projectilesEyeLaserPortal;
                case EnumData.Projectiles.StarShower:
                    return projectilesStarShower;
                case EnumData.Projectiles.CentaurBow:
                    return projectilesCentaurBow;
                default:
                    return null;
            }
        }

        public static MultiplayerGamePrefab instance;
        private void Awake()
        {
            instance = this;
        }

        public GameObject GetLocalPlayer(EnumData.Heroes heroEnum)
        {
            switch(heroEnum)
            {
                case EnumData.Heroes.Medusa:
                    return localMedusa;
                case EnumData.Heroes.Posidanna:
                    return localPosidanna;
                case EnumData.Heroes.Heliemis:
                    return localHelmis;
                case EnumData.Heroes.Ermolai:
                    return localErmolai;
                case EnumData.Heroes.Averna:
                    return localAverna;
                default:
                    return null;
            }
        }

        public GameObject GetRemotePlayer(EnumData.Heroes heroEnum)
        {
            switch (heroEnum)
            {
                case EnumData.Heroes.Medusa:
                    return remoteMedusa;
                case EnumData.Heroes.Posidanna:
                    return remotePosidanna;
                case EnumData.Heroes.Heliemis:
                    return remoteHelmis;
                case EnumData.Heroes.Ermolai:
                    return remoteErmolai;
                case EnumData.Heroes.Averna:
                    return remoteAverna;
                default:
                    return null;
            }
        }

        public GameObject GetRemoteOtherClientPlayer(EnumData.Heroes heroEnum)
        {
            switch (heroEnum)
            {
                case EnumData.Heroes.Medusa:
                    return remoteClientOtherMedusa;
                case EnumData.Heroes.Posidanna:
                    return remoteClientOtherPosidanna;
                case EnumData.Heroes.Heliemis:
                    return remoteClientOtherHelmis;
                case EnumData.Heroes.Ermolai:
                    return remoteClientOtherErmolai;
                case EnumData.Heroes.Averna:
                    return remoteClientOtherAverna;
                default:
                    return null;
            }
        }

        public GameObject GetServerPredictedPlayer(EnumData.Heroes heroEnum)
        {
            switch (heroEnum)
            {
                case EnumData.Heroes.Medusa:
                    return serverPredictedMedusa;
                case EnumData.Heroes.Posidanna:
                    return serverPredictedPosidanna;
                case EnumData.Heroes.Heliemis:
                    return serverPredictedHelmis;
                case EnumData.Heroes.Ermolai:
                    return serverPredictedErmolai;
                case EnumData.Heroes.Averna:
                    return serverPredictedAverna;
                default:
                    return null;
            }
        }

        public GameObject GetServerInstancePlayer(EnumData.Heroes heroEnum)
        {
            switch (heroEnum)
            {
                case EnumData.Heroes.Medusa:
                    return serverInstanceMedusa;
                case EnumData.Heroes.Posidanna:
                    return serverInstancePosidanna;
                case EnumData.Heroes.Heliemis:
                    return serverInstanceHelmis;
                case EnumData.Heroes.Ermolai:
                    return serverInstanceErmolai;
                case EnumData.Heroes.Averna:
                    return serverInstanceAverna;
                default:
                    return null;
            }
        }

        public GameObject GetClientOnlyProjectiles(EnumData.Projectiles projectiles)
        {
            switch (projectiles)
            {
                case EnumData.Projectiles.Arrow:
                    return clientProjectilesArrow;
                case EnumData.Projectiles.BubbleShield:
                    return clientProjectilesBubbleShield;
                case EnumData.Projectiles.DispersedFireBallMirrorKnight:
                    return clientProjectilesDispersedFireballMirrorKnight;
                case EnumData.Projectiles.EyeLaserMirrorKnight:
                    return clientProjectilesEyeLaserMirrorKnight;
                case EnumData.Projectiles.FireBallMirrorKnight:
                    return clientProjectilesFireballMirrorKnight;
                case EnumData.Projectiles.FlamePillar:
                    return clientProjectilesFlamePillar;
                case EnumData.Projectiles.MightyWind:
                    return clientProjectilesMightyWind;
                case EnumData.Projectiles.MightyWindMirrorKnight:
                    return clientProjectilesMightyWindMirrorKnight;
                case EnumData.Projectiles.TidalWave:
                    return clientProjectilesMightyWindTidalWave;
                default:
                    return null;
            }
        }

        public GameObject GetClientTileGameObject(EnumData.StaticAnimatingTiles staticAnimatingTiles)
        {
            switch (staticAnimatingTiles)
            {
                case EnumData.StaticAnimatingTiles.SmallExplosion:
                    return clientTileGameObjectSmallExplosion;
                case EnumData.StaticAnimatingTiles.BigExplosion:
                    return clientTileGameObjectBigExplosions;
                case EnumData.StaticAnimatingTiles.Lightning:
                    return clientTileGameObjectLightning;
                case EnumData.StaticAnimatingTiles.Earthquake:
                    return clientTileGameObjectEarthquake;
                default:
                    return null;
            }
        }


    }
}

