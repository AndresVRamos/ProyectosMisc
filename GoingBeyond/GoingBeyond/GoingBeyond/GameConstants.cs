using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoingBeyond
{
    class GameConstants
    {
        //Constantes de camara
        public const float CameraHeight = 25000.0f;
        public const float PlayfieldSizeX = 16000;
        public const float PlayfieldSizeY = 12500;

        //Constantes de asteroides
        public const int NumAsteroids = 10;
        public const float AsteroidMinSpeed = 100.0f;
        public const float AsteroidMaxSpeed = 300.0f;
        public const float AsteroidSpeedAdjustment = 5.0f;

        //Hitboxes
        public const float AsteroidBoundingSphereScale = 0.95f; //95% del tamaño real
        public const float ShipBoundingSphereScale = 0.5f; //50% del tamaño real

        //Balas
        public const int NumBullets = 30;
        public const float BulletSpeedAdjustment = 100.0f;

        //Puntuación
        public const int ShotPenalty = 1;
        public const int DeathPenalty = 100;
        public const int WarpPenalty = 50;
        public const int KillBonus = 25;
    }
}
